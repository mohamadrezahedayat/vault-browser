using Autodesk.DataManagement.Client.Framework.Vault.Services.Connection.Implementation;
using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VDF = Autodesk.DataManagement.Client.Framework;

using ACW = Autodesk.Connectivity.WebServices;
using Vault = Autodesk.DataManagement.Client.Framework.Vault;
using Forms = Autodesk.DataManagement.Client.Framework.Vault.Forms;
using Autodesk.DataManagement.Client.Framework.Vault.Forms.Settings;
using VaultViewer;
using Autodesk.DataManagement.Client.Framework.Vault.Internal.ExtensionMethods;
using Autodesk.Connectivity.WebServices;
using Autodesk.DataManagement.Client.Framework.Vault.Currency.Properties;
using Autodesk.DataManagement.Client.Framework.Vault.Currency.Entities;

namespace VaultViewer
{

    public partial class FilesGridForm : Form
    {
        private VDF.Vault.Currency.Connections.Connection m_connection;
        UnitOfWork db = new UnitOfWork();
        public FilesGridForm(VDF.Vault.Currency.Connections.Connection connection)
        {
            InitializeComponent();
            reloadGrid();

            m_connection = connection;
        }

        private void reloadGrid()
        {
            fileGridView.DataSource = db.FileRipository.Get();
        }
        private void CleanAllFilesdb()
        {
            var files = db.FileRipository.Get();
            var persons = db.PersonRipository.Get();
            if (files != null)
            {
                foreach (var file in files)
                {
                    db.FileRipository.Delete(file);
                    db.FileRipository.save();
                }
            }


        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            CleanAllFilesdb();
            var rootFolder = m_connection.FolderManager.RootFolder;
            string[] pathes = { rootFolder.FolderPath };


            //m_connection.FileManager.
            var foldersIds = m_connection.WebServiceManager.DocumentService.GetFolderIdsByParentIds(new long[] { 1 }, true);
            var files = new List<File>();

            foreach (var folderid in foldersIds)
            {
                var folderfiles = m_connection.WebServiceManager.DocumentService.GetLatestFilesByFolderId(folderid, false);
                if (folderfiles != null)
                {
                    files.AddRange(folderfiles);
                }

            }
            PropertyService propertyService = m_connection.WebServiceManager.PropertyService;
            var allProperties = m_connection.PropertyManager.GetPropertyDefinitions(null, null, PropertyDefinitionFilter.IncludeUserDefined);
            string propertySystemName = string.Empty;
            foreach (var property in allProperties)
            {
                if (property.Value.DisplayName == "Document Number")
                {
                    propertySystemName = property.Value.SystemName;
                }
            }
            //var propertySystemName = "60821119-9640-4590-883a-024912c0393b";

            var propDef = m_connection.PropertyManager.GetPropertyDefinitionBySystemName(propertySystemName);

            foreach (var file in files)
            {

                var fileIteration = new FileIteration(m_connection, file);
                var path0 = m_connection.WorkingFoldersManager.GetPathOfFileInWorkingFolder(fileIteration).ToString();
                string path1 = "$" + path0.Substring(path0.IndexOf("Vault")+5);
                var path = path1.Replace('\\', '/');

                var pvs = new PropertyValueSettings();
                var DocumentNumberValue = m_connection.PropertyManager.GetPropertyValue(fileIteration, propDef, pvs);

                var filedb = new DataLayer.Models.File()
                {
                    FullPath = path,
                    CreatorId = file.CreateUserId,
                    CreationDate = file.CreateDate,
                    EditorId = file.CheckedOut ? file.CkOutUserId : file.CreateUserId,
                    LastRevisionDate = file.CheckedOut ? file.ModDate : file.CreateDate,
                    LastRevisionID = file.Id,
                    LastComment = file.Comm,
                    LastState = DataLayer.Models.FileStates.a,
                    DocumentNumber = DocumentNumberValue != null ? DocumentNumberValue.ToString() : "",

                };
                var createPersonDb = new DataLayer.Models.Person()
                {
                    PersonID = file.CreateUserId,
                    Name = file.CreateUserName
                };
                if (db.PersonRipository.GetById(createPersonDb.PersonID) == null)
                {
                    db.PersonRipository.Insert(createPersonDb);
                    db.PersonRipository.save();
                }

                //To Modify later
                //var EditPersonDb = new DataLayer.Models.Person()
                //{
                //    PersonID = file.CkOutUserId,
                //    Name = file.cus
                //};

                db.FileRipository.Insert(filedb);
                db.FileRipository.save();


            }
            reloadGrid();
        }



        private void btmCleanFilesDb_Click(object sender, EventArgs e)
        {
            CleanAllFilesdb();
            reloadGrid();
        }
    }
}

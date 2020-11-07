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
            var files= db.FileRipository.Get();
            var persons = db.PersonRipository.Get();
            if (files !=null)
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
            foreach (var file in files)
            {
                var filedb = new DataLayer.Models.File()
                {
                    ID = file.MasterId,
                    FileName = file.Name,
                    CreatorId = file.CreateUserId,
                    CreationDate = file.CreateDate,
                    EditorId = file.CheckedOut? file.CkOutUserId: file.CreateUserId,
                    LastRevisionDate = file.CheckedOut ? file.ModDate:file.CreateDate,
                    LastRevisionID = file.Id,
                    LastComment = file.Comm,
                    LastState = DataLayer.Models.FileStates.a,
                    
                };
                var createPersonDb = new DataLayer.Models.Person()
                {
                    PersonID = file.CreateUserId,
                    Name = file.CreateUserName
                };
                //var EditPersonDb = new DataLayer.Models.Person()
                //{
                //    PersonID = file.CkOutUserId,
                //    Name = file.
                //};
                if (db.PersonRipository.GetById(createPersonDb.PersonID) == null)
                {
                    db.PersonRipository.Insert(createPersonDb);
                    db.PersonRipository.save();
                }
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using VDF = Autodesk.DataManagement.Client.Framework;
using Excel;

namespace VaultViewer
{
    public partial class MdrGridForm : Form
    {
        private VDF.Vault.Currency.Connections.Connection m_connection;
        private object[,] filteredarray;
        UnitOfWork db = new UnitOfWork();
        public MdrGridForm(VDF.Vault.Currency.Connections.Connection connection)
        {
            InitializeComponent();
            m_connection = connection;
        }
        private void reloadGrid()
        {
            gridviewDocs.Columns.Clear();
            gridviewDocs.DataSource = db.DocumentRipository.Get();
        }
        private void btnSyncDocDb_Click(object sender, EventArgs e)
        {
            btnSyncDocDb.BackColor = Color.Black;
            if (db.TransmitalRipository.GetById("No Transmital") == null)
            {
                var NotDefinedtransmitalDb = new DataLayer.Models.Transmital()
                {
                    Title = "No Transmital",
                    Date = new DateTime(1900, 01, 01),
                    TransmitalNumber = "No Transmital",
                    POI = "Not defined",

                };
                db.TransmitalRipository.Insert(NotDefinedtransmitalDb);
                db.TransmitalRipository.save();
            }


            for (int i = 0; i < filteredarray.GetUpperBound(0); i++)
            {
                for (int j = 0; j < filteredarray.GetUpperBound(1); j += 10)
                {

                    var doublicate = db.TransmitalRipository.GetById(filteredarray[i, 4 + j]);
                    var transmitalNumber = filteredarray[i, 4 + j];
                    var days = filteredarray[i, 5 + j];
                    if (transmitalNumber != null && days.ToString() != "" && doublicate == null)
                    {
                        var date = new DateTime(1900, 01, 01).AddDays(Convert.ToDouble(days) - 2);

                        var transmitalDb = new DataLayer.Models.Transmital()
                        {
                            Title = transmitalNumber.ToString(),
                            Date = date,
                            TransmitalNumber = transmitalNumber.ToString(),
                            POI = filteredarray[i, 2 + j].ToString(),

                        };
                        db.TransmitalRipository.Insert(transmitalDb);
                        db.TransmitalRipository.save();
                    }

                }

            }
            btnSyncDocDb.BackColor = Color.Yellow;
            for (int i = 0; i < filteredarray.GetUpperBound(0); i++)
            {
                var doublicate = db.DocumentRipository.GetById(filteredarray[i, 1]);
                var transmitalNumber = "No Transmital";
                var temp = filteredarray[i, 4];
                if (filteredarray[i, 4]!=null && filteredarray[i, 4].ToString() != "")
                {
                    transmitalNumber = filteredarray[i, 4].ToString();
                }

                if (filteredarray[i, 1] != null && doublicate == null)
                {
                    var docDb = new DataLayer.Models.Document()
                    {
                        Title = filteredarray[i, 0].ToString(),
                        DocumentNumber = filteredarray[i, 1].ToString(),
                        DocumentVersion = DataLayer.Models.Version.a,
                        TransmitalNumber = transmitalNumber,

                    };
                    db.DocumentRipository.Insert(docDb);
                    db.DocumentRipository.save();

                }
            }
            btnSyncDocDb.BackColor = Color.Green;

        }
        private object[,] filterArray(object[,] myArray, int row, int col)
        {
            int cols = myArray.GetUpperBound(1);
            int rows = myArray.GetUpperBound(0);
            object[,] filterdArray = new object[rows - row, cols - col];
            for (int i = row; i < rows; i++)
            {
                for (int j = col; j < cols; j++)
                {
                    filterdArray[i - row, j - col] = myArray[i + 1, j + 1];
                }
            }

            return filterdArray;
        }
        private void btnUploadMdr_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open Mdr File (Exel File)";
            ofd.Filter = "Excel Files|*.xls;*.xlsx";
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                var excel = new Excel.Excel(ofd.FileName, 1);
                excel.Selectsheet("MDR");

                var rangeData = excel.ReadUsedRange_obj();

                excel.Close();

                //coloumns
                gridviewDocs.Columns.Clear();

                // Get the title values.
                for (int col = 5; col <= rangeData.GetUpperBound(1); col++)
                {
                    if (rangeData[2, col] != null)
                    {
                        string title = rangeData[2, col].ToString();
                        gridviewDocs.Columns.Add(title, title);
                    }

                }

                //remove first 5 cols and 5 rows from data range
                filteredarray = filterArray(rangeData, 5, 4);
                // get rows
                for (int i = 0; i < filteredarray.GetUpperBound(0); i++)
                {
                    object[] row = new object[filteredarray.GetUpperBound(0)];
                    for (int j = 0; j < filteredarray.GetUpperBound(1); j++)
                    {
                        row[j] = filteredarray[i, j];
                    }
                    if (row[0] != null)
                    {
                        gridviewDocs.Rows.Add(row);
                    }

                }



            }
        }
    }
}
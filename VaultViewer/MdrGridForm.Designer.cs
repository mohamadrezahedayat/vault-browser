namespace VaultViewer
{
    partial class MdrGridForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridviewDocs = new System.Windows.Forms.DataGridView();
            this.btnUploadMdr = new System.Windows.Forms.Button();
            this.btnCreateFolders = new System.Windows.Forms.Button();
            this.btnSyncDocDb = new System.Windows.Forms.Button();
            this.openFileDialogExcel = new System.Windows.Forms.OpenFileDialog();
            this.btnShowMdrdb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewDocs)).BeginInit();
            this.SuspendLayout();
            // 
            // gridviewDocs
            // 
            this.gridviewDocs.AllowUserToAddRows = false;
            this.gridviewDocs.AllowUserToDeleteRows = false;
            this.gridviewDocs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridviewDocs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewDocs.Location = new System.Drawing.Point(-3, 66);
            this.gridviewDocs.Name = "gridviewDocs";
            this.gridviewDocs.ReadOnly = true;
            this.gridviewDocs.RowHeadersWidth = 62;
            this.gridviewDocs.RowTemplate.Height = 28;
            this.gridviewDocs.Size = new System.Drawing.Size(779, 478);
            this.gridviewDocs.TabIndex = 0;
            // 
            // btnUploadMdr
            // 
            this.btnUploadMdr.Location = new System.Drawing.Point(12, 11);
            this.btnUploadMdr.Name = "btnUploadMdr";
            this.btnUploadMdr.Size = new System.Drawing.Size(122, 48);
            this.btnUploadMdr.TabIndex = 1;
            this.btnUploadMdr.Text = "Upload MDR";
            this.btnUploadMdr.UseVisualStyleBackColor = true;
            this.btnUploadMdr.Click += new System.EventHandler(this.btnUploadMdr_Click);
            // 
            // btnCreateFolders
            // 
            this.btnCreateFolders.Location = new System.Drawing.Point(321, 11);
            this.btnCreateFolders.Name = "btnCreateFolders";
            this.btnCreateFolders.Size = new System.Drawing.Size(129, 48);
            this.btnCreateFolders.TabIndex = 2;
            this.btnCreateFolders.Text = "Create Folders";
            this.btnCreateFolders.UseVisualStyleBackColor = true;
            // 
            // btnSyncDocDb
            // 
            this.btnSyncDocDb.Location = new System.Drawing.Point(150, 11);
            this.btnSyncDocDb.Name = "btnSyncDocDb";
            this.btnSyncDocDb.Size = new System.Drawing.Size(152, 48);
            this.btnSyncDocDb.TabIndex = 3;
            this.btnSyncDocDb.Text = "Sync to Database";
            this.btnSyncDocDb.UseVisualStyleBackColor = true;
            this.btnSyncDocDb.Click += new System.EventHandler(this.btnSyncDocDb_Click);
            // 
            // openFileDialogExcel
            // 
            this.openFileDialogExcel.FileName = "openFileDialogExcel";
            // 
            // btnShowMdrdb
            // 
            this.btnShowMdrdb.Location = new System.Drawing.Point(465, 12);
            this.btnShowMdrdb.Name = "btnShowMdrdb";
            this.btnShowMdrdb.Size = new System.Drawing.Size(175, 48);
            this.btnShowMdrdb.TabIndex = 4;
            this.btnShowMdrdb.Text = "Show Mdr Database";
            this.btnShowMdrdb.UseVisualStyleBackColor = true;
            // 
            // MdrGridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 544);
            this.Controls.Add(this.btnShowMdrdb);
            this.Controls.Add(this.btnSyncDocDb);
            this.Controls.Add(this.btnCreateFolders);
            this.Controls.Add(this.btnUploadMdr);
            this.Controls.Add(this.gridviewDocs);
            this.Name = "MdrGridForm";
            this.Text = "MdrGridForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridviewDocs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridviewDocs;
        private System.Windows.Forms.Button btnUploadMdr;
        private System.Windows.Forms.Button btnCreateFolders;
        private System.Windows.Forms.Button btnSyncDocDb;
        private System.Windows.Forms.OpenFileDialog openFileDialogExcel;
        private System.Windows.Forms.Button btnShowMdrdb;
    }
}
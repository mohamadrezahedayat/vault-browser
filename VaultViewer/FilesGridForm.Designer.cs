namespace VaultViewer
{
    partial class FilesGridForm
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
            this.components = new System.ComponentModel.Container();
            this.fileGridView = new System.Windows.Forms.DataGridView();
            this.btnSync = new System.Windows.Forms.Button();
            this.btmCleanFilesDb = new System.Windows.Forms.Button();
            this.fileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creatorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastRevisionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastRevisionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastCommentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.fileGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fileGridView
            // 
            this.fileGridView.AllowUserToAddRows = false;
            this.fileGridView.AllowUserToDeleteRows = false;
            this.fileGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileGridView.AutoGenerateColumns = false;
            this.fileGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fileGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.fileNameDataGridViewTextBoxColumn,
            this.creatorIdDataGridViewTextBoxColumn,
            this.creationDateDataGridViewTextBoxColumn,
            this.editorIdDataGridViewTextBoxColumn,
            this.lastRevisionDateDataGridViewTextBoxColumn,
            this.lastRevisionIDDataGridViewTextBoxColumn,
            this.lastCommentDataGridViewTextBoxColumn,
            this.lastStateDataGridViewTextBoxColumn});
            this.fileGridView.DataSource = this.fileBindingSource;
            this.fileGridView.Location = new System.Drawing.Point(0, 53);
            this.fileGridView.Name = "fileGridView";
            this.fileGridView.ReadOnly = true;
            this.fileGridView.RowHeadersWidth = 62;
            this.fileGridView.RowTemplate.Height = 28;
            this.fileGridView.Size = new System.Drawing.Size(815, 397);
            this.fileGridView.TabIndex = 0;
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(12, 12);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(148, 35);
            this.btnSync.TabIndex = 1;
            this.btnSync.Text = "Sync From Vault";
            this.btnSync.UseVisualStyleBackColor = true;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // btmCleanFilesDb
            // 
            this.btmCleanFilesDb.Location = new System.Drawing.Point(176, 12);
            this.btmCleanFilesDb.Name = "btmCleanFilesDb";
            this.btmCleanFilesDb.Size = new System.Drawing.Size(148, 35);
            this.btmCleanFilesDb.TabIndex = 2;
            this.btmCleanFilesDb.Text = "Clean All";
            this.btmCleanFilesDb.UseVisualStyleBackColor = true;
            this.btmCleanFilesDb.Click += new System.EventHandler(this.btmCleanFilesDb_Click);
            // 
            // fileBindingSource
            // 
            this.fileBindingSource.DataSource = typeof(DataLayer.Models.File);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 150;
            // 
            // fileNameDataGridViewTextBoxColumn
            // 
            this.fileNameDataGridViewTextBoxColumn.DataPropertyName = "FileName";
            this.fileNameDataGridViewTextBoxColumn.HeaderText = "FileName";
            this.fileNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fileNameDataGridViewTextBoxColumn.Name = "fileNameDataGridViewTextBoxColumn";
            this.fileNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fileNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // creatorIdDataGridViewTextBoxColumn
            // 
            this.creatorIdDataGridViewTextBoxColumn.DataPropertyName = "CreatorId";
            this.creatorIdDataGridViewTextBoxColumn.HeaderText = "CreatorId";
            this.creatorIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.creatorIdDataGridViewTextBoxColumn.Name = "creatorIdDataGridViewTextBoxColumn";
            this.creatorIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.creatorIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // creationDateDataGridViewTextBoxColumn
            // 
            this.creationDateDataGridViewTextBoxColumn.DataPropertyName = "CreationDate";
            this.creationDateDataGridViewTextBoxColumn.HeaderText = "CreationDate";
            this.creationDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.creationDateDataGridViewTextBoxColumn.Name = "creationDateDataGridViewTextBoxColumn";
            this.creationDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.creationDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // editorIdDataGridViewTextBoxColumn
            // 
            this.editorIdDataGridViewTextBoxColumn.DataPropertyName = "EditorId";
            this.editorIdDataGridViewTextBoxColumn.HeaderText = "EditorId";
            this.editorIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.editorIdDataGridViewTextBoxColumn.Name = "editorIdDataGridViewTextBoxColumn";
            this.editorIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.editorIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // lastRevisionDateDataGridViewTextBoxColumn
            // 
            this.lastRevisionDateDataGridViewTextBoxColumn.DataPropertyName = "LastRevisionDate";
            this.lastRevisionDateDataGridViewTextBoxColumn.HeaderText = "LastRevisionDate";
            this.lastRevisionDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lastRevisionDateDataGridViewTextBoxColumn.Name = "lastRevisionDateDataGridViewTextBoxColumn";
            this.lastRevisionDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastRevisionDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // lastRevisionIDDataGridViewTextBoxColumn
            // 
            this.lastRevisionIDDataGridViewTextBoxColumn.DataPropertyName = "LastRevisionID";
            this.lastRevisionIDDataGridViewTextBoxColumn.HeaderText = "LastRevisionID";
            this.lastRevisionIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lastRevisionIDDataGridViewTextBoxColumn.Name = "lastRevisionIDDataGridViewTextBoxColumn";
            this.lastRevisionIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastRevisionIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // lastCommentDataGridViewTextBoxColumn
            // 
            this.lastCommentDataGridViewTextBoxColumn.DataPropertyName = "LastComment";
            this.lastCommentDataGridViewTextBoxColumn.HeaderText = "LastComment";
            this.lastCommentDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lastCommentDataGridViewTextBoxColumn.Name = "lastCommentDataGridViewTextBoxColumn";
            this.lastCommentDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastCommentDataGridViewTextBoxColumn.Width = 150;
            // 
            // lastStateDataGridViewTextBoxColumn
            // 
            this.lastStateDataGridViewTextBoxColumn.DataPropertyName = "LastState";
            this.lastStateDataGridViewTextBoxColumn.HeaderText = "LastState";
            this.lastStateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.lastStateDataGridViewTextBoxColumn.Name = "lastStateDataGridViewTextBoxColumn";
            this.lastStateDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastStateDataGridViewTextBoxColumn.Width = 150;
            // 
            // FilesGridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 450);
            this.Controls.Add(this.btmCleanFilesDb);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.fileGridView);
            this.Name = "FilesGridForm";
            this.Text = "Files";
            
            ((System.ComponentModel.ISupportInitialize)(this.fileGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView fileGridView;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Button btmCleanFilesDb;
        private System.Windows.Forms.DataGridViewTextBoxColumn masterIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fileBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creatorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastRevisionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastRevisionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastCommentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastStateDataGridViewTextBoxColumn;
    }
}
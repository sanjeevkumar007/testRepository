namespace InstallationLocation
{
    partial class LocationUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInstalltionHeader = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTsmpDir = new System.Windows.Forms.Label();
            this.lblInitialDatabaseLocation = new System.Windows.Forms.Label();
            this.lblInitialDatabaseVersion = new System.Windows.Forms.Label();
            this.txtTspmInstallDir = new System.Windows.Forms.TextBox();
            this.txtInitialDatabaseLocation = new System.Windows.Forms.TextBox();
            this.txtInitialDatabaseVersion = new System.Windows.Forms.TextBox();
            this.lblPatchFolderLocation = new System.Windows.Forms.Label();
            this.txtPatchFolderLocation = new System.Windows.Forms.TextBox();
            this.lblCertficateDir = new System.Windows.Forms.Label();
            this.txtCertificateLocation = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInstalltionHeader
            // 
            this.lblInstalltionHeader.AutoSize = true;
            this.lblInstalltionHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstalltionHeader.Location = new System.Drawing.Point(20, 18);
            this.lblInstalltionHeader.Name = "lblInstalltionHeader";
            this.lblInstalltionHeader.Size = new System.Drawing.Size(180, 20);
            this.lblInstalltionHeader.TabIndex = 0;
            this.lblInstalltionHeader.Text = "Installtion Directories";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 395F));
            this.tableLayoutPanel1.Controls.Add(this.lblTsmpDir, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblInitialDatabaseLocation, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblInitialDatabaseVersion, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtTspmInstallDir, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtInitialDatabaseLocation, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtInitialDatabaseVersion, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPatchFolderLocation, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtPatchFolderLocation, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblCertficateDir, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtCertificateLocation, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 88);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(568, 159);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblTsmpDir
            // 
            this.lblTsmpDir.AutoSize = true;
            this.lblTsmpDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTsmpDir.Location = new System.Drawing.Point(4, 1);
            this.lblTsmpDir.Name = "lblTsmpDir";
            this.lblTsmpDir.Size = new System.Drawing.Size(167, 30);
            this.lblTsmpDir.TabIndex = 0;
            this.lblTsmpDir.Text = "TSPM Installation Directory";
            this.lblTsmpDir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInitialDatabaseLocation
            // 
            this.lblInitialDatabaseLocation.AutoSize = true;
            this.lblInitialDatabaseLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInitialDatabaseLocation.Location = new System.Drawing.Point(4, 32);
            this.lblInitialDatabaseLocation.Name = "lblInitialDatabaseLocation";
            this.lblInitialDatabaseLocation.Size = new System.Drawing.Size(167, 30);
            this.lblInitialDatabaseLocation.TabIndex = 1;
            this.lblInitialDatabaseLocation.Text = "Initial Database Location";
            this.lblInitialDatabaseLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInitialDatabaseVersion
            // 
            this.lblInitialDatabaseVersion.AutoSize = true;
            this.lblInitialDatabaseVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInitialDatabaseVersion.Location = new System.Drawing.Point(4, 63);
            this.lblInitialDatabaseVersion.Name = "lblInitialDatabaseVersion";
            this.lblInitialDatabaseVersion.Size = new System.Drawing.Size(167, 30);
            this.lblInitialDatabaseVersion.TabIndex = 2;
            this.lblInitialDatabaseVersion.Text = "Inital Database Version";
            this.lblInitialDatabaseVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTspmInstallDir
            // 
            this.txtTspmInstallDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTspmInstallDir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtTspmInstallDir.Enabled = false;
            this.txtTspmInstallDir.Location = new System.Drawing.Point(178, 8);
            this.txtTspmInstallDir.Name = "txtTspmInstallDir";
            this.txtTspmInstallDir.Size = new System.Drawing.Size(389, 20);
            this.txtTspmInstallDir.TabIndex = 6;
            this.txtTspmInstallDir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInitialDatabaseLocation
            // 
            this.txtInitialDatabaseLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInitialDatabaseLocation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtInitialDatabaseLocation.Enabled = false;
            this.txtInitialDatabaseLocation.Location = new System.Drawing.Point(178, 39);
            this.txtInitialDatabaseLocation.Name = "txtInitialDatabaseLocation";
            this.txtInitialDatabaseLocation.Size = new System.Drawing.Size(389, 20);
            this.txtInitialDatabaseLocation.TabIndex = 7;
            this.txtInitialDatabaseLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInitialDatabaseVersion
            // 
            this.txtInitialDatabaseVersion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInitialDatabaseVersion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtInitialDatabaseVersion.Enabled = false;
            this.txtInitialDatabaseVersion.Location = new System.Drawing.Point(178, 70);
            this.txtInitialDatabaseVersion.Name = "txtInitialDatabaseVersion";
            this.txtInitialDatabaseVersion.Size = new System.Drawing.Size(389, 20);
            this.txtInitialDatabaseVersion.TabIndex = 8;
            this.txtInitialDatabaseVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPatchFolderLocation
            // 
            this.lblPatchFolderLocation.AutoSize = true;
            this.lblPatchFolderLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPatchFolderLocation.Location = new System.Drawing.Point(4, 94);
            this.lblPatchFolderLocation.Name = "lblPatchFolderLocation";
            this.lblPatchFolderLocation.Size = new System.Drawing.Size(167, 30);
            this.lblPatchFolderLocation.TabIndex = 16;
            this.lblPatchFolderLocation.Text = "Patch Folder Location";
            this.lblPatchFolderLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPatchFolderLocation
            // 
            this.txtPatchFolderLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPatchFolderLocation.Enabled = false;
            this.txtPatchFolderLocation.Location = new System.Drawing.Point(178, 97);
            this.txtPatchFolderLocation.Name = "txtPatchFolderLocation";
            this.txtPatchFolderLocation.Size = new System.Drawing.Size(389, 20);
            this.txtPatchFolderLocation.TabIndex = 17;
            this.txtPatchFolderLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCertficateDir
            // 
            this.lblCertficateDir.AutoSize = true;
            this.lblCertficateDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCertficateDir.Location = new System.Drawing.Point(4, 125);
            this.lblCertficateDir.Name = "lblCertficateDir";
            this.lblCertficateDir.Size = new System.Drawing.Size(167, 33);
            this.lblCertficateDir.TabIndex = 18;
            this.lblCertficateDir.Text = "Certificates Location";
            this.lblCertficateDir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCertificateLocation
            // 
            this.txtCertificateLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCertificateLocation.Enabled = false;
            this.txtCertificateLocation.Location = new System.Drawing.Point(178, 128);
            this.txtCertificateLocation.Name = "txtCertificateLocation";
            this.txtCertificateLocation.Size = new System.Drawing.Size(389, 20);
            this.txtCertificateLocation.TabIndex = 19;
            this.txtCertificateLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LocationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblInstalltionHeader);
            this.Name = "LocationUserControl";
            this.Size = new System.Drawing.Size(617, 449);
            this.Load += new System.EventHandler(this.LocationUserControl_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstalltionHeader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTsmpDir;
        private System.Windows.Forms.Label lblInitialDatabaseLocation;
        private System.Windows.Forms.Label lblInitialDatabaseVersion;
        private System.Windows.Forms.TextBox txtTspmInstallDir;
        private System.Windows.Forms.TextBox txtInitialDatabaseLocation;
        private System.Windows.Forms.TextBox txtInitialDatabaseVersion;
        private System.Windows.Forms.Label lblPatchFolderLocation;
        private System.Windows.Forms.TextBox txtPatchFolderLocation;
        private System.Windows.Forms.Label lblCertficateDir;
        private System.Windows.Forms.TextBox txtCertificateLocation;

    }
}

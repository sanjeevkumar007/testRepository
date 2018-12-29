namespace ConnectSQLServer
{
    partial class SQLServerConnect
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAuthenticationType = new System.Windows.Forms.ComboBox();
            this.grboxAuthenticationSQL = new System.Windows.Forms.GroupBox();
            this.lblErrorPassword = new System.Windows.Forms.Label();
            this.lblErrorUserName = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblSqlServer = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblSQLConfiguration = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlConfigurationScreen = new System.Windows.Forms.Panel();
            this.grboxAuthenticationSQL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnlConfigurationScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SQL Authentication Type";
            // 
            // cmbAuthenticationType
            // 
            this.cmbAuthenticationType.FormattingEnabled = true;
            this.cmbAuthenticationType.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
            this.cmbAuthenticationType.Location = new System.Drawing.Point(179, 70);
            this.cmbAuthenticationType.Name = "cmbAuthenticationType";
            this.cmbAuthenticationType.Size = new System.Drawing.Size(226, 21);
            this.cmbAuthenticationType.TabIndex = 1;
            // 
            // grboxAuthenticationSQL
            // 
            this.grboxAuthenticationSQL.Controls.Add(this.lblErrorPassword);
            this.grboxAuthenticationSQL.Controls.Add(this.lblErrorUserName);
            this.grboxAuthenticationSQL.Controls.Add(this.txtPassword);
            this.grboxAuthenticationSQL.Controls.Add(this.txtUserName);
            this.grboxAuthenticationSQL.Controls.Add(this.label3);
            this.grboxAuthenticationSQL.Controls.Add(this.label2);
            this.grboxAuthenticationSQL.Location = new System.Drawing.Point(68, 118);
            this.grboxAuthenticationSQL.Name = "grboxAuthenticationSQL";
            this.grboxAuthenticationSQL.Size = new System.Drawing.Size(337, 96);
            this.grboxAuthenticationSQL.TabIndex = 2;
            this.grboxAuthenticationSQL.TabStop = false;
            // 
            // lblErrorPassword
            // 
            this.lblErrorPassword.AutoSize = true;
            this.lblErrorPassword.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPassword.Location = new System.Drawing.Point(325, 58);
            this.lblErrorPassword.Name = "lblErrorPassword";
            this.lblErrorPassword.Size = new System.Drawing.Size(0, 13);
            this.lblErrorPassword.TabIndex = 5;
            // 
            // lblErrorUserName
            // 
            this.lblErrorUserName.AutoSize = true;
            this.lblErrorUserName.ForeColor = System.Drawing.Color.Red;
            this.lblErrorUserName.Location = new System.Drawing.Point(321, 26);
            this.lblErrorUserName.Name = "lblErrorUserName";
            this.lblErrorUserName.Size = new System.Drawing.Size(0, 13);
            this.lblErrorUserName.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(144, 58);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(174, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(144, 20);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(174, 20);
            this.txtUserName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "User Name:";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(176, 231);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(123, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect SQL";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblSqlServer
            // 
            this.lblSqlServer.AutoSize = true;
            this.lblSqlServer.Location = new System.Drawing.Point(43, 33);
            this.lblSqlServer.Name = "lblSqlServer";
            this.lblSqlServer.Size = new System.Drawing.Size(72, 13);
            this.lblSqlServer.TabIndex = 4;
            this.lblSqlServer.Text = "Server Name:";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(179, 32);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(226, 20);
            this.txtServer.TabIndex = 5;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(55, 313);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(72, 16);
            this.lblMessage.TabIndex = 7;
            this.lblMessage.Text = "Message";
            // 
            // lblSQLConfiguration
            // 
            this.lblSQLConfiguration.AutoSize = true;
            this.lblSQLConfiguration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSQLConfiguration.Location = new System.Drawing.Point(23, 16);
            this.lblSQLConfiguration.Name = "lblSQLConfiguration";
            this.lblSQLConfiguration.Size = new System.Drawing.Size(219, 20);
            this.lblSQLConfiguration.TabIndex = 8;
            this.lblSQLConfiguration.Text = "SQL Configuration Screen";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pnlConfigurationScreen
            // 
            this.pnlConfigurationScreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlConfigurationScreen.Controls.Add(this.lblSqlServer);
            this.pnlConfigurationScreen.Controls.Add(this.txtServer);
            this.pnlConfigurationScreen.Controls.Add(this.lblMessage);
            this.pnlConfigurationScreen.Controls.Add(this.label1);
            this.pnlConfigurationScreen.Controls.Add(this.btnConnect);
            this.pnlConfigurationScreen.Controls.Add(this.cmbAuthenticationType);
            this.pnlConfigurationScreen.Controls.Add(this.grboxAuthenticationSQL);
            this.pnlConfigurationScreen.Location = new System.Drawing.Point(67, 70);
            this.pnlConfigurationScreen.Name = "pnlConfigurationScreen";
            this.pnlConfigurationScreen.Size = new System.Drawing.Size(442, 315);
            this.pnlConfigurationScreen.TabIndex = 9;
            // 
            // SQLServerConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnlConfigurationScreen);
            this.Controls.Add(this.lblSQLConfiguration);
            this.Name = "SQLServerConnect";
            this.Size = new System.Drawing.Size(615, 447);
            this.grboxAuthenticationSQL.ResumeLayout(false);
            this.grboxAuthenticationSQL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnlConfigurationScreen.ResumeLayout(false);
            this.pnlConfigurationScreen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAuthenticationType;
        private System.Windows.Forms.GroupBox grboxAuthenticationSQL;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblSqlServer;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label lblErrorUserName;
        private System.Windows.Forms.Label lblErrorPassword;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblSQLConfiguration;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel pnlConfigurationScreen;
    }
}

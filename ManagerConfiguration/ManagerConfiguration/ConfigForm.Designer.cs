namespace ManagerConfiguration
{
    partial class ConfigForm
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
            this.ConfigTabControl = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // ConfigTabControl
            // 
            this.ConfigTabControl.Location = new System.Drawing.Point(12, 12);
            this.ConfigTabControl.Name = "ConfigTabControl";
            this.ConfigTabControl.SelectedIndex = 0;
            this.ConfigTabControl.Size = new System.Drawing.Size(617, 449);
            this.ConfigTabControl.TabIndex = 0;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 487);
            this.Controls.Add(this.ConfigTabControl);
            this.MaximizeBox = false;
            this.Name = "ConfigForm";
            this.Text = "Configuration Manager";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ConfigTabControl;
    }
}


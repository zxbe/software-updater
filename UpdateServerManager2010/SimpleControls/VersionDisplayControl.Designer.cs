namespace UpdateServerManager2010.SimpleControls {
    partial class VersionDisplayControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.lblMajorText = new DevExpress.XtraEditors.LabelControl();
            this.lblMajorNumber = new DevExpress.XtraEditors.LabelControl();
            this.lblMinorNumber = new DevExpress.XtraEditors.LabelControl();
            this.lblMinorText = new DevExpress.XtraEditors.LabelControl();
            this.lblBuildNumber = new DevExpress.XtraEditors.LabelControl();
            this.lblBuildText = new DevExpress.XtraEditors.LabelControl();
            this.lblRevisionNumber = new DevExpress.XtraEditors.LabelControl();
            this.lblBuildRevision = new DevExpress.XtraEditors.LabelControl();
            this.lblVersionAsString = new DevExpress.XtraEditors.LabelControl();
            this.bsVersionNumber = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsVersionNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMajorText
            // 
            this.lblMajorText.Location = new System.Drawing.Point(18, 25);
            this.lblMajorText.Name = "lblMajorText";
            this.lblMajorText.Size = new System.Drawing.Size(27, 13);
            this.lblMajorText.TabIndex = 0;
            this.lblMajorText.Text = "Major";
            // 
            // lblMajorNumber
            // 
            this.lblMajorNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVersionNumber, "Major", true));
            this.lblMajorNumber.Location = new System.Drawing.Point(70, 25);
            this.lblMajorNumber.Name = "lblMajorNumber";
            this.lblMajorNumber.Size = new System.Drawing.Size(6, 13);
            this.lblMajorNumber.TabIndex = 1;
            this.lblMajorNumber.Text = "0";
            // 
            // lblMinorNumber
            // 
            this.lblMinorNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVersionNumber, "Minor", true));
            this.lblMinorNumber.Location = new System.Drawing.Point(70, 44);
            this.lblMinorNumber.Name = "lblMinorNumber";
            this.lblMinorNumber.Size = new System.Drawing.Size(6, 13);
            this.lblMinorNumber.TabIndex = 3;
            this.lblMinorNumber.Text = "0";
            // 
            // lblMinorText
            // 
            this.lblMinorText.Location = new System.Drawing.Point(18, 44);
            this.lblMinorText.Name = "lblMinorText";
            this.lblMinorText.Size = new System.Drawing.Size(26, 13);
            this.lblMinorText.TabIndex = 2;
            this.lblMinorText.Text = "Minor";
            // 
            // lblBuildNumber
            // 
            this.lblBuildNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVersionNumber, "Build", true));
            this.lblBuildNumber.Location = new System.Drawing.Point(70, 63);
            this.lblBuildNumber.Name = "lblBuildNumber";
            this.lblBuildNumber.Size = new System.Drawing.Size(6, 13);
            this.lblBuildNumber.TabIndex = 5;
            this.lblBuildNumber.Text = "0";
            // 
            // lblBuildText
            // 
            this.lblBuildText.Location = new System.Drawing.Point(18, 63);
            this.lblBuildText.Name = "lblBuildText";
            this.lblBuildText.Size = new System.Drawing.Size(22, 13);
            this.lblBuildText.TabIndex = 4;
            this.lblBuildText.Text = "Build";
            // 
            // lblRevisionNumber
            // 
            this.lblRevisionNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVersionNumber, "Revision", true));
            this.lblRevisionNumber.Location = new System.Drawing.Point(70, 82);
            this.lblRevisionNumber.Name = "lblRevisionNumber";
            this.lblRevisionNumber.Size = new System.Drawing.Size(6, 13);
            this.lblRevisionNumber.TabIndex = 7;
            this.lblRevisionNumber.Text = "0";
            // 
            // lblBuildRevision
            // 
            this.lblBuildRevision.Location = new System.Drawing.Point(18, 82);
            this.lblBuildRevision.Name = "lblBuildRevision";
            this.lblBuildRevision.Size = new System.Drawing.Size(40, 13);
            this.lblBuildRevision.TabIndex = 6;
            this.lblBuildRevision.Text = "Revision";
            // 
            // lblVersionAsString
            // 
            this.lblVersionAsString.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblVersionAsString.Appearance.Options.UseFont = true;
            this.lblVersionAsString.Location = new System.Drawing.Point(3, 3);
            this.lblVersionAsString.Name = "lblVersionAsString";
            this.lblVersionAsString.Size = new System.Drawing.Size(44, 16);
            this.lblVersionAsString.TabIndex = 8;
            this.lblVersionAsString.Text = "0.0.0.0";
            // 
            // bsVersionNumber
            // 
            this.bsVersionNumber.DataSource = typeof(Com.QueoMedia.Updater.Data.VersionNumber);
            // 
            // VersionDisplayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblVersionAsString);
            this.Controls.Add(this.lblRevisionNumber);
            this.Controls.Add(this.lblBuildRevision);
            this.Controls.Add(this.lblBuildNumber);
            this.Controls.Add(this.lblBuildText);
            this.Controls.Add(this.lblMinorNumber);
            this.Controls.Add(this.lblMinorText);
            this.Controls.Add(this.lblMajorNumber);
            this.Controls.Add(this.lblMajorText);
            this.Name = "VersionDisplayControl";
            this.Size = new System.Drawing.Size(127, 106);
            ((System.ComponentModel.ISupportInitialize)(this.bsVersionNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblMajorText;
        private DevExpress.XtraEditors.LabelControl lblMajorNumber;
        private DevExpress.XtraEditors.LabelControl lblMinorNumber;
        private DevExpress.XtraEditors.LabelControl lblMinorText;
        private DevExpress.XtraEditors.LabelControl lblBuildNumber;
        private DevExpress.XtraEditors.LabelControl lblBuildText;
        private DevExpress.XtraEditors.LabelControl lblRevisionNumber;
        private DevExpress.XtraEditors.LabelControl lblBuildRevision;
        private DevExpress.XtraEditors.LabelControl lblVersionAsString;
        private System.Windows.Forms.BindingSource bsVersionNumber;
    }
}

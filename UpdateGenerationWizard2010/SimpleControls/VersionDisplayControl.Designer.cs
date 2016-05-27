namespace UpdateGenerationWizard2010.SimpleControls {
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
            this.bsVersionNumber = new System.Windows.Forms.BindingSource(this.components);
            this.lblMinorText = new DevExpress.XtraEditors.LabelControl();
            this.lblBuildText = new DevExpress.XtraEditors.LabelControl();
            this.lblBuildRevision = new DevExpress.XtraEditors.LabelControl();
            this.lblVersionAsString = new DevExpress.XtraEditors.LabelControl();
            this.spinMinor = new DevExpress.XtraEditors.SpinEdit();
            this.spinMajor = new DevExpress.XtraEditors.SpinEdit();
            this.spinBuild = new DevExpress.XtraEditors.SpinEdit();
            this.spinRevision = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVersionNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinMinor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinMajor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinBuild.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinRevision.Properties)).BeginInit();
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
            // bsVersionNumber
            // 
            this.bsVersionNumber.DataSource = typeof(Com.QueoMedia.Updater.Data.VersionNumber);
            // 
            // lblMinorText
            // 
            this.lblMinorText.Location = new System.Drawing.Point(18, 51);
            this.lblMinorText.Name = "lblMinorText";
            this.lblMinorText.Size = new System.Drawing.Size(26, 13);
            this.lblMinorText.TabIndex = 2;
            this.lblMinorText.Text = "Minor";
            // 
            // lblBuildText
            // 
            this.lblBuildText.Location = new System.Drawing.Point(18, 77);
            this.lblBuildText.Name = "lblBuildText";
            this.lblBuildText.Size = new System.Drawing.Size(22, 13);
            this.lblBuildText.TabIndex = 4;
            this.lblBuildText.Text = "Build";
            // 
            // lblBuildRevision
            // 
            this.lblBuildRevision.Location = new System.Drawing.Point(18, 103);
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
            // spinMinor
            // 
            this.spinMinor.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinMinor.Location = new System.Drawing.Point(64, 48);
            this.spinMinor.Name = "spinMinor";
            this.spinMinor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinMinor.Properties.IsFloatValue = false;
            this.spinMinor.Properties.Mask.EditMask = "N00";
            this.spinMinor.Size = new System.Drawing.Size(68, 20);
            this.spinMinor.TabIndex = 9;
            this.spinMinor.ValueChanged += new System.EventHandler(this.SpinMinorValueChanged);
            // 
            // spinMajor
            // 
            this.spinMajor.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinMajor.Location = new System.Drawing.Point(64, 22);
            this.spinMajor.Name = "spinMajor";
            this.spinMajor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinMajor.Properties.IsFloatValue = false;
            this.spinMajor.Properties.Mask.EditMask = "N00";
            this.spinMajor.Size = new System.Drawing.Size(68, 20);
            this.spinMajor.TabIndex = 10;
            this.spinMajor.ValueChanged += new System.EventHandler(this.SpinMajorValueChanged);
            // 
            // spinBuild
            // 
            this.spinBuild.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinBuild.Location = new System.Drawing.Point(64, 74);
            this.spinBuild.Name = "spinBuild";
            this.spinBuild.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinBuild.Properties.IsFloatValue = false;
            this.spinBuild.Properties.Mask.EditMask = "N00";
            this.spinBuild.Size = new System.Drawing.Size(68, 20);
            this.spinBuild.TabIndex = 11;
            this.spinBuild.ValueChanged += new System.EventHandler(this.SpinBuildValueChanged);
            // 
            // spinRevision
            // 
            this.spinRevision.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinRevision.Location = new System.Drawing.Point(64, 100);
            this.spinRevision.Name = "spinRevision";
            this.spinRevision.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spinRevision.Properties.IsFloatValue = false;
            this.spinRevision.Properties.Mask.EditMask = "N00";
            this.spinRevision.Size = new System.Drawing.Size(68, 20);
            this.spinRevision.TabIndex = 12;
            this.spinRevision.ValueChanged += new System.EventHandler(this.SpinRevisionValueChanged);
            // 
            // VersionDisplayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spinRevision);
            this.Controls.Add(this.spinBuild);
            this.Controls.Add(this.spinMajor);
            this.Controls.Add(this.spinMinor);
            this.Controls.Add(this.lblVersionAsString);
            this.Controls.Add(this.lblBuildRevision);
            this.Controls.Add(this.lblBuildText);
            this.Controls.Add(this.lblMinorText);
            this.Controls.Add(this.lblMajorText);
            this.Name = "VersionDisplayControl";
            this.Size = new System.Drawing.Size(145, 134);
            ((System.ComponentModel.ISupportInitialize)(this.bsVersionNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinMinor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinMajor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinBuild.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinRevision.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblMajorText;
        private DevExpress.XtraEditors.LabelControl lblMinorText;
        private DevExpress.XtraEditors.LabelControl lblBuildText;
        private DevExpress.XtraEditors.LabelControl lblBuildRevision;
        private DevExpress.XtraEditors.LabelControl lblVersionAsString;
        private System.Windows.Forms.BindingSource bsVersionNumber;
        private DevExpress.XtraEditors.SpinEdit spinMinor;
        private DevExpress.XtraEditors.SpinEdit spinMajor;
        private DevExpress.XtraEditors.SpinEdit spinBuild;
        private DevExpress.XtraEditors.SpinEdit spinRevision;
    }
}

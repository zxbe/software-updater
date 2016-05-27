namespace UpdateServerManager2010.Views.ZipImportWizard.Winform.Implementation {
    partial class ZipWizard {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.welcomeWizardPage1 = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.page1BtnEdit = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.wizardPage1 = new DevExpress.XtraWizard.WizardPage();
            this.wizardPage2 = new DevExpress.XtraWizard.WizardPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonEdit1 = new DevExpress.XtraEditors.ButtonEdit();
            this.wizardControl1 = new DevExpress.XtraWizard.WizardControl();
            this.completionWizardPage1 = new DevExpress.XtraWizard.CompletionWizardPage();
            this.wizardControl2 = new DevExpress.XtraWizard.WizardControl();
            this.page1 = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.page1FileStatus = new DevExpress.XtraEditors.LabelControl();
            this.page1BtnTxt = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.page2 = new DevExpress.XtraWizard.WizardPage();
            this.zipContent = new DevExpress.XtraEditors.ListBoxControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.VersionResultsIn = new UpdateServerManager2010.SimpleControls.VersionDisplayControl();
            this.versionAppliesTo = new UpdateServerManager2010.SimpleControls.VersionDisplayControl();
            this.page4 = new DevExpress.XtraWizard.CompletionWizardPage();
            this.page4LstOperations = new DevExpress.XtraEditors.ListBoxControl();
            this.gaugeControl1 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.linearGauge1 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge();
            this.linearScaleBackgroundLayerComponent1 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent();
            this.linearScaleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent();
            this.linearScaleLevelComponent1 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent();
            this.linearScaleComponent2 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent();
            this.page3 = new DevExpress.XtraWizard.WizardPage();
            this.page3LstValidations = new DevExpress.XtraEditors.ListBoxControl();
            this.welcomeWizardPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.page1BtnEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.wizardControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl2)).BeginInit();
            this.wizardControl2.SuspendLayout();
            this.page1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.page1BtnTxt.Properties)).BeginInit();
            this.page2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zipContent)).BeginInit();
            this.page4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.page4LstOperations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearGauge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleBackgroundLayerComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleLevelComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleComponent2)).BeginInit();
            this.page3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.page3LstValidations)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Black";
            // 
            // welcomeWizardPage1
            // 
            this.welcomeWizardPage1.Controls.Add(this.labelControl2);
            this.welcomeWizardPage1.Controls.Add(this.page1BtnEdit);
            this.welcomeWizardPage1.Controls.Add(this.labelControl1);
            this.welcomeWizardPage1.Name = "welcomeWizardPage1";
            this.welcomeWizardPage1.Size = new System.Drawing.Size(389, 149);
            this.welcomeWizardPage1.Text = "ZIP Import";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(94, 26);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "labelControl2";
            // 
            // page1BtnEdit
            // 
            this.page1BtnEdit.EditValue = "";
            this.page1BtnEdit.Location = new System.Drawing.Point(94, 0);
            this.page1BtnEdit.Name = "page1BtnEdit";
            this.page1BtnEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "Datei öffnen", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.Default, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.page1BtnEdit.Size = new System.Drawing.Size(280, 20);
            this.page1BtnEdit.TabIndex = 2;
            this.page1BtnEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ButtonEdit1ButtonClick);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(3, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(85, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ZIP Datei wählen:";
            // 
            // wizardPage1
            // 
            this.wizardPage1.Name = "wizardPage1";
            this.wizardPage1.Size = new System.Drawing.Size(389, 149);
            this.wizardPage1.Text = "Update Inhalte";
            // 
            // wizardPage2
            // 
            this.wizardPage2.Name = "wizardPage2";
            this.wizardPage2.Size = new System.Drawing.Size(389, 149);
            this.wizardPage2.Text = "Versionsprüfung";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Zu importierende ZIP Datei wählen ...";
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.EditValue = "";
            this.buttonEdit1.Location = new System.Drawing.Point(94, 0);
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.Size = new System.Drawing.Size(280, 20);
            this.buttonEdit1.TabIndex = 2;
            // 
            // wizardControl1
            // 
            this.wizardControl1.Controls.Add(this.welcomeWizardPage1);
            this.wizardControl1.Controls.Add(this.wizardPage1);
            this.wizardControl1.Controls.Add(this.wizardPage2);
            this.wizardControl1.Controls.Add(this.completionWizardPage1);
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.Location = new System.Drawing.Point(0, 0);
            this.wizardControl1.LookAndFeel.SkinName = "Black";
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.welcomeWizardPage1,
            this.wizardPage1,
            this.wizardPage2});
            this.wizardControl1.Size = new System.Drawing.Size(449, 309);
            this.wizardControl1.Text = "ZIP Import";
            this.wizardControl1.WizardStyle = DevExpress.XtraWizard.WizardStyle.WizardAero;
            // 
            // completionWizardPage1
            // 
            this.completionWizardPage1.Name = "completionWizardPage1";
            this.completionWizardPage1.Size = new System.Drawing.Size(389, 149);
            this.completionWizardPage1.Text = "Update bereitstellen";
            // 
            // wizardControl2
            // 
            this.wizardControl2.Controls.Add(this.page1);
            this.wizardControl2.Controls.Add(this.page2);
            this.wizardControl2.Controls.Add(this.page4);
            this.wizardControl2.Controls.Add(this.page3);
            this.wizardControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl2.Location = new System.Drawing.Point(0, 0);
            this.wizardControl2.LookAndFeel.SkinName = "Black";
            this.wizardControl2.Name = "wizardControl2";
            this.wizardControl2.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.page1,
            this.page2,
            this.page3,
            this.page4});
            this.wizardControl2.Size = new System.Drawing.Size(560, 309);
            this.wizardControl2.Text = "ZIP Import";
            this.wizardControl2.WizardStyle = DevExpress.XtraWizard.WizardStyle.WizardAero;
            this.wizardControl2.SelectedPageChanged += new DevExpress.XtraWizard.WizardPageChangedEventHandler(this.WizardControl2SelectedPageChanged);
            // 
            // page1
            // 
            this.page1.AllowNext = false;
            this.page1.Controls.Add(this.page1FileStatus);
            this.page1.Controls.Add(this.page1BtnTxt);
            this.page1.Controls.Add(this.labelControl3);
            this.page1.Name = "page1";
            this.page1.Size = new System.Drawing.Size(500, 149);
            this.page1.Text = "ZIP Datei wählen";
            // 
            // page1FileStatus
            // 
            this.page1FileStatus.Location = new System.Drawing.Point(157, 75);
            this.page1FileStatus.Name = "page1FileStatus";
            this.page1FileStatus.Size = new System.Drawing.Size(70, 13);
            this.page1FileStatus.TabIndex = 2;
            this.page1FileStatus.Text = "Dateistatus ...";
            // 
            // page1BtnTxt
            // 
            this.page1BtnTxt.Location = new System.Drawing.Point(157, 49);
            this.page1BtnTxt.Name = "page1BtnTxt";
            this.page1BtnTxt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "Datei öffnen", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.Default, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.page1BtnTxt.Size = new System.Drawing.Size(270, 20);
            this.page1BtnTxt.TabIndex = 1;
            this.page1BtnTxt.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.Page1BtnTxtButtonClick);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(68, 52);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(83, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Zip Datei wählen:";
            // 
            // page2
            // 
            this.page2.AllowNext = false;
            this.page2.Controls.Add(this.zipContent);
            this.page2.Controls.Add(this.labelControl5);
            this.page2.Controls.Add(this.labelControl4);
            this.page2.Controls.Add(this.VersionResultsIn);
            this.page2.Controls.Add(this.versionAppliesTo);
            this.page2.Name = "page2";
            this.page2.Size = new System.Drawing.Size(500, 149);
            this.page2.Text = "Inhalte";
            // 
            // zipContent
            // 
            this.zipContent.Location = new System.Drawing.Point(275, 3);
            this.zipContent.Name = "zipContent";
            this.zipContent.Size = new System.Drawing.Size(222, 143);
            this.zipContent.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(142, 3);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(85, 13);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Erzeugte Version:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(9, 3);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(88, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Benötigte Version:";
            // 
            // VersionResultsIn
            // 
            this.VersionResultsIn.Appearance.BackColor = System.Drawing.Color.White;
            this.VersionResultsIn.Appearance.Options.UseBackColor = true;
            this.VersionResultsIn.Location = new System.Drawing.Point(142, 22);
            this.VersionResultsIn.Name = "VersionResultsIn";
            this.VersionResultsIn.Size = new System.Drawing.Size(127, 106);
            this.VersionResultsIn.TabIndex = 1;
            // 
            // versionAppliesTo
            // 
            this.versionAppliesTo.Appearance.BackColor = System.Drawing.Color.White;
            this.versionAppliesTo.Appearance.Options.UseBackColor = true;
            this.versionAppliesTo.Location = new System.Drawing.Point(9, 22);
            this.versionAppliesTo.Name = "versionAppliesTo";
            this.versionAppliesTo.Size = new System.Drawing.Size(127, 106);
            this.versionAppliesTo.TabIndex = 0;
            // 
            // page4
            // 
            this.page4.AllowBack = false;
            this.page4.AllowCancel = false;
            this.page4.AllowNext = false;
            this.page4.Controls.Add(this.page4LstOperations);
            this.page4.Controls.Add(this.gaugeControl1);
            this.page4.Name = "page4";
            this.page4.Size = new System.Drawing.Size(500, 149);
            this.page4.Text = "Bereitstellung";
            // 
            // page4LstOperations
            // 
            this.page4LstOperations.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.page4LstOperations.Location = new System.Drawing.Point(3, 3);
            this.page4LstOperations.Name = "page4LstOperations";
            this.page4LstOperations.Size = new System.Drawing.Size(230, 143);
            this.page4LstOperations.TabIndex = 1;
            // 
            // gaugeControl1
            // 
            this.gaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gaugeControl1.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.linearGauge1});
            this.gaugeControl1.Location = new System.Drawing.Point(239, 1);
            this.gaugeControl1.Name = "gaugeControl1";
            this.gaugeControl1.Size = new System.Drawing.Size(258, 146);
            this.gaugeControl1.TabIndex = 0;
            // 
            // linearGauge1
            // 
            this.linearGauge1.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent[] {
            this.linearScaleBackgroundLayerComponent1});
            this.linearGauge1.Bounds = new System.Drawing.Rectangle(6, 6, 246, 134);
            this.linearGauge1.Levels.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent[] {
            this.linearScaleLevelComponent1});
            this.linearGauge1.Name = "linearGauge1";
            this.linearGauge1.Orientation = DevExpress.XtraGauges.Core.Model.ScaleOrientation.Horizontal;
            this.linearGauge1.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent[] {
            this.linearScaleComponent1,
            this.linearScaleComponent2});
            // 
            // linearScaleBackgroundLayerComponent1
            // 
            this.linearScaleBackgroundLayerComponent1.LinearScale = this.linearScaleComponent1;
            this.linearScaleBackgroundLayerComponent1.Name = "bg1";
            this.linearScaleBackgroundLayerComponent1.ScaleEndPos = new DevExpress.XtraGauges.Core.Base.PointF2D(0.508F, 0.08F);
            this.linearScaleBackgroundLayerComponent1.ScaleStartPos = new DevExpress.XtraGauges.Core.Base.PointF2D(0.508F, 0.92F);
            this.linearScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style11;
            this.linearScaleBackgroundLayerComponent1.ZOrder = 1000;
            // 
            // linearScaleComponent1
            // 
            this.linearScaleComponent1.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black");
            this.linearScaleComponent1.EndPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 20F);
            this.linearScaleComponent1.MajorTickCount = 6;
            this.linearScaleComponent1.MajorTickmark.FormatString = "{0:F0}";
            this.linearScaleComponent1.MajorTickmark.ShapeOffset = 6F;
            this.linearScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style11_2;
            this.linearScaleComponent1.MajorTickmark.TextOffset = 35F;
            this.linearScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.BottomToTop;
            this.linearScaleComponent1.MaxValue = 100F;
            this.linearScaleComponent1.MinorTickCount = 4;
            this.linearScaleComponent1.MinorTickmark.ShapeOffset = 6F;
            this.linearScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style11_1;
            this.linearScaleComponent1.Name = "scale1";
            this.linearScaleComponent1.StartPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 230F);
            this.linearScaleComponent1.Value = 100F;
            // 
            // linearScaleLevelComponent1
            // 
            this.linearScaleLevelComponent1.LinearScale = this.linearScaleComponent1;
            this.linearScaleLevelComponent1.Name = "level1";
            this.linearScaleLevelComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style11;
            this.linearScaleLevelComponent1.ZOrder = -50;
            // 
            // linearScaleComponent2
            // 
            this.linearScaleComponent2.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black");
            this.linearScaleComponent2.EndPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 20F);
            this.linearScaleComponent2.MajorTickCount = 6;
            this.linearScaleComponent2.MajorTickmark.FormatString = "{0:F0}";
            this.linearScaleComponent2.MajorTickmark.ShapeOffset = -18F;
            this.linearScaleComponent2.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style11_3;
            this.linearScaleComponent2.MajorTickmark.TextOffset = -32F;
            this.linearScaleComponent2.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.BottomToTop;
            this.linearScaleComponent2.MaxValue = 100F;
            this.linearScaleComponent2.MinorTickCount = 4;
            this.linearScaleComponent2.MinorTickmark.ShapeOffset = -12F;
            this.linearScaleComponent2.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style11_4;
            this.linearScaleComponent2.Name = "scale2";
            this.linearScaleComponent2.StartPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 230F);
            // 
            // page3
            // 
            this.page3.AllowNext = false;
            this.page3.Controls.Add(this.page3LstValidations);
            this.page3.Name = "page3";
            this.page3.Size = new System.Drawing.Size(500, 149);
            this.page3.Text = "Prüfung";
            // 
            // page3LstValidations
            // 
            this.page3LstValidations.Location = new System.Drawing.Point(3, 3);
            this.page3LstValidations.Name = "page3LstValidations";
            this.page3LstValidations.Size = new System.Drawing.Size(494, 143);
            this.page3LstValidations.TabIndex = 0;
            // 
            // ZipWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 309);
            this.ControlBox = false;
            this.Controls.Add(this.wizardControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(566, 334);
            this.Name = "ZipWizard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.welcomeWizardPage1.ResumeLayout(false);
            this.welcomeWizardPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.page1BtnEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.wizardControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl2)).EndInit();
            this.wizardControl2.ResumeLayout(false);
            this.page1.ResumeLayout(false);
            this.page1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.page1BtnTxt.Properties)).EndInit();
            this.page2.ResumeLayout(false);
            this.page2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zipContent)).EndInit();
            this.page4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.page4LstOperations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearGauge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleBackgroundLayerComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleLevelComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleComponent2)).EndInit();
            this.page3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.page3LstValidations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraWizard.WelcomeWizardPage welcomeWizardPage1;
        private DevExpress.XtraWizard.WizardPage wizardPage1;
        private DevExpress.XtraWizard.WizardPage wizardPage2;
        private DevExpress.XtraEditors.ButtonEdit page1BtnEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ButtonEdit buttonEdit1;
        private DevExpress.XtraWizard.WizardControl wizardControl1;
        private DevExpress.XtraWizard.WizardControl wizardControl2;
        private DevExpress.XtraWizard.WelcomeWizardPage page1;
        private DevExpress.XtraEditors.LabelControl page1FileStatus;
        private DevExpress.XtraEditors.ButtonEdit page1BtnTxt;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraWizard.WizardPage page2;
        private DevExpress.XtraWizard.CompletionWizardPage page4;
        private DevExpress.XtraWizard.WizardPage page3;
        private DevExpress.XtraWizard.CompletionWizardPage completionWizardPage1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private SimpleControls.VersionDisplayControl VersionResultsIn;
        private SimpleControls.VersionDisplayControl versionAppliesTo;
        private DevExpress.XtraEditors.ListBoxControl zipContent;
        private DevExpress.XtraEditors.ListBoxControl page3LstValidations;
        private DevExpress.XtraEditors.ListBoxControl page4LstOperations;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl1;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge linearGauge1;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent linearScaleBackgroundLayerComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent linearScaleComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent linearScaleLevelComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent linearScaleComponent2;
    }
}
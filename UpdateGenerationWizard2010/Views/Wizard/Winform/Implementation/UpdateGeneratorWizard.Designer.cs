namespace UpdateGenerationWizard2010.Views.Wizard.Winform.Implementation {
    partial class UpdateGeneratorWizard {
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
            Com.QueoMedia.Updater.Data.VersionNumber versionNumber1 = new Com.QueoMedia.Updater.Data.VersionNumber();
            Com.QueoMedia.Updater.Data.VersionNumber versionNumber2 = new Com.QueoMedia.Updater.Data.VersionNumber();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.wizardControl1 = new DevExpress.XtraWizard.WizardControl();
            this.wizP1 = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.versionAppliesTo = new UpdateGenerationWizard2010.SimpleControls.VersionDisplayControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.wizP2 = new DevExpress.XtraWizard.WizardPage();
            this.versionResultsIn = new UpdateGenerationWizard2010.SimpleControls.VersionDisplayControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.wizP5 = new DevExpress.XtraWizard.CompletionWizardPage();
            this.txtFinalDestination = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.wizP3 = new DevExpress.XtraWizard.WizardPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bsFiles = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDirectory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTxtDirectory = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colFile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repTxtBtnFile = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colOperation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCmbOperation = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colUpdateType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repCmbType = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.wizP4 = new DevExpress.XtraWizard.WizardPage();
            this.txtBtnFinalFolder = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.wizardControl1.SuspendLayout();
            this.wizP1.SuspendLayout();
            this.wizP2.SuspendLayout();
            this.wizP5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFinalDestination.Properties)).BeginInit();
            this.wizP3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTxtDirectory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTxtBtnFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCmbOperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCmbType)).BeginInit();
            this.wizP4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBtnFinalFolder.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Black";
            // 
            // wizardControl1
            // 
            this.wizardControl1.CancelText = "Abbrechen";
            this.wizardControl1.Controls.Add(this.wizP1);
            this.wizardControl1.Controls.Add(this.wizP2);
            this.wizardControl1.Controls.Add(this.wizP5);
            this.wizardControl1.Controls.Add(this.wizP3);
            this.wizardControl1.Controls.Add(this.wizP4);
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.Location = new System.Drawing.Point(0, 0);
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.NextText = "&Weiter >";
            this.wizardControl1.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.wizP1,
            this.wizP2,
            this.wizP3,
            this.wizP4,
            this.wizP5});
            this.wizardControl1.Size = new System.Drawing.Size(820, 527);
            this.wizardControl1.Text = "Update Erstellungs Assistent";
            this.wizardControl1.WizardStyle = DevExpress.XtraWizard.WizardStyle.WizardAero;
            this.wizardControl1.SelectedPageChanged += new DevExpress.XtraWizard.WizardPageChangedEventHandler(this.WizardControl1SelectedPageChanged);
            this.wizardControl1.CancelClick += new System.ComponentModel.CancelEventHandler(this.WizardControl1CancelClick);
            this.wizardControl1.FinishClick += new System.ComponentModel.CancelEventHandler(this.WizardControl1FinishClick);
            // 
            // wizP1
            // 
            this.wizP1.Controls.Add(this.versionAppliesTo);
            this.wizP1.Controls.Add(this.labelControl1);
            this.wizP1.Name = "wizP1";
            this.wizP1.Size = new System.Drawing.Size(760, 364);
            this.wizP1.Text = "Aktuelle Version";
            // 
            // versionAppliesTo
            // 
            this.versionAppliesTo.Appearance.BackColor = System.Drawing.Color.White;
            this.versionAppliesTo.Appearance.Options.UseBackColor = true;
            this.versionAppliesTo.Location = new System.Drawing.Point(284, 115);
            this.versionAppliesTo.Name = "versionAppliesTo";
            this.versionAppliesTo.Size = new System.Drawing.Size(145, 134);
            this.versionAppliesTo.TabIndex = 1;
            versionNumber1.Build = "0";
            versionNumber1.Major = "0";
            versionNumber1.Minor = "0";
            versionNumber1.Revision = "0";
            this.versionAppliesTo.VersionNumber = versionNumber1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(152, 71);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(441, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Auf welche Programmversion soll dieses Update angewand werden?";
            // 
            // wizP2
            // 
            this.wizP2.AllowNext = false;
            this.wizP2.Controls.Add(this.versionResultsIn);
            this.wizP2.Controls.Add(this.labelControl2);
            this.wizP2.Name = "wizP2";
            this.wizP2.Size = new System.Drawing.Size(760, 364);
            this.wizP2.Text = "Resultierende Version";
            // 
            // versionResultsIn
            // 
            this.versionResultsIn.Appearance.BackColor = System.Drawing.Color.White;
            this.versionResultsIn.Appearance.Options.UseBackColor = true;
            this.versionResultsIn.Location = new System.Drawing.Point(284, 115);
            this.versionResultsIn.Name = "versionResultsIn";
            this.versionResultsIn.Size = new System.Drawing.Size(145, 134);
            this.versionResultsIn.TabIndex = 3;
            versionNumber2.Build = "0";
            versionNumber2.Major = "0";
            versionNumber2.Minor = "0";
            versionNumber2.Revision = "0";
            this.versionResultsIn.VersionNumber = versionNumber2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(191, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(364, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Welche Programmversion liegt nach diesem Update vor?";
            // 
            // wizP5
            // 
            this.wizP5.AllowNext = false;
            this.wizP5.Controls.Add(this.txtFinalDestination);
            this.wizP5.Controls.Add(this.labelControl4);
            this.wizP5.Name = "wizP5";
            this.wizP5.Size = new System.Drawing.Size(760, 364);
            this.wizP5.Text = "Erstellung abgeschlossen";
            // 
            // txtFinalDestination
            // 
            this.txtFinalDestination.Location = new System.Drawing.Point(203, 157);
            this.txtFinalDestination.Name = "txtFinalDestination";
            this.txtFinalDestination.Size = new System.Drawing.Size(393, 20);
            this.txtFinalDestination.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(167, 110);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(456, 16);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Das Update wurde erstellt und als Datei im gewählen Ordner abgelegt.";
            // 
            // wizP3
            // 
            this.wizP3.AllowNext = false;
            this.wizP3.Controls.Add(this.gridControl1);
            this.wizP3.Name = "wizP3";
            this.wizP3.Size = new System.Drawing.Size(760, 364);
            this.wizP3.Text = "Update Inhalte";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bsFiles;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repTxtDirectory,
            this.repTxtBtnFile,
            this.repCmbOperation,
            this.repCmbType});
            this.gridControl1.Size = new System.Drawing.Size(760, 364);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bsFiles
            // 
            this.bsFiles.DataSource = typeof(UpdateGenerationWizard2010.Data.UpdateFileDto);
            this.bsFiles.CurrentChanged += new System.EventHandler(this.BsFilesCurrentChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDirectory,
            this.colFile,
            this.colOperation,
            this.colUpdateType});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowColumnMoving = false;
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colDirectory
            // 
            this.colDirectory.Caption = "Verzeichnis";
            this.colDirectory.ColumnEdit = this.repTxtDirectory;
            this.colDirectory.FieldName = "Directory";
            this.colDirectory.Name = "colDirectory";
            this.colDirectory.Visible = true;
            this.colDirectory.VisibleIndex = 0;
            this.colDirectory.Width = 178;
            // 
            // repTxtDirectory
            // 
            this.repTxtDirectory.AutoHeight = false;
            this.repTxtDirectory.Name = "repTxtDirectory";
            // 
            // colFile
            // 
            this.colFile.Caption = "Datei";
            this.colFile.ColumnEdit = this.repTxtBtnFile;
            this.colFile.FieldName = "File";
            this.colFile.Name = "colFile";
            this.colFile.Visible = true;
            this.colFile.VisibleIndex = 1;
            this.colFile.Width = 401;
            // 
            // repTxtBtnFile
            // 
            this.repTxtBtnFile.AutoHeight = false;
            this.repTxtBtnFile.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repTxtBtnFile.Name = "repTxtBtnFile";
            this.repTxtBtnFile.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.RepTxtBtnFileButtonClick);
            // 
            // colOperation
            // 
            this.colOperation.Caption = "Operation";
            this.colOperation.ColumnEdit = this.repCmbOperation;
            this.colOperation.FieldName = "Operation";
            this.colOperation.MaxWidth = 70;
            this.colOperation.MinWidth = 70;
            this.colOperation.Name = "colOperation";
            this.colOperation.Visible = true;
            this.colOperation.VisibleIndex = 2;
            this.colOperation.Width = 70;
            // 
            // repCmbOperation
            // 
            this.repCmbOperation.AutoHeight = false;
            this.repCmbOperation.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repCmbOperation.Items.AddRange(new object[] {
            "Hinzufügen",
            "Entfernen"});
            this.repCmbOperation.Name = "repCmbOperation";
            // 
            // colUpdateType
            // 
            this.colUpdateType.Caption = "Typ";
            this.colUpdateType.ColumnEdit = this.repCmbType;
            this.colUpdateType.FieldName = "UpdateType";
            this.colUpdateType.MaxWidth = 70;
            this.colUpdateType.MinWidth = 70;
            this.colUpdateType.Name = "colUpdateType";
            this.colUpdateType.Visible = true;
            this.colUpdateType.VisibleIndex = 3;
            this.colUpdateType.Width = 70;
            // 
            // repCmbType
            // 
            this.repCmbType.AutoHeight = false;
            this.repCmbType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repCmbType.Items.AddRange(new object[] {
            "Datei",
            "ZIP"});
            this.repCmbType.Name = "repCmbType";
            // 
            // wizP4
            // 
            this.wizP4.AllowNext = false;
            this.wizP4.Controls.Add(this.txtBtnFinalFolder);
            this.wizP4.Controls.Add(this.labelControl3);
            this.wizP4.Name = "wizP4";
            this.wizP4.Size = new System.Drawing.Size(760, 364);
            this.wizP4.Text = "Zielverzeichnis";
            // 
            // txtBtnFinalFolder
            // 
            this.txtBtnFinalFolder.Location = new System.Drawing.Point(211, 157);
            this.txtBtnFinalFolder.Name = "txtBtnFinalFolder";
            this.txtBtnFinalFolder.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtBtnFinalFolder.Size = new System.Drawing.Size(328, 20);
            this.txtBtnFinalFolder.TabIndex = 4;
            this.txtBtnFinalFolder.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.ButtonEdit1ButtonClick);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(192, 110);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(374, 16);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "In welchem Verzeichnis soll das Update abgelegt werden?";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // UpdateGeneratorWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 527);
            this.ControlBox = false;
            this.Controls.Add(this.wizardControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.LookAndFeel.SkinName = "Black";
            this.MaximizeBox = false;
            this.Name = "UpdateGeneratorWizard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.wizardControl1.ResumeLayout(false);
            this.wizP1.ResumeLayout(false);
            this.wizP1.PerformLayout();
            this.wizP2.ResumeLayout(false);
            this.wizP2.PerformLayout();
            this.wizP5.ResumeLayout(false);
            this.wizP5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFinalDestination.Properties)).EndInit();
            this.wizP3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTxtDirectory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repTxtBtnFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCmbOperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCmbType)).EndInit();
            this.wizP4.ResumeLayout(false);
            this.wizP4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBtnFinalFolder.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraWizard.WizardControl wizardControl1;
        private DevExpress.XtraWizard.WelcomeWizardPage wizP1;
        private DevExpress.XtraWizard.WizardPage wizP2;
        private DevExpress.XtraWizard.CompletionWizardPage wizP5;
        private DevExpress.XtraWizard.WizardPage wizP3;
        private DevExpress.XtraWizard.WizardPage wizP4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private SimpleControls.VersionDisplayControl versionAppliesTo;
        private SimpleControls.VersionDisplayControl versionResultsIn;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtFinalDestination;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repTxtDirectory;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repTxtBtnFile;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repCmbOperation;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repCmbType;
        private DevExpress.XtraEditors.ButtonEdit txtBtnFinalFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.BindingSource bsFiles;
        private DevExpress.XtraGrid.Columns.GridColumn colDirectory;
        private DevExpress.XtraGrid.Columns.GridColumn colFile;
        private DevExpress.XtraGrid.Columns.GridColumn colOperation;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdateType;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
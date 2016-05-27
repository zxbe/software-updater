namespace UpdateServerManager2010.Views.ServerGeneratorWizard.Winform.Implementation {
    partial class ServerWizard {
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.wizardControl1 = new DevExpress.XtraWizard.WizardControl();
            this.wizP1 = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.page1LblExecutable = new DevExpress.XtraEditors.LabelControl();
            this.page1TxtExecutable = new DevExpress.XtraEditors.TextEdit();
            this.page1LblError = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.page1TxtServername = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.page1BtnTxt = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.wizP2 = new DevExpress.XtraWizard.WizardPage();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.page2TxtProxyHttpsPort = new DevExpress.XtraEditors.TextEdit();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.page2TxtProxyPwd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.page2TxtProxyUser = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.page2TxtProxyUrl = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.page2TxtSecurityPwd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.page2TxtSecurityUser = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.page2TxtServerpath = new DevExpress.XtraEditors.TextEdit();
            this.wizP3 = new DevExpress.XtraWizard.CompletionWizardPage();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.page3TxtInfoXmlContent = new System.Windows.Forms.TextBox();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.wizardControl1.SuspendLayout();
            this.wizP1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.page1TxtExecutable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.page1TxtServername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.page1BtnTxt.Properties)).BeginInit();
            this.wizP2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.page2TxtProxyHttpsPort.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.page2TxtProxyPwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.page2TxtProxyUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.page2TxtProxyUrl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.page2TxtSecurityPwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.page2TxtSecurityUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.page2TxtServerpath.Properties)).BeginInit();
            this.wizP3.SuspendLayout();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Black";
            // 
            // wizardControl1
            // 
            this.wizardControl1.Controls.Add(this.wizP1);
            this.wizardControl1.Controls.Add(this.wizP2);
            this.wizardControl1.Controls.Add(this.wizP3);
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.Location = new System.Drawing.Point(0, 0);
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.wizP1,
            this.wizP2,
            this.wizP3});
            this.wizardControl1.Size = new System.Drawing.Size(636, 520);
            this.wizardControl1.Text = "Neuen Server erstellen";
            this.wizardControl1.WizardStyle = DevExpress.XtraWizard.WizardStyle.WizardAero;
            this.wizardControl1.SelectedPageChanged += new DevExpress.XtraWizard.WizardPageChangedEventHandler(this.WizardControl1SelectedPageChanged);
            this.wizardControl1.CancelClick += new System.ComponentModel.CancelEventHandler(this.WizardControl1CancelClick);
            // 
            // wizP1
            // 
            this.wizP1.AllowNext = false;
            this.wizP1.Controls.Add(this.labelControl23);
            this.wizP1.Controls.Add(this.page1LblExecutable);
            this.wizP1.Controls.Add(this.page1TxtExecutable);
            this.wizP1.Controls.Add(this.page1LblError);
            this.wizP1.Controls.Add(this.labelControl4);
            this.wizP1.Controls.Add(this.labelControl2);
            this.wizP1.Controls.Add(this.page1TxtServername);
            this.wizP1.Controls.Add(this.labelControl1);
            this.wizP1.Controls.Add(this.page1BtnTxt);
            this.wizP1.Controls.Add(this.labelControl3);
            this.wizP1.Name = "wizP1";
            this.wizP1.Size = new System.Drawing.Size(576, 360);
            this.wizP1.Text = "Grundlegende Einstellungen";
            // 
            // labelControl23
            // 
            this.labelControl23.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl23.Appearance.Options.UseForeColor = true;
            this.labelControl23.Location = new System.Drawing.Point(172, 294);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(231, 26);
            this.labelControl23.TabIndex = 17;
            this.labelControl23.Text = "Kompletter Name der Datei die nach Ausführung\r\neines Updates aufgerufen werden so" +
                "ll.";
            // 
            // page1LblExecutable
            // 
            this.page1LblExecutable.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.page1LblExecutable.Appearance.Options.UseFont = true;
            this.page1LblExecutable.Location = new System.Drawing.Point(121, 253);
            this.page1LblExecutable.Name = "page1LblExecutable";
            this.page1LblExecutable.Size = new System.Drawing.Size(61, 13);
            this.page1LblExecutable.TabIndex = 16;
            this.page1LblExecutable.Text = "Startdatei:";
            // 
            // page1TxtExecutable
            // 
            this.page1TxtExecutable.Location = new System.Drawing.Point(172, 272);
            this.page1TxtExecutable.Name = "page1TxtExecutable";
            this.page1TxtExecutable.Size = new System.Drawing.Size(270, 20);
            this.page1TxtExecutable.TabIndex = 15;
            // 
            // page1LblError
            // 
            this.page1LblError.Appearance.ForeColor = System.Drawing.Color.Red;
            this.page1LblError.Appearance.Options.UseForeColor = true;
            this.page1LblError.Location = new System.Drawing.Point(172, 200);
            this.page1LblError.Name = "page1LblError";
            this.page1LblError.Size = new System.Drawing.Size(69, 13);
            this.page1LblError.TabIndex = 14;
            this.page1LblError.Text = "labelControl23";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(172, 157);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(219, 26);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Name des Servers, der später auch\r\nin den Konfigurationsdateien verwendet wird.";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(121, 112);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(73, 13);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Servername:";
            // 
            // page1TxtServername
            // 
            this.page1TxtServername.Location = new System.Drawing.Point(172, 131);
            this.page1TxtServername.Name = "page1TxtServername";
            this.page1TxtServername.Size = new System.Drawing.Size(270, 20);
            this.page1TxtServername.TabIndex = 11;
            this.page1TxtServername.TextChanged += new System.EventHandler(this.Page1TxtServernameTextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(172, 67);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(257, 39);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Ordner in dem der neue Server angelegt werden soll.\r\nInnerhalb dieses Ordners wir" +
                "d später ein Unterordner\r\nmit dem Namen des Server angelegt.";
            // 
            // page1BtnTxt
            // 
            this.page1BtnTxt.Location = new System.Drawing.Point(172, 43);
            this.page1BtnTxt.Name = "page1BtnTxt";
            this.page1BtnTxt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "Ordner wählen", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.Default, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.page1BtnTxt.Size = new System.Drawing.Size(270, 20);
            this.page1BtnTxt.TabIndex = 9;
            this.page1BtnTxt.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.Page1BtnTxtButtonClick);
            this.page1BtnTxt.TextChanged += new System.EventHandler(this.Page1BtnTxtTextChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(121, 24);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Serverpfad:";
            // 
            // wizP2
            // 
            this.wizP2.AllowNext = false;
            this.wizP2.Controls.Add(this.labelControl21);
            this.wizP2.Controls.Add(this.labelControl22);
            this.wizP2.Controls.Add(this.page2TxtProxyHttpsPort);
            this.wizP2.Controls.Add(this.labelControl17);
            this.wizP2.Controls.Add(this.labelControl18);
            this.wizP2.Controls.Add(this.page2TxtProxyPwd);
            this.wizP2.Controls.Add(this.labelControl13);
            this.wizP2.Controls.Add(this.labelControl14);
            this.wizP2.Controls.Add(this.page2TxtProxyUser);
            this.wizP2.Controls.Add(this.labelControl15);
            this.wizP2.Controls.Add(this.labelControl16);
            this.wizP2.Controls.Add(this.page2TxtProxyUrl);
            this.wizP2.Controls.Add(this.labelControl12);
            this.wizP2.Controls.Add(this.labelControl11);
            this.wizP2.Controls.Add(this.page2TxtSecurityPwd);
            this.wizP2.Controls.Add(this.labelControl10);
            this.wizP2.Controls.Add(this.labelControl9);
            this.wizP2.Controls.Add(this.labelControl7);
            this.wizP2.Controls.Add(this.labelControl8);
            this.wizP2.Controls.Add(this.page2TxtSecurityUser);
            this.wizP2.Controls.Add(this.labelControl5);
            this.wizP2.Controls.Add(this.labelControl6);
            this.wizP2.Controls.Add(this.page2TxtServerpath);
            this.wizP2.Name = "wizP2";
            this.wizP2.Size = new System.Drawing.Size(576, 360);
            this.wizP2.Text = "Zugriffseinstellungen";
            // 
            // labelControl21
            // 
            this.labelControl21.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl21.Appearance.Options.UseForeColor = true;
            this.labelControl21.Location = new System.Drawing.Point(141, 257);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(217, 13);
            this.labelControl21.TabIndex = 36;
            this.labelControl21.Text = "Port zur Nutzung von HTTPS über den Proxy.";
            // 
            // labelControl22
            // 
            this.labelControl22.Location = new System.Drawing.Point(74, 238);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(58, 13);
            this.labelControl22.TabIndex = 35;
            this.labelControl22.Text = "HTTPS Port:";
            // 
            // page2TxtProxyHttpsPort
            // 
            this.page2TxtProxyHttpsPort.Location = new System.Drawing.Point(141, 235);
            this.page2TxtProxyHttpsPort.Name = "page2TxtProxyHttpsPort";
            this.page2TxtProxyHttpsPort.Size = new System.Drawing.Size(326, 20);
            this.page2TxtProxyHttpsPort.TabIndex = 34;
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl17.Appearance.Options.UseForeColor = true;
            this.labelControl17.Location = new System.Drawing.Point(141, 339);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(160, 13);
            this.labelControl17.TabIndex = 33;
            this.labelControl17.Text = "Passwort zur Nutzung des Proxy.";
            // 
            // labelControl18
            // 
            this.labelControl18.Location = new System.Drawing.Point(84, 320);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(48, 13);
            this.labelControl18.TabIndex = 32;
            this.labelControl18.Text = "Passwort:";
            // 
            // page2TxtProxyPwd
            // 
            this.page2TxtProxyPwd.Location = new System.Drawing.Point(141, 317);
            this.page2TxtProxyPwd.Name = "page2TxtProxyPwd";
            this.page2TxtProxyPwd.Size = new System.Drawing.Size(326, 20);
            this.page2TxtProxyPwd.TabIndex = 31;
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl13.Appearance.Options.UseForeColor = true;
            this.labelControl13.Location = new System.Drawing.Point(141, 298);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(174, 13);
            this.labelControl13.TabIndex = 30;
            this.labelControl13.Text = "Nutzername zur Nutzung des Proxy.";
            // 
            // labelControl14
            // 
            this.labelControl14.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl14.Appearance.Options.UseForeColor = true;
            this.labelControl14.Location = new System.Drawing.Point(141, 216);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(114, 13);
            this.labelControl14.TabIndex = 29;
            this.labelControl14.Text = "URL des Proxy Servers.";
            // 
            // page2TxtProxyUser
            // 
            this.page2TxtProxyUser.Location = new System.Drawing.Point(141, 276);
            this.page2TxtProxyUser.Name = "page2TxtProxyUser";
            this.page2TxtProxyUser.Size = new System.Drawing.Size(326, 20);
            this.page2TxtProxyUser.TabIndex = 28;
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(70, 279);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(62, 13);
            this.labelControl15.TabIndex = 27;
            this.labelControl15.Text = "Nutzername:";
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(78, 197);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(54, 13);
            this.labelControl16.TabIndex = 26;
            this.labelControl16.Text = "Proxy URL:";
            // 
            // page2TxtProxyUrl
            // 
            this.page2TxtProxyUrl.Location = new System.Drawing.Point(141, 194);
            this.page2TxtProxyUrl.Name = "page2TxtProxyUrl";
            this.page2TxtProxyUrl.Size = new System.Drawing.Size(326, 20);
            this.page2TxtProxyUrl.TabIndex = 25;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl12.Appearance.Options.UseForeColor = true;
            this.labelControl12.Location = new System.Drawing.Point(141, 160);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(163, 13);
            this.labelControl12.TabIndex = 24;
            this.labelControl12.Text = "Passwort bei Nutzung von HTTPS.";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl11.Appearance.Options.UseForeColor = true;
            this.labelControl11.Location = new System.Drawing.Point(141, 115);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(186, 13);
            this.labelControl11.TabIndex = 23;
            this.labelControl11.Text = "Anmeldename bei Nutzung von HTTPS.";
            // 
            // page2TxtSecurityPwd
            // 
            this.page2TxtSecurityPwd.Enabled = false;
            this.page2TxtSecurityPwd.Location = new System.Drawing.Point(141, 138);
            this.page2TxtSecurityPwd.Name = "page2TxtSecurityPwd";
            this.page2TxtSecurityPwd.Size = new System.Drawing.Size(326, 20);
            this.page2TxtSecurityPwd.TabIndex = 22;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(84, 141);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(48, 13);
            this.labelControl10.TabIndex = 21;
            this.labelControl10.Text = "Passwort:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(70, 96);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(62, 13);
            this.labelControl9.TabIndex = 20;
            this.labelControl9.Text = "Nutzername:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(19, 176);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(36, 13);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "Proxy:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(19, 74);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(60, 13);
            this.labelControl8.TabIndex = 18;
            this.labelControl8.Text = "Sicherheit:";
            // 
            // page2TxtSecurityUser
            // 
            this.page2TxtSecurityUser.Enabled = false;
            this.page2TxtSecurityUser.Location = new System.Drawing.Point(141, 93);
            this.page2TxtSecurityUser.Name = "page2TxtSecurityUser";
            this.page2TxtSecurityUser.Size = new System.Drawing.Size(326, 20);
            this.page2TxtSecurityUser.TabIndex = 17;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(141, 48);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(326, 26);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "Pfad oder URL unter der dieser Update Server später erreichbar ist.\r\nC:\\Temp - \\\\" +
                "PC2\\Temp - HTTP:\\\\server - HTTPS:\\\\server";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(19, 3);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(71, 13);
            this.labelControl6.TabIndex = 15;
            this.labelControl6.Text = "Zugriffspfad:";
            // 
            // page2TxtServerpath
            // 
            this.page2TxtServerpath.Location = new System.Drawing.Point(70, 22);
            this.page2TxtServerpath.Name = "page2TxtServerpath";
            this.page2TxtServerpath.Size = new System.Drawing.Size(397, 20);
            this.page2TxtServerpath.TabIndex = 14;
            this.page2TxtServerpath.TextChanged += new System.EventHandler(this.Page2TxtServerpathTextChanged);
            // 
            // wizP3
            // 
            this.wizP3.AllowNext = false;
            this.wizP3.Controls.Add(this.labelControl20);
            this.wizP3.Controls.Add(this.page3TxtInfoXmlContent);
            this.wizP3.Controls.Add(this.labelControl19);
            this.wizP3.Name = "wizP3";
            this.wizP3.Size = new System.Drawing.Size(576, 360);
            this.wizP3.Text = "Updater Konfigurationsdatei";
            // 
            // labelControl20
            // 
            this.labelControl20.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.labelControl20.Appearance.Options.UseForeColor = true;
            this.labelControl20.Location = new System.Drawing.Point(262, 331);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(261, 13);
            this.labelControl20.TabIndex = 18;
            this.labelControl20.Text = "Inhalt der info.xml Datei für das Programmverzeichnis.";
            // 
            // page3TxtInfoXmlContent
            // 
            this.page3TxtInfoXmlContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.page3TxtInfoXmlContent.Location = new System.Drawing.Point(36, 22);
            this.page3TxtInfoXmlContent.Multiline = true;
            this.page3TxtInfoXmlContent.Name = "page3TxtInfoXmlContent";
            this.page3TxtInfoXmlContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.page3TxtInfoXmlContent.Size = new System.Drawing.Size(503, 303);
            this.page3TxtInfoXmlContent.TabIndex = 17;
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl19.Appearance.Options.UseFont = true;
            this.labelControl19.Location = new System.Drawing.Point(19, 3);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(45, 13);
            this.labelControl19.TabIndex = 16;
            this.labelControl19.Text = "info.xml";
            // 
            // ServerWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 520);
            this.ControlBox = false;
            this.Controls.Add(this.wizardControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ServerWizard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.wizardControl1.ResumeLayout(false);
            this.wizP1.ResumeLayout(false);
            this.wizP1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.page1TxtExecutable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.page1TxtServername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.page1BtnTxt.Properties)).EndInit();
            this.wizP2.ResumeLayout(false);
            this.wizP2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.page2TxtProxyHttpsPort.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.page2TxtProxyPwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.page2TxtProxyUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.page2TxtProxyUrl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.page2TxtSecurityPwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.page2TxtSecurityUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.page2TxtServerpath.Properties)).EndInit();
            this.wizP3.ResumeLayout(false);
            this.wizP3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraWizard.WizardControl wizardControl1;
        private DevExpress.XtraWizard.WelcomeWizardPage wizP1;
        private DevExpress.XtraWizard.WizardPage wizP2;
        private DevExpress.XtraWizard.CompletionWizardPage wizP3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit page1TxtServername;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ButtonEdit page1BtnTxt;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.TextEdit page2TxtProxyPwd;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.TextEdit page2TxtProxyUser;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.TextEdit page2TxtProxyUrl;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit page2TxtSecurityPwd;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit page2TxtSecurityUser;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit page2TxtServerpath;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private System.Windows.Forms.TextBox page3TxtInfoXmlContent;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        private DevExpress.XtraEditors.LabelControl labelControl22;
        private DevExpress.XtraEditors.TextEdit page2TxtProxyHttpsPort;
        private DevExpress.XtraEditors.LabelControl page1LblError;
        private DevExpress.XtraEditors.LabelControl labelControl23;
        private DevExpress.XtraEditors.LabelControl page1LblExecutable;
        private DevExpress.XtraEditors.TextEdit page1TxtExecutable;
    }
}
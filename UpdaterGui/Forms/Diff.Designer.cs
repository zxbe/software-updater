namespace Com.QueoMedia.Updater.Gui.Forms
{
    partial class Diff
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNewVersionChangedFiles = new System.Windows.Forms.Label();
            this.lblCellCurrentVersionchangedFiles = new System.Windows.Forms.Label();
            this.lblRowHeaderChanegdFiles = new System.Windows.Forms.Label();
            this.lblCellNewVersionNumber = new System.Windows.Forms.Label();
            this.lblCellCurrentVersionNumber = new System.Windows.Forms.Label();
            this.lblRowHeaderVersionNumber = new System.Windows.Forms.Label();
            this.lblColHeaderNewVersion = new System.Windows.Forms.Label();
            this.lblColHeaderCurrentVersion = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(288, 7);
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(207, 7);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(369, 7);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.lblNewVersionChangedFiles, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCellCurrentVersionchangedFiles, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblRowHeaderChanegdFiles, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCellNewVersionNumber, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCellCurrentVersionNumber, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblRowHeaderVersionNumber, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblColHeaderNewVersion, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblColHeaderCurrentVersion, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblProductName, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(33, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(398, 179);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lblNewVersionChangedFiles
            // 
            this.lblNewVersionChangedFiles.AutoSize = true;
            this.lblNewVersionChangedFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNewVersionChangedFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewVersionChangedFiles.Location = new System.Drawing.Point(267, 118);
            this.lblNewVersionChangedFiles.Name = "lblNewVersionChangedFiles";
            this.lblNewVersionChangedFiles.Size = new System.Drawing.Size(128, 61);
            this.lblNewVersionChangedFiles.TabIndex = 8;
            this.lblNewVersionChangedFiles.Text = "Versionsnumer";
            this.lblNewVersionChangedFiles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCellCurrentVersionchangedFiles
            // 
            this.lblCellCurrentVersionchangedFiles.AutoSize = true;
            this.lblCellCurrentVersionchangedFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCellCurrentVersionchangedFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCellCurrentVersionchangedFiles.Location = new System.Drawing.Point(135, 118);
            this.lblCellCurrentVersionchangedFiles.Name = "lblCellCurrentVersionchangedFiles";
            this.lblCellCurrentVersionchangedFiles.Size = new System.Drawing.Size(126, 61);
            this.lblCellCurrentVersionchangedFiles.TabIndex = 7;
            this.lblCellCurrentVersionchangedFiles.Text = "-";
            this.lblCellCurrentVersionchangedFiles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRowHeaderChanegdFiles
            // 
            this.lblRowHeaderChanegdFiles.AutoSize = true;
            this.lblRowHeaderChanegdFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRowHeaderChanegdFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRowHeaderChanegdFiles.Location = new System.Drawing.Point(3, 118);
            this.lblRowHeaderChanegdFiles.Name = "lblRowHeaderChanegdFiles";
            this.lblRowHeaderChanegdFiles.Size = new System.Drawing.Size(126, 61);
            this.lblRowHeaderChanegdFiles.TabIndex = 6;
            this.lblRowHeaderChanegdFiles.Text = "Geänderte Dateien";
            this.lblRowHeaderChanegdFiles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCellNewVersionNumber
            // 
            this.lblCellNewVersionNumber.AutoSize = true;
            this.lblCellNewVersionNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCellNewVersionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCellNewVersionNumber.Location = new System.Drawing.Point(267, 59);
            this.lblCellNewVersionNumber.Name = "lblCellNewVersionNumber";
            this.lblCellNewVersionNumber.Size = new System.Drawing.Size(128, 59);
            this.lblCellNewVersionNumber.TabIndex = 5;
            this.lblCellNewVersionNumber.Text = "Versionsnumer";
            this.lblCellNewVersionNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCellCurrentVersionNumber
            // 
            this.lblCellCurrentVersionNumber.AutoSize = true;
            this.lblCellCurrentVersionNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCellCurrentVersionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCellCurrentVersionNumber.Location = new System.Drawing.Point(135, 59);
            this.lblCellCurrentVersionNumber.Name = "lblCellCurrentVersionNumber";
            this.lblCellCurrentVersionNumber.Size = new System.Drawing.Size(126, 59);
            this.lblCellCurrentVersionNumber.TabIndex = 4;
            this.lblCellCurrentVersionNumber.Text = "Versionsnumer";
            this.lblCellCurrentVersionNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRowHeaderVersionNumber
            // 
            this.lblRowHeaderVersionNumber.AutoSize = true;
            this.lblRowHeaderVersionNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRowHeaderVersionNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRowHeaderVersionNumber.Location = new System.Drawing.Point(3, 59);
            this.lblRowHeaderVersionNumber.Name = "lblRowHeaderVersionNumber";
            this.lblRowHeaderVersionNumber.Size = new System.Drawing.Size(126, 59);
            this.lblRowHeaderVersionNumber.TabIndex = 3;
            this.lblRowHeaderVersionNumber.Text = "Versionsnumer";
            this.lblRowHeaderVersionNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColHeaderNewVersion
            // 
            this.lblColHeaderNewVersion.AutoSize = true;
            this.lblColHeaderNewVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblColHeaderNewVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColHeaderNewVersion.Location = new System.Drawing.Point(267, 0);
            this.lblColHeaderNewVersion.Name = "lblColHeaderNewVersion";
            this.lblColHeaderNewVersion.Size = new System.Drawing.Size(128, 59);
            this.lblColHeaderNewVersion.TabIndex = 2;
            this.lblColHeaderNewVersion.Text = "Neue Version";
            this.lblColHeaderNewVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColHeaderCurrentVersion
            // 
            this.lblColHeaderCurrentVersion.AutoSize = true;
            this.lblColHeaderCurrentVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblColHeaderCurrentVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColHeaderCurrentVersion.Location = new System.Drawing.Point(135, 0);
            this.lblColHeaderCurrentVersion.Name = "lblColHeaderCurrentVersion";
            this.lblColHeaderCurrentVersion.Size = new System.Drawing.Size(126, 59);
            this.lblColHeaderCurrentVersion.TabIndex = 1;
            this.lblColHeaderCurrentVersion.Text = "Aktuelle Version";
            this.lblColHeaderCurrentVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(3, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(126, 59);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "product name";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Red;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(36, 238);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(395, 22);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "label1";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStatus.Visible = false;
            // 
            // Diff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 304);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Diff";
            this.Text = "Diff";
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.lblStatus, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblCellCurrentVersionNumber;
        private System.Windows.Forms.Label lblRowHeaderVersionNumber;
        private System.Windows.Forms.Label lblColHeaderNewVersion;
        private System.Windows.Forms.Label lblColHeaderCurrentVersion;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblNewVersionChangedFiles;
        private System.Windows.Forms.Label lblCellCurrentVersionchangedFiles;
        private System.Windows.Forms.Label lblRowHeaderChanegdFiles;
        private System.Windows.Forms.Label lblCellNewVersionNumber;
        private System.Windows.Forms.Label lblStatus;
    }
}
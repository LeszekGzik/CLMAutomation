namespace CLMAutomation
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageTests = new System.Windows.Forms.TabPage();
            this.tabPageConfig = new System.Windows.Forms.TabPage();
            this.checkBoxOpenExcel = new System.Windows.Forms.CheckBox();
            this.checkBoxOpenMessage = new System.Windows.Forms.CheckBox();
            this.buttonUndoProperties = new System.Windows.Forms.Button();
            this.buttonSaveProperties = new System.Windows.Forms.Button();
            this.checkBoxProxy = new System.Windows.Forms.CheckBox();
            this.buttonGeckoPath = new System.Windows.Forms.Button();
            this.labelProxy = new System.Windows.Forms.Label();
            this.textBoxProxy = new System.Windows.Forms.TextBox();
            this.labelGeckoPath = new System.Windows.Forms.Label();
            this.textBoxGeckoPath = new System.Windows.Forms.TextBox();
            this.buttonFirefoxPath = new System.Windows.Forms.Button();
            this.labelFirefoxPath = new System.Windows.Forms.Label();
            this.textBoxFirefoxPath = new System.Windows.Forms.TextBox();
            this.tabPageResult = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonSaveAs = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageTests);
            this.tabControl1.Controls.Add(this.tabPageConfig);
            this.tabControl1.Controls.Add(this.tabPageResult);
            this.tabControl1.Location = new System.Drawing.Point(13, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(590, 649);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageTests
            // 
            this.tabPageTests.Location = new System.Drawing.Point(4, 22);
            this.tabPageTests.Name = "tabPageTests";
            this.tabPageTests.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTests.Size = new System.Drawing.Size(582, 623);
            this.tabPageTests.TabIndex = 0;
            this.tabPageTests.Text = "Tests";
            this.tabPageTests.UseVisualStyleBackColor = true;
            // 
            // tabPageConfig
            // 
            this.tabPageConfig.Controls.Add(this.checkBoxOpenExcel);
            this.tabPageConfig.Controls.Add(this.checkBoxOpenMessage);
            this.tabPageConfig.Controls.Add(this.buttonUndoProperties);
            this.tabPageConfig.Controls.Add(this.buttonSaveProperties);
            this.tabPageConfig.Controls.Add(this.checkBoxProxy);
            this.tabPageConfig.Controls.Add(this.buttonGeckoPath);
            this.tabPageConfig.Controls.Add(this.labelProxy);
            this.tabPageConfig.Controls.Add(this.textBoxProxy);
            this.tabPageConfig.Controls.Add(this.labelGeckoPath);
            this.tabPageConfig.Controls.Add(this.textBoxGeckoPath);
            this.tabPageConfig.Controls.Add(this.buttonFirefoxPath);
            this.tabPageConfig.Controls.Add(this.labelFirefoxPath);
            this.tabPageConfig.Controls.Add(this.textBoxFirefoxPath);
            this.tabPageConfig.Location = new System.Drawing.Point(4, 22);
            this.tabPageConfig.Name = "tabPageConfig";
            this.tabPageConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfig.Size = new System.Drawing.Size(582, 623);
            this.tabPageConfig.TabIndex = 1;
            this.tabPageConfig.Text = "Config";
            this.tabPageConfig.UseVisualStyleBackColor = true;
            // 
            // checkBoxOpenExcel
            // 
            this.checkBoxOpenExcel.AutoSize = true;
            this.checkBoxOpenExcel.Location = new System.Drawing.Point(9, 268);
            this.checkBoxOpenExcel.Name = "checkBoxOpenExcel";
            this.checkBoxOpenExcel.Size = new System.Drawing.Size(249, 17);
            this.checkBoxOpenExcel.TabIndex = 24;
            this.checkBoxOpenExcel.Text = "Open report file in Excel when test is completed";
            this.checkBoxOpenExcel.UseVisualStyleBackColor = true;
            this.checkBoxOpenExcel.CheckedChanged += new System.EventHandler(this.configChangesOccured);
            // 
            // checkBoxOpenMessage
            // 
            this.checkBoxOpenMessage.AutoSize = true;
            this.checkBoxOpenMessage.Location = new System.Drawing.Point(9, 232);
            this.checkBoxOpenMessage.Name = "checkBoxOpenMessage";
            this.checkBoxOpenMessage.Size = new System.Drawing.Size(235, 17);
            this.checkBoxOpenMessage.TabIndex = 23;
            this.checkBoxOpenMessage.Text = "Show me a message when test is completed";
            this.checkBoxOpenMessage.UseVisualStyleBackColor = true;
            this.checkBoxOpenMessage.CheckedChanged += new System.EventHandler(this.configChangesOccured);
            // 
            // buttonUndoProperties
            // 
            this.buttonUndoProperties.Enabled = false;
            this.buttonUndoProperties.Location = new System.Drawing.Point(426, 330);
            this.buttonUndoProperties.Name = "buttonUndoProperties";
            this.buttonUndoProperties.Size = new System.Drawing.Size(75, 23);
            this.buttonUndoProperties.TabIndex = 22;
            this.buttonUndoProperties.Text = "Undo";
            this.buttonUndoProperties.UseVisualStyleBackColor = true;
            this.buttonUndoProperties.Click += new System.EventHandler(this.buttonUndoProperties_Click);
            // 
            // buttonSaveProperties
            // 
            this.buttonSaveProperties.Location = new System.Drawing.Point(9, 330);
            this.buttonSaveProperties.Name = "buttonSaveProperties";
            this.buttonSaveProperties.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveProperties.TabIndex = 21;
            this.buttonSaveProperties.Text = "Save";
            this.buttonSaveProperties.UseVisualStyleBackColor = true;
            this.buttonSaveProperties.Click += new System.EventHandler(this.buttonSaveProperties_Click);
            // 
            // checkBoxProxy
            // 
            this.checkBoxProxy.AutoSize = true;
            this.checkBoxProxy.Location = new System.Drawing.Point(9, 132);
            this.checkBoxProxy.Name = "checkBoxProxy";
            this.checkBoxProxy.Size = new System.Drawing.Size(73, 17);
            this.checkBoxProxy.TabIndex = 20;
            this.checkBoxProxy.Text = "Use proxy";
            this.checkBoxProxy.UseVisualStyleBackColor = true;
            this.checkBoxProxy.CheckedChanged += new System.EventHandler(this.checkBoxProxy_CheckedChanged);
            // 
            // buttonGeckoPath
            // 
            this.buttonGeckoPath.Image = global::CLMAutomation.Properties.Resources.Folder_16x;
            this.buttonGeckoPath.Location = new System.Drawing.Point(477, 87);
            this.buttonGeckoPath.Name = "buttonGeckoPath";
            this.buttonGeckoPath.Size = new System.Drawing.Size(24, 24);
            this.buttonGeckoPath.TabIndex = 16;
            this.buttonGeckoPath.UseVisualStyleBackColor = true;
            this.buttonGeckoPath.Click += new System.EventHandler(this.buttonGeckoPath_Click);
            // 
            // labelProxy
            // 
            this.labelProxy.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.labelProxy.AutoSize = true;
            this.labelProxy.Location = new System.Drawing.Point(6, 164);
            this.labelProxy.Name = "labelProxy";
            this.labelProxy.Size = new System.Drawing.Size(58, 13);
            this.labelProxy.TabIndex = 15;
            this.labelProxy.Text = "Proxy URL";
            // 
            // textBoxProxy
            // 
            this.textBoxProxy.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.textBoxProxy.Enabled = false;
            this.textBoxProxy.Location = new System.Drawing.Point(9, 180);
            this.textBoxProxy.Name = "textBoxProxy";
            this.textBoxProxy.Size = new System.Drawing.Size(462, 20);
            this.textBoxProxy.TabIndex = 14;
            this.textBoxProxy.TextChanged += new System.EventHandler(this.configChangesOccured);
            // 
            // labelGeckoPath
            // 
            this.labelGeckoPath.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.labelGeckoPath.AutoSize = true;
            this.labelGeckoPath.Location = new System.Drawing.Point(6, 73);
            this.labelGeckoPath.Name = "labelGeckoPath";
            this.labelGeckoPath.Size = new System.Drawing.Size(89, 13);
            this.labelGeckoPath.TabIndex = 15;
            this.labelGeckoPath.Text = "Geckodriver path";
            // 
            // textBoxGeckoPath
            // 
            this.textBoxGeckoPath.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.textBoxGeckoPath.Location = new System.Drawing.Point(9, 89);
            this.textBoxGeckoPath.Name = "textBoxGeckoPath";
            this.textBoxGeckoPath.Size = new System.Drawing.Size(462, 20);
            this.textBoxGeckoPath.TabIndex = 14;
            this.textBoxGeckoPath.TextChanged += new System.EventHandler(this.configChangesOccured);
            // 
            // buttonFirefoxPath
            // 
            this.buttonFirefoxPath.Image = global::CLMAutomation.Properties.Resources.Folder_16x;
            this.buttonFirefoxPath.Location = new System.Drawing.Point(477, 35);
            this.buttonFirefoxPath.Name = "buttonFirefoxPath";
            this.buttonFirefoxPath.Size = new System.Drawing.Size(24, 24);
            this.buttonFirefoxPath.TabIndex = 13;
            this.buttonFirefoxPath.UseVisualStyleBackColor = true;
            this.buttonFirefoxPath.Click += new System.EventHandler(this.buttonFirefoxPath_Click);
            // 
            // labelFirefoxPath
            // 
            this.labelFirefoxPath.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.labelFirefoxPath.AutoSize = true;
            this.labelFirefoxPath.Location = new System.Drawing.Point(6, 21);
            this.labelFirefoxPath.Name = "labelFirefoxPath";
            this.labelFirefoxPath.Size = new System.Drawing.Size(117, 13);
            this.labelFirefoxPath.TabIndex = 12;
            this.labelFirefoxPath.Text = "Firefox executable path";
            // 
            // textBoxFirefoxPath
            // 
            this.textBoxFirefoxPath.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.textBoxFirefoxPath.Location = new System.Drawing.Point(9, 37);
            this.textBoxFirefoxPath.Name = "textBoxFirefoxPath";
            this.textBoxFirefoxPath.Size = new System.Drawing.Size(462, 20);
            this.textBoxFirefoxPath.TabIndex = 11;
            this.textBoxFirefoxPath.TextChanged += new System.EventHandler(this.configChangesOccured);
            // 
            // tabPageResult
            // 
            this.tabPageResult.Location = new System.Drawing.Point(4, 22);
            this.tabPageResult.Name = "tabPageResult";
            this.tabPageResult.Size = new System.Drawing.Size(582, 651);
            this.tabPageResult.TabIndex = 2;
            this.tabPageResult.Text = "Result";
            this.tabPageResult.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "c";
            // 
            // buttonRun
            // 
            this.buttonRun.Image = global::CLMAutomation.Properties.Resources.Run_16x;
            this.buttonRun.Location = new System.Drawing.Point(114, 11);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(24, 24);
            this.buttonRun.TabIndex = 55;
            this.buttonRun.UseVisualStyleBackColor = true;
            // 
            // buttonSaveAs
            // 
            this.buttonSaveAs.Image = global::CLMAutomation.Properties.Resources.SaveAs_16x;
            this.buttonSaveAs.Location = new System.Drawing.Point(77, 11);
            this.buttonSaveAs.Name = "buttonSaveAs";
            this.buttonSaveAs.Size = new System.Drawing.Size(24, 24);
            this.buttonSaveAs.TabIndex = 54;
            this.buttonSaveAs.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Image = global::CLMAutomation.Properties.Resources.Save_16x;
            this.buttonSave.Location = new System.Drawing.Point(47, 11);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(24, 24);
            this.buttonSave.TabIndex = 53;
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonNew
            // 
            this.buttonNew.Image = global::CLMAutomation.Properties.Resources.NewFile_16x;
            this.buttonNew.Location = new System.Drawing.Point(17, 11);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(24, 24);
            this.buttonNew.TabIndex = 52;
            this.buttonNew.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 692);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.buttonSaveAs);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "CLMAutomation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPageConfig.ResumeLayout(false);
            this.tabPageConfig.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageTests;
        private System.Windows.Forms.TabPage tabPageConfig;
        private System.Windows.Forms.TabPage tabPageResult;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonFirefoxPath;
        private System.Windows.Forms.Label labelFirefoxPath;
        private System.Windows.Forms.TextBox textBoxFirefoxPath;
        private System.Windows.Forms.Button buttonGeckoPath;
        private System.Windows.Forms.Label labelGeckoPath;
        private System.Windows.Forms.TextBox textBoxGeckoPath;
        private System.Windows.Forms.CheckBox checkBoxProxy;
        private System.Windows.Forms.Label labelProxy;
        private System.Windows.Forms.TextBox textBoxProxy;
        private System.Windows.Forms.Button buttonUndoProperties;
        private System.Windows.Forms.Button buttonSaveProperties;
        private System.Windows.Forms.CheckBox checkBoxOpenExcel;
        private System.Windows.Forms.CheckBox checkBoxOpenMessage;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Button buttonSaveAs;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonNew;
    }
}


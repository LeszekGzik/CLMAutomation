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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonMoveRight = new System.Windows.Forms.Button();
            this.buttonMoveLeft = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonCloseAll = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonRunAll = new System.Windows.Forms.Button();
            this.buttonSaveAll = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonSaveAs = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.tabPageTests = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "c";
            // 
            // buttonMoveRight
            // 
            this.buttonMoveRight.Image = global::CLMAutomation.Properties.Resources.Next_16x;
            this.buttonMoveRight.Location = new System.Drawing.Point(214, 11);
            this.buttonMoveRight.Name = "buttonMoveRight";
            this.buttonMoveRight.Size = new System.Drawing.Size(24, 24);
            this.buttonMoveRight.TabIndex = 63;
            this.toolTip1.SetToolTip(this.buttonMoveRight, "Move scenario right");
            this.buttonMoveRight.UseVisualStyleBackColor = true;
            this.buttonMoveRight.Click += new System.EventHandler(this.buttonMoveRight_Click);
            // 
            // buttonMoveLeft
            // 
            this.buttonMoveLeft.Image = global::CLMAutomation.Properties.Resources.Previous_16x;
            this.buttonMoveLeft.Location = new System.Drawing.Point(184, 11);
            this.buttonMoveLeft.Name = "buttonMoveLeft";
            this.buttonMoveLeft.Size = new System.Drawing.Size(24, 24);
            this.buttonMoveLeft.TabIndex = 62;
            this.toolTip1.SetToolTip(this.buttonMoveLeft, "Move scenario left");
            this.buttonMoveLeft.UseVisualStyleBackColor = true;
            this.buttonMoveLeft.Click += new System.EventHandler(this.buttonMoveLeft_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Image = global::CLMAutomation.Properties.Resources.Settings_16x;
            this.buttonSettings.Location = new System.Drawing.Point(574, 10);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(24, 24);
            this.buttonSettings.TabIndex = 61;
            this.toolTip1.SetToolTip(this.buttonSettings, "Settings");
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonCloseAll
            // 
            this.buttonCloseAll.Image = global::CLMAutomation.Properties.Resources.CloseAll_16x;
            this.buttonCloseAll.Location = new System.Drawing.Point(386, 10);
            this.buttonCloseAll.Name = "buttonCloseAll";
            this.buttonCloseAll.Size = new System.Drawing.Size(24, 24);
            this.buttonCloseAll.TabIndex = 60;
            this.toolTip1.SetToolTip(this.buttonCloseAll, "Close all");
            this.buttonCloseAll.UseVisualStyleBackColor = true;
            this.buttonCloseAll.Click += new System.EventHandler(this.buttonCloseAll_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Image = global::CLMAutomation.Properties.Resources.Close_16x;
            this.buttonClose.Location = new System.Drawing.Point(356, 10);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(24, 24);
            this.buttonClose.TabIndex = 59;
            this.toolTip1.SetToolTip(this.buttonClose, "Close");
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonRunAll
            // 
            this.buttonRunAll.Image = global::CLMAutomation.Properties.Resources.RunAll_16x1;
            this.buttonRunAll.Location = new System.Drawing.Point(304, 10);
            this.buttonRunAll.Name = "buttonRunAll";
            this.buttonRunAll.Size = new System.Drawing.Size(24, 24);
            this.buttonRunAll.TabIndex = 58;
            this.toolTip1.SetToolTip(this.buttonRunAll, "Run all");
            this.buttonRunAll.UseVisualStyleBackColor = true;
            this.buttonRunAll.Click += new System.EventHandler(this.buttonRunAll_Click);
            // 
            // buttonSaveAll
            // 
            this.buttonSaveAll.Image = global::CLMAutomation.Properties.Resources.SaveAll_16x;
            this.buttonSaveAll.Location = new System.Drawing.Point(137, 11);
            this.buttonSaveAll.Name = "buttonSaveAll";
            this.buttonSaveAll.Size = new System.Drawing.Size(24, 24);
            this.buttonSaveAll.TabIndex = 57;
            this.toolTip1.SetToolTip(this.buttonSaveAll, "Save All");
            this.buttonSaveAll.UseVisualStyleBackColor = true;
            this.buttonSaveAll.Click += new System.EventHandler(this.buttonSaveAll_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Image = global::CLMAutomation.Properties.Resources.Folder_16x;
            this.buttonOpen.Location = new System.Drawing.Point(47, 11);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(24, 24);
            this.buttonOpen.TabIndex = 56;
            this.toolTip1.SetToolTip(this.buttonOpen, "Open");
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonRun
            // 
            this.buttonRun.Image = global::CLMAutomation.Properties.Resources.Run_16x;
            this.buttonRun.Location = new System.Drawing.Point(274, 10);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(24, 24);
            this.buttonRun.TabIndex = 55;
            this.toolTip1.SetToolTip(this.buttonRun, "Run");
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // buttonSaveAs
            // 
            this.buttonSaveAs.Image = global::CLMAutomation.Properties.Resources.SaveAs_16x;
            this.buttonSaveAs.Location = new System.Drawing.Point(107, 11);
            this.buttonSaveAs.Name = "buttonSaveAs";
            this.buttonSaveAs.Size = new System.Drawing.Size(24, 24);
            this.buttonSaveAs.TabIndex = 54;
            this.toolTip1.SetToolTip(this.buttonSaveAs, "Save As...");
            this.buttonSaveAs.UseVisualStyleBackColor = true;
            this.buttonSaveAs.Click += new System.EventHandler(this.buttonSaveAs_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Image = global::CLMAutomation.Properties.Resources.Save_16x;
            this.buttonSave.Location = new System.Drawing.Point(77, 11);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(24, 24);
            this.buttonSave.TabIndex = 53;
            this.toolTip1.SetToolTip(this.buttonSave, "Save");
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Image = global::CLMAutomation.Properties.Resources.NewFile_16x;
            this.buttonNew.Location = new System.Drawing.Point(17, 11);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(24, 24);
            this.buttonNew.TabIndex = 52;
            this.toolTip1.SetToolTip(this.buttonNew, "New");
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // tabPageTests
            // 
            this.tabPageTests.Location = new System.Drawing.Point(4, 22);
            this.tabPageTests.Name = "tabPageTests";
            this.tabPageTests.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTests.Size = new System.Drawing.Size(582, 623);
            this.tabPageTests.TabIndex = 0;
            this.tabPageTests.Text = "new 1";
            this.tabPageTests.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageTests);
            this.tabControl1.Location = new System.Drawing.Point(13, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(590, 649);
            this.tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 692);
            this.Controls.Add(this.buttonMoveRight);
            this.Controls.Add(this.buttonMoveLeft);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonCloseAll);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonRunAll);
            this.Controls.Add(this.buttonSaveAll);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.buttonSaveAs);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "CLMAutomation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Button buttonSaveAs;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSaveAll;
        private System.Windows.Forms.Button buttonRunAll;
        private System.Windows.Forms.TabPage tabPageTests;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonCloseAll;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonMoveRight;
        private System.Windows.Forms.Button buttonMoveLeft;
    }
}


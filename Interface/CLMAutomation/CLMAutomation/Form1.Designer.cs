﻿namespace CLMAutomation
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonSaveAs = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonSelectScreenFolder = new System.Windows.Forms.Button();
            this.labelScreenshootingLevel = new System.Windows.Forms.Label();
            this.comboBoxScreenshootingLevel = new System.Windows.Forms.ComboBox();
            this.labelReportingLevel = new System.Windows.Forms.Label();
            this.comboBoxReportingLevel = new System.Windows.Forms.ComboBox();
            this.labelLoggingLevel = new System.Windows.Forms.Label();
            this.comboBoxLoggingLevel = new System.Windows.Forms.ComboBox();
            this.labelDelay = new System.Windows.Forms.Label();
            this.numericUpDownDelay = new System.Windows.Forms.NumericUpDown();
            this.labelMaxRepetitions = new System.Windows.Forms.Label();
            this.numericUpDownMaxRepetitions = new System.Windows.Forms.NumericUpDown();
            this.labelReportTitle = new System.Windows.Forms.Label();
            this.textBoxReportTitle = new System.Windows.Forms.TextBox();
            this.buttonSelectOutputFile = new System.Windows.Forms.Button();
            this.labelReportFile = new System.Windows.Forms.Label();
            this.textBoxOutputFile = new System.Windows.Forms.TextBox();
            this.labelScenarioName = new System.Windows.Forms.Label();
            this.textBoxScreenFolder = new System.Windows.Forms.TextBox();
            this.labelScreenFolder = new System.Windows.Forms.Label();
            this.textBoxScenarioName = new System.Windows.Forms.TextBox();
            this.labelCurrentScenario = new System.Windows.Forms.Label();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTestCase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTestData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxRepetitions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(590, 677);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonRun);
            this.tabPage1.Controls.Add(this.buttonSaveAs);
            this.tabPage1.Controls.Add(this.buttonSave);
            this.tabPage1.Controls.Add(this.buttonNew);
            this.tabPage1.Controls.Add(this.buttonSelectScreenFolder);
            this.tabPage1.Controls.Add(this.labelScreenshootingLevel);
            this.tabPage1.Controls.Add(this.comboBoxScreenshootingLevel);
            this.tabPage1.Controls.Add(this.labelReportingLevel);
            this.tabPage1.Controls.Add(this.comboBoxReportingLevel);
            this.tabPage1.Controls.Add(this.labelLoggingLevel);
            this.tabPage1.Controls.Add(this.comboBoxLoggingLevel);
            this.tabPage1.Controls.Add(this.labelDelay);
            this.tabPage1.Controls.Add(this.numericUpDownDelay);
            this.tabPage1.Controls.Add(this.labelMaxRepetitions);
            this.tabPage1.Controls.Add(this.numericUpDownMaxRepetitions);
            this.tabPage1.Controls.Add(this.labelReportTitle);
            this.tabPage1.Controls.Add(this.textBoxReportTitle);
            this.tabPage1.Controls.Add(this.buttonSelectOutputFile);
            this.tabPage1.Controls.Add(this.labelReportFile);
            this.tabPage1.Controls.Add(this.textBoxOutputFile);
            this.tabPage1.Controls.Add(this.labelScenarioName);
            this.tabPage1.Controls.Add(this.textBoxScreenFolder);
            this.tabPage1.Controls.Add(this.labelScreenFolder);
            this.tabPage1.Controls.Add(this.textBoxScenarioName);
            this.tabPage1.Controls.Add(this.labelCurrentScenario);
            this.tabPage1.Controls.Add(this.textBoxFile);
            this.tabPage1.Controls.Add(this.buttonSelectFile);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(582, 651);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tests";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonRun
            // 
            this.buttonRun.Image = global::CLMAutomation.Properties.Resources.Run_16x;
            this.buttonRun.Location = new System.Drawing.Point(103, 6);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(24, 24);
            this.buttonRun.TabIndex = 23;
            this.buttonRun.UseVisualStyleBackColor = true;
            // 
            // buttonSaveAs
            // 
            this.buttonSaveAs.Image = global::CLMAutomation.Properties.Resources.SaveAs_16x;
            this.buttonSaveAs.Location = new System.Drawing.Point(66, 6);
            this.buttonSaveAs.Name = "buttonSaveAs";
            this.buttonSaveAs.Size = new System.Drawing.Size(24, 24);
            this.buttonSaveAs.TabIndex = 23;
            this.buttonSaveAs.UseVisualStyleBackColor = true;
            this.buttonSaveAs.Click += new System.EventHandler(this.buttonSaveAs_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Image = global::CLMAutomation.Properties.Resources.Save_16x;
            this.buttonSave.Location = new System.Drawing.Point(36, 6);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(24, 24);
            this.buttonSave.TabIndex = 23;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Image = global::CLMAutomation.Properties.Resources.NewFile_16x;
            this.buttonNew.Location = new System.Drawing.Point(6, 6);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(24, 24);
            this.buttonNew.TabIndex = 22;
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonSelectScreenFolder
            // 
            this.buttonSelectScreenFolder.Location = new System.Drawing.Point(474, 404);
            this.buttonSelectScreenFolder.Name = "buttonSelectScreenFolder";
            this.buttonSelectScreenFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectScreenFolder.TabIndex = 21;
            this.buttonSelectScreenFolder.Text = "Select folder";
            this.buttonSelectScreenFolder.UseVisualStyleBackColor = true;
            this.buttonSelectScreenFolder.Click += new System.EventHandler(this.buttonSelectScreenFolder_Click);
            // 
            // labelScreenshootingLevel
            // 
            this.labelScreenshootingLevel.AutoSize = true;
            this.labelScreenshootingLevel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelScreenshootingLevel.Location = new System.Drawing.Point(3, 600);
            this.labelScreenshootingLevel.Name = "labelScreenshootingLevel";
            this.labelScreenshootingLevel.Size = new System.Drawing.Size(106, 13);
            this.labelScreenshootingLevel.TabIndex = 20;
            this.labelScreenshootingLevel.Text = "Screenshooting level";
            // 
            // comboBoxScreenshootingLevel
            // 
            this.comboBoxScreenshootingLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxScreenshootingLevel.FormattingEnabled = true;
            this.comboBoxScreenshootingLevel.Items.AddRange(new object[] {
            "debug",
            "step",
            "test",
            "scenario",
            "error",
            "scr",
            "never"});
            this.comboBoxScreenshootingLevel.Location = new System.Drawing.Point(6, 615);
            this.comboBoxScreenshootingLevel.Name = "comboBoxScreenshootingLevel";
            this.comboBoxScreenshootingLevel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxScreenshootingLevel.TabIndex = 19;
            this.comboBoxScreenshootingLevel.SelectedIndexChanged += new System.EventHandler(this.changesOccured);
            // 
            // labelReportingLevel
            // 
            this.labelReportingLevel.AutoSize = true;
            this.labelReportingLevel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelReportingLevel.Location = new System.Drawing.Point(3, 550);
            this.labelReportingLevel.Name = "labelReportingLevel";
            this.labelReportingLevel.Size = new System.Drawing.Size(78, 13);
            this.labelReportingLevel.TabIndex = 18;
            this.labelReportingLevel.Text = "Reporting level";
            // 
            // comboBoxReportingLevel
            // 
            this.comboBoxReportingLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReportingLevel.FormattingEnabled = true;
            this.comboBoxReportingLevel.Items.AddRange(new object[] {
            "debug",
            "step",
            "test",
            "scenario",
            "error",
            "scr",
            "never"});
            this.comboBoxReportingLevel.Location = new System.Drawing.Point(6, 565);
            this.comboBoxReportingLevel.Name = "comboBoxReportingLevel";
            this.comboBoxReportingLevel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxReportingLevel.TabIndex = 17;
            this.comboBoxReportingLevel.SelectedIndexChanged += new System.EventHandler(this.changesOccured);
            // 
            // labelLoggingLevel
            // 
            this.labelLoggingLevel.AutoSize = true;
            this.labelLoggingLevel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelLoggingLevel.Location = new System.Drawing.Point(3, 502);
            this.labelLoggingLevel.Name = "labelLoggingLevel";
            this.labelLoggingLevel.Size = new System.Drawing.Size(70, 13);
            this.labelLoggingLevel.TabIndex = 18;
            this.labelLoggingLevel.Text = "Logging level";
            // 
            // comboBoxLoggingLevel
            // 
            this.comboBoxLoggingLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLoggingLevel.FormattingEnabled = true;
            this.comboBoxLoggingLevel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxLoggingLevel.Items.AddRange(new object[] {
            "debug",
            "step",
            "test",
            "scenario",
            "error",
            "scr",
            "never"});
            this.comboBoxLoggingLevel.Location = new System.Drawing.Point(6, 517);
            this.comboBoxLoggingLevel.Name = "comboBoxLoggingLevel";
            this.comboBoxLoggingLevel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLoggingLevel.TabIndex = 17;
            this.comboBoxLoggingLevel.SelectedIndexChanged += new System.EventHandler(this.changesOccured);
            // 
            // labelDelay
            // 
            this.labelDelay.AutoSize = true;
            this.labelDelay.Location = new System.Drawing.Point(159, 598);
            this.labelDelay.Name = "labelDelay";
            this.labelDelay.Size = new System.Drawing.Size(131, 13);
            this.labelDelay.TabIndex = 16;
            this.labelDelay.Text = "Delay between inputs [ms]";
            // 
            // numericUpDownDelay
            // 
            this.numericUpDownDelay.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownDelay.Location = new System.Drawing.Point(162, 614);
            this.numericUpDownDelay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownDelay.Name = "numericUpDownDelay";
            this.numericUpDownDelay.Size = new System.Drawing.Size(103, 20);
            this.numericUpDownDelay.TabIndex = 15;
            this.numericUpDownDelay.ValueChanged += new System.EventHandler(this.changesOccured);
            // 
            // labelMaxRepetitions
            // 
            this.labelMaxRepetitions.AutoSize = true;
            this.labelMaxRepetitions.Location = new System.Drawing.Point(159, 550);
            this.labelMaxRepetitions.Name = "labelMaxRepetitions";
            this.labelMaxRepetitions.Size = new System.Drawing.Size(102, 13);
            this.labelMaxRepetitions.TabIndex = 14;
            this.labelMaxRepetitions.Text = "Maximum repetitions";
            // 
            // numericUpDownMaxRepetitions
            // 
            this.numericUpDownMaxRepetitions.Location = new System.Drawing.Point(162, 566);
            this.numericUpDownMaxRepetitions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMaxRepetitions.Name = "numericUpDownMaxRepetitions";
            this.numericUpDownMaxRepetitions.Size = new System.Drawing.Size(103, 20);
            this.numericUpDownMaxRepetitions.TabIndex = 13;
            this.numericUpDownMaxRepetitions.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMaxRepetitions.ValueChanged += new System.EventHandler(this.changesOccured);
            // 
            // labelReportTitle
            // 
            this.labelReportTitle.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.labelReportTitle.AutoSize = true;
            this.labelReportTitle.Location = new System.Drawing.Point(159, 502);
            this.labelReportTitle.Name = "labelReportTitle";
            this.labelReportTitle.Size = new System.Drawing.Size(58, 13);
            this.labelReportTitle.TabIndex = 12;
            this.labelReportTitle.Text = "Report title";
            // 
            // textBoxReportTitle
            // 
            this.textBoxReportTitle.Location = new System.Drawing.Point(162, 518);
            this.textBoxReportTitle.Name = "textBoxReportTitle";
            this.textBoxReportTitle.Size = new System.Drawing.Size(140, 20);
            this.textBoxReportTitle.TabIndex = 11;
            this.textBoxReportTitle.TextChanged += new System.EventHandler(this.changesOccured);
            // 
            // buttonSelectOutputFile
            // 
            this.buttonSelectOutputFile.Location = new System.Drawing.Point(474, 454);
            this.buttonSelectOutputFile.Name = "buttonSelectOutputFile";
            this.buttonSelectOutputFile.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectOutputFile.TabIndex = 10;
            this.buttonSelectOutputFile.Text = "Select file";
            this.buttonSelectOutputFile.UseVisualStyleBackColor = true;
            this.buttonSelectOutputFile.Click += new System.EventHandler(this.buttonSelectOutputFile_Click);
            // 
            // labelReportFile
            // 
            this.labelReportFile.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.labelReportFile.AutoSize = true;
            this.labelReportFile.Location = new System.Drawing.Point(3, 440);
            this.labelReportFile.Name = "labelReportFile";
            this.labelReportFile.Size = new System.Drawing.Size(55, 13);
            this.labelReportFile.TabIndex = 9;
            this.labelReportFile.Text = "Report file";
            // 
            // textBoxOutputFile
            // 
            this.textBoxOutputFile.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.textBoxOutputFile.Location = new System.Drawing.Point(6, 456);
            this.textBoxOutputFile.Name = "textBoxOutputFile";
            this.textBoxOutputFile.Size = new System.Drawing.Size(462, 20);
            this.textBoxOutputFile.TabIndex = 8;
            this.textBoxOutputFile.TextChanged += new System.EventHandler(this.changesOccured);
            // 
            // labelScenarioName
            // 
            this.labelScenarioName.AutoSize = true;
            this.labelScenarioName.Location = new System.Drawing.Point(3, 345);
            this.labelScenarioName.Name = "labelScenarioName";
            this.labelScenarioName.Size = new System.Drawing.Size(78, 13);
            this.labelScenarioName.TabIndex = 7;
            this.labelScenarioName.Text = "Scenario name";
            // 
            // textBoxScreenFolder
            // 
            this.textBoxScreenFolder.Location = new System.Drawing.Point(6, 407);
            this.textBoxScreenFolder.Name = "textBoxScreenFolder";
            this.textBoxScreenFolder.Size = new System.Drawing.Size(462, 20);
            this.textBoxScreenFolder.TabIndex = 6;
            this.textBoxScreenFolder.TextChanged += new System.EventHandler(this.changesOccured);
            // 
            // labelScreenFolder
            // 
            this.labelScreenFolder.AutoSize = true;
            this.labelScreenFolder.Location = new System.Drawing.Point(3, 391);
            this.labelScreenFolder.Name = "labelScreenFolder";
            this.labelScreenFolder.Size = new System.Drawing.Size(90, 13);
            this.labelScreenFolder.TabIndex = 7;
            this.labelScreenFolder.Text = "Screenshot folder";
            // 
            // textBoxScenarioName
            // 
            this.textBoxScenarioName.Location = new System.Drawing.Point(6, 359);
            this.textBoxScenarioName.Name = "textBoxScenarioName";
            this.textBoxScenarioName.Size = new System.Drawing.Size(462, 20);
            this.textBoxScenarioName.TabIndex = 6;
            this.textBoxScenarioName.TextChanged += new System.EventHandler(this.changesOccured);
            // 
            // labelCurrentScenario
            // 
            this.labelCurrentScenario.AutoSize = true;
            this.labelCurrentScenario.Location = new System.Drawing.Point(3, 45);
            this.labelCurrentScenario.Name = "labelCurrentScenario";
            this.labelCurrentScenario.Size = new System.Drawing.Size(86, 13);
            this.labelCurrentScenario.TabIndex = 5;
            this.labelCurrentScenario.Text = "Current Scenario";
            // 
            // textBoxFile
            // 
            this.textBoxFile.Enabled = false;
            this.textBoxFile.Location = new System.Drawing.Point(6, 61);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(462, 20);
            this.textBoxFile.TabIndex = 4;
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.Location = new System.Drawing.Point(474, 59);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectFile.TabIndex = 3;
            this.buttonSelectFile.Text = "Open file";
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.buttonSelectFile_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnName,
            this.columnTestCase,
            this.columnTestData});
            this.dataGridView1.Location = new System.Drawing.Point(6, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 242);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.changesOccured);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(582, 651);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Config";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(582, 651);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Result";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // columnName
            // 
            this.columnName.HeaderText = "name";
            this.columnName.Name = "columnName";
            // 
            // columnTestCase
            // 
            this.columnTestCase.HeaderText = "testcase";
            this.columnTestCase.Name = "columnTestCase";
            // 
            // columnTestData
            // 
            this.columnTestData.HeaderText = "testdata";
            this.columnTestData.Name = "columnTestData";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 692);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "CLMAutomation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxRepetitions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label labelCurrentScenario;
        private System.Windows.Forms.Label labelReportFile;
        private System.Windows.Forms.TextBox textBoxOutputFile;
        private System.Windows.Forms.Label labelScreenFolder;
        private System.Windows.Forms.TextBox textBoxScenarioName;
        private System.Windows.Forms.Button buttonSelectOutputFile;
        private System.Windows.Forms.Label labelReportTitle;
        private System.Windows.Forms.TextBox textBoxReportTitle;
        private System.Windows.Forms.Label labelMaxRepetitions;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxRepetitions;
        private System.Windows.Forms.Label labelDelay;
        private System.Windows.Forms.NumericUpDown numericUpDownDelay;
        private System.Windows.Forms.Label labelScreenshootingLevel;
        private System.Windows.Forms.ComboBox comboBoxScreenshootingLevel;
        private System.Windows.Forms.Label labelReportingLevel;
        private System.Windows.Forms.ComboBox comboBoxReportingLevel;
        private System.Windows.Forms.Label labelLoggingLevel;
        private System.Windows.Forms.ComboBox comboBoxLoggingLevel;
        private System.Windows.Forms.Label labelScenarioName;
        private System.Windows.Forms.TextBox textBoxScreenFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonSelectScreenFolder;
        private System.Windows.Forms.Button buttonSaveAs;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTestCase;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTestData;
    }
}


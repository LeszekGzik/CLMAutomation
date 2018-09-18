namespace CLMAutomation
{
    partial class UserControlScenario
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxAuto = new System.Windows.Forms.CheckBox();
            this.labelAutoFolder = new System.Windows.Forms.Label();
            this.textBoxAutoFolder = new System.Windows.Forms.TextBox();
            this.buttonSelectAutoFolder = new System.Windows.Forms.Button();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTestCase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTestData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxRepetitions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSelectScreenFolder
            // 
            this.buttonSelectScreenFolder.Location = new System.Drawing.Point(482, 328);
            this.buttonSelectScreenFolder.Name = "buttonSelectScreenFolder";
            this.buttonSelectScreenFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectScreenFolder.TabIndex = 47;
            this.buttonSelectScreenFolder.Text = "Select folder";
            this.buttonSelectScreenFolder.UseVisualStyleBackColor = true;
            this.buttonSelectScreenFolder.Click += new System.EventHandler(this.buttonSelectScreenFolder_Click);
            // 
            // labelScreenshootingLevel
            // 
            this.labelScreenshootingLevel.AutoSize = true;
            this.labelScreenshootingLevel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelScreenshootingLevel.Location = new System.Drawing.Point(11, 567);
            this.labelScreenshootingLevel.Name = "labelScreenshootingLevel";
            this.labelScreenshootingLevel.Size = new System.Drawing.Size(106, 13);
            this.labelScreenshootingLevel.TabIndex = 46;
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
            this.comboBoxScreenshootingLevel.Location = new System.Drawing.Point(14, 582);
            this.comboBoxScreenshootingLevel.Name = "comboBoxScreenshootingLevel";
            this.comboBoxScreenshootingLevel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxScreenshootingLevel.TabIndex = 45;
            this.toolTip1.SetToolTip(this.comboBoxScreenshootingLevel, "How often screenshots are taken");
            this.comboBoxScreenshootingLevel.SelectedIndexChanged += new System.EventHandler(this.changesOccured);
            // 
            // labelReportingLevel
            // 
            this.labelReportingLevel.AutoSize = true;
            this.labelReportingLevel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelReportingLevel.Location = new System.Drawing.Point(11, 517);
            this.labelReportingLevel.Name = "labelReportingLevel";
            this.labelReportingLevel.Size = new System.Drawing.Size(78, 13);
            this.labelReportingLevel.TabIndex = 44;
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
            this.comboBoxReportingLevel.Location = new System.Drawing.Point(14, 532);
            this.comboBoxReportingLevel.Name = "comboBoxReportingLevel";
            this.comboBoxReportingLevel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxReportingLevel.TabIndex = 42;
            this.toolTip1.SetToolTip(this.comboBoxReportingLevel, "How often reports are made");
            this.comboBoxReportingLevel.SelectedIndexChanged += new System.EventHandler(this.changesOccured);
            // 
            // labelLoggingLevel
            // 
            this.labelLoggingLevel.AutoSize = true;
            this.labelLoggingLevel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelLoggingLevel.Location = new System.Drawing.Point(11, 469);
            this.labelLoggingLevel.Name = "labelLoggingLevel";
            this.labelLoggingLevel.Size = new System.Drawing.Size(70, 13);
            this.labelLoggingLevel.TabIndex = 43;
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
            this.comboBoxLoggingLevel.Location = new System.Drawing.Point(14, 484);
            this.comboBoxLoggingLevel.Name = "comboBoxLoggingLevel";
            this.comboBoxLoggingLevel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLoggingLevel.TabIndex = 41;
            this.toolTip1.SetToolTip(this.comboBoxLoggingLevel, "How often logs are saved");
            this.comboBoxLoggingLevel.SelectedIndexChanged += new System.EventHandler(this.changesOccured);
            // 
            // labelDelay
            // 
            this.labelDelay.AutoSize = true;
            this.labelDelay.Location = new System.Drawing.Point(167, 565);
            this.labelDelay.Name = "labelDelay";
            this.labelDelay.Size = new System.Drawing.Size(131, 13);
            this.labelDelay.TabIndex = 40;
            this.labelDelay.Text = "Delay between inputs [ms]";
            // 
            // numericUpDownDelay
            // 
            this.numericUpDownDelay.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownDelay.Location = new System.Drawing.Point(170, 581);
            this.numericUpDownDelay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownDelay.Name = "numericUpDownDelay";
            this.numericUpDownDelay.Size = new System.Drawing.Size(103, 20);
            this.numericUpDownDelay.TabIndex = 39;
            this.toolTip1.SetToolTip(this.numericUpDownDelay, "Time to wait between actions, in miliseconds");
            this.numericUpDownDelay.ValueChanged += new System.EventHandler(this.changesOccured);
            // 
            // labelMaxRepetitions
            // 
            this.labelMaxRepetitions.AutoSize = true;
            this.labelMaxRepetitions.Location = new System.Drawing.Point(167, 517);
            this.labelMaxRepetitions.Name = "labelMaxRepetitions";
            this.labelMaxRepetitions.Size = new System.Drawing.Size(102, 13);
            this.labelMaxRepetitions.TabIndex = 38;
            this.labelMaxRepetitions.Text = "Maximum repetitions";
            // 
            // numericUpDownMaxRepetitions
            // 
            this.numericUpDownMaxRepetitions.Location = new System.Drawing.Point(170, 533);
            this.numericUpDownMaxRepetitions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMaxRepetitions.Name = "numericUpDownMaxRepetitions";
            this.numericUpDownMaxRepetitions.Size = new System.Drawing.Size(103, 20);
            this.numericUpDownMaxRepetitions.TabIndex = 37;
            this.toolTip1.SetToolTip(this.numericUpDownMaxRepetitions, "Number of action repetitions in case of error");
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
            this.labelReportTitle.Location = new System.Drawing.Point(167, 469);
            this.labelReportTitle.Name = "labelReportTitle";
            this.labelReportTitle.Size = new System.Drawing.Size(58, 13);
            this.labelReportTitle.TabIndex = 36;
            this.labelReportTitle.Text = "Report title";
            // 
            // textBoxReportTitle
            // 
            this.textBoxReportTitle.Location = new System.Drawing.Point(170, 485);
            this.textBoxReportTitle.Name = "textBoxReportTitle";
            this.textBoxReportTitle.Size = new System.Drawing.Size(140, 20);
            this.textBoxReportTitle.TabIndex = 35;
            this.toolTip1.SetToolTip(this.textBoxReportTitle, "Title for the .xls report sheet");
            this.textBoxReportTitle.TextChanged += new System.EventHandler(this.changesOccured);
            // 
            // buttonSelectOutputFile
            // 
            this.buttonSelectOutputFile.Location = new System.Drawing.Point(482, 378);
            this.buttonSelectOutputFile.Name = "buttonSelectOutputFile";
            this.buttonSelectOutputFile.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectOutputFile.TabIndex = 34;
            this.buttonSelectOutputFile.Text = "Select file";
            this.buttonSelectOutputFile.UseVisualStyleBackColor = true;
            this.buttonSelectOutputFile.Click += new System.EventHandler(this.buttonSelectOutputFile_Click);
            // 
            // labelReportFile
            // 
            this.labelReportFile.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.labelReportFile.AutoSize = true;
            this.labelReportFile.Location = new System.Drawing.Point(11, 364);
            this.labelReportFile.Name = "labelReportFile";
            this.labelReportFile.Size = new System.Drawing.Size(55, 13);
            this.labelReportFile.TabIndex = 33;
            this.labelReportFile.Text = "Report file";
            // 
            // textBoxOutputFile
            // 
            this.textBoxOutputFile.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.textBoxOutputFile.Location = new System.Drawing.Point(14, 380);
            this.textBoxOutputFile.Name = "textBoxOutputFile";
            this.textBoxOutputFile.Size = new System.Drawing.Size(462, 20);
            this.textBoxOutputFile.TabIndex = 32;
            this.toolTip1.SetToolTip(this.textBoxOutputFile, ".xls report file location");
            this.textBoxOutputFile.TextChanged += new System.EventHandler(this.changesOccured);
            // 
            // labelScenarioName
            // 
            this.labelScenarioName.AutoSize = true;
            this.labelScenarioName.Location = new System.Drawing.Point(11, 269);
            this.labelScenarioName.Name = "labelScenarioName";
            this.labelScenarioName.Size = new System.Drawing.Size(78, 13);
            this.labelScenarioName.TabIndex = 31;
            this.labelScenarioName.Text = "Scenario name";
            // 
            // textBoxScreenFolder
            // 
            this.textBoxScreenFolder.Location = new System.Drawing.Point(14, 331);
            this.textBoxScreenFolder.Name = "textBoxScreenFolder";
            this.textBoxScreenFolder.Size = new System.Drawing.Size(462, 20);
            this.textBoxScreenFolder.TabIndex = 29;
            this.toolTip1.SetToolTip(this.textBoxScreenFolder, "Screenshots taken during execution will be saved here");
            this.textBoxScreenFolder.TextChanged += new System.EventHandler(this.changesOccured);
            // 
            // labelScreenFolder
            // 
            this.labelScreenFolder.AutoSize = true;
            this.labelScreenFolder.Location = new System.Drawing.Point(11, 315);
            this.labelScreenFolder.Name = "labelScreenFolder";
            this.labelScreenFolder.Size = new System.Drawing.Size(90, 13);
            this.labelScreenFolder.TabIndex = 30;
            this.labelScreenFolder.Text = "Screenshot folder";
            // 
            // textBoxScenarioName
            // 
            this.textBoxScenarioName.Location = new System.Drawing.Point(14, 283);
            this.textBoxScenarioName.Name = "textBoxScenarioName";
            this.textBoxScenarioName.Size = new System.Drawing.Size(462, 20);
            this.textBoxScenarioName.TabIndex = 28;
            this.toolTip1.SetToolTip(this.textBoxScenarioName, "Name that will be displayed in logs and reports");
            this.textBoxScenarioName.TextChanged += new System.EventHandler(this.changesOccured);
            // 
            // labelCurrentScenario
            // 
            this.labelCurrentScenario.AutoSize = true;
            this.labelCurrentScenario.Location = new System.Drawing.Point(11, 12);
            this.labelCurrentScenario.Name = "labelCurrentScenario";
            this.labelCurrentScenario.Size = new System.Drawing.Size(86, 13);
            this.labelCurrentScenario.TabIndex = 27;
            this.labelCurrentScenario.Text = "Current Scenario";
            // 
            // textBoxFile
            // 
            this.textBoxFile.Enabled = false;
            this.textBoxFile.Location = new System.Drawing.Point(14, 28);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(543, 20);
            this.textBoxFile.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnName,
            this.columnTestCase,
            this.columnTestData});
            this.dataGridView1.Location = new System.Drawing.Point(14, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 206);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.changesOccured);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // checkBoxAuto
            // 
            this.checkBoxAuto.AutoSize = true;
            this.checkBoxAuto.Location = new System.Drawing.Point(389, 468);
            this.checkBoxAuto.Name = "checkBoxAuto";
            this.checkBoxAuto.Size = new System.Drawing.Size(168, 17);
            this.checkBoxAuto.TabIndex = 48;
            this.checkBoxAuto.Text = "Auto-generate report file name";
            this.toolTip1.SetToolTip(this.checkBoxAuto, "Automatically generate a unique report file for each execution of this scenario ");
            this.checkBoxAuto.UseVisualStyleBackColor = true;
            this.checkBoxAuto.CheckedChanged += new System.EventHandler(this.checkBoxAuto_CheckedChanged);
            // 
            // labelAutoFolder
            // 
            this.labelAutoFolder.AutoSize = true;
            this.labelAutoFolder.Location = new System.Drawing.Point(11, 409);
            this.labelAutoFolder.Name = "labelAutoFolder";
            this.labelAutoFolder.Size = new System.Drawing.Size(206, 13);
            this.labelAutoFolder.TabIndex = 30;
            this.labelAutoFolder.Text = "Report folder (auto-generated reports only)";
            // 
            // textBoxAutoFolder
            // 
            this.textBoxAutoFolder.Enabled = false;
            this.textBoxAutoFolder.Location = new System.Drawing.Point(14, 425);
            this.textBoxAutoFolder.Name = "textBoxAutoFolder";
            this.textBoxAutoFolder.Size = new System.Drawing.Size(462, 20);
            this.textBoxAutoFolder.TabIndex = 29;
            this.textBoxAutoFolder.TextChanged += new System.EventHandler(this.changesOccured);
            // 
            // buttonSelectAutoFolder
            // 
            this.buttonSelectAutoFolder.Enabled = false;
            this.buttonSelectAutoFolder.Location = new System.Drawing.Point(482, 423);
            this.buttonSelectAutoFolder.Name = "buttonSelectAutoFolder";
            this.buttonSelectAutoFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectAutoFolder.TabIndex = 47;
            this.buttonSelectAutoFolder.Text = "Select folder";
            this.buttonSelectAutoFolder.UseVisualStyleBackColor = true;
            this.buttonSelectAutoFolder.Click += new System.EventHandler(this.buttonSelectAutoFolder_Click);
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
            // UserControlScenario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxAuto);
            this.Controls.Add(this.buttonSelectAutoFolder);
            this.Controls.Add(this.buttonSelectScreenFolder);
            this.Controls.Add(this.labelScreenshootingLevel);
            this.Controls.Add(this.comboBoxScreenshootingLevel);
            this.Controls.Add(this.labelReportingLevel);
            this.Controls.Add(this.comboBoxReportingLevel);
            this.Controls.Add(this.labelLoggingLevel);
            this.Controls.Add(this.comboBoxLoggingLevel);
            this.Controls.Add(this.labelDelay);
            this.Controls.Add(this.numericUpDownDelay);
            this.Controls.Add(this.labelMaxRepetitions);
            this.Controls.Add(this.numericUpDownMaxRepetitions);
            this.Controls.Add(this.labelReportTitle);
            this.Controls.Add(this.textBoxReportTitle);
            this.Controls.Add(this.buttonSelectOutputFile);
            this.Controls.Add(this.labelReportFile);
            this.Controls.Add(this.textBoxOutputFile);
            this.Controls.Add(this.labelScenarioName);
            this.Controls.Add(this.textBoxAutoFolder);
            this.Controls.Add(this.textBoxScreenFolder);
            this.Controls.Add(this.labelAutoFolder);
            this.Controls.Add(this.labelScreenFolder);
            this.Controls.Add(this.textBoxScenarioName);
            this.Controls.Add(this.labelCurrentScenario);
            this.Controls.Add(this.textBoxFile);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserControlScenario";
            this.Size = new System.Drawing.Size(585, 619);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxRepetitions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSelectScreenFolder;
        private System.Windows.Forms.Label labelScreenshootingLevel;
        private System.Windows.Forms.ComboBox comboBoxScreenshootingLevel;
        private System.Windows.Forms.Label labelReportingLevel;
        private System.Windows.Forms.ComboBox comboBoxReportingLevel;
        private System.Windows.Forms.Label labelLoggingLevel;
        private System.Windows.Forms.ComboBox comboBoxLoggingLevel;
        private System.Windows.Forms.Label labelDelay;
        private System.Windows.Forms.NumericUpDown numericUpDownDelay;
        private System.Windows.Forms.Label labelMaxRepetitions;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxRepetitions;
        private System.Windows.Forms.Label labelReportTitle;
        private System.Windows.Forms.TextBox textBoxReportTitle;
        private System.Windows.Forms.Button buttonSelectOutputFile;
        private System.Windows.Forms.Label labelReportFile;
        private System.Windows.Forms.TextBox textBoxOutputFile;
        private System.Windows.Forms.Label labelScenarioName;
        private System.Windows.Forms.TextBox textBoxScreenFolder;
        private System.Windows.Forms.Label labelScreenFolder;
        private System.Windows.Forms.TextBox textBoxScenarioName;
        private System.Windows.Forms.Label labelCurrentScenario;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox checkBoxAuto;
        private System.Windows.Forms.Label labelAutoFolder;
        private System.Windows.Forms.TextBox textBoxAutoFolder;
        private System.Windows.Forms.Button buttonSelectAutoFolder;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTestCase;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTestData;
    }
}

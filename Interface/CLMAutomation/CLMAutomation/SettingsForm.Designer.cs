namespace CLMAutomation
{
    partial class SettingsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonUndo = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.checkBoxProxy = new System.Windows.Forms.CheckBox();
            this.labelProxy = new System.Windows.Forms.Label();
            this.textBoxProxy = new System.Windows.Forms.TextBox();
            this.textBoxGeckoPath = new System.Windows.Forms.TextBox();
            this.textBoxFirefoxPath = new System.Windows.Forms.TextBox();
            this.labelGeckoPath = new System.Windows.Forms.Label();
            this.labelFirefoxPath = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonGeckoPath = new System.Windows.Forms.Button();
            this.buttonFirefoxPath = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // buttonUndo
            // 
            this.buttonUndo.Enabled = false;
            this.buttonUndo.Location = new System.Drawing.Point(432, 194);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(75, 23);
            this.buttonUndo.TabIndex = 35;
            this.buttonUndo.Text = "Undo";
            this.buttonUndo.UseVisualStyleBackColor = true;
            this.buttonUndo.Click += new System.EventHandler(this.buttonUndo_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(226, 255);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 34;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // checkBoxProxy
            // 
            this.checkBoxProxy.AutoSize = true;
            this.checkBoxProxy.Location = new System.Drawing.Point(15, 120);
            this.checkBoxProxy.Name = "checkBoxProxy";
            this.checkBoxProxy.Size = new System.Drawing.Size(73, 17);
            this.checkBoxProxy.TabIndex = 33;
            this.checkBoxProxy.Text = "Use proxy";
            this.checkBoxProxy.UseVisualStyleBackColor = true;
            this.checkBoxProxy.CheckedChanged += new System.EventHandler(this.checkBoxProxy_CheckedChanged);
            // 
            // labelProxy
            // 
            this.labelProxy.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.labelProxy.AutoSize = true;
            this.labelProxy.Location = new System.Drawing.Point(12, 152);
            this.labelProxy.Name = "labelProxy";
            this.labelProxy.Size = new System.Drawing.Size(58, 13);
            this.labelProxy.TabIndex = 30;
            this.labelProxy.Text = "Proxy URL";
            // 
            // textBoxProxy
            // 
            this.textBoxProxy.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.textBoxProxy.Enabled = false;
            this.textBoxProxy.Location = new System.Drawing.Point(15, 168);
            this.textBoxProxy.Name = "textBoxProxy";
            this.textBoxProxy.Size = new System.Drawing.Size(462, 20);
            this.textBoxProxy.TabIndex = 28;
            this.textBoxProxy.TextChanged += new System.EventHandler(this.configChangesOccured);
            // 
            // textBoxGeckoPath
            // 
            this.textBoxGeckoPath.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.textBoxGeckoPath.Location = new System.Drawing.Point(15, 77);
            this.textBoxGeckoPath.Name = "textBoxGeckoPath";
            this.textBoxGeckoPath.Size = new System.Drawing.Size(462, 20);
            this.textBoxGeckoPath.TabIndex = 29;
            this.textBoxGeckoPath.TextChanged += new System.EventHandler(this.configChangesOccured);
            // 
            // textBoxFirefoxPath
            // 
            this.textBoxFirefoxPath.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.textBoxFirefoxPath.Location = new System.Drawing.Point(15, 25);
            this.textBoxFirefoxPath.Name = "textBoxFirefoxPath";
            this.textBoxFirefoxPath.Size = new System.Drawing.Size(462, 20);
            this.textBoxFirefoxPath.TabIndex = 25;
            this.textBoxFirefoxPath.TextChanged += new System.EventHandler(this.configChangesOccured);
            // 
            // labelGeckoPath
            // 
            this.labelGeckoPath.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.labelGeckoPath.AutoSize = true;
            this.labelGeckoPath.Location = new System.Drawing.Point(12, 61);
            this.labelGeckoPath.Name = "labelGeckoPath";
            this.labelGeckoPath.Size = new System.Drawing.Size(89, 13);
            this.labelGeckoPath.TabIndex = 31;
            this.labelGeckoPath.Text = "Geckodriver path";
            // 
            // labelFirefoxPath
            // 
            this.labelFirefoxPath.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.labelFirefoxPath.AutoSize = true;
            this.labelFirefoxPath.Location = new System.Drawing.Point(12, 9);
            this.labelFirefoxPath.Name = "labelFirefoxPath";
            this.labelFirefoxPath.Size = new System.Drawing.Size(117, 13);
            this.labelFirefoxPath.TabIndex = 26;
            this.labelFirefoxPath.Text = "Firefox executable path";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(15, 255);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 36;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(432, 255);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 37;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonGeckoPath
            // 
            this.buttonGeckoPath.Image = global::CLMAutomation.Properties.Resources.Folder_16x;
            this.buttonGeckoPath.Location = new System.Drawing.Point(483, 75);
            this.buttonGeckoPath.Name = "buttonGeckoPath";
            this.buttonGeckoPath.Size = new System.Drawing.Size(24, 24);
            this.buttonGeckoPath.TabIndex = 32;
            this.buttonGeckoPath.UseVisualStyleBackColor = true;
            this.buttonGeckoPath.Click += new System.EventHandler(this.buttonGeckoPath_Click);
            // 
            // buttonFirefoxPath
            // 
            this.buttonFirefoxPath.Image = global::CLMAutomation.Properties.Resources.Folder_16x;
            this.buttonFirefoxPath.Location = new System.Drawing.Point(483, 23);
            this.buttonFirefoxPath.Name = "buttonFirefoxPath";
            this.buttonFirefoxPath.Size = new System.Drawing.Size(24, 24);
            this.buttonFirefoxPath.TabIndex = 27;
            this.buttonFirefoxPath.UseVisualStyleBackColor = true;
            this.buttonFirefoxPath.Click += new System.EventHandler(this.buttonFirefoxPath_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "c";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 312);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonUndo);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.checkBoxProxy);
            this.Controls.Add(this.labelProxy);
            this.Controls.Add(this.textBoxProxy);
            this.Controls.Add(this.textBoxGeckoPath);
            this.Controls.Add(this.textBoxFirefoxPath);
            this.Controls.Add(this.labelGeckoPath);
            this.Controls.Add(this.labelFirefoxPath);
            this.Controls.Add(this.buttonGeckoPath);
            this.Controls.Add(this.buttonFirefoxPath);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonUndo;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.CheckBox checkBoxProxy;
        private System.Windows.Forms.Label labelProxy;
        private System.Windows.Forms.TextBox textBoxProxy;
        private System.Windows.Forms.TextBox textBoxGeckoPath;
        private System.Windows.Forms.TextBox textBoxFirefoxPath;
        private System.Windows.Forms.Label labelGeckoPath;
        private System.Windows.Forms.Label labelFirefoxPath;
        private System.Windows.Forms.Button buttonGeckoPath;
        private System.Windows.Forms.Button buttonFirefoxPath;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
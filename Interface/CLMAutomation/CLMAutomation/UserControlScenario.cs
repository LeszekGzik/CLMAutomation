using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Diagnostics;

namespace CLMAutomation
{
    public partial class UserControlScenario : UserControl
    {
        Boolean changed, unnamed;
        Stopwatch watch;
        String shortName;

        public bool Changed { get => changed; set => changed = value; }
        public bool Unnamed { get => unnamed; set => unnamed = value; }
        public string ShortName { get => shortName; set => shortName = value; }

        public event EventHandler ScenarioChanged;

        public UserControlScenario()
        {
            InitializeComponent();
            Changed = false;
            Unnamed = true;
        }

        public UserControlScenario(String name)
        {
            InitializeComponent();
            ShortName = name;
            Changed = false;
            Unnamed = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int column = e.ColumnIndex;
            int row = e.RowIndex;
            if ((column == 1) || (column == 2))
            {
                openFileDialog1.Filter = "Microsoft Excel Spreadsheets|*.xls";
                openFileDialog1.FileName = "";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    dataGridView1[column, row].Value = openFileDialog1.FileName;
                    if (ScenarioChanged != null) ScenarioChanged(this, new EventArgs());
                    Changed = true;
                }
            }
        }

        private void buttonSelectOutputFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Microsoft Excel Spreadsheets|*.xls";
            saveFileDialog1.FileName = "";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxOutputFile.Text = saveFileDialog1.FileName;
                if (ScenarioChanged != null) ScenarioChanged(this, new EventArgs());
                Changed = true;
            }
        }

        private void buttonSelectScreenFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxScreenFolder.Text = folderBrowserDialog1.SelectedPath;
                if (ScenarioChanged != null) ScenarioChanged(this, new EventArgs());
                Changed = true;
            }
        }

        private void changesOccured(object sender, EventArgs e)
        {
            if (ScenarioChanged != null) ScenarioChanged(this, new EventArgs());
            Changed = true;
        }

        private void changesOccured(object sender, DataGridViewCellEventArgs e)
        {
            if (ScenarioChanged != null) ScenarioChanged(this, new EventArgs());
            Changed = true;
        }

        public void saveScenarioAs(String fileName)
        {
            XmlDocument doc = new XmlDocument();
            XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(docNode);

            XmlElement scenarioNode = doc.CreateElement("scenario");
            scenarioNode.SetAttribute("name", textBoxScenarioName.Text);
            doc.AppendChild(scenarioNode);

            XmlElement otherNode = doc.CreateElement("screenfolder");
            otherNode.InnerText = textBoxScreenFolder.Text;
            scenarioNode.AppendChild(otherNode);

            otherNode = doc.CreateElement("xlsoutput");
            otherNode.InnerText = textBoxOutputFile.Text;
            scenarioNode.AppendChild(otherNode);

            otherNode = doc.CreateElement("xlssheet");
            otherNode.InnerText = textBoxReportTitle.Text;
            scenarioNode.AppendChild(otherNode);

            otherNode = doc.CreateElement("maxrepetitions");
            otherNode.InnerText = numericUpDownMaxRepetitions.Value.ToString();
            scenarioNode.AppendChild(otherNode);

            otherNode = doc.CreateElement("waitforinput");
            otherNode.InnerText = numericUpDownDelay.Value.ToString();
            scenarioNode.AppendChild(otherNode);

            otherNode = doc.CreateElement("reportinglevel");
            otherNode.InnerText = comboBoxReportingLevel.Text;
            scenarioNode.AppendChild(otherNode);

            otherNode = doc.CreateElement("logginglevel");
            otherNode.InnerText = comboBoxLoggingLevel.Text;
            scenarioNode.AppendChild(otherNode);

            otherNode = doc.CreateElement("screenshootinglevel");
            otherNode.InnerText = comboBoxScreenshootingLevel.Text;
            scenarioNode.AppendChild(otherNode);

            XmlElement testsNode = doc.CreateElement("tests");
            scenarioNode.AppendChild(testsNode);

            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                XmlElement testNode = doc.CreateElement("test");
                testNode.SetAttribute("name", dataGridView1[0, i].Value.ToString());
                testNode.SetAttribute("testcase", dataGridView1[1, i].Value.ToString());
                testNode.SetAttribute("testdata", dataGridView1[2, i].Value.ToString());
                testsNode.AppendChild(testNode);
            }

            doc.Save(fileName);
            textBoxFile.Text = fileName;
            Changed = false;
            Unnamed = false;
            ShortName = fileName.Substring(fileName.LastIndexOf('\\') + 1);
        }

        public void saveScenario()
        {
            saveScenarioAs(textBoxFile.Text);
        }

        //jeśli formatka jest niezapisana, pyta i/lub zapisuje; zwraca false jeśli użytkownik anulował, lub true w przeciwnym wypadku
        public Boolean askAboutSaving()
        {
            Boolean ok = true;
            if (Changed)
            {
                DialogResult dialogResult = MessageBox.Show("There are unsaved changes in " + ShortName + ". Do you want to save now?", "Warning", MessageBoxButtons.YesNoCancel);
                if (dialogResult == DialogResult.Yes)
                {
                    if (Unnamed)
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            saveScenarioAs(saveFileDialog1.FileName);
                            Unnamed = false;
                            Changed = false;
                        }
                        else if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                        {
                            ok = false;
                        }
                    }
                    else
                    {
                        saveScenarioAs(textBoxFile.Text);
                        Changed = false;
                    }
                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    ok = false;
                }
            }
            return ok;
        }

        public void loadScenario(String fileName)
        {
            try
            {
                //wypełnianie gridview
                dataGridView1.Columns.Clear();
                XmlDocument doc = new XmlDocument();
                doc.Load(fileName);
                XmlNode node = doc.SelectSingleNode("//tests");
                XmlNodeReader xnr = new XmlNodeReader(node);
                DataSet ds = new DataSet();
                ds.ReadXml(xnr);
                dataGridView1.DataSource = ds.Tables[0];
                textBoxFile.Text = fileName;

                textBoxScenarioName.Text = doc.SelectSingleNode("//scenario").Attributes["name"].Value;
                textBoxOutputFile.Text = doc.SelectSingleNode("//xlsoutput/text()").Value;
                textBoxReportTitle.Text = doc.SelectSingleNode("//xlssheet/text()").Value;
                textBoxScreenFolder.Text = doc.SelectSingleNode("//screenfolder/text()").Value;
                numericUpDownMaxRepetitions.Value = Int32.Parse(doc.SelectSingleNode("//maxrepetitions/text()").Value);
                numericUpDownDelay.Value = Int32.Parse(doc.SelectSingleNode("//waitforinput/text()").Value);
                comboBoxLoggingLevel.Text = doc.SelectSingleNode("//scenario/logginglevel/text()").Value;
                comboBoxReportingLevel.Text = doc.SelectSingleNode("//scenario/reportinglevel/text()").Value;
                comboBoxScreenshootingLevel.Text = doc.SelectSingleNode("//scenario/screenshootinglevel/text()").Value;
                Changed = false;
                Unnamed = false;
                ShortName = fileName.Substring(fileName.LastIndexOf('\\') + 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void run()
        {
            Boolean ok = askAboutSaving();
            if (ok)
            {
                Process runJar = new Process();
                runJar.Exited += new EventHandler(exited);
                runJar.EnableRaisingEvents = true;
                runJar.StartInfo.UseShellExecute = false;
                runJar.StartInfo.FileName = "java";
                runJar.StartInfo.WorkingDirectory = Application.StartupPath + "\\..\\..\\..\\..\\..\\CLMautomatisation";
                runJar.StartInfo.Arguments = "-jar CLMautomation.jar " + textBoxFile.Text;
                runJar.Start();
                watch = Stopwatch.StartNew();
            }
        }

        private void exited(object sender, EventArgs e)
        {
            watch.Stop();
            double elapsed = (double)watch.ElapsedMilliseconds / 1000;
            /*if (checkBoxOpenMessage.Checked)
            {
                MessageBox.Show("Scenario completed in " + elapsed + " seconds.", "Testing finished");
            }
            if (checkBoxOpenExcel.Checked)
            {
                Process runExcel = new Process();
                runExcel.StartInfo.WorkingDirectory = Application.StartupPath + "\\..\\..\\..\\..\\..\\CLMautomatisation";
                runExcel.StartInfo.FileName = textBoxOutputFile.Text;
                runExcel.Start();
            }*/
            MessageBox.Show("Scenario completed in " + elapsed + " seconds.", "Testing finished");
        }

        public Boolean isCorrect()
        {
            Boolean correct = true;
            correct &= (textBoxScenarioName.Text.Length > 0);
            correct &= (textBoxScreenFolder.Text.Length > 0);
            correct &= (textBoxReportTitle.Text.Length > 0);
            correct &= (textBoxOutputFile.Text.Length > 0);
            correct &= (comboBoxLoggingLevel.SelectedItem != null);
            correct &= (comboBoxReportingLevel.SelectedItem != null);
            correct &= (comboBoxScreenshootingLevel.SelectedItem != null);
            return correct;
        }
    }
}

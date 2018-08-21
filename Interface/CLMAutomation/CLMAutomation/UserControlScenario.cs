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

        public UserControlScenario()
        {
            InitializeComponent();
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
                    changed = true;
                }
            }
        }

        private void buttonSelectOutputFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Microsoft Excel Spreadsheets|*.xls";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxOutputFile.Text = openFileDialog1.FileName;
                changed = true;
            }
        }

        private void buttonSelectScreenFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxScreenFolder.Text = folderBrowserDialog1.SelectedPath;
                changed = true;
            }
        }

        private void changesOccured(object sender, EventArgs e)
        {
            changed = true;
        }

        private void changesOccured(object sender, DataGridViewCellEventArgs e)
        {
            changed = true;
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
        }

        //jeśli formatka jest niezapisana, pyta i/lub zapisuje; zwraca false jeśli użytkownik anulował, lub true w przeciwnym wypadku
        public Boolean askAboutSaving()
        {
            Boolean ok = true;
            if (changed)
            {
                DialogResult dialogResult = MessageBox.Show("There are unsaved changes in the form. Do you want to save now?", "Warning", MessageBoxButtons.YesNoCancel);
                if (dialogResult == DialogResult.Yes)
                {
                    if (unnamed)
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            saveScenarioAs(saveFileDialog1.FileName);
                            unnamed = false;
                            changed = false;
                        }
                        else if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                        {
                            ok = false;
                        }
                    }
                    else
                    {
                        saveScenarioAs(textBoxFile.Text);
                        changed = false;
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
                changed = false;
                unnamed = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void newScenario()
        {
            Boolean changesSaved = askAboutSaving();

            if (changesSaved)
            {
                textBoxFile.Text = "";
                textBoxOutputFile.Text = "";
                textBoxReportTitle.Text = "";
                textBoxScenarioName.Text = "";
                textBoxScreenFolder.Text = "";
                numericUpDownDelay.Value = 0;
                numericUpDownMaxRepetitions.Value = 1;
                comboBoxLoggingLevel.SelectedItem = null;
                comboBoxReportingLevel.SelectedItem = null;
                comboBoxScreenshootingLevel.SelectedItem = null;
                dataGridView1.DataSource = null;
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add(columnName);
                dataGridView1.Columns.Add(columnTestCase);
                dataGridView1.Columns.Add(columnTestData);
                unnamed = true;
                changed = false;
            }
        }

        public void run()
        {
            askAboutSaving();
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
    }
}

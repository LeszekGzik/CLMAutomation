using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CLMAutomation
{
    public partial class Form1 : Form
    {
        Boolean changed, unnamed;
        String propertiesComment;

        public Form1()
        {
            InitializeComponent();
            loadProperties();
            buttonUndoProperties.Enabled = false;
            saveFileDialog1.Filter = "XML Files|*.xml";
            changed = false;
            unnamed = true;
        }

        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            Boolean changesSaved = askAboutSaving();

            if (changesSaved) {
                openFileDialog1.Filter = "XML Files|*.xml";
                openFileDialog1.FileName = "";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    loadScenario(openFileDialog1.FileName);
                    unnamed = false;
                }
            }
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

            for (int i = 0; i<dataGridView1.RowCount-1; i++)
            {
                XmlElement testNode = doc.CreateElement("test");
                testNode.SetAttribute("name", dataGridView1[0,i].Value.ToString());
                testNode.SetAttribute("testcase", dataGridView1[1, i].Value.ToString());
                testNode.SetAttribute("testdata", dataGridView1[2, i].Value.ToString());
                testsNode.AppendChild(testNode);
            }

            doc.Save(fileName);
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

        private void buttonSelectScreenFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxScreenFolder.Text = folderBrowserDialog1.SelectedPath;
                changed = true;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (unnamed)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    saveScenarioAs(saveFileDialog1.FileName);
                    changed = false;
                    unnamed = false;
                }
            }
            else
            {
                saveScenarioAs(textBoxFile.Text);
                changed = false;
            }
        }

        private void buttonSaveAs_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                saveScenarioAs(saveFileDialog1.FileName);
                textBoxFile.Text = saveFileDialog1.FileName;
                changed = false;
                unnamed = false;
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

        private void configChangesOccured(object sender, EventArgs e)
        {
            buttonUndoProperties.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Boolean close = askAboutSaving();
            if (!close)
            {
                e.Cancel = true;
            }
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process runJar = new System.Diagnostics.Process();
            runJar.Exited += new EventHandler(exited);
            runJar.EnableRaisingEvents = true;
            runJar.StartInfo.UseShellExecute = false;
            runJar.StartInfo.FileName = "java";
            runJar.StartInfo.WorkingDirectory = Application.StartupPath + "\\..\\..\\..\\..\\..\\CLMautomatisation";
            runJar.StartInfo.Arguments = "-jar CLMautomation.jar " + textBoxFile.Text;
            runJar.Start();
        }

        private void buttonNew_Click(object sender, EventArgs e)
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

        private void checkBoxProxy_CheckedChanged(object sender, EventArgs e)
        {
            textBoxProxy.Enabled = checkBoxProxy.Checked;
            buttonUndoProperties.Enabled = true;
        }

        private void buttonFirefoxPath_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Executable Files|*.exe";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxFirefoxPath.Text = openFileDialog1.FileName;
            }
        }

        private void buttonGeckoPath_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Executable Files|*.exe";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxGeckoPath.Text = openFileDialog1.FileName;
            }
        }

        private void buttonUndoProperties_Click(object sender, EventArgs e)
        {
            loadProperties();
            buttonUndoProperties.Enabled = false;
        }

        private void buttonSaveProperties_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(docNode);


            XmlDocumentType docType = doc.CreateDocumentType("properties", null, "http://java.sun.com/dtd/properties.dtd", null);
            doc.AppendChild(docType);

            XmlNode propertiesNode = doc.CreateElement("properties");
            doc.AppendChild(propertiesNode);

            XmlElement property = doc.CreateElement("comment");
            property.InnerText = propertiesComment;
            propertiesNode.AppendChild(property);

            property = doc.CreateElement("entry");
            property.SetAttribute("key", "firefox");
            property.InnerText = textBoxFirefoxPath.Text;
            propertiesNode.AppendChild(property);

            property = doc.CreateElement("entry");
            property.SetAttribute("key", "geckodriver");
            property.InnerText = textBoxGeckoPath.Text;
            propertiesNode.AppendChild(property);

            property = doc.CreateElement("entry");
            property.SetAttribute("key", "proxy");
            if (checkBoxProxy.Checked)
            {
                property.InnerText = "true";
            }
            else
            {
                property.InnerText = "false";
            }
            propertiesNode.AppendChild(property);

            property = doc.CreateElement("entry");
            property.SetAttribute("key", "proxyURL");
            property.InnerText = textBoxProxy.Text;
            propertiesNode.AppendChild(property);

            doc.Save(Application.StartupPath + "\\..\\..\\..\\..\\..\\CLMautomatisation\\properties.xml");
            buttonUndoProperties.Enabled = false;
        }

        public void loadProperties()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Application.StartupPath + "\\..\\..\\..\\..\\..\\CLMautomatisation\\properties.xml");
            propertiesComment = doc.SelectSingleNode("//comment/text()").Value;
            foreach(XmlNode entry in doc.SelectNodes("//entry"))
            {
                switch(entry.Attributes["key"].Value)
                {
                    case "firefox":
                        textBoxFirefoxPath.Text = entry.SelectSingleNode("./text()").Value;
                        break;
                    case "geckodriver":
                        textBoxGeckoPath.Text = entry.SelectSingleNode("./text()").Value;
                        break;
                    case "proxyURL":
                        if (entry.SelectSingleNode("./text()") != null) {
                            textBoxProxy.Text = entry.SelectSingleNode("./text()").Value;
                        }
                        else
                        {
                            textBoxProxy.Text = "";
                        }
                        break;
                    case "proxy":
                        if (entry.SelectSingleNode("./text()").Value == "true")
                        {
                            checkBoxProxy.Checked = true;
                        }
                        else
                        {
                            checkBoxProxy.Checked = false;
                        }
                        break;
                }
            }
        }

        private void exited(object sender, EventArgs e)
        {
            MessageBox.Show("Test completed", "Message");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        Stopwatch watch;

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
            
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            
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
            property.SetAttribute("key", "openexcel");
            if (checkBoxOpenExcel.Checked)
            {
                property.InnerText = "true";
            }
            else
            {
                property.InnerText = "false";
            }
            propertiesNode.AppendChild(property);

            property = doc.CreateElement("entry");
            property.SetAttribute("key", "messagebox");
            if (checkBoxOpenMessage.Checked)
            {
                property.InnerText = "true";
            }
            else
            {
                property.InnerText = "false";
            }
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
                    case "openexcel":
                        if (entry.SelectSingleNode("./text()").Value == "true")
                        {
                            checkBoxOpenExcel.Checked = true;
                        }
                        else
                        {
                            checkBoxOpenExcel.Checked = false;
                        }
                        break;
                    case "messagebox":
                        if (entry.SelectSingleNode("./text()").Value == "true")
                        {
                            checkBoxOpenMessage.Checked = true;
                        }
                        else
                        {
                            checkBoxOpenMessage.Checked = false;
                        }
                        break;
                }
            }
        }
    }
}
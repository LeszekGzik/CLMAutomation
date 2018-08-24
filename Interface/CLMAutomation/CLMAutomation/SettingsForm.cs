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
    public partial class SettingsForm : Form
    {
        String propertiesComment;
        public SettingsForm()
        {
            InitializeComponent();
            loadProperties();
            buttonUndo.Enabled = false;
            buttonApply.Enabled = false;
        }

        private void configChangesOccured(object sender, EventArgs e)
        {
            buttonUndo.Enabled = true;
            buttonApply.Enabled = true;
        }

        private void checkBoxProxy_CheckedChanged(object sender, EventArgs e)
        {
            textBoxProxy.Enabled = checkBoxProxy.Checked;
            buttonUndo.Enabled = true;
            buttonApply.Enabled = true;
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

        public void loadProperties()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Application.StartupPath + "\\..\\..\\..\\..\\..\\CLMautomatisation\\properties.xml");
            propertiesComment = doc.SelectSingleNode("//comment/text()").Value;
            foreach (XmlNode entry in doc.SelectNodes("//entry"))
            {
                switch (entry.Attributes["key"].Value)
                {
                    case "firefox":
                        textBoxFirefoxPath.Text = entry.SelectSingleNode("./text()").Value;
                        break;
                    case "geckodriver":
                        textBoxGeckoPath.Text = entry.SelectSingleNode("./text()").Value;
                        break;
                    case "proxyURL":
                        if (entry.SelectSingleNode("./text()") != null)
                        {
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

        public void saveProperties()
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
            buttonUndo.Enabled = false;
            buttonApply.Enabled = false;
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            loadProperties();
            buttonUndo.Enabled = false;
            buttonApply.Enabled = false;
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            saveProperties();
            buttonUndo.Enabled = false;
            buttonApply.Enabled = false;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            saveProperties();
            this.Close();
        }
    }
}

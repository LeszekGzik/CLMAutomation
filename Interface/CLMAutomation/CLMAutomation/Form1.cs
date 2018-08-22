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
        int nextNewTabNumber;

        public Form1()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "XML Files|*.xml";
            UserControlScenario userControlScenario = new UserControlScenario("new 1");
            tabControl1.TabPages[0].Controls.Add(userControlScenario);
            nextNewTabNumber = 2;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            UserControlScenario userControlScenario = (UserControlScenario)tabControl1.SelectedTab.Controls["userControlScenario"];
            if (userControlScenario.Unnamed)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    String path = saveFileDialog1.FileName;
                    userControlScenario.saveScenarioAs(path);
                    userControlScenario.Changed = false;
                    userControlScenario.Unnamed = false;
                    tabControl1.SelectedTab.Text = userControlScenario.ShortName;
                }
            }
            else
            {
                userControlScenario.saveScenario();
                userControlScenario.Changed = false;
            }
        }

        private void buttonSaveAs_Click(object sender, EventArgs e)
        {
            UserControlScenario userControlScenario = (UserControlScenario)tabControl1.SelectedTab.Controls["userControlScenario"];
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String path = saveFileDialog1.FileName;
                userControlScenario.saveScenarioAs(path);
                userControlScenario.Changed = false;
                userControlScenario.Unnamed = false;
                tabControl1.SelectedTab.Text = path.Substring(path.LastIndexOf('\\') + 1);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*Boolean close = askAboutSaving();
            if (!close)
            {
                e.Cancel = true;
            }*/
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            TabPage newTab = new TabPage("new " + nextNewTabNumber);
            newTab.BackColor = Color.White;
            UserControlScenario userControlScenario = new UserControlScenario("new " + nextNewTabNumber);
            newTab.Controls.Add(userControlScenario);
            tabControl1.TabPages.Add(newTab);
            int last = tabControl1.TabPages.Count - 1;
            tabControl1.SelectTab(last);
            nextNewTabNumber++;
        }
      
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "XML Files|*.xml";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String path = openFileDialog1.FileName;
                TabPage newTab = new TabPage(path.Substring(path.LastIndexOf('\\')+1));
                newTab.BackColor = Color.White;
                UserControlScenario userControlScenario = new UserControlScenario();
                newTab.Controls.Add(userControlScenario);
                tabControl1.TabPages.Add(newTab);
                userControlScenario.loadScenario(path);
                int last = tabControl1.TabPages.Count - 1;
                tabControl1.SelectTab(last);
            }
        }

        private void buttonSaveAll_Click(object sender, EventArgs e)
        {
            foreach(TabPage tab in tabControl1.TabPages)
            {
                UserControlScenario userControlScenario = (UserControlScenario)tab.Controls["userControlScenario"];
                if (userControlScenario.Changed)
                {
                    if (userControlScenario.Unnamed)
                    {
                        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            String path = saveFileDialog1.FileName;
                            userControlScenario.saveScenarioAs(path);
                            userControlScenario.Changed = false;
                            userControlScenario.Unnamed = false;
                            tab.Text = userControlScenario.ShortName;
                        }
                    }
                    else
                    {
                        userControlScenario.saveScenario();
                        userControlScenario.Changed = false;
                    }
                }
            }
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            UserControlScenario userControlScenario = (UserControlScenario)tabControl1.SelectedTab.Controls["userControlScenario"];
            Boolean okToClose = userControlScenario.askAboutSaving(); //zapytanie użytkownika czy chce zapisać w przypadku gdy niezapisane
            if (okToClose)
            {
                //jeśli istnieje więcej niż jedna zakładka, przełącz się na inną
                if (tabControl1.TabPages.Count > 1)
                {
                    int index = tabControl1.SelectedIndex;
                    if (index > 0)
                    {
                        tabControl1.SelectTab(index - 1);
                    }
                    else
                    {
                        tabControl1.SelectTab(index + 1);
                    }
                    tabControl1.TabPages.RemoveAt(index);
                }
                //jeśli istnieje tylko jedna zakładka, utwórz nową
                else
                {
                    tabControl1.TabPages.RemoveAt(0);
                    TabPage newTab = new TabPage("new 1");
                    newTab.BackColor = Color.White;
                    userControlScenario = new UserControlScenario("new 1");
                    newTab.Controls.Add(userControlScenario);
                    tabControl1.TabPages.Add(newTab);
                    tabControl1.SelectTab(0);
                    nextNewTabNumber = 2;
                }
            }
        }
    }
}
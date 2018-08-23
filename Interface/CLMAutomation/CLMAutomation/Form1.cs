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
            userControlScenario.ScenarioChanged += new EventHandler(ScenarioChangedEventHandler);
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
                    tabControl1.SelectedTab.Text = userControlScenario.ShortName;
                }
            }
            else
            {
                userControlScenario.saveScenario();
                tabControl1.SelectedTab.Text = userControlScenario.ShortName;
            }
        }

        private void buttonSaveAs_Click(object sender, EventArgs e)
        {
            UserControlScenario userControlScenario = (UserControlScenario)tabControl1.SelectedTab.Controls["userControlScenario"];
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String path = saveFileDialog1.FileName;
                userControlScenario.saveScenarioAs(path);
                tabControl1.SelectedTab.Text = userControlScenario.ShortName;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (TabPage tab in tabControl1.TabPages)
            {
                UserControlScenario userControlScenario = (UserControlScenario)tab.Controls["userControlScenario"];
                Boolean okToClose = userControlScenario.askAboutSaving();
                if (okToClose)
                {
                    tabControl1.TabPages.Remove(tab);
                }
            }
            //jeśli zostały jakieś niezamknięte zakładki, przełącz się na pierwszą z lewej i nie zamykaj okna
            if (tabControl1.TabCount > 0)
            {
                e.Cancel = true;
                tabControl1.SelectTab(0);
            }
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            UserControlScenario userControlScenario = (UserControlScenario)tabControl1.SelectedTab.Controls["userControlScenario"];
            if (userControlScenario.isCorrect())
            {
                userControlScenario.run();
            }
            else
            {
                MessageBox.Show("The following scenario has missing data and cannot be run: " + userControlScenario.ShortName, "Error");
            }
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            TabPage newTab = new TabPage("new " + nextNewTabNumber);
            newTab.BackColor = Color.White;
            UserControlScenario userControlScenario = new UserControlScenario("new " + nextNewTabNumber);
            userControlScenario.ScenarioChanged += new EventHandler(ScenarioChangedEventHandler);
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
                userControlScenario.ScenarioChanged += new EventHandler(ScenarioChangedEventHandler);
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
                            tab.Text = userControlScenario.ShortName;
                        }
                    }
                    else
                    {
                        userControlScenario.saveScenario();
                        tab.Text = userControlScenario.ShortName;
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
                    userControlScenario.ScenarioChanged += new EventHandler(ScenarioChangedEventHandler);
                    newTab.Controls.Add(userControlScenario);
                    tabControl1.TabPages.Add(newTab);
                    tabControl1.SelectTab(0);
                    nextNewTabNumber = 2;
                }
            }
        }

        public void ScenarioChangedEventHandler(object sender, EventArgs e)
        {
            UserControlScenario userControlScenario = (UserControlScenario)tabControl1.SelectedTab.Controls["userControlScenario"];
            if (userControlScenario.Changed) {
                tabControl1.SelectedTab.Text = userControlScenario.ShortName + "*";
            }
        }

        private void buttonMoveLeft_Click(object sender, EventArgs e)
        {
            int index = tabControl1.SelectedIndex;
            if (index>0)
            {
                TabPage tab = tabControl1.SelectedTab;
                tabControl1.TabPages.Remove(tab);
                tabControl1.TabPages.Insert(index - 1, tab);
                tabControl1.SelectTab(tab);
            }
        }

        private void buttonMoveRight_Click(object sender, EventArgs e)
        {
            int index = tabControl1.SelectedIndex;
            if (index < (tabControl1.TabCount - 1))
            {
                TabPage tab = tabControl1.SelectedTab;
                tabControl1.TabPages.Remove(tab);
                tabControl1.TabPages.Insert(index + 1, tab);
                tabControl1.SelectTab(tab);
            }
        }

        private void buttonCloseAll_Click(object sender, EventArgs e)
        {
            foreach(TabPage tab in tabControl1.TabPages)
            {
                UserControlScenario userControlScenario = (UserControlScenario)tab.Controls["userControlScenario"];
                Boolean okToClose = userControlScenario.askAboutSaving();
                if(okToClose)
                {
                    tabControl1.TabPages.Remove(tab);
                }
            }
            //jeśli zostały jakieś niezamknięte zakładki, przełącz się na pierwszą z lewej
            if (tabControl1.TabCount>0)
            {
                tabControl1.SelectTab(0);
            }
            //jeśli nie, utwórz nową zakładkę
            else
            {
                TabPage newTab = new TabPage("new 1");
                newTab.BackColor = Color.White;
                UserControlScenario userControlScenario = new UserControlScenario("new 1");
                userControlScenario.ScenarioChanged += new EventHandler(ScenarioChangedEventHandler);
                newTab.Controls.Add(userControlScenario);
                tabControl1.TabPages.Add(newTab);
                tabControl1.SelectTab(0);
                nextNewTabNumber = 2;
            }
        }

        private void buttonRunAll_Click(object sender, EventArgs e)
        {
            String incorrectScenarios = "";
            foreach (TabPage tab in tabControl1.TabPages)
            {
                UserControlScenario userControlScenario = (UserControlScenario)tab.Controls["userControlScenario"];
                if (!userControlScenario.isCorrect())
                {
                    incorrectScenarios += userControlScenario.ShortName + "\n";
                }
            }
            if (incorrectScenarios != "")
            {
                MessageBox.Show("The following scenarios have missing data and cannot be run: \n" + incorrectScenarios, "Error");
            }
            else
            {
                foreach (TabPage tab in tabControl1.TabPages)
                {
                    UserControlScenario userControlScenario = (UserControlScenario)tab.Controls["userControlScenario"];
                    userControlScenario.run();
                }
            }
        }
    }
}
using System;
using StateEditor.Entity;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StateEditor.Manager;
using HOI4MI.Forms;
using System.Diagnostics;

namespace StateEditor.Forms
{
    public partial class MainForm : Form
    {
        private string basePath = @"A:\Files\Documents\Paradox Interactive\Hearts of Iron IV\mod\thirdreich";

        private ResultDialog resultDialog;
        private ResourceEditorForm resourceEditor;
        private StateSplitterForm stateSplitter;
        private StateEditorForm stateEditor;
        private ProvinceCreatorForm provinceCreator;

        private readonly LocalisationManager localeManager;
        private readonly ResourceManager resourceManager;

        public MainForm() {
            InitializeComponent();
            Province.SetBasePath(basePath);
            State.SetBasePath(basePath);
            Country.SetBasePath(basePath);
            localeManager = new LocalisationManager(basePath);
            resourceManager = new ResourceManager(basePath);
            resultDialog = new ResultDialog();

            Reload();
        }

        private void OpenForm(Form f) {
            mainPanel.Controls.Clear();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(f);
            mainPanel.Tag = f;
            f.BringToFront();
            f.Show();
        }

        private void Reload() {

            localeManager.ReloadLocalisation();
            Parser.SetLocalisationManager(localeManager);
            if (!Province.ReloadAll()) {
                ShowMessage($"Error loading provinces:\n{Province.Status}\n{Parser.Status}");
            }
            if (!State.ReloadAll()) {
                ShowMessage($"Error loading states:\n{State.Status}\n{Parser.Status}");
            }
            if (!Country.ReloadAll()) { 
                ShowMessage($"Error loading countries:\n{Parser.Status}");
            }
            resourceManager.ReloadResourceMap(true, false);


            stateSplitter = new StateSplitterForm(localeManager, resourceManager);
            resourceEditor = new ResourceEditorForm(localeManager, resourceManager);
            stateEditor = new StateEditorForm(localeManager, resourceManager);
            provinceCreator = new ProvinceCreatorForm();
            
        }

        private void writeButton_Click(object sender, EventArgs e) {

            State.Save();

            ShowMessage(State.Status);
        }

        private void ShowMessage(string s) {
            resultDialog.SetMessage(s);
            resultDialog.ShowDialog();
        }

        private void reloadButton_Click(object sender, EventArgs e) {
            mainPanel.Controls.Clear();
            Reload();
        }

        #region forms
        private void resourceEditorFormButton_Click(object sender, EventArgs e) {
            OpenForm(resourceEditor);
        }
        private void stateSplitterFormButton_Click(object sender, EventArgs e) {
            OpenForm(stateSplitter);
        }

        private void stateEditorFormButton_Click(object sender, EventArgs e) {
            OpenForm(stateEditor);
        }

        private void provinceCreatorFormButton_Click(object sender, EventArgs e) {
            OpenForm(provinceCreator);
        }
        #endregion
    }
}

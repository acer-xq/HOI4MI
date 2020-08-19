using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using StateEditor;
using StateEditor.Entity;
using StateEditor.Manager;

namespace HOI4MI.Forms {
    public partial class StateEditorForm : Form {

        private readonly LocalisationManager localeManager;
        private readonly ResourceManager resourceManager;

        public StateEditorForm(LocalisationManager lm, ResourceManager rm) {
            InitializeComponent();

            localeManager = lm;
            resourceManager = rm;

            SetDataSources();
        }

        private void Reload() {
            localeManager.ReloadLocalisation();
            Parser.SetLocalisationManager(localeManager);
            Province.ReloadAll();
            State.ReloadAll();
            Country.ReloadAll();
            resourceManager.ReloadResourceMap(true, false);
        }

        private void SetDataSources() {
            countryList.DataSource = Country.Countries;
        }

        private void countryList_SelectedIndexChanged(object sender, EventArgs e) {
            Country c = (Country)countryList.SelectedItem;
            testBox.Text = c.ToStringVerbose();
        }
    }
}

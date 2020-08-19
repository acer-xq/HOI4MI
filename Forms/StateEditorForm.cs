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
using StateEditor.Util;

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
            for (int i = 0; i < State.Count; i += 100) {
                selectList.Items.Add(i);
            }
            stateCategoryInput.DataSource = Enum.GetValues(typeof(StateCategory));
            stateOwnerInput.DataSource = Country.Countries;
            stateCoreInput.DataSource = Country.Countries;
        }

        private void countryList_SelectedIndexChanged(object sender, EventArgs e) {
            int startId = (int)selectList.SelectedItem;
            stateList.DataSource = State.Find(s => s.id >= startId && s.id < startId+100);
        }

        private void stateList_SelectedIndexChanged(object sender, EventArgs e) {
            State currentState = (State)stateList.SelectedItem;
            testBox.Text = ((State)stateList.SelectedItem).ToStringVerbose();

            stateNameInput.Text = $"{currentState.LocalisedName}";

            stateManpowerInput.Value = currentState.Manpower;

            stateCategoryInput.SelectedItem = currentState.Category;

            stateOilInput.Value = (decimal)currentState.Resources.Oil;
            stateRubberInput.Value = (decimal)currentState.Resources.Rubber;
            stateSteelInput.Value = (decimal)currentState.Resources.Steel;
            stateTungstenInput.Value = (decimal)currentState.Resources.Tungsten;
            stateAluminiumInput.Value = (decimal)currentState.Resources.Aluminium;
            stateChromiumInput.Value = (decimal)currentState.Resources.Chromium;

            stateOwnerInput.SelectedItem = Country.Get(currentState.Owner);

            stateCoreInput.SelectedItems.Clear();
            foreach (string s in currentState.Cores) {
                Country c = Country.Get(s);
                stateCoreInput.SelectedItems.Add(c);
            }

            stateInfrastructureInput.Value = currentState.Infrastructure;
            stateCivFactoriesInput.Value = currentState.CivillianFactories;
            stateMilFactoriesInput.Value = currentState.MilitaryFactories;
            stateDockyardsInput.Value = currentState.Dockyards;
            stateRefineriesInput.Value = currentState.Refineries;
            stateSilosInput.Value = currentState.Silos;
            stateReactorsInput.Value = currentState.Reactors;
            stateAirbaseInput.Value = currentState.Airbases;
            stateRadarInput.Value = currentState.Radar;
            stateRocketsInput.Value = currentState.Rockets;
            stateAntiairInput.Value = currentState.Antiair;
        }
    }
}

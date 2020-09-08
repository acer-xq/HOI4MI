using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using HOI4MI;
using HOI4MI.Entity;
using HOI4MI.Manager;
using HOI4MI.Util;

namespace HOI4MI.Forms {
    public partial class StateEditorForm : Form {

        private readonly ResourceManager resourceManager;

        private State currentState;
        private Province currentProvince;

        public StateEditorForm(ResourceManager rm) {
            InitializeComponent();

            resourceManager = rm;

            SetDataSources();
            SetImages();
        }

        private void Reload() {
            Localisation.Reload();
            Province.ReloadAll();
            State.ReloadAll();
            Country.ReloadAll();
            resourceManager.ReloadResourceMap(true, false);
        }

        private void SetImages() {
            oilImage.BackgroundImage = Properties.Resources.oil;
            rubberImage.BackgroundImage = Properties.Resources.rubber;
            steelImage.BackgroundImage = Properties.Resources.steel;
            aluminiumImage.BackgroundImage = Properties.Resources.aluminium;
            tungstenImage.BackgroundImage = Properties.Resources.tungsten;
            chromiumImage.BackgroundImage = Properties.Resources.chromium;

            infrastructureImage.BackgroundImage = Properties.Resources.infrastructure;
            civillianImage.BackgroundImage = Properties.Resources.civillian;
            militaryImage.BackgroundImage = Properties.Resources.military;
            dockyardImage.BackgroundImage = Properties.Resources.dockyard;
            refineryImage.BackgroundImage = Properties.Resources.refinery;
            silosImage.BackgroundImage = Properties.Resources.silo;
            airbaseImage.BackgroundImage = Properties.Resources.airbase;
            antiairImage.BackgroundImage = Properties.Resources.antiair;
            reactorImage.BackgroundImage = Properties.Resources.reactor;
            radarImage.BackgroundImage = Properties.Resources.radar;
            rocketImage.BackgroundImage = Properties.Resources.rocket;

            vpImage.BackgroundImage = Properties.Resources.vp;
            fortImage.BackgroundImage = Properties.Resources.fort;
            coastalFortImage.BackgroundImage = Properties.Resources.coastalfort;
            navalBaseImage.BackgroundImage = Properties.Resources.navalbase;
        }

        private void SetDataSources() {
            selectList.Items.Clear();
            for (int i = 0; i < State.Count; i += 100) {
                selectList.Items.Add(i);
            }
            stateCategoryInput.DataSource = Enum.GetValues(typeof(StateCategory));
            stateOwnerInput.DataSource = Country.Countries;
            stateCoreInput.DataSource = Country.Countries;
            stateImpassableInput.DataSource = Utils.BoolValues();
        }

        private void selectList_SelectedIndexChanged(object sender, EventArgs e) {
            int startId = (int)selectList.SelectedItem;
            stateList.DataSource = State.Find(s => s.id >= startId && s.id < startId+100);
        }

        private void stateList_SelectedIndexChanged(object sender, EventArgs e) {
            currentState = (State)stateList.SelectedItem;
            testBox.Text = ((State)stateList.SelectedItem).ToStringVerbose();

            stateNameInput.Text = $"{currentState.LocalisedName}";
            stateManpowerInput.Value = currentState.Manpower;
            stateCategoryInput.SelectedItem = currentState.Category;
            stateImpassableInput.SelectedItem = currentState.Impassable;
            stateOwnerInput.SelectedItem = Country.Get(currentState.Owner);
            stateCoreInput.SelectedItems.Clear();
            foreach (string s in currentState.Cores) {
                Country c = Country.Get(s);
                stateCoreInput.SelectedItems.Add(c);
            }

            stateOilInput.Value = (decimal)currentState.Resources.Oil;
            stateRubberInput.Value = (decimal)currentState.Resources.Rubber;
            stateSteelInput.Value = (decimal)currentState.Resources.Steel;
            stateTungstenInput.Value = (decimal)currentState.Resources.Tungsten;
            stateAluminiumInput.Value = (decimal)currentState.Resources.Aluminium;
            stateChromiumInput.Value = (decimal)currentState.Resources.Chromium;

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

            provinceList.Items.Clear();
            foreach (Province p in currentState.Provinces) {
                provinceList.Items.Add(p);
            }
            provinceList.SelectedIndex = 0;
        }

        private void provinceList_SelectedIndexChanged(object sender, EventArgs e) {
            currentProvince = (Province)provinceList.SelectedItem;

            provinceNameInput.Text = currentProvince.HasVictoryPoints() ? $"{currentProvince.Name}" : "N/A";
            victoryPointsInput.Value = currentProvince.VictoryPoints;
            fortInput.Value = currentProvince.LandForts;
            coastalFortInput.Value = currentProvince.CoastalForts;
            navalBaseInput.Value = currentProvince.NavalBase;
        }

        private void stateSaveButton_Click(object sender, EventArgs e) {
            //old state
            currentState.LocalisedName = stateNameInput.Text;
            currentState.Manpower = (int)stateManpowerInput.Value;
            currentState.Category = (StateCategory)stateCategoryInput.SelectedItem;
            currentState.Impassable = (bool)stateImpassableInput.SelectedItem;
            currentState.Owner = stateOwnerInput.SelectedItem.ToString();
            foreach (object o in stateCoreInput.SelectedItems) {
                currentState.Cores.Add(o.ToString());
            }

            currentState.Resources.Oil = (double)stateOilInput.Value;
            currentState.Resources.Rubber = (double)stateRubberInput.Value;
            currentState.Resources.Steel = (double)stateSteelInput.Value;
            currentState.Resources.Tungsten = (double)stateTungstenInput.Value;
            currentState.Resources.Aluminium = (double)stateAluminiumInput.Value;
            currentState.Resources.Chromium = (double)stateChromiumInput.Value;

            currentState.Infrastructure = (int)stateInfrastructureInput.Value;
            currentState.CivillianFactories = (int)stateCivFactoriesInput.Value;
            currentState.MilitaryFactories = (int)stateMilFactoriesInput.Value;
            currentState.Dockyards = (int)stateDockyardsInput.Value;
            currentState.Refineries = (int)stateRefineriesInput.Value;
            currentState.Silos = (int)stateSilosInput.Value;
            currentState.Reactors = (int)stateReactorsInput.Value;
            currentState.Airbases = (int)stateAirbaseInput.Value;
            currentState.Radar = (int)stateRadarInput.Value;
            currentState.Rockets = (int)stateRocketsInput.Value;
            currentState.Antiair = (int)stateAntiairInput.Value;

            if (provinceNameInput.Text != "N/A") currentProvince.Name = provinceNameInput.Text;
            currentProvince.VictoryPoints = (int)victoryPointsInput.Value;
            currentProvince.LandForts = (int)fortInput.Value;
            currentProvince.CoastalForts = (int)coastalFortInput.Value;
            currentProvince.NavalBase = (int)navalBaseInput.Value;
        }

        private void resetButton_Click(object sender, EventArgs e) {
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

        private void StateEditorForm_Load(object sender, EventArgs e) {

        }

        private void testBox_TextChanged(object sender, EventArgs e) {

        }


    }
}

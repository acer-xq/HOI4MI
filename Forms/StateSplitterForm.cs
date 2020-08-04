using StateEditor.Entity;
using StateEditor.Manager;
using StateEditor.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StateEditor.Forms {
    public partial class StateSplitterForm : FormDark.FormDark {

        public string baseDirectory = @"A:\Files\Documents\Paradox Interactive\Hearts of Iron IV\mod\thirdreich";
        private readonly LocalisationManager localeManager;
        private readonly CountryManager countryManager;
        private readonly ResourceManager resourceManager;

        public StateSplitterForm() {
            InitializeComponent();

            localeManager = new LocalisationManager(baseDirectory);
            countryManager = new CountryManager(baseDirectory, localeManager);
            resourceManager = new ResourceManager(baseDirectory, countryManager);

            Reload();
        }

        private void Reload() {
            localeManager.ReloadLocalisation();
            Parser.SetLocalisationManager(localeManager);
            Province.ReloadAll();
            State.ReloadAll();
            countryManager.ReloadCountries();
            resourceManager.ReloadResourceMap(true, false);
            SetDataSources();
        }

        private void SetDataSources() {
            stateList.DataSource = State.States;
            oldStateCategoryInput.DataSource = Enum.GetValues(typeof(StateCategory));
            newStateCategoryInput.DataSource = Enum.GetValues(typeof(StateCategory));
            oldStateOwnerInput.DataSource = countryManager.Countries;
            newStateOwnerInput.DataSource = countryManager.Countries;
            oldStateCoreInput.DataSource = countryManager.Countries;
            newStateCoreInput.DataSource = countryManager.Countries;
        }

        private void debugButton_Click(object sender, EventArgs e) {
            
        }

        private void stateList_SelectedIndexChanged(object sender, EventArgs e) {
            
            //populate province list
            provinceSelectList.Items.Clear();
            State currentState = (State)stateList.SelectedItem;
            foreach (Province p in currentState.Provinces) {
                provinceSelectList.Items.Add(p);
            }

            validLabel.Text = $"Current Valid: {currentState.IsValid()}";

            newStateNameInput.Text = $"STATE {State.Count+1}";

            oldStateManpowerInput.Maximum = currentState.Manpower;
            newStateManpowerInput.Maximum = currentState.Manpower;
            oldStateManpowerInput.Value = currentState.Manpower;

            oldStateCategoryInput.SelectedItem = currentState.Category;
            newStateCategoryInput.SelectedItem = currentState.Category;

            oldStateOilInput.Value = (decimal)currentState.Resources.Oil;
            oldStateRubberInput.Value = (decimal)currentState.Resources.Rubber;
            oldStateSteelInput.Value = (decimal)currentState.Resources.Steel;
            oldStateTungstenInput.Value = (decimal)currentState.Resources.Tungsten;
            oldStateAluminiumInput.Value = (decimal)currentState.Resources.Aluminium;
            oldStateChromiumInput.Value = (decimal)currentState.Resources.Chromium;

            oldStateOwnerInput.SelectedItem = countryManager.GetCountry(currentState.Owner);
            newStateOwnerInput.SelectedItem = countryManager.GetCountry(currentState.Owner);

            oldStateCoreInput.SelectedItems.Clear();
            foreach (string s in currentState.Cores) {
                Country c = countryManager.GetCountry(s);
                oldStateCoreInput.SelectedItems.Add(c);
            }

            oldStateInfrastructureInput.Value = currentState.Infrastructure;
            oldStateCivFactoriesInput.Value = currentState.CivillianFactories;
            oldStateMilFactoriesInput.Value = currentState.MilitaryFactories;
            oldStateDockyardsInput.Value = currentState.Dockyards;
            oldStateRefineriesInput.Value = currentState.Refineries;
            oldStateSilosInput.Value = currentState.Silos;
            oldStateReactorsInput.Value = currentState.Reactors;
            oldStateAirbaseInput.Value = currentState.Airbases;
            oldStateRadarInput.Value = currentState.Radar;
            oldStateRocketsInput.Value = currentState.Rockets;
            oldStateAntiairInput.Value = currentState.Antiair;

        }
    }
}

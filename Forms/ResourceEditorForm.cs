using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using StateEditor.Manager;
using StateEditor.Entity;
using StateEditor.Util;
using System.Collections;
using System.Reflection;

namespace StateEditor
{
    public partial class ResourceEditorForm : Form
    {
        private readonly LocalisationManager localeManager;
        private readonly ResourceManager resourceManager;

        public ResourceEditorForm(LocalisationManager lm, ResourceManager rm) {
            InitializeComponent();

            localeManager = lm;
            resourceManager = rm;

            stateList.DataSource = State.States;
            DisplayResources();
        }

        private void Reload() { 
            localeManager.ReloadLocalisation();
            Parser.SetLocalisationManager(localeManager);
            Province.ReloadAll();
            State.ReloadAll();
            Country.ReloadAll();
            resourceManager.ReloadResourceMap(true, false);

            
        }

        private void MainForm_Load(object sender, EventArgs e) {
        }

        private void debugButton_Click(object sender, EventArgs e) {
           
        }

        private void stateList_SelectedIndexChanged(object sender, EventArgs e) {
            State selected = (State)stateList.SelectedItem;
            stateListTextBox.Text = selected.Resources.ToString();
        }

        private void excavationSelect_ValueChanged(object sender, EventArgs e) {
            //resourceManager.ReloadResourceMap(stateManager, true, Convert.ToDouble(excavationSelect.Value), true);
            //DisplayResources();
        }

        private void DisplayResources() { 
            Dictionary<Country, ResourceSet> resMap = resourceManager.GetResourceMap();

            resourceList.Columns.Add("Country", "Country");
            resourceList.Columns.GetLastColumn(DataGridViewElementStates.None, DataGridViewElementStates.None).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            foreach (string s in ResourceSet.ResourceStrings) {
                resourceList.Columns.Add(s, s);
            }

            DataGridViewRow row;
            foreach (var x in resMap) {
                row = new DataGridViewRow();
                row.CreateCells(resourceList);
                row.Tag = x.Key;
                row.Cells[0].Tag = x.Key;
                row.Cells[0].Value = x.Key.tag;
                for (int i = 0; i < 6; i++) {
                    row.Cells[i + 1].Tag = x.Value[i];
                    row.Cells[i + 1].Value = Math.Round(x.Value[i]);
                }
                resourceList.Rows.Add(row);
            }
        }

        private void resourceList_SelectionChanged(object sender, EventArgs e) {
            //stored by country, with a list of the columns selected for that country
            //e.g. "FRA", { -1, 0, 2 }
            //FRA has cells 0 1 and 3 selected from its row
            //column 0 is the country name column, so -1 in the list does not correspond to any resource
            Dictionary<string, List<int>> selected = new Dictionary<string, List<int>>();

            foreach (DataGridViewCell c in resourceList.SelectedCells) {
                int column = c.OwningColumn.Index;
                string tag = c.OwningRow.Tag.ToString();
                if (selected.ContainsKey(tag))
                    selected[tag].Add(column-1);
                else
                    selected.Add(tag, new List<int> { column-1 });
            }

            Country selectedCountry = (Country)resourceList.CurrentCell.OwningRow.Tag;
            countryInfoTextBox.Text = selectedCountry.ToStringVerbose();

            //get all states which match both the owner and resource from any of the selected cells

            List<State> result = State.Find(state => {
                if (!selected.ContainsKey(state.Owner)) {
                    return false;
                }
                else {
                    List<int> res = selected[state.Owner];
                    foreach (int i in res) {
                        if (i < 0) continue; //ignore -1
                        if (state.Resources[i] > 0) return true; //state has a resource we care about
                    }
                    return false;
                }
            });
            stateList.DataSource = result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using StateEditor.Entity;
using StateEditor.Util;

namespace HOI4MI.Forms {
    public partial class ProvinceCreatorForm : Form {
        public ProvinceCreatorForm() {
            InitializeComponent();

            SetDataSources();
            Reload();
        }

        private void SetDataSources() {
            provTypeInput.DataSource = Enum.GetValues(typeof(ProvinceType));
            terrainInput.DataSource = Enum.GetValues(typeof(Terrain));
            continentInput.DataSource = Enum.GetValues(typeof(Continent));
            coastalInput.DataSource = new bool[] { true, false };
            stateInput.DataSource = State.States;
        }

        private void Reload() {
            redInput.Value = 0;
            greenInput.Value = 0;
            blueInput.Value = 0;

            provTypeInput.SelectedIndex = 0;
            terrainInput.SelectedIndex = 0;
            continentInput.SelectedIndex = 0;
            coastalInput.SelectedIndex = 0;
            stateInput.SelectedIndex = 0;

            provinceIdLabel.Text = Province.Provinces.Count.ToString();

        }

        private void writeButton_Click(object sender, EventArgs e) {
            int id = Province.Provinces.Count;
            int[] colour = { (int)redInput.Value, (int)greenInput.Value, (int)blueInput.Value };
            if (!Province.Create(id, colour)) return;
            Province p = Province.Get(id);
            p.Type = (ProvinceType)provTypeInput.SelectedItem;
            p.Terrain = (Terrain)terrainInput.SelectedItem;
            p.Continent = (Continent)continentInput.SelectedItem;
            p.Coastal = (bool)coastalInput.SelectedItem;
            State s = (State)stateInput.SelectedItem;
            s.Provinces.Add(p);
            Province.Save();

            Reload();
        }
    }
}

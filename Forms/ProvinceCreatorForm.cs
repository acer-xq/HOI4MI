using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using HOI4MI.Entity;
using HOI4MI.Util;

namespace HOI4MI.Forms {
    public partial class ProvinceCreatorForm : Form {

        List<string> regionFiles;

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

            regionFiles = Directory.GetFiles(@"A:\Files\Documents\Paradox Interactive\Hearts of Iron IV\mod\thirdreich\map\strategicregions").ToList();
            regionInput.DataSource = Enumerable.Range(1, regionFiles.Count).ToList();
        }

        private void Reload() {
            Reset();

            provTypeInput.SelectedIndex = 0;
            terrainInput.SelectedIndex = 0;
            continentInput.SelectedIndex = 0;
            coastalInput.SelectedIndex = 0;
            stateInput.SelectedIndex = 0;

        }

        private void Reset() {
            int[] newColour = null;
            while (!Province.IsColourUnique(newColour)) {
                newColour = Utils.RandomColour();
            }
            redInput.Value = newColour[0];
            greenInput.Value = newColour[1];
            blueInput.Value = newColour[2];

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

            string regionFile = regionFiles.Find(x => x.Split(@"\").Last().StartsWith($"{regionInput.SelectedItem}-"));

            string[] regionFileContents = File.ReadAllLines(regionFile);
            regionFileContents[4] += $" {id}";
            File.WriteAllLines(regionFile, regionFileContents);

            statusLabel.Text = $"Province {id} successfully written";

            Reset();
        }

        private void copyIdButton_Click(object sender, EventArgs e) {
            Clipboard.SetData(DataFormats.Text, provinceIdLabel.Text);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using HOI4MI.Entity;
using HOI4MI.Manager;

namespace HOI4MI.Forms {
    public partial class DebugForm : Form {
        public DebugForm() {
            InitializeComponent();

            Reload();    
        }

        public void Reload() {
            stateList.DataSource = State.States;
            modifiedStateList.DataSource = State.Find(s => s.Modified);
            provinceList.DataSource = Province.Provinces;
            modifiedProvinceList.DataSource = Province.Provinces.FindAll(p => p.Modified);
            localeList.DataSource = Localisation.Locale.OrderBy(x => x.Key).ToList();
            modifiedLocaleList.DataSource = Localisation.Locale.Where(x => x.Value.Modified).ToList();
        }

        private void stateList_SelectedIndexChanged(object sender, EventArgs e) {
            stateInfoBox.Text = ((State)stateList.SelectedItem).ToStringVerbose();
        }

        private void modifiedStateList_SelectedIndexChanged(object sender, EventArgs e) {
            stateInfoBox.Text = ((State)modifiedStateList.SelectedItem).ToStringVerbose();

        }

        private void provinceList_SelectedIndexChanged(object sender, EventArgs e) {
            provinceInfoBox.Text = ((Province)provinceList.SelectedItem).ToStringVerbose();

        }

        private void modifiedProvinceList_SelectedIndexChanged(object sender, EventArgs e) {
            provinceInfoBox.Text = ((Province)modifiedProvinceList.SelectedItem).ToStringVerbose();

        }

        private void localeList_SelectedIndexChanged(object sender, EventArgs e) {
            KeyValuePair<string, LocaleItem> k = (KeyValuePair<string, LocaleItem>)localeList.SelectedItem;
            localeInfoList.Text = $"{k.Key}\n{k.Value.Source}\n{k.Value.Content}";
        }

        private void modifiedLocaleList_SelectedIndexChanged(object sender, EventArgs e) {
            KeyValuePair<string, LocaleItem> k = (KeyValuePair<string, LocaleItem>)modifiedLocaleList.SelectedItem;
            localeInfoList.Text = $"{k.Key}\n{k.Value.Source}\n{k.Value.Content}";
        }

        private void reloadButton_Click(object sender, EventArgs e) {
            Reload();
        }
    }
}

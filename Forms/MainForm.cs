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

namespace StateEditor.Forms
{
    public partial class MainForm : Form
    {
        private string basePath = @"A:\Files\Documents\Paradox Interactive\Hearts of Iron IV\mod\thirdreich";

        public MainForm() {
            InitializeComponent();
            Province.SetBasePath(basePath);
            State.SetBasePath(basePath);
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

        private void resourceEditorFormButton_Click(object sender, EventArgs e) {
            ResourceEditorForm f = new ResourceEditorForm();
            OpenForm(f);
        }

        private void stateSplitterFormButton_Click(object sender, EventArgs e) {
            StateSplitterForm f = new StateSplitterForm();
            OpenForm(f);
        }
    }
}

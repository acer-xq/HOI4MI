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
    public partial class MainForm : FormDark.FormDark
    {
        private string basePath = @"A:\Files\Documents\Paradox Interactive\Hearts of Iron IV\mod\thirdreich";

        public MainForm() {
            InitializeComponent();
            Province.SetBasePath(basePath);
            State.SetBasePath(basePath);
        }

        private void resourceEditorFormButton_Click(object sender, EventArgs e) {
            ResourceEditorForm f = new ResourceEditorForm();
            f.Show();
        }

        private void stateSplitterFormButton_Click(object sender, EventArgs e) {
            StateSplitterForm f = new StateSplitterForm();
            f.Show();
        }
    }
}

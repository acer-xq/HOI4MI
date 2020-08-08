using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HOI4MI.Forms {
    public partial class ResultDialog : Form {
        public ResultDialog() {
            InitializeComponent();
        }

        public void SetMessage(string msg) { 
            resultLabel.Text = msg;
        }

        private void okButton_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}

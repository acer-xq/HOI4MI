using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using StateEditor.Manager;

namespace HOI4MI.Forms {
    public partial class StateEditorForm : Form {

        private readonly LocalisationManager localeManager;
        private readonly CountryManager countryManager;
        private readonly ResourceManager resourceManager;

        public StateEditorForm(LocalisationManager lm, CountryManager cm, ResourceManager rm) {
            InitializeComponent();

            localeManager = lm;
            countryManager = cm;
            resourceManager = rm;
        }
    }
}

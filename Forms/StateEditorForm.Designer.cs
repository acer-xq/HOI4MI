namespace HOI4MI.Forms {
    partial class StateEditorForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.selectList = new System.Windows.Forms.ListBox();
            this.testBox = new System.Windows.Forms.RichTextBox();
            this.stateList = new System.Windows.Forms.ListBox();
            this.sideBar = new System.Windows.Forms.Panel();
            this.divider1 = new System.Windows.Forms.Panel();
            this.stateManpowerInput = new System.Windows.Forms.NumericUpDown();
            this.stateOilInput = new System.Windows.Forms.NumericUpDown();
            this.stateRubberInput = new System.Windows.Forms.NumericUpDown();
            this.stateSteelInput = new System.Windows.Forms.NumericUpDown();
            this.stateTungstenInput = new System.Windows.Forms.NumericUpDown();
            this.stateAluminiumInput = new System.Windows.Forms.NumericUpDown();
            this.stateChromiumInput = new System.Windows.Forms.NumericUpDown();
            this.stateOwnerInput = new System.Windows.Forms.ComboBox();
            this.stateInfrastructureInput = new System.Windows.Forms.NumericUpDown();
            this.stateCivFactoriesInput = new System.Windows.Forms.NumericUpDown();
            this.stateMilFactoriesInput = new System.Windows.Forms.NumericUpDown();
            this.stateDockyardsInput = new System.Windows.Forms.NumericUpDown();
            this.stateSilosInput = new System.Windows.Forms.NumericUpDown();
            this.stateRefineriesInput = new System.Windows.Forms.NumericUpDown();
            this.stateReactorsInput = new System.Windows.Forms.NumericUpDown();
            this.stateAirbaseInput = new System.Windows.Forms.NumericUpDown();
            this.stateRadarInput = new System.Windows.Forms.NumericUpDown();
            this.stateRocketsInput = new System.Windows.Forms.NumericUpDown();
            this.stateCoreInput = new System.Windows.Forms.ListBox();
            this.stateAntiairInput = new System.Windows.Forms.NumericUpDown();
            this.stateCategoryInput = new System.Windows.Forms.ComboBox();
            this.stateNameInput = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.sideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stateManpowerInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateOilInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateRubberInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateSteelInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateTungstenInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateAluminiumInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateChromiumInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateInfrastructureInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateCivFactoriesInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateMilFactoriesInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateDockyardsInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateSilosInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateRefineriesInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateReactorsInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateAirbaseInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateRadarInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateRocketsInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateAntiairInput)).BeginInit();
            this.SuspendLayout();
            // 
            // selectList
            // 
            this.selectList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.selectList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.selectList.Dock = System.Windows.Forms.DockStyle.Top;
            this.selectList.ForeColor = System.Drawing.Color.White;
            this.selectList.FormattingEnabled = true;
            this.selectList.IntegralHeight = false;
            this.selectList.ItemHeight = 17;
            this.selectList.Location = new System.Drawing.Point(0, 0);
            this.selectList.Name = "selectList";
            this.selectList.Size = new System.Drawing.Size(214, 199);
            this.selectList.TabIndex = 5;
            this.selectList.SelectedIndexChanged += new System.EventHandler(this.countryList_SelectedIndexChanged);
            // 
            // testBox
            // 
            this.testBox.Location = new System.Drawing.Point(793, 171);
            this.testBox.Name = "testBox";
            this.testBox.Size = new System.Drawing.Size(265, 244);
            this.testBox.TabIndex = 6;
            this.testBox.Text = "";
            // 
            // stateList
            // 
            this.stateList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.stateList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stateList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stateList.ForeColor = System.Drawing.Color.White;
            this.stateList.FormattingEnabled = true;
            this.stateList.IntegralHeight = false;
            this.stateList.ItemHeight = 17;
            this.stateList.Location = new System.Drawing.Point(0, 209);
            this.stateList.Name = "stateList";
            this.stateList.Size = new System.Drawing.Size(214, 438);
            this.stateList.TabIndex = 5;
            this.stateList.SelectedIndexChanged += new System.EventHandler(this.stateList_SelectedIndexChanged);
            // 
            // sideBar
            // 
            this.sideBar.Controls.Add(this.stateList);
            this.sideBar.Controls.Add(this.divider1);
            this.sideBar.Controls.Add(this.selectList);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(214, 647);
            this.sideBar.TabIndex = 7;
            // 
            // divider1
            // 
            this.divider1.Dock = System.Windows.Forms.DockStyle.Top;
            this.divider1.Location = new System.Drawing.Point(0, 199);
            this.divider1.Name = "divider1";
            this.divider1.Size = new System.Drawing.Size(214, 10);
            this.divider1.TabIndex = 8;
            // 
            // stateManpowerInput
            // 
            this.stateManpowerInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.stateManpowerInput.ForeColor = System.Drawing.Color.White;
            this.stateManpowerInput.Location = new System.Drawing.Point(353, 172);
            this.stateManpowerInput.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.stateManpowerInput.Name = "stateManpowerInput";
            this.stateManpowerInput.Size = new System.Drawing.Size(120, 22);
            this.stateManpowerInput.TabIndex = 9;
            this.stateManpowerInput.ThousandsSeparator = true;
            // 
            // stateOilInput
            // 
            this.stateOilInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.stateOilInput.ForeColor = System.Drawing.Color.White;
            this.stateOilInput.Location = new System.Drawing.Point(509, 172);
            this.stateOilInput.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.stateOilInput.Name = "stateOilInput";
            this.stateOilInput.Size = new System.Drawing.Size(54, 22);
            this.stateOilInput.TabIndex = 13;
            this.stateOilInput.ThousandsSeparator = true;
            // 
            // stateRubberInput
            // 
            this.stateRubberInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.stateRubberInput.ForeColor = System.Drawing.Color.White;
            this.stateRubberInput.Location = new System.Drawing.Point(594, 172);
            this.stateRubberInput.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.stateRubberInput.Name = "stateRubberInput";
            this.stateRubberInput.Size = new System.Drawing.Size(54, 22);
            this.stateRubberInput.TabIndex = 14;
            this.stateRubberInput.ThousandsSeparator = true;
            // 
            // stateSteelInput
            // 
            this.stateSteelInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.stateSteelInput.ForeColor = System.Drawing.Color.White;
            this.stateSteelInput.Location = new System.Drawing.Point(509, 200);
            this.stateSteelInput.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.stateSteelInput.Name = "stateSteelInput";
            this.stateSteelInput.Size = new System.Drawing.Size(54, 22);
            this.stateSteelInput.TabIndex = 15;
            this.stateSteelInput.ThousandsSeparator = true;
            // 
            // stateTungstenInput
            // 
            this.stateTungstenInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.stateTungstenInput.ForeColor = System.Drawing.Color.White;
            this.stateTungstenInput.Location = new System.Drawing.Point(594, 200);
            this.stateTungstenInput.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.stateTungstenInput.Name = "stateTungstenInput";
            this.stateTungstenInput.Size = new System.Drawing.Size(54, 22);
            this.stateTungstenInput.TabIndex = 16;
            this.stateTungstenInput.ThousandsSeparator = true;
            // 
            // stateAluminiumInput
            // 
            this.stateAluminiumInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.stateAluminiumInput.ForeColor = System.Drawing.Color.White;
            this.stateAluminiumInput.Location = new System.Drawing.Point(509, 228);
            this.stateAluminiumInput.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.stateAluminiumInput.Name = "stateAluminiumInput";
            this.stateAluminiumInput.Size = new System.Drawing.Size(54, 22);
            this.stateAluminiumInput.TabIndex = 17;
            this.stateAluminiumInput.ThousandsSeparator = true;
            // 
            // stateChromiumInput
            // 
            this.stateChromiumInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.stateChromiumInput.ForeColor = System.Drawing.Color.White;
            this.stateChromiumInput.Location = new System.Drawing.Point(594, 228);
            this.stateChromiumInput.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.stateChromiumInput.Name = "stateChromiumInput";
            this.stateChromiumInput.Size = new System.Drawing.Size(54, 22);
            this.stateChromiumInput.TabIndex = 18;
            this.stateChromiumInput.ThousandsSeparator = true;
            // 
            // stateOwnerInput
            // 
            this.stateOwnerInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.stateOwnerInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateOwnerInput.ForeColor = System.Drawing.Color.White;
            this.stateOwnerInput.FormattingEnabled = true;
            this.stateOwnerInput.Location = new System.Drawing.Point(353, 200);
            this.stateOwnerInput.MaxDropDownItems = 31;
            this.stateOwnerInput.Name = "stateOwnerInput";
            this.stateOwnerInput.Size = new System.Drawing.Size(121, 25);
            this.stateOwnerInput.TabIndex = 25;
            // 
            // stateInfrastructureInput
            // 
            this.stateInfrastructureInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.stateInfrastructureInput.ForeColor = System.Drawing.Color.White;
            this.stateInfrastructureInput.Location = new System.Drawing.Point(509, 283);
            this.stateInfrastructureInput.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.stateInfrastructureInput.Name = "stateInfrastructureInput";
            this.stateInfrastructureInput.Size = new System.Drawing.Size(54, 22);
            this.stateInfrastructureInput.TabIndex = 27;
            this.stateInfrastructureInput.ThousandsSeparator = true;
            // 
            // stateCivFactoriesInput
            // 
            this.stateCivFactoriesInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.stateCivFactoriesInput.ForeColor = System.Drawing.Color.White;
            this.stateCivFactoriesInput.Location = new System.Drawing.Point(594, 283);
            this.stateCivFactoriesInput.Name = "stateCivFactoriesInput";
            this.stateCivFactoriesInput.Size = new System.Drawing.Size(54, 22);
            this.stateCivFactoriesInput.TabIndex = 28;
            this.stateCivFactoriesInput.ThousandsSeparator = true;
            // 
            // stateMilFactoriesInput
            // 
            this.stateMilFactoriesInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.stateMilFactoriesInput.ForeColor = System.Drawing.Color.White;
            this.stateMilFactoriesInput.Location = new System.Drawing.Point(509, 311);
            this.stateMilFactoriesInput.Name = "stateMilFactoriesInput";
            this.stateMilFactoriesInput.Size = new System.Drawing.Size(54, 22);
            this.stateMilFactoriesInput.TabIndex = 29;
            this.stateMilFactoriesInput.ThousandsSeparator = true;
            // 
            // stateDockyardsInput
            // 
            this.stateDockyardsInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.stateDockyardsInput.ForeColor = System.Drawing.Color.White;
            this.stateDockyardsInput.Location = new System.Drawing.Point(594, 311);
            this.stateDockyardsInput.Name = "stateDockyardsInput";
            this.stateDockyardsInput.Size = new System.Drawing.Size(54, 22);
            this.stateDockyardsInput.TabIndex = 30;
            this.stateDockyardsInput.ThousandsSeparator = true;
            // 
            // stateSilosInput
            // 
            this.stateSilosInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.stateSilosInput.ForeColor = System.Drawing.Color.White;
            this.stateSilosInput.Location = new System.Drawing.Point(594, 339);
            this.stateSilosInput.Name = "stateSilosInput";
            this.stateSilosInput.Size = new System.Drawing.Size(54, 22);
            this.stateSilosInput.TabIndex = 35;
            this.stateSilosInput.ThousandsSeparator = true;
            // 
            // stateRefineriesInput
            // 
            this.stateRefineriesInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.stateRefineriesInput.ForeColor = System.Drawing.Color.White;
            this.stateRefineriesInput.Location = new System.Drawing.Point(509, 339);
            this.stateRefineriesInput.Name = "stateRefineriesInput";
            this.stateRefineriesInput.Size = new System.Drawing.Size(54, 22);
            this.stateRefineriesInput.TabIndex = 36;
            this.stateRefineriesInput.ThousandsSeparator = true;
            // 
            // stateReactorsInput
            // 
            this.stateReactorsInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.stateReactorsInput.ForeColor = System.Drawing.Color.White;
            this.stateReactorsInput.Location = new System.Drawing.Point(509, 367);
            this.stateReactorsInput.Name = "stateReactorsInput";
            this.stateReactorsInput.Size = new System.Drawing.Size(54, 22);
            this.stateReactorsInput.TabIndex = 39;
            this.stateReactorsInput.ThousandsSeparator = true;
            // 
            // stateAirbaseInput
            // 
            this.stateAirbaseInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.stateAirbaseInput.ForeColor = System.Drawing.Color.White;
            this.stateAirbaseInput.Location = new System.Drawing.Point(509, 395);
            this.stateAirbaseInput.Name = "stateAirbaseInput";
            this.stateAirbaseInput.Size = new System.Drawing.Size(54, 22);
            this.stateAirbaseInput.TabIndex = 41;
            this.stateAirbaseInput.ThousandsSeparator = true;
            // 
            // stateRadarInput
            // 
            this.stateRadarInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.stateRadarInput.ForeColor = System.Drawing.Color.White;
            this.stateRadarInput.Location = new System.Drawing.Point(509, 423);
            this.stateRadarInput.Name = "stateRadarInput";
            this.stateRadarInput.Size = new System.Drawing.Size(54, 22);
            this.stateRadarInput.TabIndex = 42;
            this.stateRadarInput.ThousandsSeparator = true;
            // 
            // stateRocketsInput
            // 
            this.stateRocketsInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.stateRocketsInput.ForeColor = System.Drawing.Color.White;
            this.stateRocketsInput.Location = new System.Drawing.Point(594, 367);
            this.stateRocketsInput.Name = "stateRocketsInput";
            this.stateRocketsInput.Size = new System.Drawing.Size(54, 22);
            this.stateRocketsInput.TabIndex = 43;
            this.stateRocketsInput.ThousandsSeparator = true;
            // 
            // stateCoreInput
            // 
            this.stateCoreInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.stateCoreInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stateCoreInput.ColumnWidth = 40;
            this.stateCoreInput.ForeColor = System.Drawing.Color.White;
            this.stateCoreInput.FormattingEnabled = true;
            this.stateCoreInput.ItemHeight = 17;
            this.stateCoreInput.Location = new System.Drawing.Point(353, 265);
            this.stateCoreInput.MultiColumn = true;
            this.stateCoreInput.Name = "stateCoreInput";
            this.stateCoreInput.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.stateCoreInput.Size = new System.Drawing.Size(121, 206);
            this.stateCoreInput.TabIndex = 48;
            // 
            // stateAntiairInput
            // 
            this.stateAntiairInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.stateAntiairInput.ForeColor = System.Drawing.Color.White;
            this.stateAntiairInput.Location = new System.Drawing.Point(594, 395);
            this.stateAntiairInput.Name = "stateAntiairInput";
            this.stateAntiairInput.Size = new System.Drawing.Size(54, 22);
            this.stateAntiairInput.TabIndex = 52;
            this.stateAntiairInput.ThousandsSeparator = true;
            // 
            // stateCategoryInput
            // 
            this.stateCategoryInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.stateCategoryInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateCategoryInput.ForeColor = System.Drawing.Color.White;
            this.stateCategoryInput.FormattingEnabled = true;
            this.stateCategoryInput.Location = new System.Drawing.Point(353, 231);
            this.stateCategoryInput.MaxDropDownItems = 31;
            this.stateCategoryInput.Name = "stateCategoryInput";
            this.stateCategoryInput.Size = new System.Drawing.Size(121, 25);
            this.stateCategoryInput.TabIndex = 10;
            // 
            // stateNameInput
            // 
            this.stateNameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.stateNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stateNameInput.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stateNameInput.ForeColor = System.Drawing.Color.White;
            this.stateNameInput.Location = new System.Drawing.Point(353, 115);
            this.stateNameInput.MaxLength = 63;
            this.stateNameInput.Name = "stateNameInput";
            this.stateNameInput.Size = new System.Drawing.Size(317, 27);
            this.stateNameInput.TabIndex = 8;
            this.stateNameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Transparent;
            this.resetButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.resetButton.FlatAppearance.BorderSize = 0;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetButton.ForeColor = System.Drawing.Color.White;
            this.resetButton.Location = new System.Drawing.Point(509, 567);
            this.resetButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(99, 32);
            this.resetButton.TabIndex = 51;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Transparent;
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(374, 567);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(99, 32);
            this.saveButton.TabIndex = 50;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.stateSaveButton_Click);
            // 
            // StateEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1113, 647);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.stateNameInput);
            this.Controls.Add(this.stateCategoryInput);
            this.Controls.Add(this.stateAntiairInput);
            this.Controls.Add(this.stateCoreInput);
            this.Controls.Add(this.stateRocketsInput);
            this.Controls.Add(this.stateRadarInput);
            this.Controls.Add(this.stateAirbaseInput);
            this.Controls.Add(this.stateReactorsInput);
            this.Controls.Add(this.stateRefineriesInput);
            this.Controls.Add(this.stateSilosInput);
            this.Controls.Add(this.stateDockyardsInput);
            this.Controls.Add(this.stateMilFactoriesInput);
            this.Controls.Add(this.stateCivFactoriesInput);
            this.Controls.Add(this.stateInfrastructureInput);
            this.Controls.Add(this.stateOwnerInput);
            this.Controls.Add(this.stateChromiumInput);
            this.Controls.Add(this.stateAluminiumInput);
            this.Controls.Add(this.stateTungstenInput);
            this.Controls.Add(this.stateSteelInput);
            this.Controls.Add(this.stateRubberInput);
            this.Controls.Add(this.stateOilInput);
            this.Controls.Add(this.stateManpowerInput);
            this.Controls.Add(this.sideBar);
            this.Controls.Add(this.testBox);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StateEditorForm";
            this.Text = "StateEditorForm";
            this.sideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stateManpowerInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateOilInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateRubberInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateSteelInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateTungstenInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateAluminiumInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateChromiumInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateInfrastructureInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateCivFactoriesInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateMilFactoriesInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateDockyardsInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateSilosInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateRefineriesInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateReactorsInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateAirbaseInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateRadarInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateRocketsInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateAntiairInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox selectList;
        private System.Windows.Forms.RichTextBox testBox;
        private System.Windows.Forms.ListBox stateList;
        private System.Windows.Forms.Panel sideBar;
        private System.Windows.Forms.Panel divider1;
        private System.Windows.Forms.NumericUpDown stateManpowerInput;
        private System.Windows.Forms.NumericUpDown stateOilInput;
        private System.Windows.Forms.NumericUpDown stateRubberInput;
        private System.Windows.Forms.NumericUpDown stateSteelInput;
        private System.Windows.Forms.NumericUpDown stateTungstenInput;
        private System.Windows.Forms.NumericUpDown stateAluminiumInput;
        private System.Windows.Forms.NumericUpDown stateChromiumInput;
        private System.Windows.Forms.ComboBox stateOwnerInput;
        private System.Windows.Forms.NumericUpDown stateInfrastructureInput;
        private System.Windows.Forms.NumericUpDown stateMilFactoriesInput;
        private System.Windows.Forms.NumericUpDown stateDockyardsInput;
        private System.Windows.Forms.NumericUpDown stateSilosInput;
        private System.Windows.Forms.NumericUpDown stateRefineriesInput;
        private System.Windows.Forms.NumericUpDown stateReactorsInput;
        private System.Windows.Forms.NumericUpDown stateAirbaseInput;
        private System.Windows.Forms.NumericUpDown stateRadarInput;
        private System.Windows.Forms.NumericUpDown stateRocketsInput;
        private System.Windows.Forms.ListBox stateCoreInput;
        private System.Windows.Forms.NumericUpDown stateAntiairInput;
        private System.Windows.Forms.ComboBox stateCategoryInput;
        private System.Windows.Forms.TextBox stateNameInput;
        private System.Windows.Forms.NumericUpDown stateCivFactoriesInput;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button saveButton;
    }
}
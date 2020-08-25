namespace HOI4MI.Forms {
    partial class ProvinceCreatorForm {
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
            this.provinceIdLabel = new System.Windows.Forms.Label();
            this.redInput = new System.Windows.Forms.NumericUpDown();
            this.greenInput = new System.Windows.Forms.NumericUpDown();
            this.blueInput = new System.Windows.Forms.NumericUpDown();
            this.provTypeInput = new System.Windows.Forms.ComboBox();
            this.terrainInput = new System.Windows.Forms.ComboBox();
            this.coastalInput = new System.Windows.Forms.ComboBox();
            this.continentInput = new System.Windows.Forms.ComboBox();
            this.writeButton = new System.Windows.Forms.Button();
            this.stateInput = new System.Windows.Forms.ComboBox();
            this.copyIdButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.regionInput = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.redInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueInput)).BeginInit();
            this.SuspendLayout();
            // 
            // provinceIdLabel
            // 
            this.provinceIdLabel.AutoSize = true;
            this.provinceIdLabel.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.provinceIdLabel.Location = new System.Drawing.Point(384, 62);
            this.provinceIdLabel.Name = "provinceIdLabel";
            this.provinceIdLabel.Size = new System.Drawing.Size(0, 22);
            this.provinceIdLabel.TabIndex = 0;
            // 
            // redInput
            // 
            this.redInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(26)))));
            this.redInput.ForeColor = System.Drawing.Color.White;
            this.redInput.Location = new System.Drawing.Point(353, 111);
            this.redInput.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.redInput.Name = "redInput";
            this.redInput.Size = new System.Drawing.Size(41, 22);
            this.redInput.TabIndex = 1;
            // 
            // greenInput
            // 
            this.greenInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(26)))));
            this.greenInput.ForeColor = System.Drawing.Color.White;
            this.greenInput.Location = new System.Drawing.Point(400, 111);
            this.greenInput.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.greenInput.Name = "greenInput";
            this.greenInput.Size = new System.Drawing.Size(41, 22);
            this.greenInput.TabIndex = 2;
            // 
            // blueInput
            // 
            this.blueInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(26)))));
            this.blueInput.ForeColor = System.Drawing.Color.White;
            this.blueInput.Location = new System.Drawing.Point(447, 111);
            this.blueInput.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.blueInput.Name = "blueInput";
            this.blueInput.Size = new System.Drawing.Size(41, 22);
            this.blueInput.TabIndex = 3;
            // 
            // provTypeInput
            // 
            this.provTypeInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.provTypeInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.provTypeInput.ForeColor = System.Drawing.Color.White;
            this.provTypeInput.FormattingEnabled = true;
            this.provTypeInput.Location = new System.Drawing.Point(359, 139);
            this.provTypeInput.MaxDropDownItems = 31;
            this.provTypeInput.Name = "provTypeInput";
            this.provTypeInput.Size = new System.Drawing.Size(121, 25);
            this.provTypeInput.TabIndex = 4;
            // 
            // terrainInput
            // 
            this.terrainInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.terrainInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.terrainInput.ForeColor = System.Drawing.Color.White;
            this.terrainInput.FormattingEnabled = true;
            this.terrainInput.Location = new System.Drawing.Point(359, 170);
            this.terrainInput.MaxDropDownItems = 31;
            this.terrainInput.Name = "terrainInput";
            this.terrainInput.Size = new System.Drawing.Size(121, 25);
            this.terrainInput.TabIndex = 6;
            // 
            // coastalInput
            // 
            this.coastalInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.coastalInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coastalInput.ForeColor = System.Drawing.Color.White;
            this.coastalInput.FormattingEnabled = true;
            this.coastalInput.Location = new System.Drawing.Point(359, 201);
            this.coastalInput.MaxDropDownItems = 31;
            this.coastalInput.Name = "coastalInput";
            this.coastalInput.Size = new System.Drawing.Size(121, 25);
            this.coastalInput.TabIndex = 7;
            // 
            // continentInput
            // 
            this.continentInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.continentInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.continentInput.ForeColor = System.Drawing.Color.White;
            this.continentInput.FormattingEnabled = true;
            this.continentInput.Location = new System.Drawing.Point(359, 232);
            this.continentInput.MaxDropDownItems = 31;
            this.continentInput.Name = "continentInput";
            this.continentInput.Size = new System.Drawing.Size(121, 25);
            this.continentInput.TabIndex = 8;
            // 
            // writeButton
            // 
            this.writeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.writeButton.Location = new System.Drawing.Point(506, 435);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(126, 42);
            this.writeButton.TabIndex = 26;
            this.writeButton.Text = "Write";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // stateInput
            // 
            this.stateInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.stateInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateInput.ForeColor = System.Drawing.Color.White;
            this.stateInput.FormattingEnabled = true;
            this.stateInput.Location = new System.Drawing.Point(359, 263);
            this.stateInput.MaxDropDownItems = 31;
            this.stateInput.Name = "stateInput";
            this.stateInput.Size = new System.Drawing.Size(121, 25);
            this.stateInput.TabIndex = 9;
            // 
            // copyIdButton
            // 
            this.copyIdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyIdButton.Location = new System.Drawing.Point(506, 400);
            this.copyIdButton.Name = "copyIdButton";
            this.copyIdButton.Size = new System.Drawing.Size(126, 29);
            this.copyIdButton.TabIndex = 26;
            this.copyIdButton.Text = "Copy Province ID";
            this.copyIdButton.UseVisualStyleBackColor = true;
            this.copyIdButton.Click += new System.EventHandler(this.copyIdButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(268, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Colour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(268, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(268, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Terrain";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(268, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Coastal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(268, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Continent";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(268, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "State";
            // 
            // regionInput
            // 
            this.regionInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.regionInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.regionInput.ForeColor = System.Drawing.Color.White;
            this.regionInput.FormattingEnabled = true;
            this.regionInput.Location = new System.Drawing.Point(359, 294);
            this.regionInput.MaxDropDownItems = 31;
            this.regionInput.Name = "regionInput";
            this.regionInput.Size = new System.Drawing.Size(121, 25);
            this.regionInput.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(268, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Region";
            // 
            // statusLabel
            // 
            this.statusLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusLabel.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statusLabel.Location = new System.Drawing.Point(0, 572);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(947, 20);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProvinceCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(947, 592);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.regionInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.copyIdButton);
            this.Controls.Add(this.stateInput);
            this.Controls.Add(this.writeButton);
            this.Controls.Add(this.continentInput);
            this.Controls.Add(this.coastalInput);
            this.Controls.Add(this.terrainInput);
            this.Controls.Add(this.provTypeInput);
            this.Controls.Add(this.blueInput);
            this.Controls.Add(this.greenInput);
            this.Controls.Add(this.redInput);
            this.Controls.Add(this.provinceIdLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProvinceCreatorForm";
            this.Text = "ProvinceCreatorForm";
            ((System.ComponentModel.ISupportInitialize)(this.redInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label provinceIdLabel;
        private System.Windows.Forms.NumericUpDown redInput;
        private System.Windows.Forms.NumericUpDown greenInput;
        private System.Windows.Forms.NumericUpDown blueInput;
        private System.Windows.Forms.ComboBox provTypeInput;
        private System.Windows.Forms.ComboBox terrainInput;
        private System.Windows.Forms.ComboBox coastalInput;
        private System.Windows.Forms.ComboBox continentInput;
        private System.Windows.Forms.Button writeButton;
        private System.Windows.Forms.ComboBox stateInput;
        private System.Windows.Forms.Button copyIdButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox regionInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label statusLabel;
    }
}
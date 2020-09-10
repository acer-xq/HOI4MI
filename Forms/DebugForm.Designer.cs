namespace HOI4MI.Forms {
    partial class DebugForm {
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
            this.stateList = new System.Windows.Forms.ListBox();
            this.provinceList = new System.Windows.Forms.ListBox();
            this.modifiedStateList = new System.Windows.Forms.ListBox();
            this.modifiedProvinceList = new System.Windows.Forms.ListBox();
            this.localeList = new System.Windows.Forms.ListBox();
            this.modifiedLocaleList = new System.Windows.Forms.ListBox();
            this.stateInfoBox = new System.Windows.Forms.RichTextBox();
            this.provinceInfoBox = new System.Windows.Forms.RichTextBox();
            this.localeInfoList = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.reloadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stateList
            // 
            this.stateList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.stateList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stateList.ForeColor = System.Drawing.Color.White;
            this.stateList.FormattingEnabled = true;
            this.stateList.ItemHeight = 17;
            this.stateList.Location = new System.Drawing.Point(12, 54);
            this.stateList.Name = "stateList";
            this.stateList.Size = new System.Drawing.Size(123, 629);
            this.stateList.TabIndex = 0;
            this.stateList.SelectedIndexChanged += new System.EventHandler(this.stateList_SelectedIndexChanged);
            // 
            // provinceList
            // 
            this.provinceList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.provinceList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.provinceList.ForeColor = System.Drawing.Color.White;
            this.provinceList.FormattingEnabled = true;
            this.provinceList.ItemHeight = 17;
            this.provinceList.Location = new System.Drawing.Point(288, 54);
            this.provinceList.Name = "provinceList";
            this.provinceList.Size = new System.Drawing.Size(123, 629);
            this.provinceList.TabIndex = 1;
            this.provinceList.SelectedIndexChanged += new System.EventHandler(this.provinceList_SelectedIndexChanged);
            // 
            // modifiedStateList
            // 
            this.modifiedStateList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.modifiedStateList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modifiedStateList.ForeColor = System.Drawing.Color.White;
            this.modifiedStateList.FormattingEnabled = true;
            this.modifiedStateList.ItemHeight = 17;
            this.modifiedStateList.Location = new System.Drawing.Point(141, 54);
            this.modifiedStateList.Name = "modifiedStateList";
            this.modifiedStateList.Size = new System.Drawing.Size(123, 629);
            this.modifiedStateList.TabIndex = 2;
            this.modifiedStateList.SelectedIndexChanged += new System.EventHandler(this.modifiedStateList_SelectedIndexChanged);
            // 
            // modifiedProvinceList
            // 
            this.modifiedProvinceList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.modifiedProvinceList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modifiedProvinceList.ForeColor = System.Drawing.Color.White;
            this.modifiedProvinceList.FormattingEnabled = true;
            this.modifiedProvinceList.ItemHeight = 17;
            this.modifiedProvinceList.Location = new System.Drawing.Point(417, 54);
            this.modifiedProvinceList.Name = "modifiedProvinceList";
            this.modifiedProvinceList.Size = new System.Drawing.Size(123, 629);
            this.modifiedProvinceList.TabIndex = 3;
            this.modifiedProvinceList.SelectedIndexChanged += new System.EventHandler(this.modifiedProvinceList_SelectedIndexChanged);
            // 
            // localeList
            // 
            this.localeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.localeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.localeList.ForeColor = System.Drawing.Color.White;
            this.localeList.FormattingEnabled = true;
            this.localeList.ItemHeight = 17;
            this.localeList.Location = new System.Drawing.Point(595, 58);
            this.localeList.Name = "localeList";
            this.localeList.Size = new System.Drawing.Size(163, 629);
            this.localeList.TabIndex = 4;
            this.localeList.SelectedIndexChanged += new System.EventHandler(this.localeList_SelectedIndexChanged);
            // 
            // modifiedLocaleList
            // 
            this.modifiedLocaleList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.modifiedLocaleList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modifiedLocaleList.ForeColor = System.Drawing.Color.White;
            this.modifiedLocaleList.FormattingEnabled = true;
            this.modifiedLocaleList.ItemHeight = 17;
            this.modifiedLocaleList.Location = new System.Drawing.Point(764, 58);
            this.modifiedLocaleList.Name = "modifiedLocaleList";
            this.modifiedLocaleList.Size = new System.Drawing.Size(163, 629);
            this.modifiedLocaleList.TabIndex = 5;
            this.modifiedLocaleList.SelectedIndexChanged += new System.EventHandler(this.modifiedLocaleList_SelectedIndexChanged);
            // 
            // stateInfoBox
            // 
            this.stateInfoBox.Location = new System.Drawing.Point(975, 69);
            this.stateInfoBox.Name = "stateInfoBox";
            this.stateInfoBox.Size = new System.Drawing.Size(371, 166);
            this.stateInfoBox.TabIndex = 7;
            this.stateInfoBox.Text = "";
            // 
            // provinceInfoBox
            // 
            this.provinceInfoBox.Location = new System.Drawing.Point(975, 264);
            this.provinceInfoBox.Name = "provinceInfoBox";
            this.provinceInfoBox.Size = new System.Drawing.Size(371, 166);
            this.provinceInfoBox.TabIndex = 8;
            this.provinceInfoBox.Text = "";
            // 
            // localeInfoList
            // 
            this.localeInfoList.Location = new System.Drawing.Point(975, 466);
            this.localeInfoList.Name = "localeInfoList";
            this.localeInfoList.Size = new System.Drawing.Size(371, 166);
            this.localeInfoList.TabIndex = 9;
            this.localeInfoList.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "States";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(141, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mod. States";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(288, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Provinces";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(417, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mod. Provinces";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(595, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Locale";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(764, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Mod. Locale";
            // 
            // reloadButton
            // 
            this.reloadButton.BackColor = System.Drawing.Color.Transparent;
            this.reloadButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.reloadButton.FlatAppearance.BorderSize = 0;
            this.reloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reloadButton.ForeColor = System.Drawing.Color.White;
            this.reloadButton.Location = new System.Drawing.Point(975, 655);
            this.reloadButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(99, 32);
            this.reloadButton.TabIndex = 52;
            this.reloadButton.Text = "Reload";
            this.reloadButton.UseVisualStyleBackColor = false;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // DebugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1387, 724);
            this.Controls.Add(this.reloadButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.localeInfoList);
            this.Controls.Add(this.provinceInfoBox);
            this.Controls.Add(this.stateInfoBox);
            this.Controls.Add(this.modifiedLocaleList);
            this.Controls.Add(this.localeList);
            this.Controls.Add(this.modifiedProvinceList);
            this.Controls.Add(this.modifiedStateList);
            this.Controls.Add(this.provinceList);
            this.Controls.Add(this.stateList);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DebugForm";
            this.Text = "DebugForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox stateList;
        private System.Windows.Forms.ListBox provinceList;
        private System.Windows.Forms.ListBox modifiedStateList;
        private System.Windows.Forms.ListBox modifiedProvinceList;
        private System.Windows.Forms.ListBox localeList;
        private System.Windows.Forms.ListBox modifiedLocaleList;
        private System.Windows.Forms.RichTextBox stateInfoBox;
        private System.Windows.Forms.RichTextBox provinceInfoBox;
        private System.Windows.Forms.RichTextBox localeInfoList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button reloadButton;
    }
}
namespace HOI4MI.Forms {
    partial class LocalisationEditorForm {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.localeItemSelectBox = new System.Windows.Forms.ListBox();
            this.divider1 = new System.Windows.Forms.Panel();
            this.localeFileSelectBox = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.localeValueInput = new System.Windows.Forms.TextBox();
            this.localeKeyInput = new System.Windows.Forms.TextBox();
            this.newButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.localeItemSelectBox);
            this.panel1.Controls.Add(this.divider1);
            this.panel1.Controls.Add(this.localeFileSelectBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 655);
            this.panel1.TabIndex = 7;
            // 
            // localeItemSelectBox
            // 
            this.localeItemSelectBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.localeItemSelectBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.localeItemSelectBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.localeItemSelectBox.ForeColor = System.Drawing.Color.White;
            this.localeItemSelectBox.FormattingEnabled = true;
            this.localeItemSelectBox.IntegralHeight = false;
            this.localeItemSelectBox.ItemHeight = 15;
            this.localeItemSelectBox.Location = new System.Drawing.Point(0, 329);
            this.localeItemSelectBox.Name = "localeItemSelectBox";
            this.localeItemSelectBox.Size = new System.Drawing.Size(166, 322);
            this.localeItemSelectBox.TabIndex = 6;
            this.localeItemSelectBox.SelectedIndexChanged += new System.EventHandler(this.localeItemSelectBox_SelectedIndexChanged);
            // 
            // divider1
            // 
            this.divider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.divider1.Dock = System.Windows.Forms.DockStyle.Top;
            this.divider1.Location = new System.Drawing.Point(0, 305);
            this.divider1.Name = "divider1";
            this.divider1.Size = new System.Drawing.Size(166, 24);
            this.divider1.TabIndex = 9;
            // 
            // localeFileSelectBox
            // 
            this.localeFileSelectBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.localeFileSelectBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.localeFileSelectBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.localeFileSelectBox.ForeColor = System.Drawing.Color.White;
            this.localeFileSelectBox.FormattingEnabled = true;
            this.localeFileSelectBox.IntegralHeight = false;
            this.localeFileSelectBox.ItemHeight = 15;
            this.localeFileSelectBox.Location = new System.Drawing.Point(0, 0);
            this.localeFileSelectBox.Name = "localeFileSelectBox";
            this.localeFileSelectBox.Size = new System.Drawing.Size(166, 305);
            this.localeFileSelectBox.TabIndex = 6;
            this.localeFileSelectBox.SelectedIndexChanged += new System.EventHandler(this.localeFileSelectBox_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(166, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(996, 655);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.localeValueInput);
            this.panel3.Controls.Add(this.localeKeyInput);
            this.panel3.Controls.Add(this.newButton);
            this.panel3.Controls.Add(this.deleteButton);
            this.panel3.Controls.Add(this.cancelButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(996, 655);
            this.panel3.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(398, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 21);
            this.label1.TabIndex = 80;
            this.label1.Text = "Localisation Value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(403, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 21);
            this.label6.TabIndex = 79;
            this.label6.Text = "Localisation Key";
            // 
            // localeValueInput
            // 
            this.localeValueInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.localeValueInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.localeValueInput.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.localeValueInput.ForeColor = System.Drawing.Color.White;
            this.localeValueInput.Location = new System.Drawing.Point(182, 188);
            this.localeValueInput.Multiline = true;
            this.localeValueInput.Name = "localeValueInput";
            this.localeValueInput.Size = new System.Drawing.Size(595, 234);
            this.localeValueInput.TabIndex = 31;
            // 
            // localeKeyInput
            // 
            this.localeKeyInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.localeKeyInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.localeKeyInput.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.localeKeyInput.ForeColor = System.Drawing.Color.White;
            this.localeKeyInput.Location = new System.Drawing.Point(184, 108);
            this.localeKeyInput.MaxLength = 63;
            this.localeKeyInput.Name = "localeKeyInput";
            this.localeKeyInput.Size = new System.Drawing.Size(593, 27);
            this.localeKeyInput.TabIndex = 30;
            // 
            // newButton
            // 
            this.newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newButton.Location = new System.Drawing.Point(184, 474);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(126, 29);
            this.newButton.TabIndex = 29;
            this.newButton.Text = "Create New";
            this.newButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.Location = new System.Drawing.Point(403, 474);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(126, 29);
            this.deleteButton.TabIndex = 28;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.Location = new System.Drawing.Point(631, 474);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(126, 29);
            this.cancelButton.TabIndex = 27;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // LocalisationEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1162, 655);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LocalisationEditorForm";
            this.Text = "LocalisationEditorForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox localeItemSelectBox;
        private System.Windows.Forms.ListBox localeFileSelectBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel divider1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox localeValueInput;
        private System.Windows.Forms.TextBox localeKeyInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}
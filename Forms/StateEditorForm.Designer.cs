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
            this.countryList = new System.Windows.Forms.ListBox();
            this.testBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // countryList
            // 
            this.countryList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.countryList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.countryList.Dock = System.Windows.Forms.DockStyle.Left;
            this.countryList.ForeColor = System.Drawing.Color.White;
            this.countryList.FormattingEnabled = true;
            this.countryList.ItemHeight = 17;
            this.countryList.Location = new System.Drawing.Point(0, 0);
            this.countryList.Name = "countryList";
            this.countryList.Size = new System.Drawing.Size(227, 636);
            this.countryList.TabIndex = 5;
            this.countryList.SelectedIndexChanged += new System.EventHandler(this.countryList_SelectedIndexChanged);
            // 
            // testBox
            // 
            this.testBox.Location = new System.Drawing.Point(389, 167);
            this.testBox.Name = "testBox";
            this.testBox.Size = new System.Drawing.Size(539, 335);
            this.testBox.TabIndex = 6;
            this.testBox.Text = "";
            // 
            // StateEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1052, 636);
            this.Controls.Add(this.testBox);
            this.Controls.Add(this.countryList);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StateEditorForm";
            this.Text = "StateEditorForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox countryList;
        private System.Windows.Forms.RichTextBox testBox;
    }
}
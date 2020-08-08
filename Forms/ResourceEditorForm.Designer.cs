namespace StateEditor
{
    partial class ResourceEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.debugButton = new System.Windows.Forms.Button();
            this.stateList = new System.Windows.Forms.ListBox();
            this.excavationSelect = new System.Windows.Forms.NumericUpDown();
            this.countryInfoTextBox = new System.Windows.Forms.RichTextBox();
            this.stateListTextBox = new System.Windows.Forms.RichTextBox();
            this.resourceList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.excavationSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceList)).BeginInit();
            this.SuspendLayout();
            // 
            // debugButton
            // 
            this.debugButton.BackColor = System.Drawing.Color.Transparent;
            this.debugButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.debugButton.FlatAppearance.BorderSize = 0;
            this.debugButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.debugButton.ForeColor = System.Drawing.Color.White;
            this.debugButton.Location = new System.Drawing.Point(1164, 31);
            this.debugButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.debugButton.Name = "debugButton";
            this.debugButton.Size = new System.Drawing.Size(71, 32);
            this.debugButton.TabIndex = 2;
            this.debugButton.Text = "debug";
            this.debugButton.UseVisualStyleBackColor = false;
            this.debugButton.Click += new System.EventHandler(this.debugButton_Click);
            // 
            // stateList
            // 
            this.stateList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(26)))));
            this.stateList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stateList.Dock = System.Windows.Forms.DockStyle.Left;
            this.stateList.ForeColor = System.Drawing.Color.White;
            this.stateList.FormattingEnabled = true;
            this.stateList.IntegralHeight = false;
            this.stateList.ItemHeight = 17;
            this.stateList.Location = new System.Drawing.Point(432, 0);
            this.stateList.Margin = new System.Windows.Forms.Padding(0);
            this.stateList.Name = "stateList";
            this.stateList.Size = new System.Drawing.Size(237, 697);
            this.stateList.TabIndex = 4;
            this.stateList.SelectedIndexChanged += new System.EventHandler(this.stateList_SelectedIndexChanged);
            // 
            // excavationSelect
            // 
            this.excavationSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.excavationSelect.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.excavationSelect.Location = new System.Drawing.Point(1256, 37);
            this.excavationSelect.Name = "excavationSelect";
            this.excavationSelect.Size = new System.Drawing.Size(120, 22);
            this.excavationSelect.TabIndex = 7;
            this.excavationSelect.ValueChanged += new System.EventHandler(this.excavationSelect_ValueChanged);
            // 
            // countryInfoTextBox
            // 
            this.countryInfoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.countryInfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.countryInfoTextBox.ForeColor = System.Drawing.Color.White;
            this.countryInfoTextBox.Location = new System.Drawing.Point(759, 209);
            this.countryInfoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.countryInfoTextBox.Name = "countryInfoTextBox";
            this.countryInfoTextBox.ReadOnly = true;
            this.countryInfoTextBox.Size = new System.Drawing.Size(374, 166);
            this.countryInfoTextBox.TabIndex = 3;
            this.countryInfoTextBox.Text = "";
            // 
            // stateListTextBox
            // 
            this.stateListTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.stateListTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stateListTextBox.ForeColor = System.Drawing.Color.White;
            this.stateListTextBox.Location = new System.Drawing.Point(759, 435);
            this.stateListTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stateListTextBox.Name = "stateListTextBox";
            this.stateListTextBox.ReadOnly = true;
            this.stateListTextBox.Size = new System.Drawing.Size(384, 188);
            this.stateListTextBox.TabIndex = 1;
            this.stateListTextBox.Text = "";
            // 
            // resourceList
            // 
            this.resourceList.AllowUserToAddRows = false;
            this.resourceList.AllowUserToDeleteRows = false;
            this.resourceList.AllowUserToResizeRows = false;
            this.resourceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resourceList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(26)))));
            this.resourceList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resourceList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.resourceList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resourceList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.resourceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resourceList.DefaultCellStyle = dataGridViewCellStyle1;
            this.resourceList.Dock = System.Windows.Forms.DockStyle.Left;
            this.resourceList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.resourceList.Location = new System.Drawing.Point(0, 0);
            this.resourceList.Name = "resourceList";
            this.resourceList.ReadOnly = true;
            this.resourceList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resourceList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.resourceList.RowHeadersVisible = false;
            this.resourceList.ShowEditingIcon = false;
            this.resourceList.Size = new System.Drawing.Size(432, 697);
            this.resourceList.TabIndex = 10;
            this.resourceList.SelectionChanged += new System.EventHandler(this.resourceList_SelectionChanged);
            // 
            // ResourceEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1509, 697);
            this.Controls.Add(this.stateList);
            this.Controls.Add(this.resourceList);
            this.Controls.Add(this.stateListTextBox);
            this.Controls.Add(this.countryInfoTextBox);
            this.Controls.Add(this.excavationSelect);
            this.Controls.Add(this.debugButton);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(100, 100);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ResourceEditorForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.excavationSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button debugButton;
        private System.Windows.Forms.ListBox stateList;
        private System.Windows.Forms.NumericUpDown excavationSelect;
        private System.Windows.Forms.RichTextBox countryInfoTextBox;
        private System.Windows.Forms.RichTextBox stateListTextBox;
        private System.Windows.Forms.DataGridView resourceList;
    }
}


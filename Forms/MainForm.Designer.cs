namespace StateEditor.Forms
{
    partial class MainForm
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
            this.resourceEditorFormButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.stateSplitterFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resourceEditorFormButton
            // 
            this.resourceEditorFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resourceEditorFormButton.Location = new System.Drawing.Point(13, 241);
            this.resourceEditorFormButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.resourceEditorFormButton.Name = "resourceEditorFormButton";
            this.resourceEditorFormButton.Size = new System.Drawing.Size(219, 99);
            this.resourceEditorFormButton.TabIndex = 1;
            this.resourceEditorFormButton.Text = "Resource Editor";
            this.resourceEditorFormButton.UseVisualStyleBackColor = true;
            this.resourceEditorFormButton.Click += new System.EventHandler(this.resourceEditorFormButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(174, 108);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(271, 78);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Hearts of Iron IV \r\nState Editor";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stateSplitterFormButton
            // 
            this.stateSplitterFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stateSplitterFormButton.Location = new System.Drawing.Point(398, 213);
            this.stateSplitterFormButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.stateSplitterFormButton.Name = "stateSplitterFormButton";
            this.stateSplitterFormButton.Size = new System.Drawing.Size(219, 87);
            this.stateSplitterFormButton.TabIndex = 3;
            this.stateSplitterFormButton.Text = "State Splitter";
            this.stateSplitterFormButton.UseVisualStyleBackColor = true;
            this.stateSplitterFormButton.Click += new System.EventHandler(this.stateSplitterFormButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 512);
            this.Controls.Add(this.stateSplitterFormButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.resourceEditorFormButton);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Controls.SetChildIndex(this.resourceEditorFormButton, 0);
            this.Controls.SetChildIndex(this.titleLabel, 0);
            this.Controls.SetChildIndex(this.stateSplitterFormButton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resourceEditorFormButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button stateSplitterFormButton;
    }
}
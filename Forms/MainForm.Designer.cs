namespace HOI4MI.Forms
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
            this.sideBar = new System.Windows.Forms.Panel();
            this.provinceCreatorFormButton = new System.Windows.Forms.Button();
            this.stateEditorFormButton = new System.Windows.Forms.Button();
            this.sideBarBottom = new System.Windows.Forms.Panel();
            this.reloadButton = new System.Windows.Forms.Button();
            this.writeButton = new System.Windows.Forms.Button();
            this.sideBarLogo = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.dividerPanel = new System.Windows.Forms.Panel();
            this.sideBar.SuspendLayout();
            this.sideBarBottom.SuspendLayout();
            this.sideBarLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // resourceEditorFormButton
            // 
            this.resourceEditorFormButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.resourceEditorFormButton.FlatAppearance.BorderSize = 0;
            this.resourceEditorFormButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.resourceEditorFormButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(55)))));
            this.resourceEditorFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resourceEditorFormButton.Location = new System.Drawing.Point(0, 0);
            this.resourceEditorFormButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.resourceEditorFormButton.Name = "resourceEditorFormButton";
            this.resourceEditorFormButton.Size = new System.Drawing.Size(196, 65);
            this.resourceEditorFormButton.TabIndex = 1;
            this.resourceEditorFormButton.Text = "Resource Editor";
            this.resourceEditorFormButton.UseVisualStyleBackColor = true;
            this.resourceEditorFormButton.Click += new System.EventHandler(this.resourceEditorFormButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(196, 100);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Hearts of Iron IV \r\nModding Interface";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stateSplitterFormButton
            // 
            this.stateSplitterFormButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.stateSplitterFormButton.FlatAppearance.BorderSize = 0;
            this.stateSplitterFormButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.stateSplitterFormButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(55)))));
            this.stateSplitterFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stateSplitterFormButton.Location = new System.Drawing.Point(0, 65);
            this.stateSplitterFormButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.stateSplitterFormButton.Name = "stateSplitterFormButton";
            this.stateSplitterFormButton.Size = new System.Drawing.Size(196, 65);
            this.stateSplitterFormButton.TabIndex = 3;
            this.stateSplitterFormButton.Text = "State Splitter";
            this.stateSplitterFormButton.UseVisualStyleBackColor = true;
            this.stateSplitterFormButton.Click += new System.EventHandler(this.stateSplitterFormButton_Click);
            // 
            // sideBar
            // 
            this.sideBar.AutoScroll = true;
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.sideBar.Controls.Add(this.provinceCreatorFormButton);
            this.sideBar.Controls.Add(this.stateEditorFormButton);
            this.sideBar.Controls.Add(this.sideBarBottom);
            this.sideBar.Controls.Add(this.sideBarLogo);
            this.sideBar.Controls.Add(this.stateSplitterFormButton);
            this.sideBar.Controls.Add(this.resourceEditorFormButton);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.ForeColor = System.Drawing.Color.White;
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(196, 829);
            this.sideBar.TabIndex = 4;
            // 
            // provinceCreatorFormButton
            // 
            this.provinceCreatorFormButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.provinceCreatorFormButton.FlatAppearance.BorderSize = 0;
            this.provinceCreatorFormButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.provinceCreatorFormButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(55)))));
            this.provinceCreatorFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.provinceCreatorFormButton.Location = new System.Drawing.Point(0, 195);
            this.provinceCreatorFormButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.provinceCreatorFormButton.Name = "provinceCreatorFormButton";
            this.provinceCreatorFormButton.Size = new System.Drawing.Size(196, 65);
            this.provinceCreatorFormButton.TabIndex = 3;
            this.provinceCreatorFormButton.Text = "Province Creator";
            this.provinceCreatorFormButton.UseVisualStyleBackColor = true;
            this.provinceCreatorFormButton.Click += new System.EventHandler(this.provinceCreatorFormButton_Click);
            // 
            // stateEditorFormButton
            // 
            this.stateEditorFormButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.stateEditorFormButton.FlatAppearance.BorderSize = 0;
            this.stateEditorFormButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.stateEditorFormButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(55)))));
            this.stateEditorFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stateEditorFormButton.Location = new System.Drawing.Point(0, 130);
            this.stateEditorFormButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.stateEditorFormButton.Name = "stateEditorFormButton";
            this.stateEditorFormButton.Size = new System.Drawing.Size(196, 65);
            this.stateEditorFormButton.TabIndex = 3;
            this.stateEditorFormButton.Text = "State Editor";
            this.stateEditorFormButton.UseVisualStyleBackColor = true;
            this.stateEditorFormButton.Click += new System.EventHandler(this.stateEditorFormButton_Click);
            // 
            // sideBarBottom
            // 
            this.sideBarBottom.BackColor = System.Drawing.Color.White;
            this.sideBarBottom.Controls.Add(this.reloadButton);
            this.sideBarBottom.Controls.Add(this.writeButton);
            this.sideBarBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sideBarBottom.Location = new System.Drawing.Point(0, 629);
            this.sideBarBottom.Name = "sideBarBottom";
            this.sideBarBottom.Size = new System.Drawing.Size(196, 100);
            this.sideBarBottom.TabIndex = 6;
            // 
            // reloadButton
            // 
            this.reloadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.reloadButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.reloadButton.FlatAppearance.BorderSize = 0;
            this.reloadButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.reloadButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(55)))));
            this.reloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reloadButton.Location = new System.Drawing.Point(98, 0);
            this.reloadButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(98, 100);
            this.reloadButton.TabIndex = 3;
            this.reloadButton.Text = "Reload";
            this.reloadButton.UseVisualStyleBackColor = false;
            this.reloadButton.Click += new System.EventHandler(this.reloadButton_Click);
            // 
            // writeButton
            // 
            this.writeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.writeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.writeButton.FlatAppearance.BorderSize = 0;
            this.writeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.writeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(55)))));
            this.writeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.writeButton.Location = new System.Drawing.Point(0, 0);
            this.writeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(100, 100);
            this.writeButton.TabIndex = 3;
            this.writeButton.Text = "Write States";
            this.writeButton.UseVisualStyleBackColor = false;
            this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // sideBarLogo
            // 
            this.sideBarLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.sideBarLogo.Controls.Add(this.titleLabel);
            this.sideBarLogo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sideBarLogo.Location = new System.Drawing.Point(0, 729);
            this.sideBarLogo.Name = "sideBarLogo";
            this.sideBarLogo.Size = new System.Drawing.Size(196, 100);
            this.sideBarLogo.TabIndex = 5;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(26)))));
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(212, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1303, 829);
            this.mainPanel.TabIndex = 5;
            // 
            // dividerPanel
            // 
            this.dividerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.dividerPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.dividerPanel.ForeColor = System.Drawing.Color.White;
            this.dividerPanel.Location = new System.Drawing.Point(196, 0);
            this.dividerPanel.Name = "dividerPanel";
            this.dividerPanel.Size = new System.Drawing.Size(16, 829);
            this.dividerPanel.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1515, 829);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.dividerPanel);
            this.Controls.Add(this.sideBar);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Hearts of Iron IV Modding Interface";
            this.sideBar.ResumeLayout(false);
            this.sideBarBottom.ResumeLayout(false);
            this.sideBarLogo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button resourceEditorFormButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button stateSplitterFormButton;
        private System.Windows.Forms.Panel sideBar;
        private System.Windows.Forms.Panel sideBarLogo;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel dividerPanel;
        private System.Windows.Forms.Button writeButton;
        private System.Windows.Forms.Panel sideBarBottom;
        private System.Windows.Forms.Button reloadButton;
        private System.Windows.Forms.Button stateEditorFormButton;
        private System.Windows.Forms.Button provinceCreatorFormButton;
    }
}
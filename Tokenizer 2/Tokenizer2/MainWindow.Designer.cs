namespace Tokenizer_2
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TokenTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.WRTokenRadioButton = new System.Windows.Forms.RadioButton();
            this.CEPTokenRadioButton = new System.Windows.Forms.RadioButton();
            this.UserDetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.ClientKeyTextBox = new System.Windows.Forms.TextBox();
            this.UserIDComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CultureComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GroupIDComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CountryComboBox = new System.Windows.Forms.ComboBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.TokenTypeGroupBox.SuspendLayout();
            this.UserDetailsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(508, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitApplication);
            // 
            // TokenTypeGroupBox
            // 
            this.TokenTypeGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TokenTypeGroupBox.Controls.Add(this.WRTokenRadioButton);
            this.TokenTypeGroupBox.Controls.Add(this.CEPTokenRadioButton);
            this.TokenTypeGroupBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TokenTypeGroupBox.Location = new System.Drawing.Point(12, 98);
            this.TokenTypeGroupBox.Name = "TokenTypeGroupBox";
            this.TokenTypeGroupBox.Size = new System.Drawing.Size(199, 155);
            this.TokenTypeGroupBox.TabIndex = 1;
            this.TokenTypeGroupBox.TabStop = false;
            this.TokenTypeGroupBox.Text = "Select Token Type";
            // 
            // WRTokenRadioButton
            // 
            this.WRTokenRadioButton.AutoSize = true;
            this.WRTokenRadioButton.Location = new System.Drawing.Point(23, 81);
            this.WRTokenRadioButton.Name = "WRTokenRadioButton";
            this.WRTokenRadioButton.Size = new System.Drawing.Size(105, 27);
            this.WRTokenRadioButton.TabIndex = 1;
            this.WRTokenRadioButton.TabStop = true;
            this.WRTokenRadioButton.Text = "WR Token";
            this.WRTokenRadioButton.UseVisualStyleBackColor = true;
            this.WRTokenRadioButton.CheckedChanged += new System.EventHandler(this.ToggleClientKeyBox);
            // 
            // CEPTokenRadioButton
            // 
            this.CEPTokenRadioButton.AutoSize = true;
            this.CEPTokenRadioButton.Location = new System.Drawing.Point(23, 48);
            this.CEPTokenRadioButton.Name = "CEPTokenRadioButton";
            this.CEPTokenRadioButton.Size = new System.Drawing.Size(105, 27);
            this.CEPTokenRadioButton.TabIndex = 0;
            this.CEPTokenRadioButton.TabStop = true;
            this.CEPTokenRadioButton.Text = "CEP Token";
            this.CEPTokenRadioButton.UseVisualStyleBackColor = true;
            // 
            // UserDetailsGroupBox
            // 
            this.UserDetailsGroupBox.Controls.Add(this.ClientKeyTextBox);
            this.UserDetailsGroupBox.Controls.Add(this.UserIDComboBox);
            this.UserDetailsGroupBox.Controls.Add(this.label5);
            this.UserDetailsGroupBox.Controls.Add(this.label4);
            this.UserDetailsGroupBox.Controls.Add(this.CultureComboBox);
            this.UserDetailsGroupBox.Controls.Add(this.label3);
            this.UserDetailsGroupBox.Controls.Add(this.GroupIDComboBox);
            this.UserDetailsGroupBox.Controls.Add(this.label2);
            this.UserDetailsGroupBox.Controls.Add(this.label1);
            this.UserDetailsGroupBox.Controls.Add(this.CountryComboBox);
            this.UserDetailsGroupBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserDetailsGroupBox.Location = new System.Drawing.Point(217, 46);
            this.UserDetailsGroupBox.Name = "UserDetailsGroupBox";
            this.UserDetailsGroupBox.Size = new System.Drawing.Size(276, 249);
            this.UserDetailsGroupBox.TabIndex = 2;
            this.UserDetailsGroupBox.TabStop = false;
            this.UserDetailsGroupBox.Text = "User Details";
            // 
            // ClientKeyTextBox
            // 
            this.ClientKeyTextBox.Enabled = false;
            this.ClientKeyTextBox.Location = new System.Drawing.Point(117, 195);
            this.ClientKeyTextBox.Name = "ClientKeyTextBox";
            this.ClientKeyTextBox.Size = new System.Drawing.Size(153, 30);
            this.ClientKeyTextBox.TabIndex = 9;
            // 
            // UserIDComboBox
            // 
            this.UserIDComboBox.FormattingEnabled = true;
            this.UserIDComboBox.Location = new System.Drawing.Point(117, 155);
            this.UserIDComboBox.Name = "UserIDComboBox";
            this.UserIDComboBox.Size = new System.Drawing.Size(153, 31);
            this.UserIDComboBox.TabIndex = 8;
            this.UserIDComboBox.DropDownClosed += new System.EventHandler(this.AutoCompleteClientKey);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Client Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(21, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "User ID";
            // 
            // CultureComboBox
            // 
            this.CultureComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CultureComboBox.FormattingEnabled = true;
            this.CultureComboBox.Items.AddRange(new object[] {
            "en-AU",
            "en-CA",
            "en-IE",
            "en-NZ",
            "en-GB",
            "en-US"});
            this.CultureComboBox.Location = new System.Drawing.Point(117, 115);
            this.CultureComboBox.Name = "CultureComboBox";
            this.CultureComboBox.Size = new System.Drawing.Size(153, 31);
            this.CultureComboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Culture";
            // 
            // GroupIDComboBox
            // 
            this.GroupIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GroupIDComboBox.FormattingEnabled = true;
            this.GroupIDComboBox.Items.AddRange(new object[] {
            "ERP LN 100",
            "ERP LN 130",
            "ERP LN 387",
            "ERP LN 408"});
            this.GroupIDComboBox.Location = new System.Drawing.Point(117, 75);
            this.GroupIDComboBox.Name = "GroupIDComboBox";
            this.GroupIDComboBox.Size = new System.Drawing.Size(153, 31);
            this.GroupIDComboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Group ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Country";
            // 
            // CountryComboBox
            // 
            this.CountryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CountryComboBox.FormattingEnabled = true;
            this.CountryComboBox.Items.AddRange(new object[] {
            "Australia",
            "Canada",
            "Ireland",
            "New-Zeeland",
            "United Kingdom",
            "United States"});
            this.CountryComboBox.Location = new System.Drawing.Point(117, 35);
            this.CountryComboBox.Name = "CountryComboBox";
            this.CountryComboBox.Size = new System.Drawing.Size(153, 31);
            this.CountryComboBox.TabIndex = 0;
            this.CountryComboBox.SelectedIndexChanged += new System.EventHandler(this.AutocompleteCombobox);
            // 
            // generateButton
            // 
            this.generateButton.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.generateButton.Location = new System.Drawing.Point(164, 332);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(138, 46);
            this.generateButton.TabIndex = 3;
            this.generateButton.Text = "Generate Token";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.GenerateToken);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(8, 306);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 23);
            this.ErrorLabel.TabIndex = 4;
            this.ErrorLabel.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(508, 390);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.UserDetailsGroupBox);
            this.Controls.Add(this.TokenTypeGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Tokenizer 2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TokenTypeGroupBox.ResumeLayout(false);
            this.TokenTypeGroupBox.PerformLayout();
            this.UserDetailsGroupBox.ResumeLayout(false);
            this.UserDetailsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox TokenTypeGroupBox;
        public System.Windows.Forms.RadioButton WRTokenRadioButton;
        public System.Windows.Forms.RadioButton CEPTokenRadioButton;
        private System.Windows.Forms.GroupBox UserDetailsGroupBox;
        private System.Windows.Forms.ComboBox CountryComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox GroupIDComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CultureComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ClientKeyTextBox;
        private System.Windows.Forms.ComboBox UserIDComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label ErrorLabel;
    }
}


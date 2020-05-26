namespace PovezavaBaza
{
    partial class Dashboard
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
            this.peopleListBox = new System.Windows.Forms.ListBox();
            this.nazDelText = new System.Windows.Forms.TextBox();
            this.nazDelLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.peopleComboBox = new System.Windows.Forms.ComboBox();
            this.potrdi = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // peopleListBox
            // 
            this.peopleListBox.FormattingEnabled = true;
            this.peopleListBox.Location = new System.Drawing.Point(12, 94);
            this.peopleListBox.Name = "peopleListBox";
            this.peopleListBox.Size = new System.Drawing.Size(379, 316);
            this.peopleListBox.TabIndex = 0;
            // 
            // nazDelText
            // 
            this.nazDelText.Location = new System.Drawing.Point(109, 39);
            this.nazDelText.Name = "nazDelText";
            this.nazDelText.Size = new System.Drawing.Size(282, 20);
            this.nazDelText.TabIndex = 1;
            // 
            // nazDelLabel
            // 
            this.nazDelLabel.AutoSize = true;
            this.nazDelLabel.Location = new System.Drawing.Point(13, 42);
            this.nazDelLabel.Name = "nazDelLabel";
            this.nazDelLabel.Size = new System.Drawing.Size(77, 13);
            this.nazDelLabel.TabIndex = 2;
            this.nazDelLabel.Text = "Naziv Delavca";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Išči";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // peopleComboBox
            // 
            this.peopleComboBox.FormattingEnabled = true;
            this.peopleComboBox.Location = new System.Drawing.Point(506, 38);
            this.peopleComboBox.Name = "peopleComboBox";
            this.peopleComboBox.Size = new System.Drawing.Size(282, 21);
            this.peopleComboBox.TabIndex = 4;
            this.peopleComboBox.SelectedIndexChanged += new System.EventHandler(this.peopleComboBox_SelectedIndexChanged);
            // 
            // potrdi
            // 
            this.potrdi.Location = new System.Drawing.Point(506, 65);
            this.potrdi.Name = "potrdi";
            this.potrdi.Size = new System.Drawing.Size(75, 23);
            this.potrdi.TabIndex = 5;
            this.potrdi.Text = "Potrdi";
            this.potrdi.UseVisualStyleBackColor = true;
            this.potrdi.Click += new System.EventHandler(this.potrdi_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(713, 387);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 6;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.potrdi);
            this.Controls.Add(this.peopleComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nazDelLabel);
            this.Controls.Add(this.nazDelText);
            this.Controls.Add(this.peopleListBox);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox peopleListBox;
        private System.Windows.Forms.TextBox nazDelText;
        private System.Windows.Forms.Label nazDelLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox peopleComboBox;
        private System.Windows.Forms.Button potrdi;
        private System.Windows.Forms.Button nextButton;
    }
}


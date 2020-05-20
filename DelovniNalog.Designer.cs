namespace PovezavaBaza
{
    partial class DelovniNalog
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DN_textbox = new System.Windows.Forms.TextBox();
            this.DN_button = new System.Windows.Forms.Button();
            this.sifra_listBox = new System.Windows.Forms.ListBox();
            this.kodaKupca_listBox = new System.Windows.Forms.ListBox();
            this.stKosov_listBox = new System.Windows.Forms.ListBox();
            this.casCikla_listbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ŠIFRA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "KODA KUPCA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ŠT. KOSOV:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ČAS CIKLA:";
            // 
            // DN_textbox
            // 
            this.DN_textbox.Location = new System.Drawing.Point(209, 38);
            this.DN_textbox.Name = "DN_textbox";
            this.DN_textbox.Size = new System.Drawing.Size(180, 20);
            this.DN_textbox.TabIndex = 5;
            // 
            // DN_button
            // 
            this.DN_button.Location = new System.Drawing.Point(405, 38);
            this.DN_button.Name = "DN_button";
            this.DN_button.Size = new System.Drawing.Size(75, 23);
            this.DN_button.TabIndex = 6;
            this.DN_button.Text = "Prikaži";
            this.DN_button.UseVisualStyleBackColor = true;
            this.DN_button.Click += new System.EventHandler(this.DN_button_Click);
            // 
            // sifra_listBox
            // 
            this.sifra_listBox.FormattingEnabled = true;
            this.sifra_listBox.Location = new System.Drawing.Point(209, 71);
            this.sifra_listBox.Name = "sifra_listBox";
            this.sifra_listBox.Size = new System.Drawing.Size(180, 17);
            this.sifra_listBox.TabIndex = 7;
            // 
            // kodaKupca_listBox
            // 
            this.kodaKupca_listBox.FormattingEnabled = true;
            this.kodaKupca_listBox.Location = new System.Drawing.Point(209, 102);
            this.kodaKupca_listBox.Name = "kodaKupca_listBox";
            this.kodaKupca_listBox.Size = new System.Drawing.Size(180, 17);
            this.kodaKupca_listBox.TabIndex = 8;
            // 
            // stKosov_listBox
            // 
            this.stKosov_listBox.FormattingEnabled = true;
            this.stKosov_listBox.Location = new System.Drawing.Point(209, 139);
            this.stKosov_listBox.Name = "stKosov_listBox";
            this.stKosov_listBox.Size = new System.Drawing.Size(180, 17);
            this.stKosov_listBox.TabIndex = 9;
            // 
            // casCikla_listbox
            // 
            this.casCikla_listbox.FormattingEnabled = true;
            this.casCikla_listbox.Location = new System.Drawing.Point(209, 172);
            this.casCikla_listbox.Name = "casCikla_listbox";
            this.casCikla_listbox.Size = new System.Drawing.Size(180, 17);
            this.casCikla_listbox.TabIndex = 10;
            // 
            // DelovniNalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.casCikla_listbox);
            this.Controls.Add(this.stKosov_listBox);
            this.Controls.Add(this.kodaKupca_listBox);
            this.Controls.Add(this.sifra_listBox);
            this.Controls.Add(this.DN_button);
            this.Controls.Add(this.DN_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DelovniNalog";
            this.Text = "DelovniNalog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DN_textbox;
        private System.Windows.Forms.Button DN_button;
        private System.Windows.Forms.ListBox sifra_listBox;
        private System.Windows.Forms.ListBox kodaKupca_listBox;
        private System.Windows.Forms.ListBox stKosov_listBox;
        private System.Windows.Forms.ListBox casCikla_listbox;
    }
}
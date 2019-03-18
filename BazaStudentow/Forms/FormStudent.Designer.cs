namespace BazaStudentow.Forms
{
    partial class FormStudent
    {

        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            this.zad_indeks = new System.Windows.Forms.TextBox();
            this.zad_imie = new System.Windows.Forms.TextBox();
            this.zad_nazwisko = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // nr indeksu
            // 
            this.zad_indeks.Enabled = false;
            this.zad_indeks.Location = new System.Drawing.Point(17, 31);
            this.zad_indeks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zad_indeks.Name = "zad_indeks";
            this.zad_indeks.Size = new System.Drawing.Size(132, 22);
            this.zad_indeks.TabIndex = 0;
            // 
            // label3
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label3";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Indeks";
            // 
            // imie
            // 
            this.zad_imie.Location = new System.Drawing.Point(17, 82);
            this.zad_imie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zad_imie.Name = "zad_imie";
            this.zad_imie.Size = new System.Drawing.Size(424, 22);
            this.zad_imie.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Imię";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label4";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Semestr";
            //
            //
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nazwa przedmiotu";
            this.label1.Click += new System.EventHandler(this.label2_Click);
            // 
            // nazwisko
            // 
            this.zad_nazwisko.Location = new System.Drawing.Point(17, 135);
            this.zad_nazwisko.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zad_nazwisko.Name = "zad_nazwisko";
            this.zad_nazwisko.Size = new System.Drawing.Size(424, 22);
            this.zad_nazwisko.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nazwisko";



            // 
            // button1
            // 
            this.button3.Location = new System.Drawing.Point(451, 134);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button1";
            this.button3.Size = new System.Drawing.Size(124, 28);
            this.button3.TabIndex = 7;
            this.button3.Text = "Zapisz";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_Click);

            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(319, 31);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(124, 22);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 178);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zad_nazwisko);
            this.Controls.Add(this.zad_imie);
            this.Controls.Add(this.zad_indeks);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj / Edytuj studenta";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox zad_indeks;
        private System.Windows.Forms.TextBox zad_imie;
        private System.Windows.Forms.TextBox zad_nazwisko;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}
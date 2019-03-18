using System.Collections.Generic;

namespace BazaStudentow
{
    partial class Form1
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dbs_studenci = new System.Windows.Forms.DataGridView();
            this.nr_semestru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.przedmiotClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dod_ocen = new System.Windows.Forms.Button();
            this.usun_ocen = new System.Windows.Forms.Button();
            this.tekskt1 = new System.Windows.Forms.Label();
            this.wczyt_stud = new System.Windows.Forms.Button();
            this.usu_stud = new System.Windows.Forms.Button();
            this.edyt_stud = new System.Windows.Forms.Button();
            this.btn_dodaj = new System.Windows.Forms.Button();
            this.wczyt_oceny = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.indeksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dbs_studenci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przedmiotClassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentClassBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_studenci
            // 
            this.dbs_studenci.AllowUserToAddRows = false;
            this.dbs_studenci.AllowUserToDeleteRows = false;
            this.dbs_studenci.AutoGenerateColumns = false;
            this.dbs_studenci.BackgroundColor = System.Drawing.Color.White;
            this.dbs_studenci.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dbs_studenci.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dbs_studenci.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dbs_studenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbs_studenci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indeksDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.nr_semestru});
            this.dbs_studenci.DataSource = this.studentClassBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dbs_studenci.DefaultCellStyle = dataGridViewCellStyle2;
            this.dbs_studenci.Location = new System.Drawing.Point(14, 125);
            this.dbs_studenci.Margin = new System.Windows.Forms.Padding(4);
            this.dbs_studenci.Name = "dbs_studenci";
            this.dbs_studenci.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dbs_studenci.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dbs_studenci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dbs_studenci.Size = new System.Drawing.Size(571, 285);
            this.dbs_studenci.TabIndex = 0;
            this.dbs_studenci.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_studenci_CellContentClick);
            this.dbs_studenci.SelectionChanged += new System.EventHandler(this.dgv_studenci_SelectionChanged);
            // nr_semestru
            this.nr_semestru.DataPropertyName = "nr_semestru";
            this.nr_semestru.HeaderText = "nr_semestru";
            this.nr_semestru.Name = "nr_semestru";
            this.nr_semestru.ReadOnly = true;
            this.nr_semestru.Width = 130;
            this.przedmiotClassBindingSource.DataSource = typeof(System.Collections.Generic.Dictionary<string, double>);
            // dod_ocen
            this.dod_ocen.Enabled = false;
            this.dod_ocen.Location = new System.Drawing.Point(618, 16);
            this.dod_ocen.Margin = new System.Windows.Forms.Padding(4);
            this.dod_ocen.Name = "dod_ocen";
            this.dod_ocen.Size = new System.Drawing.Size(137, 26);
            this.dod_ocen.TabIndex = 5;
            this.dod_ocen.Text = "Dodaj ocenę";
            this.dod_ocen.UseVisualStyleBackColor = true;
            this.dod_ocen.Click += new System.EventHandler(this.Button2_Click);
            // usun_ocen
            this.usun_ocen.Enabled = false;
            this.usun_ocen.Location = new System.Drawing.Point(763, 17);
            this.usun_ocen.Margin = new System.Windows.Forms.Padding(4);
            this.usun_ocen.Name = "button5";
            this.usun_ocen.Size = new System.Drawing.Size(137, 25);
            this.usun_ocen.TabIndex = 10;
            this.usun_ocen.Text = "Usuń ocenę";
            this.usun_ocen.UseVisualStyleBackColor = true;
            this.usun_ocen.Click += new System.EventHandler(this.Button5_Click);
            // label7
            this.tekskt1.AutoSize = true;
            this.tekskt1.BackColor = System.Drawing.Color.Transparent;
            this.tekskt1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tekskt1.Location = new System.Drawing.Point(114, 80);
            this.tekskt1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tekskt1.Name = "label7";
            this.tekskt1.Size = new System.Drawing.Size(259, 24);
            this.tekskt1.TabIndex = 12;
            this.tekskt1.Text = "Lista przedmiotów i ocen studenta";
            // wczyt_stud
            this.wczyt_stud.Location = new System.Drawing.Point(448, 15);
            this.wczyt_stud.Margin = new System.Windows.Forms.Padding(4);
            this.wczyt_stud.Name = "button8";
            this.wczyt_stud.Size = new System.Drawing.Size(137, 27);
            this.wczyt_stud.TabIndex = 16;
            this.wczyt_stud.Text = "Wczytaj Studentów";
            this.wczyt_stud.UseVisualStyleBackColor = true;
            // usu_stud
            this.usu_stud.Location = new System.Drawing.Point(303, 15);
            this.usu_stud.Margin = new System.Windows.Forms.Padding(4);
            this.usu_stud.Name = "button3";
            this.usu_stud.Size = new System.Drawing.Size(137, 26);
            this.usu_stud.TabIndex = 7;
            this.usu_stud.Text = "Usuń studenta";
            this.usu_stud.UseVisualStyleBackColor = true;
            this.usu_stud.Click += new System.EventHandler(this.Button3_Click);
            // edyt_stud
            this.edyt_stud.Location = new System.Drawing.Point(158, 14);
            this.edyt_stud.Margin = new System.Windows.Forms.Padding(4);
            this.edyt_stud.Name = "button1";
            this.edyt_stud.Size = new System.Drawing.Size(137, 27);
            this.edyt_stud.TabIndex = 6;
            this.edyt_stud.Text = "Edytuj studenta";
            this.edyt_stud.UseVisualStyleBackColor = true;
            this.edyt_stud.Click += new System.EventHandler(this.Button1_Click_2); 
            // btn_dodaj
            this.btn_dodaj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_dodaj.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_dodaj.Location = new System.Drawing.Point(13, 13);
            this.btn_dodaj.Margin = new System.Windows.Forms.Padding(4);
            this.btn_dodaj.Name = "btn_dodaj";
            this.btn_dodaj.Size = new System.Drawing.Size(137, 28);
            this.btn_dodaj.TabIndex = 1;
            this.btn_dodaj.Text = "Dodaj studenta";
            this.btn_dodaj.UseVisualStyleBackColor = true;
            this.btn_dodaj.Click += new System.EventHandler(this.Button1_Click);
            // wczyt_oceny (nie działa)
            this.wczyt_oceny.Location = new System.Drawing.Point(909, 17);
            this.wczyt_oceny.Margin = new System.Windows.Forms.Padding(4);
            this.wczyt_oceny.Name = "button9";
            this.wczyt_oceny.Size = new System.Drawing.Size(137, 26);
            this.wczyt_oceny.TabIndex = 17;
            this.wczyt_oceny.Text = "Wczytaj Oceny";
            this.wczyt_oceny.UseVisualStyleBackColor = true;
            // tabelka
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView2.DataSource = this.przedmiotClassBindingSource;
            this.dataGridView2.Enabled = false;
            this.dataGridView2.Location = new System.Drawing.Point(619, 125);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(427, 285);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(767, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Słowniczek ocen";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // indeksDataGridViewTextBoxColumn
            this.indeksDataGridViewTextBoxColumn.DataPropertyName = "indeks";
            this.indeksDataGridViewTextBoxColumn.HeaderText = "indeks";
            this.indeksDataGridViewTextBoxColumn.Name = "indeksDataGridViewTextBoxColumn";
            this.indeksDataGridViewTextBoxColumn.ReadOnly = true;
            // imieDataGridViewTextBoxColumn
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "imie";
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            this.imieDataGridViewTextBoxColumn.ReadOnly = true;
            this.imieDataGridViewTextBoxColumn.Width = 150;
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            this.nazwiskoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazwiskoDataGridViewTextBoxColumn.Width = 150;
            // studentClassBindingSource
            this.studentClassBindingSource.DataSource = typeof(BazaStudentow.Class.StudentClass);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "nazwa";
            this.Column1.HeaderText = "Przedmiot";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 245;
            // Column2
            this.Column2.DataPropertyName = "ocena";
            this.Column2.HeaderText = "Ocena";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 135;
            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 433);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wczyt_oceny);
            this.Controls.Add(this.wczyt_stud);
            this.Controls.Add(this.tekskt1);
            this.Controls.Add(this.usun_ocen);
            this.Controls.Add(this.dbs_studenci);
            this.Controls.Add(this.usu_stud);
            this.Controls.Add(this.edyt_stud);
            this.Controls.Add(this.dod_ocen);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btn_dodaj);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbs_studenci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przedmiotClassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentClassBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dbs_studenci;
        private System.Windows.Forms.Button btn_dodaj;
        private System.Windows.Forms.BindingSource studentClassBindingSource;
        private System.Windows.Forms.BindingSource przedmiotClassBindingSource;
        private System.Windows.Forms.Button dod_ocen;
        private System.Windows.Forms.Button edyt_stud;
        private System.Windows.Forms.Button usu_stud;
        private System.Windows.Forms.Button usun_ocen;
        private System.Windows.Forms.Label tekskt1;
        private System.Windows.Forms.Button wczyt_stud;
        private System.Windows.Forms.Button wczyt_oceny;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn indeksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nr_semestru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}


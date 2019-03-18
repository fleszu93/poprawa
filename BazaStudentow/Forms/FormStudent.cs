using System;
using System.Windows.Forms;

namespace BazaStudentow.Forms
{
    public partial class FormStudent : Form
    {

        public Class.StudentClass student;

        private void button1_Click(object sender, EventArgs e)
        {
            student.imie = zad_imie.Text;
            student.nazwisko = zad_nazwisko.Text;
            student.nr_semestru = (int)numericUpDown1.Value;
            DialogResult = DialogResult.OK;
        }

        public FormStudent(Class.StudentClass student)
        {
            InitializeComponent();
            this.student = student;
            zad_imie.Text = student.imie;
            zad_nazwisko.Text = student.nazwisko;
            zad_indeks.Text = student.indeks.ToString();
        }

       

    

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

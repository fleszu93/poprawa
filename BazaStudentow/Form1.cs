using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BazaStudentow
{
    public partial class Form1 : Form
    {

        BindingList<Class.StudentClass> lista_studentow = new BindingList<Class.StudentClass>();

        public Form1()
        {
            InitializeComponent();
            dbs_studenci.AutoGenerateColumns = false;
            studentClassBindingSource.DataSource = lista_studentow;
            dbs_studenci.DataSource = studentClassBindingSource;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Forms.FormStudent add_new_student = new Forms.FormStudent(new Class.StudentClass());

            if (add_new_student.ShowDialog() == DialogResult.OK)
            {
                add_new_student.student.indeks = (lista_studentow.Count > 0) ? lista_studentow.Select(x => x.indeks).Max() + 1 : 1;
                lista_studentow.Add(add_new_student.student);
            }
        }

        private void dgv_studenci_SelectionChanged(object sender, EventArgs e)
        {
            if(lista_studentow.Count > 0)
            {
                przedmiotClassBindingSource.DataSource = (studentClassBindingSource.Current as Class.StudentClass).lista_ocen;
                dod_ocen.Enabled = true;
                if((studentClassBindingSource.Current as Class.StudentClass).lista_ocen.Count > 0)
                {
                    usun_ocen.Enabled = true;
                }
                else
                {
                    usun_ocen.Enabled = false;
                }
            }
            else
            {
                dod_ocen.Enabled = false;
            }
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            Class.PrzedmiotClass przedmiot = new Class.PrzedmiotClass();
            Forms.FormOcena add_ocena = new Forms.FormOcena(przedmiot);

            if(add_ocena.ShowDialog() == DialogResult.OK)
            {
                (studentClassBindingSource.Current as Class.StudentClass).lista_ocen.Add(add_ocena.przedmiot);
            }
        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            
                Forms.FormStudent add_new_student = new Forms.FormStudent(studentClassBindingSource.Current as Class.StudentClass);
                if (add_new_student.ShowDialog() == DialogResult.OK)
                {

                }
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            lista_studentow.Remove(studentClassBindingSource.Current as Class.StudentClass);
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if((studentClassBindingSource.Current as Class.StudentClass).lista_ocen.Count > 0)
            {
                usun_ocen.Enabled = true;
            }
            else
            {

            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            (studentClassBindingSource.Current as Class.StudentClass).lista_ocen.Remove(przedmiotClassBindingSource.Current as Class.PrzedmiotClass);
            if ((studentClassBindingSource.Current as Class.StudentClass).lista_ocen.Count > 0)
            {
                usun_ocen.Enabled = true;
            }
            else
            {
                usun_ocen.Enabled = false;
            }
        }

   

       



        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

       

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Dgv_studenci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

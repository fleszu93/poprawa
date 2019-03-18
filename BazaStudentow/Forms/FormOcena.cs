using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BazaStudentow.Forms
{
    public partial class FormOcena : Form
    {
        public Class.PrzedmiotClass przedmiot;

        public FormOcena(Class.PrzedmiotClass przedmiot)
        {
            InitializeComponent();
            this.przedmiot = przedmiot;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            przedmiot.nazwa = comboBox1.Text;
            przedmiot.ocena = ocena.Value;
            DialogResult = DialogResult.OK;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ocena_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void FormOcena_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaStudentow.Class
{
    public class StudentClass
    {

        public int indeks { get; set; }
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public int? nr_semestru { get; set; }
        public BindingList<PrzedmiotClass> lista_ocen = new BindingList<PrzedmiotClass>(); 
        public double? srednia_ocen { get; set; }
    }
    
    public class PrzedmiotClass
    {
        public string nazwa { get; set;}
        public decimal ocena { get; set; }
    }

    
}

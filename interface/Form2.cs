using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        { }

        public static int examsNumber;
        public static int studentsNumber;
        public static int[,] graph;

        private void Dalej_Click(object sender, EventArgs e)
        {
            graph = new int[examsNumber, examsNumber];
            Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();   
        }

        public void listaEgzamin_ValueChanged(object sender, EventArgs e)
        {
            examsNumber = Convert.ToInt32(listaEgzamin.Value);
        }

        private void listaStudent_ValueChanged(object sender, EventArgs e)
        {
            studentsNumber = Convert.ToInt32(listaStudent.Value);
        }
    }
}

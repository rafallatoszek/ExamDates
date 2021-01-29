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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            egz.Add(egz1);
            egz.Add(egz2);
            egz.Add(egz3);
            egz.Add(egz4);
            egz.Add(egz5);
            egz.Add(egz6);
            egz.Add(egz7);
            egz.Add(egz8);
            egz.Add(egz9);
            for (int i = Form2.examsNumber; i < egz.Count; i++)
            {
                egz[i].Visible = false;
            }
        }

        List<CheckBox> egz = new List<CheckBox>();
        public static int nrStudenta = 1;
        public static int[,] graph = Form2.graph;
        public static int[] color; // ZA POMOCA TEJ TABLICY ROBIMY TABELKE, GDZIE INDEKSY TO NUMER EGZAMINU, A WARTOSC(KOLOR) TO TERMIN

        private void Clear()
        {
            for (int i = 0; i < Form2.examsNumber; i++)
            {
                egz[i].Checked = false;
            }
        }

        private void Następny_Click(object sender, EventArgs e)
        {
            ++nrStudenta;
            List<int> list = new List<int>();
            for (int i = 0; i < Form2.examsNumber; i++)
            {
                if (egz[i].Checked)
                    list.Add(i);
            }
            Clear();
            graph = Coloring.Connect(list, graph);
            if (nrStudenta == Form2.studentsNumber)
            {
                Następny.Text = "Pokaż rozkład egzaminów";
            }
            if (nrStudenta > Form2.studentsNumber)
            {
                color = Coloring.GraphColoring(graph);
                Form4 f4 = new Form4();
                f4.ShowDialog();
            }
            label2.Text = Convert.ToString(nrStudenta);
        }
    }
}

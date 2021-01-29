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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            labelRows.Add(label10);
            labelRows.Add(label11);
            labelRows.Add(label12);
            labelRows.Add(label13);
            labelRows.Add(label14);
            labelRows.Add(label15);
            labelRows.Add(label16);
            labelRows.Add(label17);
            labelRows.Add(label18);
            for (int i = Form2.examsNumber; i < labelRows.Count; i++)
            {
                labelRows[i].Visible = false;
            }

            //Całą tabelkę wypełniam labelami z tekstem X i od razu ustawiam na niewidoczne 
            w1.Add(k11);
            w1.Add(k12);
            w1.Add(k13);
            w1.Add(k14);
            w1.Add(k15);
            w1.Add(k16);
            w1.Add(k17);
            w1.Add(k18);
            w1.Add(k19);
            for (int i = 0; i < w1.Count; i++)
            {
                w1[i].Visible = false;
            }

            w2.Add(k21);
            w2.Add(k22);
            w2.Add(k23);
            w2.Add(k24);
            w2.Add(k25);
            w2.Add(k26);
            w2.Add(k27);
            w2.Add(k28);
            w2.Add(k29);
            for (int i = 0; i < w2.Count; i++)
            {
                w2[i].Visible = false;
            }

            w3.Add(k31);
            w3.Add(k32);
            w3.Add(k33);
            w3.Add(k34);
            w3.Add(k35);
            w3.Add(k36);
            w3.Add(k37);
            w3.Add(k38);
            w3.Add(k39);
            for (int i = 0; i < w3.Count; i++)
            {
                w3[i].Visible = false;
            }

            w4.Add(k41);
            w4.Add(k42);
            w4.Add(k43);
            w4.Add(k44);
            w4.Add(k45);
            w4.Add(k46);
            w4.Add(k47);
            w4.Add(k48);
            w4.Add(k49);
            for (int i = 0; i < w4.Count; i++)
            {
                w4[i].Visible = false;
            }

            w5.Add(k51);
            w5.Add(k52);
            w5.Add(k53);
            w5.Add(k54);
            w5.Add(k55);
            w5.Add(k56);
            w5.Add(k57);
            w5.Add(k58);
            w5.Add(k59);
            for (int i = 0; i < w5.Count; i++)
            {
                w5[i].Visible = false;
            }

            w6.Add(k61);
            w6.Add(k62);
            w6.Add(k63);
            w6.Add(k64);
            w6.Add(k65);
            w6.Add(k66);
            w6.Add(k67);
            w6.Add(k68);
            w6.Add(k69);
            for (int i = 0; i < w6.Count; i++)
            {
                w6[i].Visible = false;
            }

            w7.Add(k71);
            w7.Add(k72);
            w7.Add(k73);
            w7.Add(k74);
            w7.Add(k75);
            w7.Add(k76);
            w7.Add(k77);
            w7.Add(k78);
            w7.Add(k79);
            for (int i = 0; i < w7.Count; i++)
            {
                w7[i].Visible = false;
            }

            w8.Add(k81);
            w8.Add(k82);
            w8.Add(k83);
            w8.Add(k84);
            w8.Add(k85);
            w8.Add(k86);
            w8.Add(k87);
            w8.Add(k88);
            w8.Add(k89);
            for (int i = 0; i < w8.Count; i++)
            {
                w8[i].Visible = false;
            }

            w9.Add(k91);
            w9.Add(k92);
            w9.Add(k93);
            w9.Add(k94);
            w9.Add(k95);
            w9.Add(k96);
            w9.Add(k97);
            w9.Add(k98);
            w9.Add(k99);
            for (int i = 0; i < w9.Count; i++)
            {
                w9[i].Visible = false;
            }

            komórki.Add(w1);
            komórki.Add(w2);
            komórki.Add(w3);
            komórki.Add(w4);
            komórki.Add(w5);
            komórki.Add(w6);
            komórki.Add(w7);
            komórki.Add(w8);
            komórki.Add(w9);


            //tutaj sprawdzam zgodność z tablicą color, wszystkie listy są niżej opisane
            //na tym drugim indeksie jest odwołanie do wybranej listy(od w1 do w9)
            for (int i = 0; i < Form2.examsNumber; i++)
            {
                if (Form3.color[i] == 1)
                {
                    komórki[i][0].Visible = true;
                }
                else if (Form3.color[i] == 2)
                {
                    komórki[i][1].Visible = true;
                }
                else if (Form3.color[i] == 3)
                {
                    komórki[i][2].Visible = true;
                }
                else if (Form3.color[i] == 4)
                {
                    komórki[i][3].Visible = true;
                }
                else if (Form3.color[i] == 5)
                {
                    komórki[i][4].Visible = true;
                }
                else if (Form3.color[i] == 6)
                {
                    komórki[i][5].Visible = true;
                }
                else if (Form3.color[i] == 7)
                {
                    komórki[i][6].Visible = true;
                }
                else if (Form3.color[i] == 8)
                {
                    komórki[i][7].Visible = true;
                }
                else
                {
                    komórki[i][8].Visible = true;
                }
            }

        }
        List<Label> labelRows = new List<Label>(); //dzięki tej zmiennej ustalam, ile wierszy z egzaminami ma się pojawić 
        List<Label> w1 = new List<Label>(); //każdy wiersz ma przeznaczoną jedną listę (od w1 do w9)
        List<Label> w2 = new List<Label>();
        List<Label> w3 = new List<Label>();
        List<Label> w4 = new List<Label>();
        List<Label> w5 = new List<Label>();
        List<Label> w6 = new List<Label>();
        List<Label> w7 = new List<Label>();
        List<Label> w8 = new List<Label>();
        List<Label> w9 = new List<Label>();

        // lista zawierająca pozostałe listy, żeby nie przechodić niepotrzebnie po pozostałych listach, 
        //jeżeli nie będzie danego egzaminu
        List<List<Label>> komórki = new List<List<Label>>();
        private void Zakończ_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

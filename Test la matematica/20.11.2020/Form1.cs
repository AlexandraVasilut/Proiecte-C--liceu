using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20._11._2020
{
    public partial class Forma_principala : Form
    {
        int a, b, c = 0, i=0, r;
        //a, b variabile
        //c=punctajul
        //i=contor intrebari
        public Forma_principala()
        {
            InitializeComponent();
            button_punctaj.Enabled = false;
            //incepator
            button_1suma.Enabled = false;//pt suma
            textBox11.Enabled = false;//scriu raspunsurile
            button_vrsuma.Enabled = false;
            button_3modulo.Enabled = false;//pt rest/modulo
            textBox12.Enabled = false;
            button_vrrest.Enabled = false;
            button_2cat.Enabled = false;//pt impartire/cat
            textBox13.Enabled = false;
            button_vrcat.Enabled = false;
            //avansat
            button_21suma.Enabled = false;//pt suma
            textBox21.Enabled = false;
            button_21vrsuma.Enabled = false;
            button_22cat.Enabled = false;//pt cat
            textBox22.Enabled = false;
            button_22vrcat.Enabled = false;
            button_23rest.Enabled = false;//pt rest
            textBox23.Enabled = false;
            button_23vrrest.Enabled = false;
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            //incepe testul
            button_1suma.BackColor = Color.SkyBlue;
            button_1suma.Enabled = true;
            button_start.Text = "Testul a început! Răspuns corect +2, răspuns greșit -1!";
            button_start.BackColor = Color.PaleTurquoise;
            button_start.Enabled = false;
            button_punctaj.Enabled = false;

            button_iesire.Enabled = false;  //cand termin proiectul
            button_iesire.BackColor = Color.Red;
        }

        private void button_autor_Click(object sender, EventArgs e)
        {
            button_autor.Text = "Vasilut Alexandra";
        }



                                                   //INCEPATOR
        private void button_1suma_Click(object sender, EventArgs e)
        {
            //generare intrebare
            i++;
            Random r = new Random();//cifre aleatorii
            a = r.Next(1, 9);//un a din intervalul 1,9
            b = r.Next(1, 9);//un b din intervalul 1,9
            button_1suma.Text = "Suma: " + a + "+" + b;
            textBox11.Enabled = true;
            textBox11.Text = "";//ca sa pot scrie raspunsul
            button_vrsuma.Text = "Verifică!";
            button_vrsuma.Enabled = true;
            if (i == 5)
            {
                button_1suma.BackColor = Color.PaleTurquoise;
                button_1suma.Text = "Ai terminat seria cu" + c + "puncte";
                textBox11.BackColor = Color.PaleTurquoise;
                textBox11.Enabled = false;
                button_1suma.Enabled = false;
                button_vrsuma.BackColor = Color.PaleTurquoise;
                button_vrsuma.Enabled = false;
                button_2cat.Enabled = true;
            }
        }

        private void button_vrsuma_Click(object sender, EventArgs e)
        {
            //generare verificare intrebare 1
            if (textBox11.Text == "")
            {
                MessageBox.Show("!!Scrie rezultatul!!");
            }
            else
            {
                button_vrsuma.Enabled = true;
                textBox11.Enabled = false;
                if (a + b == int.Parse(textBox11.Text))
                {
                    textBox11.Text = "Bravo!";
                    button_1suma.Enabled = true;
                    button_vrsuma.Enabled = false;
                    textBox11.Enabled = false;
                    c += 2;
                }
                else
                {
                    button_vrsuma.BackColor = Color.Red;
                    textBox11.Text = "Mai încearcă!";
                    button_1suma.Enabled = false;
                    textBox11.Text = "";
                    textBox11.Enabled = true;
                    button_vrsuma.Enabled = true;
                    c = c - 1;
                }
            }
            button_punctaj.Text = "Punctajul este: " + c;
            //am terminat prima serie de intrebari
            if (i == 5)
            {
                button_vrsuma.Text = "Următoarea serie!";
                button_vrsuma.Text = "Ai terminat seria cu" + c + "punctaj!";
                textBox11.Enabled = false;
                button_vrsuma.Enabled = false;
                button_1suma.Enabled = false;
                button_2cat.Enabled = true;
            }
            //am terminat verificarea la prima serie de intrebari la suma
        }

        private void button_2cat_Click(object sender, EventArgs e)
        {
            //generare intrebare
            i++;
            Random r = new Random();//cifre aleatorii
            a = r.Next(1, 9);//un a din intervalul 1,9
            b = r.Next(1, 9);//un b din intervalul 1,9
            button_2cat.Text = "Câtul: " + a + ":" + b;
            textBox13.Enabled = true;
            textBox13.Text = "";//ca sa pot scrie raspunsul
            button_vrcat.Text = "Verifică!";
            button_vrcat.Enabled = true;
            if (i == 10)
            {
                button_2cat.BackColor = Color.PaleTurquoise;
                button_2cat.Text = "Ai terminat seria cu" + c + "puncte";
                textBox13.BackColor = Color.PaleTurquoise;
                textBox13.Enabled = false;
                button_2cat.Enabled = false;
                button_vrcat.BackColor = Color.PaleTurquoise;
                button_vrcat.Enabled = false;
                button_3modulo.Enabled = true;
            }
        }

        private void button_vrcat_Click(object sender, EventArgs e)
        {
            //generare verificare intrebare 1
            if (textBox13.Text == "")
            {
                MessageBox.Show("!!Scrie rezultatul!!");
            }
            else
            {
                button_vrcat.Enabled = true;
                textBox13.Enabled = false;
                if (a / b == int.Parse(textBox13.Text))
                {
                    textBox13.Text = "Bravo!";
                    button_2cat.Enabled = true;
                    button_vrcat.Enabled = false;
                    textBox13.Enabled = false;
                    c += 2;
                }
                else
                {
                    button_vrcat.BackColor = Color.Red;
                    textBox13.Text = "Mai încearcă!";
                    button_2cat.Enabled = false;
                    textBox13.Text = "";
                    textBox13.Enabled = true;
                    button_vrcat.Enabled = true;
                    c = c - 1;
                }
            }
            button_punctaj.Text = "Punctajul este: " + c;
            //am terminat prima serie de intrebari
            if (i == 10)
            {
                button_vrcat.Text = "Următoarea serie!";
                button_vrcat.Text = "Ai terminat seria cu" + c + "punctaj!";
                textBox13.Enabled = false;
                button_vrcat.Enabled = false;
                button_2cat.Enabled = false;
                button_3modulo.Enabled = true;
            }
            //am terminat verificarea la prima serie de intrebari la cat
        }

        private void button_3modulo_Click(object sender, EventArgs e)
        {
            //generare intrebare
            i++;
            Random r = new Random();//cifre aleatorii
            a = r.Next(1, 9);//un a din intervalul 1,9
            b = r.Next(1, 9);//un b din intervalul 1,9
            button_3modulo.Text = "Rest: " + a + ":" + b;
            textBox12.Enabled = true;
            textBox12.Text = "";//ca sa pot scrie raspunsul
            button_vrrest.Text = "Verifică!";
            button_vrrest.Enabled = true;
            if (i == 15)
            {
                button_3modulo.BackColor = Color.PaleTurquoise;
                button_3modulo.Text = "Ai terminat seria cu" + c + "puncte";
                textBox12.BackColor = Color.PaleTurquoise;
                textBox12.Enabled = false;
                button_3modulo.Enabled = false;
                button_vrrest.BackColor = Color.PaleTurquoise;
                button_vrrest.Enabled = false;
                button_21suma.Enabled = true;
            }
        }

        private void button_vrrest_Click(object sender, EventArgs e)
        {
            //generare verificare intrebare 1
            if (textBox12.Text == "")
            {
                MessageBox.Show("!!Scrie rezultatul!!");
            }
            else
            {
                button_vrrest.Enabled = true;
                textBox12.Enabled = false;
                if (a % b == int.Parse(textBox12.Text))
                {
                    textBox12.Text = "Bravo!";
                    button_3modulo.Enabled = true;
                    button_vrrest.Enabled = false;
                    textBox12.Enabled = false;
                    c += 2;
                }
                else
                {
                    button_vrrest.BackColor = Color.Red;
                    textBox12.Text = "Mai încearcă!";
                    button_3modulo.Enabled = false;
                    textBox12.Text = "";
                    textBox12.Enabled = true;
                    button_vrrest.Enabled = true;
                    c = c - 1;
                }
            }
            button_punctaj.Text = "Punctajul este: " + c;
            //am terminat prima serie de intrebari
            if (i == 15)
            {
                button_vrrest.Text = "Următoarea serie!";
                button_vrrest.Text = "Ai terminat seria cu" + c + "punctaj!";
                textBox12.Enabled = false;
                button_vrrest.Enabled = false;
                button_3modulo.Enabled = false;
                button_21suma.Enabled = true;
            }
            //am terminat verificarea la prima serie de intrebari la rest
        }

                                            //AVANSAT
        private void button_21suma_Click(object sender, EventArgs e)
        {
            //generare intrebare
            i++;
            Random r = new Random();//cifre aleatorii
            a = r.Next(10, 99);//un a din intervalul 10,99
            b = r.Next(10, 99);//un b din intervalul 10,99
            button_21suma.Text = "Suma: " + a + "+" + b;
            textBox21.Enabled = true;
            textBox21.Text = "";//ca sa pot scrie raspunsul
            button_21vrsuma.Text = "Verifică!";
            button_21vrsuma.Enabled = true;
            if (i == 20)
            {
                button_21suma.BackColor = Color.PaleTurquoise;
                button_21suma.Text = "Ai terminat seria cu" + c + "puncte";
                textBox21.BackColor = Color.PaleTurquoise;
                textBox21.Enabled = false;
                button_21suma.Enabled = false;
                button_21vrsuma.BackColor = Color.PaleTurquoise;
                button_21vrsuma.Enabled = false;
                button_22cat.Enabled = true;
            }
        }

        private void button_21vrsuma_Click(object sender, EventArgs e)
        {
            //generare verificare intrebare 1
            if (textBox21.Text == "")
            {
                MessageBox.Show("!!Scrie rezultatul!!");
            }
            else
            {
                button_21vrsuma.Enabled = true;
                textBox21.Enabled = false;
                if (a + b == int.Parse(textBox21.Text))
                {
                    textBox21.Text = "Bravo!";
                    button_21suma.Enabled = true;
                    button_21vrsuma.Enabled = false;
                    textBox21.Enabled = false;
                    c += 2;
                }
                else
                {
                    button_21vrsuma.BackColor = Color.Red;
                    textBox21.Text = "Mai încearcă!";
                    button_21suma.Enabled = false;
                    textBox21.Text = "";
                    textBox21.Enabled = true;
                    button_21vrsuma.Enabled = true;
                    c = c - 1;
                }
            }
            button_punctaj.Text = "Punctajul este: " + c;
            //am terminat prima serie de intrebari
            if (i == 20)
            {
                button_21vrsuma.Text = "Următoarea serie!";
                button_21vrsuma.Text = "Ai terminat seria cu" + c + "punctaj!";
                textBox21.Enabled = false;
                button_21vrsuma.Enabled = false;
                button_21suma.Enabled = false;
                button_22cat.Enabled = true;
            }
            //am terminat verificarea la prima serie de intrebari la suma la mediu
        }

        private void button_22cat_Click(object sender, EventArgs e)
        {
            //generare intrebare
            i++;
            Random r = new Random();//cifre aleatorii
            a = r.Next(10, 99);//un a din intervalul 10,99
            b = r.Next(10, 99);//un b din intervalul 10,99
            button_22cat.Text = "Câtul: " + a + ":" + b;
            textBox22.Enabled = true;
            textBox22.Text = "";//ca sa pot scrie raspunsul
            button_22vrcat.Text = "Verifică!";
            button_22vrcat.Enabled = true;
            if (i == 25)
            {
                button_22cat.BackColor = Color.PaleTurquoise;
                button_22cat.Text = "Ai terminat seria cu" + c + "puncte";
                textBox22.BackColor = Color.PaleTurquoise;
                textBox22.Enabled = false;
                button_22cat.Enabled = false;
                button_22vrcat.BackColor = Color.PaleTurquoise;
                button_22vrcat.Enabled = false;
                button_23rest.Enabled = true;
            }
        }

        private void button_22vrcat_Click(object sender, EventArgs e)
        {
            //generare verificare intrebare 1
            if (textBox22.Text == "")
            {
                MessageBox.Show("!!Scrie rezultatul!!");
            }
            else
            {
                button_22vrcat.Enabled = true;
                textBox22.Enabled = false;
                if (a / b == int.Parse(textBox22.Text))
                {
                    textBox22.Text = "Bravo!";
                    button_22cat.Enabled = true;
                    button_22vrcat.Enabled = false;
                    textBox22.Enabled = false;
                    c += 2;
                }
                else
                {
                    button_22vrcat.BackColor = Color.Red;
                    textBox22.Text = "Mai încearcă!";
                    button_22cat.Enabled = false;
                    textBox22.Text = "";
                    textBox22.Enabled = true;
                    button_22vrcat.Enabled = true;
                    c = c - 1;
                }
            }
            button_punctaj.Text = "Punctajul este: " + c;
            //am terminat prima serie de intrebari
            if (i == 25)
            {
                button_22vrcat.Text = "Următoarea serie!";
                button_22vrcat.Text = "Ai terminat seria cu" + c + "punctaj!";
                textBox22.Enabled = false;
                button_22vrcat.Enabled = false;
                button_22cat.Enabled = false;
                button_23rest.Enabled = true;
            }
            //am terminat verificarea la prima serie de intrebari la cat la mediu
        }

        private void button_23rest_Click(object sender, EventArgs e)
        {
            //generare intrebare
            i++;
            Random r = new Random();//cifre aleatorii
            a = r.Next(10, 99);//un a din intervalul 10,99
            b = r.Next(10, 99);//un b din intervalul 10,99
            button_23rest.Text = "Câtul: " + a + ":" + b;
            textBox23.Enabled = true;
            textBox23.Text = "";//ca sa pot scrie raspunsul
            button_23vrrest.Text = "Verifică!";
            button_23vrrest.Enabled = true;
            if (i == 30)
            {
                button_23rest.BackColor = Color.PaleTurquoise;
                button_23rest.Text = "Ai terminat seria cu" + c + "puncte";
                textBox23.BackColor = Color.PaleTurquoise;
                textBox23.Enabled = false;
                button_23rest.Enabled = false;
                button_23vrrest.BackColor = Color.PaleTurquoise;
                button_23vrrest.Enabled = false;
                button_iesire.BackColor = Color.SkyBlue;
                button_iesire.Enabled = true;
            }
        }

        private void button_23vrrest_Click(object sender, EventArgs e)
        {
            //generare verificare intrebare 1
            if (textBox23.Text == "")
            {
                MessageBox.Show("!!Scrie rezultatul!!");
            }
            else
            {
                button_23vrrest.Enabled = true;
                textBox23.Enabled = false;
                if (a % b == int.Parse(textBox23.Text))
                {
                    textBox23.Text = "Bravo!";
                    button_23rest.Enabled = true;
                    button_23vrrest.Enabled = false;
                    textBox23.Enabled = false;
                    c += 2;
                }
                else
                {
                    button_23vrrest.BackColor = Color.Red;
                    textBox23.Text = "Mai încearcă!";
                    button_23rest.Enabled = false;
                    textBox23.Text = "";
                    textBox23.Enabled = true;
                    button_23vrrest.Enabled = true;
                    c = c - 1;
                }
            }
            button_punctaj.Text = "Punctajul este: " + c;
            //am terminat prima serie de intrebari
            if (i == 30)
            {
                button_23vrrest.Text = "Următoarea serie!";
                button_23vrrest.Text = "Ai terminat seria cu" + c + "punctaj!";
                textBox23.Enabled = false;
                button_23vrrest.Enabled = false;
                button_23rest.Enabled = false;
                button_iesire.BackColor = Color.SkyBlue;
                button_iesire.Enabled = true;
            }
            //am terminat verificarea la prima serie de intrebari la rest la mediu
        }

        private void buton_iesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Forma_principala_Load(object sender, EventArgs e)
        {

        }
    }
}

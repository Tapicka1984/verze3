using System.Configuration;

namespace nákladní_vozidlo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            groupBox2.Visible = false;
            button4.Visible = false;
        }

        NakladniAuto Auto;
        VleckaZaAutem vlecka;
        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == string.Empty) || (textBox2.Text == string.Empty)||(textBox3.Text == string.Empty) || (textBox6.Text == string.Empty))
            {
                MessageBox.Show("zadej neco do vsech textboxu");
            }
            else
            {
                MessageBox.Show("dekuji");
                string SPZ = textBox2.Text;
                double hmotnost_nakladu = double.Parse(textBox3.Text);
                vlecka = new VleckaZaAutem(string.Empty, '\0', '\0', double.Parse(textBox6.Text));
                double nosnost = double.Parse(textBox1.Text) + vlecka.Vlecka_Nosnost();
                Auto = new NakladniAuto(SPZ, nosnost, hmotnost_nakladu);
                groupBox1.Visible = false;
                textBox6.Visible = false;
                label7.Visible = false;
                groupBox2.Visible = true;
                groupBox2.Location = new Point(12, 42);
                button4.Visible = true;
                label3.Text = "Step 2";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != String.Empty)
            {
                double naloz = double.Parse(textBox4.Text);
                MessageBox.Show(Auto.NalozNaklad(naloz));
            }
            else
            {
                MessageBox.Show("ctyrka ma prázdno");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox5.Text != String.Empty)
            {
                double vyloz = double.Parse(textBox5.Text);
                MessageBox.Show(Auto.Vyloz_Naklad(vyloz));
            }
            else
            {
                MessageBox.Show("petka ma prázdno");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(Auto.ToString());
            }
            catch
            {
                MessageBox.Show("možná zkuste prvne nastavit parametry?");
            }

        }
    }
}
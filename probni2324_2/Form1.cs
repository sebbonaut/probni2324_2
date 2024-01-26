using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace probni2324_2
{
    public partial class Form1 : Form
    {
        public List<Linija> linije = new List<Linija>()
        {
            new Linija("Zagreb", "Split", 150.21M,
                new DateTime(2024,02,10), 120),
            new Linija("Zagreb", "Copenhagen", 450.99M,
                new DateTime(2024,02,10), 50),
            new Linija("Copenhagen", "Split", 504.25M,
                new DateTime(2024,02,10), 74),
            new Linija("Split", "Zagreb", 140.89M,
                new DateTime(2024,02,11), 110)
        };
        public Form1()
        {
            InitializeComponent();
            Destinacije();
        }

        private void Destinacije()
        {
            List<string> destinacije1 = new List<string>(),
                destinacije2 = new List<string>();
            foreach (var linija in linije)
            {
                if (!destinacije1.Contains(linija.polaziste))
                    destinacije1.Add(linija.polaziste);
                if (!destinacije2.Contains(linija.odrediste))
                    destinacije2.Add(linija.odrediste);
            }
            comboPolazak.Items.Clear();
            foreach(var d in destinacije1)
                comboPolazak.Items.Add(d);
            comboDolazak.Items.Clear();
            foreach (var d in destinacije2)
                comboDolazak.Items.Add(d);
        }

        private void gumbPrikazSvih_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = linije;
        }

        private void informacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor: Sebastijan Horvat\n" +
                "Trenutno vrijeme: " + DateTime.Now, "Informacije");
        }

        private void dodajLinijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 dodaj = new Form2(linije);
            dodaj.ShowDialog();
            Destinacije();
            dataGridView1.Invalidate();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(sender is DataGridView d)
            {
                int indeksRetka = d.CurrentRow.Index;
                List<Linija> popis = d.DataSource as List<Linija>;
                MessageBox.Show(popis[indeksRetka].ToString(),
                    "Informacije o odabranoj liniji");
            }
        }

        private void textNaziv_TextChanged(object sender, EventArgs e)
        {
            List<Linija> popis = new List<Linija>();
            foreach(var linija in linije)
            {
                if(linija.polaziste.IndexOf(textNaziv.Text,
                    StringComparison.OrdinalIgnoreCase) >= 0
                  || linija.odrediste.IndexOf(textNaziv.Text, 
                  StringComparison.OrdinalIgnoreCase) >= 0)
                    popis.Add(linija);
            }
            dataGridView1.DataSource = popis;
        }

        private void odabirLinija(string p, string d)
        {
            List<Linija> popis = new List<Linija>();
            foreach (var linija in linije)
            {
                if((p == "" && d == linija.odrediste)
                    || (p == linija.polaziste && d == "")
                    || (p == linija.polaziste && d == linija.odrediste))
                    popis.Add((linija));
            }
            dataGridView1.DataSource = popis;
        }

        private void comboPolazak_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(sender is ComboBox c)
            {
                if (comboDolazak.SelectedIndex == -1)
                    odabirLinija(c.Text, "");
                else
                    odabirLinija(c.Text, comboDolazak.Text);
            }
        }

        private void comboDolazak_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox c)
            {
                if (comboPolazak.SelectedIndex == -1)
                    odabirLinija("", c.Text);
                else
                    odabirLinija(comboPolazak.Text, c.Text);
            }
        }
    }
}

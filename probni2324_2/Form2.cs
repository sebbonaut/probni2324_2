using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace probni2324_2
{
    public partial class Form2 : Form
    {
        public List<Linija> linije;
        public Form2(List<Linija> linije)
        {
            InitializeComponent();
            this.linije = linije;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gumbDodaj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPolazak.Text))
                MessageBox.Show("Morate unijeti mjesto polaska!");
            else if (string.IsNullOrWhiteSpace(textBoxDolazak.Text))
                MessageBox.Show("Morate unijeti mjesto dolaska!");
            else
            {
                Linija linija = new Linija(
                    textBoxPolazak.Text,
                    textBoxDolazak.Text,
                    numericCijena.Value,
                    monthCalendar1.SelectionStart,
                    (int)numericSlobodnaMjesta.Value
                );
                if (MessageBox.Show(linija.ToString(),
                    "Zelite li dodati sljedecu liniju:",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    linije.Add(linija);
                    Close();
                }
            }
        }
    }
}

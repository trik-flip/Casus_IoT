using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Deur_App
{
    public partial class MenuPasAanpassen : Form
    {
        public MenuPasAanpassen()
        {
            InitializeComponent();
        }

        private void btn_Uitloggen_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("U bent uitgelogd", "Uitloggen", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Inloggen inloggen = new Inloggen();
                inloggen.Show();
                this.Close();
            };
        }

        private void btn_MedewerkerPas_Click(object sender, EventArgs e)
        {
            MedewerkersPasAanpassen medewerkersPasAanpassen = new MedewerkersPasAanpassen();
            medewerkersPasAanpassen.Show();
            this.Hide();
        }

        private void btn_BezoekerPas_Click(object sender, EventArgs e)
        {
            BezoekersPasAanpassen bezoekersPasAanpassen = new BezoekersPasAanpassen();
            bezoekersPasAanpassen.Show();
            this.Hide();
        }

        private void btn_Annuleren_Click(object sender, EventArgs e)
        {
            HoofdmenuBeveiligingIT hoofdmenuBeveiligingIT = new HoofdmenuBeveiligingIT();
            hoofdmenuBeveiligingIT.Show();
            this.Close();
        }

        private void MenuPasAanpassen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Weet u het zeker?", "Afsluiten", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

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
    public partial class BezoekersPasAanpassen : Form
    {
        public BezoekersPasAanpassen()
        {
            InitializeComponent();
        }

        private void btn_Uitloggen_Click(object sender, EventArgs e)
        {
            //bij het uitloggen wordt gevraagd of de gebruiker het zeker weet, weet deze het zeker wordt het inlogscherm weergegeven.
            if (MessageBox.Show("Weet u het zeker?","Uitloggen", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Inloggen inloggen = new Inloggen();
                inloggen.Show();
                this.Hide();
            };
        }

        private void btn_Annuleren_Click(object sender, EventArgs e)
        {
            //Bij annuleren wordt het menu voor het aanpassen van een pas weergegeven
            MenuPasAanpassen menuPasAanpassen = new MenuPasAanpassen();
            menuPasAanpassen.Show();
            this.Close();
        }

        private void BezoekersPasAanpassen_FormClosing(object sender, FormClosingEventArgs e)
        {
            //als de gebruiker op het kruisje klikt wordt het inlogscherm weergegeven
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Weet u het zeker?", "Afsluiten", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                {
                    Inloggen inloggen = new Inloggen();
                    inloggen.Show();
                    this.Close();

                }
            }
        }

        private void btn_Aanpassen_Click(object sender, EventArgs e)
        {
            //TODO: Gegevens bezoeker ophalen, de gegevens update naar de database
            if (MessageBox.Show("Bezoekerspas is aangepast.", "Bezoekerspas aanpassen", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                MenuPasAanpassen menuPasAanpassen = new MenuPasAanpassen();
                menuPasAanpassen.Show();
                this.Close();
            }
        }

        private void bt_ZoekOuder_Click(object sender, EventArgs e)
        {
            //TODO: Zoeken naar bezoeker in de database
        }
    }
}

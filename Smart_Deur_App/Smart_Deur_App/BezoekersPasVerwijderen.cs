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
    public partial class BezoekersPasVerwijderen : Form
    {
        public BezoekersPasVerwijderen()
        {
            InitializeComponent();
        }

        private void btn_Uitloggen_Click(object sender, EventArgs e)
        {
            //bij het uitloggen wordt gevraagd of de gebruiker het zeker weet, weet deze het zeker wordt het inlogscherm weergegeven.
            if (MessageBox.Show("U bent uitgelogd", "Uitloggen", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Inloggen inloggen = new Inloggen();
                inloggen.Show();
                this.Hide();
            };
        }

        private void BezoekersPasVerwijderen_FormClosing(object sender, FormClosingEventArgs e)
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

            private void btn_Verwijderen_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bezoekerspas is verwijdert", "Bezoekerspas verwijderen", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                //TODO bezoekerpas verwijderen uit database
                MenuPasVerwijderen menuPasVerwijderen = new MenuPasVerwijderen();
                menuPasVerwijderen.Show();
                this.Close();
            }
        }

        private void btn_Annuleren_Click(object sender, EventArgs e)
        {
            //Bij annuleren wordt het menu voor het aanpassen van een pas weergegeven

            MenuPasVerwijderen menuPasVerwijderen = new MenuPasVerwijderen();
            menuPasVerwijderen.Show();
            this.Close();
        }

        private void btn_NaamZoeken_Click(object sender, EventArgs e)
        {
            //TODO naam opzoeken van bezoeker in database
        }

        private void btn_ScanBarcode_Click(object sender, EventArgs e)
        {
            // TODO barcode van de pas inscannen en verwijderen uit database
        }
    }
    
}

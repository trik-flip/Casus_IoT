﻿using System;
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
    public partial class MenuPasMaken : Form
    {
        public MenuPasMaken()
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

        private void MenuPasMaken_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btn_MedewerkerPas_Click(object sender, EventArgs e)
        {
            MedewerkersPasMaken medewerkersPasMaken = new MedewerkersPasMaken();
            medewerkersPasMaken.Show();
            this.Hide();
        }

        private void btn_BezoekerPas_Click(object sender, EventArgs e)
        {
            BezoekersPasMaken bezoekersPasMaken = new BezoekersPasMaken();
            bezoekersPasMaken.Show();
            this.Hide();
        }

        private void btn_Annuleren_Click(object sender, EventArgs e)
        {
            // Als een gebruiker annuleert wordt het hoofdmenu weergegeven
            HoofdmenuBeveiligingIT hoofdmenuBeveiligingIT = new HoofdmenuBeveiligingIT();
            hoofdmenuBeveiligingIT.Show();
            this.Hide();
        }
    }
    
}

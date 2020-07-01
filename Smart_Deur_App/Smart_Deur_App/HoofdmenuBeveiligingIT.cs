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
    public partial class HoofdmenuBeveiligingIT : Form
    {
        public HoofdmenuBeveiligingIT()
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
        private void HoofdmenuBeveiligingIT_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btn_PasMaken_Click(object sender, EventArgs e)
        {
            MenuPasMaken menuPasMaken = new MenuPasMaken();
            menuPasMaken.Show();
            this.Hide();
        }

        private void btn_PasAanpassen_Click(object sender, EventArgs e)
        {
            MenuPasAanpassen menuPasAanpassen = new MenuPasAanpassen();
            menuPasAanpassen.Show();
            this.Hide();
        }

        private void btn_PasVerwijderen_Click(object sender, EventArgs e)
        {
            MenuPasVerwijderen menuPasVerwijderen = new MenuPasVerwijderen();
            menuPasVerwijderen.Show();
            this.Hide();
        }

        private void btn_MedewerkerToevoegen_Click(object sender, EventArgs e)
        {
            MedewerkerToevoegen medewerkerToevoegen = new MedewerkerToevoegen();
            medewerkerToevoegen.Show();
            this.Hide();
        }

        private void btn_MedewerkerAanapssen_Click(object sender, EventArgs e)
        {
            MedewerkerAanpassen medewerkerAanpassen = new MedewerkerAanpassen();
            medewerkerAanpassen.Show();
            this.Hide();
        }

        private void btn_MedewerkerVerwijderen_Click(object sender, EventArgs e)
        {
            MedewerkerVerwijderen medewerkerVerwijderen = new MedewerkerVerwijderen();
            medewerkerVerwijderen.Show();
            this.Hide();
        }

        private void btn_LogboekOpvragen_Click(object sender, EventArgs e)
        {
            Logboek logboek = new Logboek();
            logboek.Show();
            this.Hide();
        }

        
    }
    
}
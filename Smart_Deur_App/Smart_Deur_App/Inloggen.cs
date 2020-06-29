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
    public partial class Inloggen : Form
    {
        public Inloggen()
        {
            InitializeComponent();
        }

        private void btn_Inloggen_Click(object sender, EventArgs e)
        {
            if (tb_Gebruikersnaam.Text == "Verpleger01")
            {
                if (tb_Wachtwoord.Text == "Welkom123")
                {
                    HoofdmenuVerpleger hoofdmenuVerpleger = new HoofdmenuVerpleger();
                    hoofdmenuVerpleger.Show();
                    this.Hide();

                }
            }
            else if (tb_Gebruikersnaam.Text == "Dokter01")
            {
                if (tb_Wachtwoord.Text == "Welkom123")
                {
                    HoofdmenuDokter hoofdmenuDokter = new HoofdmenuDokter();
                    hoofdmenuDokter.Show();
                    this.Hide();
                }
            }
            else if (tb_Gebruikersnaam.Text == "Beveiliger01")
            {
                if (tb_Wachtwoord.Text == "Welkom123")
                {
                    HoofdmenuBeveiligingIT hoofdmenuBeveiliging = new HoofdmenuBeveiligingIT();
                    hoofdmenuBeveiliging.Show();
                    this.Hide();
                }
            }
            else if (tb_Gebruikersnaam.Text == "IT01")
            {
                if (tb_Wachtwoord.Text == "Welkom123")
                {
                    HoofdmenuBeveiligingIT hoofdmenuIt = new HoofdmenuBeveiligingIT();
                    hoofdmenuIt.Show();
                    this.Hide();        
                }
            }
            else MessageBox.Show("Ongeldige gebruikersnaam/wachtwoord");
        }

        private void Inloggen_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Weet u het zeker?", "Afsluiten", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                {
                    Application.ExitThread();
                }
            }

        }
    }
    
}

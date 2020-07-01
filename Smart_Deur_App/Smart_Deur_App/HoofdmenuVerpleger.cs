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
    public partial class HoofdmenuVerpleger : Form
    {
        public HoofdmenuVerpleger()
        {
            InitializeComponent();
            pb_Deur.Hide();
        }

        private void btn_DeurOpenen_Click(object sender, EventArgs e)
        {
            //TODO fysieke deur openen van het gekozen kamernummer
            pb_Deur.Show();
            pb_Deur.ImageLocation = "C:/Users/shirl/Desktop/giphy.gif";           // "C:/Users/samir nemri/Desktop/gif/giphy.gif";                   
            pb_Deur.Load();
        }

        private void btn_Uitloggen_Click(object sender, EventArgs e)
        {
            //bij het uitloggen wordt gevraagd of de gebruiker het zeker weet, weet deze het zeker wordt het inlogscherm weergegeven.
            if (MessageBox.Show("U bent uitgelogd","Uitloggen",MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK){
                Inloggen inloggen = new Inloggen();
                inloggen.Show();
                this.Hide();

            };
        }


        private void HoofdmenuVerpleger_FormClosing(object sender, FormClosingEventArgs e)
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
    

        private void btn_BezoekerspasAanvragen_Click(object sender, EventArgs e)
        {
            BezoekersPasAanvragen bezoekersPasAanvragen = new BezoekersPasAanvragen();
            bezoekersPasAanvragen.Show();
            this.Hide();
        }

        private void HoofdmenuVerpleger_Load(object sender, EventArgs e)
        {

        }

        private void pb_Deur_Click(object sender, EventArgs e)
        {

        }

        private void cb_Kamers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO kamernummers invoeren die bij de ingelogde verpleger horen.
        }
    }
}

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
    public partial class HoofdmenuDokter : Form
    {
        public HoofdmenuDokter()
        {

            InitializeComponent();
            pb_Deur.Hide();
        }

        private void btn_Uitloggen_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("U bent uitgelogd", "Uitloggen", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Inloggen inloggen = new Inloggen();
                inloggen.Show();
                this.Hide();
            };
        }

        private void HoofdmenuDokter_FormClosing(object sender, FormClosingEventArgs e)
        {
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

        private void cb_Kamers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_DeurOpenen_Click(object sender, EventArgs e)
        {
           pb_Deur.Show();
           pb_Deur.ImageLocation = "C:/Users/shirl/Desktop/giphy.gif";           // "C:/Users/samir nemri/Desktop/gif/giphy.gif";                   
           pb_Deur.Load();
        }
    }

    
}

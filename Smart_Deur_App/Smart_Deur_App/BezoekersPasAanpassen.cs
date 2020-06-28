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
            if (MessageBox.Show("Weet u het zeker?","Uitloggen", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Inloggen inloggen = new Inloggen();
                inloggen.Show();
                this.Close();
            };
        }

        private void btn_Annuleren_Click(object sender, EventArgs e)
        {
            MenuPasAanpassen menuPasAanpassen = new MenuPasAanpassen();
            menuPasAanpassen.Show();
            this.Close();
        }

        private void BezoekersPasAanpassen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Weet u het zeker?", "Afsluiten", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            };
        }

        private void btn_Aanpassen_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bezoekerspas is aangepast.", "Bezoekerspas aanpassen", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                MenuPasAanpassen menuPasAanpassen = new MenuPasAanpassen();
                menuPasAanpassen.Show();
                this.Close();
            }
        }
    }
}

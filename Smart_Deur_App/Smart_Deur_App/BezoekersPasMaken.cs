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
    public partial class BezoekersPasMaken : Form
    {
        public BezoekersPasMaken()
        {
            InitializeComponent();
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

        private void BezoekersPasMaken_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Weet u het zeker?", "Afsluiten", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                {
                    this.Close();
                }
            }
        }

        private void btn_Aanmaken_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bezoekerspas is aangemaakt", "Bezoekerspas aanmaken", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                MenuPasMaken menuPasMaken = new MenuPasMaken();
                menuPasMaken.Show();
                this.Hide();
            }
        }

        private void btn_Annuleren_Click(object sender, EventArgs e)
        {
            MenuPasMaken menuPasMaken = new MenuPasMaken();
            menuPasMaken.Show();
            this.Close();
        }
    }
}

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
        private Button btn_Inloggen;
        private TextBox tb_Gebruikersnaam;
        private Label lb_Wachtwoord;
        private TextBox tb_Wachtwoord;
        private Label lb_Gebruikersnaam;

        public Inloggen()
        {
            InitializeComponent();
        }

        private void Inloggen_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.btn_Inloggen = new System.Windows.Forms.Button();
            this.tb_Gebruikersnaam = new System.Windows.Forms.TextBox();
            this.lb_Gebruikersnaam = new System.Windows.Forms.Label();
            this.lb_Wachtwoord = new System.Windows.Forms.Label();
            this.tb_Wachtwoord = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Inloggen
            // 
            this.btn_Inloggen.Location = new System.Drawing.Point(250, 194);
            this.btn_Inloggen.Name = "btn_Inloggen";
            this.btn_Inloggen.Size = new System.Drawing.Size(75, 23);
            this.btn_Inloggen.TabIndex = 0;
            this.btn_Inloggen.Text = "Inloggen";
            this.btn_Inloggen.UseVisualStyleBackColor = true;
            // 
            // tb_Gebruikersnaam
            // 
            this.tb_Gebruikersnaam.Location = new System.Drawing.Point(291, 103);
            this.tb_Gebruikersnaam.Name = "tb_Gebruikersnaam";
            this.tb_Gebruikersnaam.Size = new System.Drawing.Size(100, 20);
            this.tb_Gebruikersnaam.TabIndex = 1;
            // 
            // lb_Gebruikersnaam
            // 
            this.lb_Gebruikersnaam.AutoSize = true;
            this.lb_Gebruikersnaam.Location = new System.Drawing.Point(177, 106);
            this.lb_Gebruikersnaam.Name = "lb_Gebruikersnaam";
            this.lb_Gebruikersnaam.Size = new System.Drawing.Size(87, 13);
            this.lb_Gebruikersnaam.TabIndex = 2;
            this.lb_Gebruikersnaam.Text = "Gebruikersnaam:";
            this.lb_Gebruikersnaam.Click += new System.EventHandler(this.lb_Gebruikersnaam_Click);
            // 
            // lb_Wachtwoord
            // 
            this.lb_Wachtwoord.AutoSize = true;
            this.lb_Wachtwoord.Location = new System.Drawing.Point(180, 147);
            this.lb_Wachtwoord.Name = "lb_Wachtwoord";
            this.lb_Wachtwoord.Size = new System.Drawing.Size(68, 13);
            this.lb_Wachtwoord.TabIndex = 3;
            this.lb_Wachtwoord.Text = "Wachtwoord";
            // 
            // tb_Wachtwoord
            // 
            this.tb_Wachtwoord.Location = new System.Drawing.Point(291, 140);
            this.tb_Wachtwoord.Name = "tb_Wachtwoord";
            this.tb_Wachtwoord.Size = new System.Drawing.Size(100, 20);
            this.tb_Wachtwoord.TabIndex = 4;
            // 
            // Inloggen
            // 
            this.ClientSize = new System.Drawing.Size(640, 366);
            this.Controls.Add(this.tb_Wachtwoord);
            this.Controls.Add(this.lb_Wachtwoord);
            this.Controls.Add(this.lb_Gebruikersnaam);
            this.Controls.Add(this.tb_Gebruikersnaam);
            this.Controls.Add(this.btn_Inloggen);
            this.Name = "Inloggen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void lb_Gebruikersnaam_Click(object sender, EventArgs e)
        {

        }
    }
}

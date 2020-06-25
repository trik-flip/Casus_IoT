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
    public partial class MenuPasAanpassen : Form
    {
        private Button btn_Uitloggen;
        private Button btn_Annuleren;
        private Button btn_BezoekerPas;
        private Button btn_MedewerkerPas;
        private Label lb_PasAanpassen;

        public MenuPasAanpassen()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btn_Uitloggen = new System.Windows.Forms.Button();
            this.btn_Annuleren = new System.Windows.Forms.Button();
            this.btn_BezoekerPas = new System.Windows.Forms.Button();
            this.btn_MedewerkerPas = new System.Windows.Forms.Button();
            this.lb_PasAanpassen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Uitloggen
            // 
            this.btn_Uitloggen.Location = new System.Drawing.Point(366, 13);
            this.btn_Uitloggen.Name = "btn_Uitloggen";
            this.btn_Uitloggen.Size = new System.Drawing.Size(124, 23);
            this.btn_Uitloggen.TabIndex = 9;
            this.btn_Uitloggen.Text = "Uitloggen";
            this.btn_Uitloggen.UseVisualStyleBackColor = true;
            // 
            // btn_Annuleren
            // 
            this.btn_Annuleren.Location = new System.Drawing.Point(159, 179);
            this.btn_Annuleren.Name = "btn_Annuleren";
            this.btn_Annuleren.Size = new System.Drawing.Size(124, 23);
            this.btn_Annuleren.TabIndex = 8;
            this.btn_Annuleren.Text = "Annuleren";
            this.btn_Annuleren.UseVisualStyleBackColor = true;
            // 
            // btn_BezoekerPas
            // 
            this.btn_BezoekerPas.Location = new System.Drawing.Point(239, 112);
            this.btn_BezoekerPas.Name = "btn_BezoekerPas";
            this.btn_BezoekerPas.Size = new System.Drawing.Size(124, 23);
            this.btn_BezoekerPas.TabIndex = 7;
            this.btn_BezoekerPas.Text = "Bezoeker";
            this.btn_BezoekerPas.UseVisualStyleBackColor = true;
            // 
            // btn_MedewerkerPas
            // 
            this.btn_MedewerkerPas.Location = new System.Drawing.Point(73, 112);
            this.btn_MedewerkerPas.Name = "btn_MedewerkerPas";
            this.btn_MedewerkerPas.Size = new System.Drawing.Size(124, 23);
            this.btn_MedewerkerPas.TabIndex = 6;
            this.btn_MedewerkerPas.Text = "Medewerker";
            this.btn_MedewerkerPas.UseVisualStyleBackColor = true;
            // 
            // lb_PasAanpassen
            // 
            this.lb_PasAanpassen.AutoSize = true;
            this.lb_PasAanpassen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PasAanpassen.Location = new System.Drawing.Point(68, 31);
            this.lb_PasAanpassen.Name = "lb_PasAanpassen";
            this.lb_PasAanpassen.Size = new System.Drawing.Size(161, 25);
            this.lb_PasAanpassen.TabIndex = 5;
            this.lb_PasAanpassen.Text = "Pas aanpassen";
            // 
            // MenuPasAanpassen
            // 
            this.ClientSize = new System.Drawing.Size(519, 408);
            this.Controls.Add(this.btn_Uitloggen);
            this.Controls.Add(this.btn_Annuleren);
            this.Controls.Add(this.btn_BezoekerPas);
            this.Controls.Add(this.btn_MedewerkerPas);
            this.Controls.Add(this.lb_PasAanpassen);
            this.Name = "MenuPasAanpassen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

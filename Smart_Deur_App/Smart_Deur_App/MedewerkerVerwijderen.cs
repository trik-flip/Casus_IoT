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
    public partial class MedewerkerVerwijderen : Form
    {
        private Button btn_Annuleren;
        private Button btn_Verwijderen;
        private Button btn_NaamZoeken;
        private Button btn_Uitloggen;
        private TextBox tb_NaamMedewerker;
        private Label lb_Functie;
        private Label lb_NaamMedewerker;
        private Label lb_MedewerkerVerwijderen;
        private TextBox tb_Functie;

        public MedewerkerVerwijderen()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btn_Annuleren = new System.Windows.Forms.Button();
            this.btn_Verwijderen = new System.Windows.Forms.Button();
            this.btn_NaamZoeken = new System.Windows.Forms.Button();
            this.btn_Uitloggen = new System.Windows.Forms.Button();
            this.tb_NaamMedewerker = new System.Windows.Forms.TextBox();
            this.lb_Functie = new System.Windows.Forms.Label();
            this.lb_NaamMedewerker = new System.Windows.Forms.Label();
            this.lb_MedewerkerVerwijderen = new System.Windows.Forms.Label();
            this.tb_Functie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Annuleren
            // 
            this.btn_Annuleren.Location = new System.Drawing.Point(229, 201);
            this.btn_Annuleren.Name = "btn_Annuleren";
            this.btn_Annuleren.Size = new System.Drawing.Size(75, 23);
            this.btn_Annuleren.TabIndex = 67;
            this.btn_Annuleren.Text = "Annuleren";
            this.btn_Annuleren.UseVisualStyleBackColor = true;
            // 
            // btn_Verwijderen
            // 
            this.btn_Verwijderen.Location = new System.Drawing.Point(99, 201);
            this.btn_Verwijderen.Name = "btn_Verwijderen";
            this.btn_Verwijderen.Size = new System.Drawing.Size(75, 23);
            this.btn_Verwijderen.TabIndex = 66;
            this.btn_Verwijderen.Text = "Verwijderen";
            this.btn_Verwijderen.UseVisualStyleBackColor = true;
            // 
            // btn_NaamZoeken
            // 
            this.btn_NaamZoeken.Location = new System.Drawing.Point(289, 68);
            this.btn_NaamZoeken.Name = "btn_NaamZoeken";
            this.btn_NaamZoeken.Size = new System.Drawing.Size(75, 23);
            this.btn_NaamZoeken.TabIndex = 64;
            this.btn_NaamZoeken.Text = "Zoeken";
            this.btn_NaamZoeken.UseVisualStyleBackColor = true;
            // 
            // btn_Uitloggen
            // 
            this.btn_Uitloggen.Location = new System.Drawing.Point(358, 9);
            this.btn_Uitloggen.Name = "btn_Uitloggen";
            this.btn_Uitloggen.Size = new System.Drawing.Size(75, 23);
            this.btn_Uitloggen.TabIndex = 63;
            this.btn_Uitloggen.Text = "Uitloggen";
            this.btn_Uitloggen.UseVisualStyleBackColor = true;
            // 
            // tb_NaamMedewerker
            // 
            this.tb_NaamMedewerker.Location = new System.Drawing.Point(148, 68);
            this.tb_NaamMedewerker.Name = "tb_NaamMedewerker";
            this.tb_NaamMedewerker.Size = new System.Drawing.Size(118, 20);
            this.tb_NaamMedewerker.TabIndex = 62;
            // 
            // lb_Functie
            // 
            this.lb_Functie.AutoSize = true;
            this.lb_Functie.Location = new System.Drawing.Point(17, 109);
            this.lb_Functie.Name = "lb_Functie";
            this.lb_Functie.Size = new System.Drawing.Size(45, 13);
            this.lb_Functie.TabIndex = 61;
            this.lb_Functie.Text = "Functie:";
            // 
            // lb_NaamMedewerker
            // 
            this.lb_NaamMedewerker.AutoSize = true;
            this.lb_NaamMedewerker.Location = new System.Drawing.Point(17, 68);
            this.lb_NaamMedewerker.Name = "lb_NaamMedewerker";
            this.lb_NaamMedewerker.Size = new System.Drawing.Size(99, 13);
            this.lb_NaamMedewerker.TabIndex = 60;
            this.lb_NaamMedewerker.Text = "Naam medewerker:";
            // 
            // lb_MedewerkerVerwijderen
            // 
            this.lb_MedewerkerVerwijderen.AutoSize = true;
            this.lb_MedewerkerVerwijderen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MedewerkerVerwijderen.Location = new System.Drawing.Point(12, 9);
            this.lb_MedewerkerVerwijderen.Name = "lb_MedewerkerVerwijderen";
            this.lb_MedewerkerVerwijderen.Size = new System.Drawing.Size(246, 25);
            this.lb_MedewerkerVerwijderen.TabIndex = 59;
            this.lb_MedewerkerVerwijderen.Text = "Medewerker verwijderen";
            // 
            // tb_Functie
            // 
            this.tb_Functie.Location = new System.Drawing.Point(148, 106);
            this.tb_Functie.Name = "tb_Functie";
            this.tb_Functie.Size = new System.Drawing.Size(118, 20);
            this.tb_Functie.TabIndex = 68;
            // 
            // MedewerkerVerwijderen
            // 
            this.ClientSize = new System.Drawing.Size(463, 413);
            this.Controls.Add(this.tb_Functie);
            this.Controls.Add(this.btn_Annuleren);
            this.Controls.Add(this.btn_Verwijderen);
            this.Controls.Add(this.btn_NaamZoeken);
            this.Controls.Add(this.btn_Uitloggen);
            this.Controls.Add(this.tb_NaamMedewerker);
            this.Controls.Add(this.lb_Functie);
            this.Controls.Add(this.lb_NaamMedewerker);
            this.Controls.Add(this.lb_MedewerkerVerwijderen);
            this.Name = "MedewerkerVerwijderen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

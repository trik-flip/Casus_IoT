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
        private Label lb_Pas;
        private Label lb_Medewerker;
        private Button btn_PasMaken;
        private Button btn_PasVerwijderen;
        private Button btn_PasAanpassen;
        private Button btn_MedewerkerAanapssen;
        private Button btn_MedewerkerVerwijderen;
        private Button btn_MedewerkerToevoegen;
        private Button btn_Annuleren;
        private Button btn_Uitloggen;

        public HoofdmenuBeveiligingIT()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lb_Pas = new System.Windows.Forms.Label();
            this.lb_Medewerker = new System.Windows.Forms.Label();
            this.btn_PasMaken = new System.Windows.Forms.Button();
            this.btn_PasVerwijderen = new System.Windows.Forms.Button();
            this.btn_PasAanpassen = new System.Windows.Forms.Button();
            this.btn_MedewerkerAanapssen = new System.Windows.Forms.Button();
            this.btn_MedewerkerVerwijderen = new System.Windows.Forms.Button();
            this.btn_MedewerkerToevoegen = new System.Windows.Forms.Button();
            this.btn_Annuleren = new System.Windows.Forms.Button();
            this.btn_Uitloggen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Pas
            // 
            this.lb_Pas.AutoSize = true;
            this.lb_Pas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Pas.Location = new System.Drawing.Point(65, 80);
            this.lb_Pas.Name = "lb_Pas";
            this.lb_Pas.Size = new System.Drawing.Size(49, 25);
            this.lb_Pas.TabIndex = 9;
            this.lb_Pas.Text = "Pas";
            // 
            // lb_Medewerker
            // 
            this.lb_Medewerker.AutoSize = true;
            this.lb_Medewerker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Medewerker.Location = new System.Drawing.Point(330, 80);
            this.lb_Medewerker.Name = "lb_Medewerker";
            this.lb_Medewerker.Size = new System.Drawing.Size(130, 25);
            this.lb_Medewerker.TabIndex = 10;
            this.lb_Medewerker.Text = "Medewerker";
            // 
            // btn_PasMaken
            // 
            this.btn_PasMaken.Location = new System.Drawing.Point(70, 148);
            this.btn_PasMaken.Name = "btn_PasMaken";
            this.btn_PasMaken.Size = new System.Drawing.Size(117, 23);
            this.btn_PasMaken.TabIndex = 11;
            this.btn_PasMaken.Text = "Pas maken";
            this.btn_PasMaken.UseVisualStyleBackColor = true;
            // 
            // btn_PasVerwijderen
            // 
            this.btn_PasVerwijderen.Location = new System.Drawing.Point(70, 246);
            this.btn_PasVerwijderen.Name = "btn_PasVerwijderen";
            this.btn_PasVerwijderen.Size = new System.Drawing.Size(117, 23);
            this.btn_PasVerwijderen.TabIndex = 12;
            this.btn_PasVerwijderen.Text = "Pas verwijderen";
            this.btn_PasVerwijderen.UseVisualStyleBackColor = true;
            // 
            // btn_PasAanpassen
            // 
            this.btn_PasAanpassen.Location = new System.Drawing.Point(70, 196);
            this.btn_PasAanpassen.Name = "btn_PasAanpassen";
            this.btn_PasAanpassen.Size = new System.Drawing.Size(117, 23);
            this.btn_PasAanpassen.TabIndex = 13;
            this.btn_PasAanpassen.Text = "Pas aanpassen";
            this.btn_PasAanpassen.UseVisualStyleBackColor = true;
            // 
            // btn_MedewerkerAanapssen
            // 
            this.btn_MedewerkerAanapssen.Location = new System.Drawing.Point(335, 196);
            this.btn_MedewerkerAanapssen.Name = "btn_MedewerkerAanapssen";
            this.btn_MedewerkerAanapssen.Size = new System.Drawing.Size(157, 23);
            this.btn_MedewerkerAanapssen.TabIndex = 16;
            this.btn_MedewerkerAanapssen.Text = "Medewerker aanpassen";
            this.btn_MedewerkerAanapssen.UseVisualStyleBackColor = true;
            // 
            // btn_MedewerkerVerwijderen
            // 
            this.btn_MedewerkerVerwijderen.Location = new System.Drawing.Point(335, 246);
            this.btn_MedewerkerVerwijderen.Name = "btn_MedewerkerVerwijderen";
            this.btn_MedewerkerVerwijderen.Size = new System.Drawing.Size(157, 23);
            this.btn_MedewerkerVerwijderen.TabIndex = 15;
            this.btn_MedewerkerVerwijderen.Text = "Medewerker verwijderen";
            this.btn_MedewerkerVerwijderen.UseVisualStyleBackColor = true;
            // 
            // btn_MedewerkerToevoegen
            // 
            this.btn_MedewerkerToevoegen.Location = new System.Drawing.Point(335, 148);
            this.btn_MedewerkerToevoegen.Name = "btn_MedewerkerToevoegen";
            this.btn_MedewerkerToevoegen.Size = new System.Drawing.Size(157, 23);
            this.btn_MedewerkerToevoegen.TabIndex = 14;
            this.btn_MedewerkerToevoegen.Text = "Medewerker toevoegen";
            this.btn_MedewerkerToevoegen.UseVisualStyleBackColor = true;
            // 
            // btn_Annuleren
            // 
            this.btn_Annuleren.Location = new System.Drawing.Point(240, 355);
            this.btn_Annuleren.Name = "btn_Annuleren";
            this.btn_Annuleren.Size = new System.Drawing.Size(75, 23);
            this.btn_Annuleren.TabIndex = 17;
            this.btn_Annuleren.Text = "Annuleren";
            this.btn_Annuleren.UseVisualStyleBackColor = true;
            // 
            // btn_Uitloggen
            // 
            this.btn_Uitloggen.Location = new System.Drawing.Point(495, 21);
            this.btn_Uitloggen.Name = "btn_Uitloggen";
            this.btn_Uitloggen.Size = new System.Drawing.Size(75, 23);
            this.btn_Uitloggen.TabIndex = 18;
            this.btn_Uitloggen.Text = "Uitloggen";
            this.btn_Uitloggen.UseVisualStyleBackColor = true;
            // 
            // HoofdmenuBeveiligingIT
            // 
            this.ClientSize = new System.Drawing.Size(582, 533);
            this.Controls.Add(this.btn_Uitloggen);
            this.Controls.Add(this.btn_Annuleren);
            this.Controls.Add(this.btn_MedewerkerAanapssen);
            this.Controls.Add(this.btn_MedewerkerVerwijderen);
            this.Controls.Add(this.btn_MedewerkerToevoegen);
            this.Controls.Add(this.btn_PasAanpassen);
            this.Controls.Add(this.btn_PasVerwijderen);
            this.Controls.Add(this.btn_PasMaken);
            this.Controls.Add(this.lb_Medewerker);
            this.Controls.Add(this.lb_Pas);
            this.Name = "HoofdmenuBeveiligingIT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

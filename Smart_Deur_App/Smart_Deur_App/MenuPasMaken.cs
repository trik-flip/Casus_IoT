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
    public partial class MenuPasMaken : Form
    {
        private Label lb_PasMaken;
        private Button btn_MedewerkerPas;
        private Button btn_BezoekerPas;
        private Button btn_Annuleren;
        private Button btn_Uitloggen;

        public MenuPasMaken()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.lb_PasMaken = new System.Windows.Forms.Label();
            this.btn_MedewerkerPas = new System.Windows.Forms.Button();
            this.btn_BezoekerPas = new System.Windows.Forms.Button();
            this.btn_Annuleren = new System.Windows.Forms.Button();
            this.btn_Uitloggen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_PasMaken
            // 
            this.lb_PasMaken.AutoSize = true;
            this.lb_PasMaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PasMaken.Location = new System.Drawing.Point(52, 30);
            this.lb_PasMaken.Name = "lb_PasMaken";
            this.lb_PasMaken.Size = new System.Drawing.Size(119, 25);
            this.lb_PasMaken.TabIndex = 0;
            this.lb_PasMaken.Text = "Pas maken";
            // 
            // btn_MedewerkerPas
            // 
            this.btn_MedewerkerPas.Location = new System.Drawing.Point(57, 111);
            this.btn_MedewerkerPas.Name = "btn_MedewerkerPas";
            this.btn_MedewerkerPas.Size = new System.Drawing.Size(124, 23);
            this.btn_MedewerkerPas.TabIndex = 1;
            this.btn_MedewerkerPas.Text = "Medewerker";
            this.btn_MedewerkerPas.UseVisualStyleBackColor = true;
            // 
            // btn_BezoekerPas
            // 
            this.btn_BezoekerPas.Location = new System.Drawing.Point(223, 111);
            this.btn_BezoekerPas.Name = "btn_BezoekerPas";
            this.btn_BezoekerPas.Size = new System.Drawing.Size(124, 23);
            this.btn_BezoekerPas.TabIndex = 2;
            this.btn_BezoekerPas.Text = "Bezoeker";
            this.btn_BezoekerPas.UseVisualStyleBackColor = true;
            // 
            // btn_Annuleren
            // 
            this.btn_Annuleren.Location = new System.Drawing.Point(143, 178);
            this.btn_Annuleren.Name = "btn_Annuleren";
            this.btn_Annuleren.Size = new System.Drawing.Size(124, 23);
            this.btn_Annuleren.TabIndex = 3;
            this.btn_Annuleren.Text = "Annuleren";
            this.btn_Annuleren.UseVisualStyleBackColor = true;
            // 
            // btn_Uitloggen
            // 
            this.btn_Uitloggen.Location = new System.Drawing.Point(350, 12);
            this.btn_Uitloggen.Name = "btn_Uitloggen";
            this.btn_Uitloggen.Size = new System.Drawing.Size(124, 23);
            this.btn_Uitloggen.TabIndex = 4;
            this.btn_Uitloggen.Text = "Uitloggen";
            this.btn_Uitloggen.UseVisualStyleBackColor = true;
            // 
            // MenuPasMaken
            // 
            this.ClientSize = new System.Drawing.Size(486, 438);
            this.Controls.Add(this.btn_Uitloggen);
            this.Controls.Add(this.btn_Annuleren);
            this.Controls.Add(this.btn_BezoekerPas);
            this.Controls.Add(this.btn_MedewerkerPas);
            this.Controls.Add(this.lb_PasMaken);
            this.Name = "MenuPasMaken";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

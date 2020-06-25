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
        private Button btn_Uitloggen;
        private Button btn_DeurOpenen;
        private Button btn_BezoekerspasAanvragen;
        private Label lb_SelecteerKamer;
        private ComboBox cb_Kamers;

        public HoofdmenuVerpleger()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btn_Uitloggen = new System.Windows.Forms.Button();
            this.btn_DeurOpenen = new System.Windows.Forms.Button();
            this.btn_BezoekerspasAanvragen = new System.Windows.Forms.Button();
            this.lb_SelecteerKamer = new System.Windows.Forms.Label();
            this.cb_Kamers = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_Uitloggen
            // 
            this.btn_Uitloggen.Location = new System.Drawing.Point(440, 31);
            this.btn_Uitloggen.Name = "btn_Uitloggen";
            this.btn_Uitloggen.Size = new System.Drawing.Size(75, 23);
            this.btn_Uitloggen.TabIndex = 0;
            this.btn_Uitloggen.Text = "Uitloggen";
            this.btn_Uitloggen.UseVisualStyleBackColor = true;
            // 
            // btn_DeurOpenen
            // 
            this.btn_DeurOpenen.Location = new System.Drawing.Point(123, 214);
            this.btn_DeurOpenen.Name = "btn_DeurOpenen";
            this.btn_DeurOpenen.Size = new System.Drawing.Size(136, 23);
            this.btn_DeurOpenen.TabIndex = 1;
            this.btn_DeurOpenen.Text = "Deur openen";
            this.btn_DeurOpenen.UseVisualStyleBackColor = true;
            // 
            // btn_BezoekerspasAanvragen
            // 
            this.btn_BezoekerspasAanvragen.Location = new System.Drawing.Point(286, 214);
            this.btn_BezoekerspasAanvragen.Name = "btn_BezoekerspasAanvragen";
            this.btn_BezoekerspasAanvragen.Size = new System.Drawing.Size(146, 23);
            this.btn_BezoekerspasAanvragen.TabIndex = 2;
            this.btn_BezoekerspasAanvragen.Text = "Bezoekerspas aanvragen";
            this.btn_BezoekerspasAanvragen.UseVisualStyleBackColor = true;
            // 
            // lb_SelecteerKamer
            // 
            this.lb_SelecteerKamer.AutoSize = true;
            this.lb_SelecteerKamer.Location = new System.Drawing.Point(77, 134);
            this.lb_SelecteerKamer.Name = "lb_SelecteerKamer";
            this.lb_SelecteerKamer.Size = new System.Drawing.Size(87, 13);
            this.lb_SelecteerKamer.TabIndex = 3;
            this.lb_SelecteerKamer.Text = "Selecteer kamer:";
            // 
            // cb_Kamers
            // 
            this.cb_Kamers.FormattingEnabled = true;
            this.cb_Kamers.Items.AddRange(new object[] {
            "K.A W01",
            "K.A W02",
            "K.A W03"});
            this.cb_Kamers.Location = new System.Drawing.Point(171, 134);
            this.cb_Kamers.Name = "cb_Kamers";
            this.cb_Kamers.Size = new System.Drawing.Size(121, 21);
            this.cb_Kamers.TabIndex = 4;
            // 
            // HoofdmenuVerpleger
            // 
            this.ClientSize = new System.Drawing.Size(557, 361);
            this.Controls.Add(this.cb_Kamers);
            this.Controls.Add(this.lb_SelecteerKamer);
            this.Controls.Add(this.btn_BezoekerspasAanvragen);
            this.Controls.Add(this.btn_DeurOpenen);
            this.Controls.Add(this.btn_Uitloggen);
            this.Name = "HoofdmenuVerpleger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

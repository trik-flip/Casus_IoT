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
        private ComboBox cb_Kamers;
        private Label lb_SelecteerKamer;
        private Button btn_DeurOpenen;
        private Button btn_Uitloggen;

        public HoofdmenuDokter()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.cb_Kamers = new System.Windows.Forms.ComboBox();
            this.lb_SelecteerKamer = new System.Windows.Forms.Label();
            this.btn_DeurOpenen = new System.Windows.Forms.Button();
            this.btn_Uitloggen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_Kamers
            // 
            this.cb_Kamers.FormattingEnabled = true;
            this.cb_Kamers.Items.AddRange(new object[] {
            "K.A W01",
            "K.A W02",
            "K.A W03"});
            this.cb_Kamers.Location = new System.Drawing.Point(152, 117);
            this.cb_Kamers.Name = "cb_Kamers";
            this.cb_Kamers.Size = new System.Drawing.Size(121, 21);
            this.cb_Kamers.TabIndex = 9;
            // 
            // lb_SelecteerKamer
            // 
            this.lb_SelecteerKamer.AutoSize = true;
            this.lb_SelecteerKamer.Location = new System.Drawing.Point(58, 117);
            this.lb_SelecteerKamer.Name = "lb_SelecteerKamer";
            this.lb_SelecteerKamer.Size = new System.Drawing.Size(87, 13);
            this.lb_SelecteerKamer.TabIndex = 8;
            this.lb_SelecteerKamer.Text = "Selecteer kamer:";
            // 
            // btn_DeurOpenen
            // 
            this.btn_DeurOpenen.Location = new System.Drawing.Point(152, 184);
            this.btn_DeurOpenen.Name = "btn_DeurOpenen";
            this.btn_DeurOpenen.Size = new System.Drawing.Size(136, 23);
            this.btn_DeurOpenen.TabIndex = 6;
            this.btn_DeurOpenen.Text = "Deur openen";
            this.btn_DeurOpenen.UseVisualStyleBackColor = true;
            // 
            // btn_Uitloggen
            // 
            this.btn_Uitloggen.Location = new System.Drawing.Point(421, 14);
            this.btn_Uitloggen.Name = "btn_Uitloggen";
            this.btn_Uitloggen.Size = new System.Drawing.Size(75, 23);
            this.btn_Uitloggen.TabIndex = 5;
            this.btn_Uitloggen.Text = "Uitloggen";
            this.btn_Uitloggen.UseVisualStyleBackColor = true;
            // 
            // HoofdmenuDokter
            // 
            this.ClientSize = new System.Drawing.Size(583, 439);
            this.Controls.Add(this.cb_Kamers);
            this.Controls.Add(this.lb_SelecteerKamer);
            this.Controls.Add(this.btn_DeurOpenen);
            this.Controls.Add(this.btn_Uitloggen);
            this.Name = "HoofdmenuDokter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

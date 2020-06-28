namespace Smart_Deur_App
{
    partial class HoofdmenuDokter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
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
            this.cb_Kamers.Location = new System.Drawing.Point(113, 115);
            this.cb_Kamers.Name = "cb_Kamers";
            this.cb_Kamers.Size = new System.Drawing.Size(121, 21);
            this.cb_Kamers.TabIndex = 13;
            // 
            // lb_SelecteerKamer
            // 
            this.lb_SelecteerKamer.AutoSize = true;
            this.lb_SelecteerKamer.Location = new System.Drawing.Point(19, 115);
            this.lb_SelecteerKamer.Name = "lb_SelecteerKamer";
            this.lb_SelecteerKamer.Size = new System.Drawing.Size(87, 13);
            this.lb_SelecteerKamer.TabIndex = 12;
            this.lb_SelecteerKamer.Text = "Selecteer kamer:";
            // 
            // btn_DeurOpenen
            // 
            this.btn_DeurOpenen.Location = new System.Drawing.Point(113, 182);
            this.btn_DeurOpenen.Name = "btn_DeurOpenen";
            this.btn_DeurOpenen.Size = new System.Drawing.Size(136, 23);
            this.btn_DeurOpenen.TabIndex = 11;
            this.btn_DeurOpenen.Text = "Deur openen";
            this.btn_DeurOpenen.UseVisualStyleBackColor = true;
            // 
            // btn_Uitloggen
            // 
            this.btn_Uitloggen.Location = new System.Drawing.Point(382, 12);
            this.btn_Uitloggen.Name = "btn_Uitloggen";
            this.btn_Uitloggen.Size = new System.Drawing.Size(75, 23);
            this.btn_Uitloggen.TabIndex = 10;
            this.btn_Uitloggen.Text = "Uitloggen";
            this.btn_Uitloggen.UseVisualStyleBackColor = true;
            this.btn_Uitloggen.Click += new System.EventHandler(this.btn_Uitloggen_Click);
            // 
            // HoofdmenuDokter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 345);
            this.Controls.Add(this.cb_Kamers);
            this.Controls.Add(this.lb_SelecteerKamer);
            this.Controls.Add(this.btn_DeurOpenen);
            this.Controls.Add(this.btn_Uitloggen);
            this.Name = "HoofdmenuDokter";
            this.Text = "HoofdmenuDokter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HoofdmenuDokter_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Kamers;
        private System.Windows.Forms.Label lb_SelecteerKamer;
        private System.Windows.Forms.Button btn_DeurOpenen;
        private System.Windows.Forms.Button btn_Uitloggen;
    }
}
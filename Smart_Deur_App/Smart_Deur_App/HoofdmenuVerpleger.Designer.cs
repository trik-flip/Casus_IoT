namespace Smart_Deur_App
{
    partial class HoofdmenuVerpleger
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
            this.btn_BezoekerspasAanvragen = new System.Windows.Forms.Button();
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
            this.cb_Kamers.Location = new System.Drawing.Point(104, 112);
            this.cb_Kamers.Name = "cb_Kamers";
            this.cb_Kamers.Size = new System.Drawing.Size(121, 21);
            this.cb_Kamers.TabIndex = 9;
            // 
            // lb_SelecteerKamer
            // 
            this.lb_SelecteerKamer.AutoSize = true;
            this.lb_SelecteerKamer.Location = new System.Drawing.Point(10, 112);
            this.lb_SelecteerKamer.Name = "lb_SelecteerKamer";
            this.lb_SelecteerKamer.Size = new System.Drawing.Size(87, 13);
            this.lb_SelecteerKamer.TabIndex = 8;
            this.lb_SelecteerKamer.Text = "Selecteer kamer:";
            // 
            // btn_BezoekerspasAanvragen
            // 
            this.btn_BezoekerspasAanvragen.Location = new System.Drawing.Point(219, 192);
            this.btn_BezoekerspasAanvragen.Name = "btn_BezoekerspasAanvragen";
            this.btn_BezoekerspasAanvragen.Size = new System.Drawing.Size(146, 23);
            this.btn_BezoekerspasAanvragen.TabIndex = 7;
            this.btn_BezoekerspasAanvragen.Text = "Bezoekerspas aanvragen";
            this.btn_BezoekerspasAanvragen.UseVisualStyleBackColor = true;
            // 
            // btn_DeurOpenen
            // 
            this.btn_DeurOpenen.Location = new System.Drawing.Point(56, 192);
            this.btn_DeurOpenen.Name = "btn_DeurOpenen";
            this.btn_DeurOpenen.Size = new System.Drawing.Size(136, 23);
            this.btn_DeurOpenen.TabIndex = 6;
            this.btn_DeurOpenen.Text = "Deur openen";
            this.btn_DeurOpenen.UseVisualStyleBackColor = true;
            // 
            // btn_Uitloggen
            // 
            this.btn_Uitloggen.Location = new System.Drawing.Point(373, 9);
            this.btn_Uitloggen.Name = "btn_Uitloggen";
            this.btn_Uitloggen.Size = new System.Drawing.Size(75, 23);
            this.btn_Uitloggen.TabIndex = 5;
            this.btn_Uitloggen.Text = "Uitloggen";
            this.btn_Uitloggen.UseVisualStyleBackColor = true;
            // 
            // HoofdmenuVerpleger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 270);
            this.Controls.Add(this.cb_Kamers);
            this.Controls.Add(this.lb_SelecteerKamer);
            this.Controls.Add(this.btn_BezoekerspasAanvragen);
            this.Controls.Add(this.btn_DeurOpenen);
            this.Controls.Add(this.btn_Uitloggen);
            this.Name = "HoofdmenuVerpleger";
            this.Text = "HoofdmenuVerpleger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Kamers;
        private System.Windows.Forms.Label lb_SelecteerKamer;
        private System.Windows.Forms.Button btn_BezoekerspasAanvragen;
        private System.Windows.Forms.Button btn_DeurOpenen;
        private System.Windows.Forms.Button btn_Uitloggen;
    }
}
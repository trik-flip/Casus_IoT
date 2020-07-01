namespace Smart_Deur_App
{
    partial class Logboek
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
            this.lb_Logboek = new System.Windows.Forms.Label();
            this.tb_Zoeken = new System.Windows.Forms.TextBox();
            this.btn_Zoeken = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dg_Logboek = new System.Windows.Forms.DataGridView();
            this.btn_Uitloggen = new System.Windows.Forms.Button();
            this.btn_Annuleren = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Logboek)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Logboek
            // 
            this.lb_Logboek.AutoSize = true;
            this.lb_Logboek.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Logboek.Location = new System.Drawing.Point(62, 34);
            this.lb_Logboek.Name = "lb_Logboek";
            this.lb_Logboek.Size = new System.Drawing.Size(95, 25);
            this.lb_Logboek.TabIndex = 30;
            this.lb_Logboek.Text = "Logboek";
            // 
            // tb_Zoeken
            // 
            this.tb_Zoeken.Location = new System.Drawing.Point(67, 80);
            this.tb_Zoeken.Name = "tb_Zoeken";
            this.tb_Zoeken.Size = new System.Drawing.Size(100, 20);
            this.tb_Zoeken.TabIndex = 31;
            // 
            // btn_Zoeken
            // 
            this.btn_Zoeken.Location = new System.Drawing.Point(173, 77);
            this.btn_Zoeken.Name = "btn_Zoeken";
            this.btn_Zoeken.Size = new System.Drawing.Size(75, 23);
            this.btn_Zoeken.TabIndex = 32;
            this.btn_Zoeken.Text = "Zoeken";
            this.btn_Zoeken.UseVisualStyleBackColor = true;
            this.btn_Zoeken.Click += new System.EventHandler(this.btn_Zoeken_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(314, 80);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // dg_Logboek
            // 
            this.dg_Logboek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Logboek.Location = new System.Drawing.Point(77, 137);
            this.dg_Logboek.Name = "dg_Logboek";
            this.dg_Logboek.Size = new System.Drawing.Size(667, 267);
            this.dg_Logboek.TabIndex = 34;
            // 
            // btn_Uitloggen
            // 
            this.btn_Uitloggen.Location = new System.Drawing.Point(713, 13);
            this.btn_Uitloggen.Name = "btn_Uitloggen";
            this.btn_Uitloggen.Size = new System.Drawing.Size(75, 23);
            this.btn_Uitloggen.TabIndex = 35;
            this.btn_Uitloggen.Text = "Uitloggen";
            this.btn_Uitloggen.UseVisualStyleBackColor = true;
            this.btn_Uitloggen.Click += new System.EventHandler(this.btn_Uitloggen_Click);
            // 
            // btn_Annuleren
            // 
            this.btn_Annuleren.Location = new System.Drawing.Point(591, 13);
            this.btn_Annuleren.Name = "btn_Annuleren";
            this.btn_Annuleren.Size = new System.Drawing.Size(75, 23);
            this.btn_Annuleren.TabIndex = 36;
            this.btn_Annuleren.Text = "Annuleren";
            this.btn_Annuleren.UseVisualStyleBackColor = true;
            this.btn_Annuleren.Click += new System.EventHandler(this.btn_Annuleren_Click);
            // 
            // Logboek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Annuleren);
            this.Controls.Add(this.btn_Uitloggen);
            this.Controls.Add(this.dg_Logboek);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_Zoeken);
            this.Controls.Add(this.tb_Zoeken);
            this.Controls.Add(this.lb_Logboek);
            this.Name = "Logboek";
            this.Text = "Logboek";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Logboek_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Logboek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Logboek;
        private System.Windows.Forms.TextBox tb_Zoeken;
        private System.Windows.Forms.Button btn_Zoeken;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dg_Logboek;
        private System.Windows.Forms.Button btn_Uitloggen;
        private System.Windows.Forms.Button btn_Annuleren;
    }
}
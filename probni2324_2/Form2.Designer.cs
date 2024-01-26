namespace probni2324_2
{
    partial class Form2
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
            this.gumbDodaj = new System.Windows.Forms.Button();
            this.gumbOdustani = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPolazak = new System.Windows.Forms.TextBox();
            this.textBoxDolazak = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericSlobodnaMjesta = new System.Windows.Forms.NumericUpDown();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.numericCijena = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericSlobodnaMjesta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCijena)).BeginInit();
            this.SuspendLayout();
            // 
            // gumbDodaj
            // 
            this.gumbDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gumbDodaj.Location = new System.Drawing.Point(353, 376);
            this.gumbDodaj.Name = "gumbDodaj";
            this.gumbDodaj.Size = new System.Drawing.Size(143, 44);
            this.gumbDodaj.TabIndex = 0;
            this.gumbDodaj.Text = "Dodaj";
            this.gumbDodaj.UseVisualStyleBackColor = true;
            this.gumbDodaj.Click += new System.EventHandler(this.gumbDodaj_Click);
            // 
            // gumbOdustani
            // 
            this.gumbOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gumbOdustani.Location = new System.Drawing.Point(353, 453);
            this.gumbOdustani.Name = "gumbOdustani";
            this.gumbOdustani.Size = new System.Drawing.Size(143, 44);
            this.gumbOdustani.TabIndex = 1;
            this.gumbOdustani.Text = "Odustani";
            this.gumbOdustani.UseVisualStyleBackColor = true;
            this.gumbOdustani.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mjesto polaska:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mjesto dolaska:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Broj slobodnih mjesta:";
            // 
            // textBoxPolazak
            // 
            this.textBoxPolazak.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPolazak.Location = new System.Drawing.Point(214, 25);
            this.textBoxPolazak.Name = "textBoxPolazak";
            this.textBoxPolazak.Size = new System.Drawing.Size(331, 34);
            this.textBoxPolazak.TabIndex = 5;
            // 
            // textBoxDolazak
            // 
            this.textBoxDolazak.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDolazak.Location = new System.Drawing.Point(214, 95);
            this.textBoxDolazak.Name = "textBoxDolazak";
            this.textBoxDolazak.Size = new System.Drawing.Size(331, 34);
            this.textBoxDolazak.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cijena (u EUR):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Datum polaska:";
            // 
            // numericSlobodnaMjesta
            // 
            this.numericSlobodnaMjesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericSlobodnaMjesta.Location = new System.Drawing.Point(300, 303);
            this.numericSlobodnaMjesta.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericSlobodnaMjesta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericSlobodnaMjesta.Name = "numericSlobodnaMjesta";
            this.numericSlobodnaMjesta.Size = new System.Drawing.Size(245, 34);
            this.numericSlobodnaMjesta.TabIndex = 10;
            this.numericSlobodnaMjesta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(17, 303);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 11;
            // 
            // numericCijena
            // 
            this.numericCijena.DecimalPlaces = 2;
            this.numericCijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericCijena.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericCijena.Location = new System.Drawing.Point(214, 170);
            this.numericCijena.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericCijena.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericCijena.Name = "numericCijena";
            this.numericCijena.Size = new System.Drawing.Size(331, 34);
            this.numericCijena.TabIndex = 12;
            this.numericCijena.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.numericCijena);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.numericSlobodnaMjesta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDolazak);
            this.Controls.Add(this.textBoxPolazak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gumbOdustani);
            this.Controls.Add(this.gumbDodaj);
            this.Name = "Form2";
            this.Text = "Dodaj liniju";
            ((System.ComponentModel.ISupportInitialize)(this.numericSlobodnaMjesta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCijena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gumbDodaj;
        private System.Windows.Forms.Button gumbOdustani;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPolazak;
        private System.Windows.Forms.TextBox textBoxDolazak;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericSlobodnaMjesta;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.NumericUpDown numericCijena;
    }
}
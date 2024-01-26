namespace probni2324_2
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gumbPrikazSvih = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dodajLinijuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textNaziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboPolazak = new System.Windows.Forms.ComboBox();
            this.comboDolazak = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(746, 269);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // gumbPrikazSvih
            // 
            this.gumbPrikazSvih.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gumbPrikazSvih.Location = new System.Drawing.Point(17, 329);
            this.gumbPrikazSvih.Name = "gumbPrikazSvih";
            this.gumbPrikazSvih.Size = new System.Drawing.Size(177, 49);
            this.gumbPrikazSvih.TabIndex = 1;
            this.gumbPrikazSvih.Text = "Prikaz svih";
            this.gumbPrikazSvih.UseVisualStyleBackColor = true;
            this.gumbPrikazSvih.Click += new System.EventHandler(this.gumbPrikazSvih_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajLinijuToolStripMenuItem,
            this.informacijeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dodajLinijuToolStripMenuItem
            // 
            this.dodajLinijuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodajLinijuToolStripMenuItem.Name = "dodajLinijuToolStripMenuItem";
            this.dodajLinijuToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.dodajLinijuToolStripMenuItem.Text = "Dodaj liniju";
            this.dodajLinijuToolStripMenuItem.Click += new System.EventHandler(this.dodajLinijuToolStripMenuItem_Click);
            // 
            // informacijeToolStripMenuItem
            // 
            this.informacijeToolStripMenuItem.Name = "informacijeToolStripMenuItem";
            this.informacijeToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.informacijeToolStripMenuItem.Text = "Informacije";
            this.informacijeToolStripMenuItem.Click += new System.EventHandler(this.informacijeToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pretraga po nazivu:";
            // 
            // textNaziv
            // 
            this.textNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNaziv.Location = new System.Drawing.Point(488, 336);
            this.textNaziv.Name = "textNaziv";
            this.textNaziv.Size = new System.Drawing.Size(275, 34);
            this.textNaziv.TabIndex = 4;
            this.textNaziv.TextChanged += new System.EventHandler(this.textNaziv_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Odabir mjesta polaska:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 484);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(260, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Odabir mjesta dolaska:";
            // 
            // comboPolazak
            // 
            this.comboPolazak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPolazak.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPolazak.FormattingEnabled = true;
            this.comboPolazak.Location = new System.Drawing.Point(306, 408);
            this.comboPolazak.Name = "comboPolazak";
            this.comboPolazak.Size = new System.Drawing.Size(457, 37);
            this.comboPolazak.TabIndex = 7;
            this.comboPolazak.SelectedIndexChanged += new System.EventHandler(this.comboPolazak_SelectedIndexChanged);
            // 
            // comboDolazak
            // 
            this.comboDolazak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDolazak.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDolazak.FormattingEnabled = true;
            this.comboDolazak.Location = new System.Drawing.Point(306, 481);
            this.comboDolazak.Name = "comboDolazak";
            this.comboDolazak.Size = new System.Drawing.Size(457, 37);
            this.comboDolazak.TabIndex = 8;
            this.comboDolazak.SelectedIndexChanged += new System.EventHandler(this.comboDolazak_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.comboDolazak);
            this.Controls.Add(this.comboPolazak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNaziv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gumbPrikazSvih);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Pregled linija";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button gumbPrikazSvih;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dodajLinijuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacijeToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboPolazak;
        private System.Windows.Forms.ComboBox comboDolazak;
    }
}


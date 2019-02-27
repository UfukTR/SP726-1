namespace EF_DBFIRST
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
            this.textBox_FilmAdi = new System.Windows.Forms.TextBox();
            this.textBox_FilmKB = new System.Windows.Forms.TextBox();
            this.textBox1_Fragman = new System.Windows.Forms.TextBox();
            this.button_FilmKaydet = new System.Windows.Forms.Button();
            this.button_FilmGuncelle = new System.Windows.Forms.Button();
            this.button_FilmSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(373, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(385, 345);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBox_FilmAdi
            // 
            this.textBox_FilmAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_FilmAdi.Location = new System.Drawing.Point(174, 102);
            this.textBox_FilmAdi.Name = "textBox_FilmAdi";
            this.textBox_FilmAdi.Size = new System.Drawing.Size(124, 26);
            this.textBox_FilmAdi.TabIndex = 1;
            // 
            // textBox_FilmKB
            // 
            this.textBox_FilmKB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox_FilmKB.Location = new System.Drawing.Point(174, 142);
            this.textBox_FilmKB.Name = "textBox_FilmKB";
            this.textBox_FilmKB.Size = new System.Drawing.Size(124, 26);
            this.textBox_FilmKB.TabIndex = 2;
            // 
            // textBox1_Fragman
            // 
            this.textBox1_Fragman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1_Fragman.Location = new System.Drawing.Point(44, 181);
            this.textBox1_Fragman.Multiline = true;
            this.textBox1_Fragman.Name = "textBox1_Fragman";
            this.textBox1_Fragman.Size = new System.Drawing.Size(254, 36);
            this.textBox1_Fragman.TabIndex = 3;
            // 
            // button_FilmKaydet
            // 
            this.button_FilmKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_FilmKaydet.Location = new System.Drawing.Point(174, 240);
            this.button_FilmKaydet.Name = "button_FilmKaydet";
            this.button_FilmKaydet.Size = new System.Drawing.Size(124, 35);
            this.button_FilmKaydet.TabIndex = 4;
            this.button_FilmKaydet.Text = "FİLM KAYDET";
            this.button_FilmKaydet.UseVisualStyleBackColor = true;
            this.button_FilmKaydet.Click += new System.EventHandler(this.button_FilmKaydet_Click);
            // 
            // button_FilmGuncelle
            // 
            this.button_FilmGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_FilmGuncelle.Location = new System.Drawing.Point(142, 281);
            this.button_FilmGuncelle.Name = "button_FilmGuncelle";
            this.button_FilmGuncelle.Size = new System.Drawing.Size(156, 35);
            this.button_FilmGuncelle.TabIndex = 5;
            this.button_FilmGuncelle.Text = "FİLM GÜNCELLE";
            this.button_FilmGuncelle.UseVisualStyleBackColor = true;
            this.button_FilmGuncelle.Click += new System.EventHandler(this.button_FilmGuncelle_Click);
            // 
            // button_FilmSil
            // 
            this.button_FilmSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_FilmSil.Location = new System.Drawing.Point(142, 322);
            this.button_FilmSil.Name = "button_FilmSil";
            this.button_FilmSil.Size = new System.Drawing.Size(156, 35);
            this.button_FilmSil.TabIndex = 6;
            this.button_FilmSil.Text = "FİLM SİL";
            this.button_FilmSil.UseVisualStyleBackColor = true;
            this.button_FilmSil.Click += new System.EventHandler(this.button_FilmSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 534);
            this.Controls.Add(this.button_FilmSil);
            this.Controls.Add(this.button_FilmGuncelle);
            this.Controls.Add(this.button_FilmKaydet);
            this.Controls.Add(this.textBox1_Fragman);
            this.Controls.Add(this.textBox_FilmKB);
            this.Controls.Add(this.textBox_FilmAdi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_FilmAdi;
        private System.Windows.Forms.TextBox textBox_FilmKB;
        private System.Windows.Forms.TextBox textBox1_Fragman;
        private System.Windows.Forms.Button button_FilmKaydet;
        private System.Windows.Forms.Button button_FilmGuncelle;
        private System.Windows.Forms.Button button_FilmSil;
    }
}


namespace FinalCalismasi
{
    partial class List
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.Ad = new System.Windows.Forms.ColumnHeader();
            this.Soyad = new System.Windows.Forms.ColumnHeader();
            this.Maas = new System.Windows.Forms.ColumnHeader();
            this.DogumTarihi = new System.Windows.Forms.ColumnHeader();
            this.Departman = new System.Windows.Forms.ColumnHeader();
            this.Gorev = new System.Windows.Forms.ColumnHeader();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.Ad,
            this.Soyad,
            this.Maas,
            this.DogumTarihi,
            this.Departman,
            this.Gorev});
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(598, 116);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "id";
            // 
            // Ad
            // 
            this.Ad.Text = "Ad";
            // 
            // Soyad
            // 
            this.Soyad.Text = "Soyad";
            // 
            // Maas
            // 
            this.Maas.Text = "Maas";
            // 
            // DogumTarihi
            // 
            this.DogumTarihi.Text = "Doğum Tarihi";
            // 
            // Departman
            // 
            this.Departman.Text = "Departman";
            // 
            // Gorev
            // 
            this.Gorev.Text = "Görev";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tümünü Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(131, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Aramalı Listeleme";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 173);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Name = "List";
            this.Text = "ListView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listView1;
        private ColumnHeader Ad;
        private ColumnHeader Soyad;
        private ColumnHeader Maas;
        private ColumnHeader DogumTarihi;
        private ColumnHeader Departman;
        private ColumnHeader Gorev;
        private Button button1;
        private ColumnHeader id;
        private TextBox textBox1;
        private Button button2;
    }
}
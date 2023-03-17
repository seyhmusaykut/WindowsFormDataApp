namespace FinalCalismasi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtsad = new System.Windows.Forms.TextBox();
            this.txtmaas = new System.Windows.Forms.TextBox();
            this.txtdt = new System.Windows.Forms.TextBox();
            this.txtdp = new System.Windows.Forms.TextBox();
            this.txtgrv = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Maas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Doğum Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Departman";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Görev";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(53, 236);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(102, 29);
            this.add.TabIndex = 6;
            this.add.Text = "Ekle";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(100, 18);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(100, 23);
            this.txtad.TabIndex = 7;
            // 
            // txtsad
            // 
            this.txtsad.Location = new System.Drawing.Point(100, 54);
            this.txtsad.Name = "txtsad";
            this.txtsad.Size = new System.Drawing.Size(100, 23);
            this.txtsad.TabIndex = 8;
            // 
            // txtmaas
            // 
            this.txtmaas.Location = new System.Drawing.Point(100, 83);
            this.txtmaas.Name = "txtmaas";
            this.txtmaas.Size = new System.Drawing.Size(100, 23);
            this.txtmaas.TabIndex = 9;
            // 
            // txtdt
            // 
            this.txtdt.Location = new System.Drawing.Point(100, 119);
            this.txtdt.Name = "txtdt";
            this.txtdt.Size = new System.Drawing.Size(100, 23);
            this.txtdt.TabIndex = 10;
            // 
            // txtdp
            // 
            this.txtdp.Location = new System.Drawing.Point(100, 150);
            this.txtdp.Name = "txtdp";
            this.txtdp.Size = new System.Drawing.Size(100, 23);
            this.txtdp.TabIndex = 11;
            // 
            // txtgrv
            // 
            this.txtgrv.Location = new System.Drawing.Point(100, 182);
            this.txtgrv.Name = "txtgrv";
            this.txtgrv.Size = new System.Drawing.Size(100, 23);
            this.txtgrv.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 289);
            this.Controls.Add(this.txtgrv);
            this.Controls.Add(this.txtdp);
            this.Controls.Add(this.txtdt);
            this.Controls.Add(this.txtmaas);
            this.Controls.Add(this.txtsad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Ekleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button add;
        private TextBox txtad;
        private TextBox txtsad;
        private TextBox txtmaas;
        private TextBox txtdt;
        private TextBox txtdp;
        private TextBox txtgrv;
    }
}
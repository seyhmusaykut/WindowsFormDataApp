namespace FinalCalismasi
{
    partial class AnaEkran
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
            this.add = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.rp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(126, 12);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 0;
            this.add.Text = "Ekle";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(126, 57);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 1;
            this.update.Text = "Güncelle";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(126, 101);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(75, 23);
            this.del.TabIndex = 2;
            this.del.Text = "Sil";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // list
            // 
            this.list.Location = new System.Drawing.Point(126, 142);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(75, 26);
            this.list.TabIndex = 3;
            this.list.Text = "Listele";
            this.list.UseVisualStyleBackColor = true;
            this.list.Click += new System.EventHandler(this.list_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(126, 229);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 4;
            this.exit.Text = "Çıkış";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // rp
            // 
            this.rp.Location = new System.Drawing.Point(126, 188);
            this.rp.Name = "rp";
            this.rp.Size = new System.Drawing.Size(75, 23);
            this.rp.TabIndex = 5;
            this.rp.Text = "Reporwiver";
            this.rp.UseVisualStyleBackColor = true;
            this.rp.Click += new System.EventHandler(this.rp_Click);
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 264);
            this.Controls.Add(this.rp);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.list);
            this.Controls.Add(this.del);
            this.Controls.Add(this.update);
            this.Controls.Add(this.add);
            this.Name = "AnaEkran";
            this.Text = "AnaEkran";
            this.ResumeLayout(false);

        }

        #endregion

        private Button add;
        private Button update;
        private Button del;
        private Button list;
        private Button exit;
        private Button rp;
    }
}
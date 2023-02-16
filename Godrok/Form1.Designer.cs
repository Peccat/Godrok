namespace Godrok
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
            this.adatokbeolv_btn = new System.Windows.Forms.Button();
            this.ki_lb = new System.Windows.Forms.ListBox();
            this.feladat1_lbl = new System.Windows.Forms.Label();
            this.feladat2_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tav_tb = new System.Windows.Forms.TextBox();
            this.feladat2_lbl = new System.Windows.Forms.Label();
            this.feladat3_btn = new System.Windows.Forms.Button();
            this.feladat3_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // adatokbeolv_btn
            // 
            this.adatokbeolv_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adatokbeolv_btn.Location = new System.Drawing.Point(12, 12);
            this.adatokbeolv_btn.Name = "adatokbeolv_btn";
            this.adatokbeolv_btn.Size = new System.Drawing.Size(151, 33);
            this.adatokbeolv_btn.TabIndex = 0;
            this.adatokbeolv_btn.Text = "Adatok beolvasása";
            this.adatokbeolv_btn.UseVisualStyleBackColor = true;
            this.adatokbeolv_btn.Click += new System.EventHandler(this.adatokbeolv_btn_Click);
            // 
            // ki_lb
            // 
            this.ki_lb.FormattingEnabled = true;
            this.ki_lb.Location = new System.Drawing.Point(583, 12);
            this.ki_lb.Name = "ki_lb";
            this.ki_lb.Size = new System.Drawing.Size(205, 420);
            this.ki_lb.TabIndex = 1;
            // 
            // feladat1_lbl
            // 
            this.feladat1_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.feladat1_lbl.Location = new System.Drawing.Point(239, 12);
            this.feladat1_lbl.Name = "feladat1_lbl";
            this.feladat1_lbl.Size = new System.Drawing.Size(244, 33);
            this.feladat1_lbl.TabIndex = 2;
            this.feladat1_lbl.Text = " ";
            this.feladat1_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // feladat2_btn
            // 
            this.feladat2_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.feladat2_btn.Location = new System.Drawing.Point(12, 141);
            this.feladat2_btn.Name = "feladat2_btn";
            this.feladat2_btn.Size = new System.Drawing.Size(151, 37);
            this.feladat2_btn.TabIndex = 3;
            this.feladat2_btn.Text = "2. feladat";
            this.feladat2_btn.UseVisualStyleBackColor = true;
            this.feladat2_btn.Click += new System.EventHandler(this.feladat2_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "2. feladathoz adjon meg egy távolság értéket:";
            // 
            // tav_tb
            // 
            this.tav_tb.Location = new System.Drawing.Point(241, 107);
            this.tav_tb.Name = "tav_tb";
            this.tav_tb.Size = new System.Drawing.Size(100, 20);
            this.tav_tb.TabIndex = 5;
            // 
            // feladat2_lbl
            // 
            this.feladat2_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.feladat2_lbl.Location = new System.Drawing.Point(239, 141);
            this.feladat2_lbl.Name = "feladat2_lbl";
            this.feladat2_lbl.Size = new System.Drawing.Size(231, 37);
            this.feladat2_lbl.TabIndex = 6;
            this.feladat2_lbl.Text = " ";
            this.feladat2_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // feladat3_btn
            // 
            this.feladat3_btn.Location = new System.Drawing.Point(16, 225);
            this.feladat3_btn.Name = "feladat3_btn";
            this.feladat3_btn.Size = new System.Drawing.Size(147, 50);
            this.feladat3_btn.TabIndex = 7;
            this.feladat3_btn.Text = "3. feladat";
            this.feladat3_btn.UseVisualStyleBackColor = true;
            this.feladat3_btn.Click += new System.EventHandler(this.feladat3_btn_Click);
            // 
            // feladat3_lbl
            // 
            this.feladat3_lbl.Location = new System.Drawing.Point(204, 225);
            this.feladat3_lbl.Name = "feladat3_lbl";
            this.feladat3_lbl.Size = new System.Drawing.Size(251, 50);
            this.feladat3_lbl.TabIndex = 8;
            this.feladat3_lbl.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.feladat3_lbl);
            this.Controls.Add(this.feladat3_btn);
            this.Controls.Add(this.feladat2_lbl);
            this.Controls.Add(this.tav_tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.feladat2_btn);
            this.Controls.Add(this.feladat1_lbl);
            this.Controls.Add(this.ki_lb);
            this.Controls.Add(this.adatokbeolv_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adatokbeolv_btn;
        private System.Windows.Forms.ListBox ki_lb;
        private System.Windows.Forms.Label feladat1_lbl;
        private System.Windows.Forms.Button feladat2_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tav_tb;
        private System.Windows.Forms.Label feladat2_lbl;
        private System.Windows.Forms.Button feladat3_btn;
        private System.Windows.Forms.Label feladat3_lbl;
    }
}


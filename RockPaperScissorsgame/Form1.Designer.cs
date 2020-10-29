namespace RockPaperScissorsgame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblpc = new System.Windows.Forms.Label();
            this.lblme = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resimgamersec = new RockPaperScissorsgame.Resim();
            this.resimpcsec = new RockPaperScissorsgame.Resim();
            this.resimtas = new RockPaperScissorsgame.Resim();
            this.resimkagıt = new RockPaperScissorsgame.Resim();
            this.resimmakas = new RockPaperScissorsgame.Resim();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resimgamersec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimpcsec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimtas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimkagıt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimmakas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "PC";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gamer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(454, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Point";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Point";
            // 
            // lblpc
            // 
            this.lblpc.Location = new System.Drawing.Point(37, 213);
            this.lblpc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpc.Name = "lblpc";
            this.lblpc.Size = new System.Drawing.Size(48, 16);
            this.lblpc.TabIndex = 4;
            this.lblpc.Text = "0";
            this.lblpc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblpc.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblme
            // 
            this.lblme.Location = new System.Drawing.Point(454, 213);
            this.lblme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblme.Name = "lblme";
            this.lblme.Size = new System.Drawing.Size(48, 16);
            this.lblme.TabIndex = 5;
            this.lblme.Text = "0";
            this.lblme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblme.Click += new System.EventHandler(this.label6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resimtas);
            this.groupBox1.Controls.Add(this.resimkagıt);
            this.groupBox1.Controls.Add(this.resimmakas);
            this.groupBox1.Location = new System.Drawing.Point(12, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 171);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selection";
            // 
            // resimgamersec
            // 
            this.resimgamersec.Location = new System.Drawing.Point(395, 41);
            this.resimgamersec.Name = "resimgamersec";
            this.resimgamersec.ResimTuru = RockPaperScissorsgame.ResimTuru.Null;
            this.resimgamersec.Size = new System.Drawing.Size(137, 106);
            this.resimgamersec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resimgamersec.TabIndex = 8;
            this.resimgamersec.TabStop = false;
            this.resimgamersec.Click += new System.EventHandler(this.resim2_Click);
            // 
            // resimpcsec
            // 
            this.resimpcsec.Location = new System.Drawing.Point(24, 41);
            this.resimpcsec.Name = "resimpcsec";
            this.resimpcsec.ResimTuru = RockPaperScissorsgame.ResimTuru.Null;
            this.resimpcsec.Size = new System.Drawing.Size(137, 106);
            this.resimpcsec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resimpcsec.TabIndex = 7;
            this.resimpcsec.TabStop = false;
            this.resimpcsec.Click += new System.EventHandler(this.resim1_Click);
            // 
            // resimtas
            // 
            this.resimtas.Image = ((System.Drawing.Image)(resources.GetObject("resimtas.Image")));
            this.resimtas.Location = new System.Drawing.Point(383, 40);
            this.resimtas.Name = "resimtas";
            this.resimtas.ResimTuru = RockPaperScissorsgame.ResimTuru.Rock;
            this.resimtas.Size = new System.Drawing.Size(109, 103);
            this.resimtas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resimtas.TabIndex = 2;
            this.resimtas.TabStop = false;
            this.resimtas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.resimkagıt_MouseClick);
            // 
            // resimkagıt
            // 
            this.resimkagıt.Image = ((System.Drawing.Image)(resources.GetObject("resimkagıt.Image")));
            this.resimkagıt.Location = new System.Drawing.Point(221, 40);
            this.resimkagıt.Name = "resimkagıt";
            this.resimkagıt.ResimTuru = RockPaperScissorsgame.ResimTuru.Paper;
            this.resimkagıt.Size = new System.Drawing.Size(109, 103);
            this.resimkagıt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resimkagıt.TabIndex = 1;
            this.resimkagıt.TabStop = false;
            this.resimkagıt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.resimkagıt_MouseClick);
            // 
            // resimmakas
            // 
            this.resimmakas.Image = ((System.Drawing.Image)(resources.GetObject("resimmakas.Image")));
            this.resimmakas.Location = new System.Drawing.Point(67, 40);
            this.resimmakas.Name = "resimmakas";
            this.resimmakas.ResimTuru = RockPaperScissorsgame.ResimTuru.Scissor;
            this.resimmakas.Size = new System.Drawing.Size(109, 103);
            this.resimmakas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resimmakas.TabIndex = 0;
            this.resimmakas.TabStop = false;
            this.resimmakas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.resimkagıt_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 496);
            this.Controls.Add(this.resimgamersec);
            this.Controls.Add(this.resimpcsec);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblme);
            this.Controls.Add(this.lblpc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resimgamersec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimpcsec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimtas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimkagıt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resimmakas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblpc;
        private System.Windows.Forms.Label lblme;
        private System.Windows.Forms.GroupBox groupBox1;
        private Resim resimtas;
        private Resim resimkagıt;
        private Resim resimmakas;
        private Resim resimpcsec;
        private Resim resimgamersec;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissorsgame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void resim2_Click(object sender, EventArgs e)
        {

        }

        private void resim1_Click(object sender, EventArgs e)
        {

        }

        void pcskorarttir()
        {
            int skor = Convert.ToInt32(lblpc.Text);
            lblpc.Text = (++skor).ToString();
        }
        void meskorarttır()
        {
            int skor = Convert.ToInt32(lblme.Text);
            lblme.Text = (++skor).ToString();
        }

        private void resimkagıt_MouseClick(object sender, MouseEventArgs e)
        {
            Resim tiklananResim = sender as Resim;
            int rastGeleSecim = new Random().Next(DateTime.Now.Millisecond,9999)%3;
            resimpcsec.ResimTuru = (ResimTuru)rastGeleSecim;
            resimgamersec.ResimTuru = tiklananResim.ResimTuru;

            if (tiklananResim.ResimTuru==ResimTuru.Paper)
            {
                if(resimpcsec.ResimTuru==ResimTuru.Scissor)
                {
                    pcskorarttir();
                }
                else if (resimpcsec.ResimTuru==ResimTuru.Rock)
                {
                    meskorarttır();
                }
            }
            else if (tiklananResim.ResimTuru==ResimTuru.Scissor)
            {
                if (resimpcsec.ResimTuru==ResimTuru.Paper)
                {
                    meskorarttır();
                }
                else if (resimpcsec.ResimTuru==ResimTuru.Rock)
                {
                    pcskorarttir();
                }
            }
            else
            {
                if (resimpcsec.ResimTuru == ResimTuru.Paper)
                {
                    pcskorarttir();
                }
                else if (resimpcsec.ResimTuru == ResimTuru.Scissor)
                {
                    meskorarttır();
                }
            }
             
        }
    }
}

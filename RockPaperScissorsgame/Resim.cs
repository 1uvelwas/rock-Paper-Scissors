using RockPaperScissorsgame.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissorsgame
{
    public enum ResimTuru
    {
        Rock,
        Paper,
        Scissor,
        Null

    }
    class Resim:PictureBox
    {
        ResimTuru resimTuru;
        public Resim()
        {
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            ResimTuru = ResimTuru.Null;
            this.Width = 110;
            this.Height = 105;
        }

        public ResimTuru ResimTuru
        {
            get
            {
                return resimTuru;
            }

            set
            {
                resimTuru = value;
                switch (value)
                {
                    case ResimTuru.Rock:
                        this.Image = Resources.rock2;
                        break;
                    case ResimTuru.Paper:
                        this.Image = Resources.paper2;
                        break;
                    case ResimTuru.Scissor:
                        this.Image = Resources.scissors2;
                        break;
                    case ResimTuru.Null:
                        this.Image = null;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

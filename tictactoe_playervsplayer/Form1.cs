using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe_playervsplayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int kolejka;

        public int Kolejka
        {
            get { return kolejka; }
            set { kolejka = value; }
        }

        private int kolko;

        public int Kolko
        {
            get { return kolko; }
            set { kolko = value; }
        }

        private int krzyzyk;

        public int Krzyzyk
        {
            get { return krzyzyk; }
            set { krzyzyk = value; }
        }

        private int btnClicked1;
        public int BtnClicked1
        {
            get { return btnClicked1; }
            set { btnClicked1 = value; }
        }

        private int btnClicked2;
        public int BtnClicked2
        {
            get { return btnClicked2; }
            set { btnClicked2 = value; }
        }

        private int btnClicked3;
        public int BtnClicked3
        {
            get { return btnClicked3; }
            set { btnClicked3 = value; }
        }

        private int btnClicked4;
        public int BtnClicked4
        {
            get { return btnClicked4; }
            set { btnClicked4 = value; }
        }

        private int btnClicked5;
        public int BtnClicked5
        {
            get { return btnClicked5; }
            set { btnClicked5 = value; }
        }

        private int btnClicked6;
        public int BtnClicked6
        {
            get { return btnClicked6; }
            set { btnClicked6 = value; }
        }

        private int btnClicked7;
        public int BtnClicked7
        {
            get { return btnClicked7; }
            set { btnClicked7 = value; }
        }

        private int btnClicked8;
        public int BtnClicked8
        {
            get { return btnClicked8; }
            set { btnClicked8 = value; }
        }

        private int btnClicked9;
        public int BtnClicked9
        {
            get { return btnClicked9; }
            set { btnClicked9 = value; }
        }

        public void ChangeBtn()
        {
            if (Kolejka % 2 != 0)
            {
                lblKolejkaActive.Text = "X";
            }
            else
            {
                lblKolejkaActive.Text = "O";
            }
        }

        public void RestartGame()
        {
            lblKolejkaActive.Text = "";
            Kolejka = 1;
            BtnClicked1 = 0; BtnClicked2 = 0; BtnClicked3 = 0; BtnClicked4 = 0; BtnClicked5 = 0; BtnClicked6 = 0; BtnClicked7 = 0; BtnClicked8 = 0; BtnClicked9 = 0;
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btn1.BackColor = Color.MintCream;
            btn1.ForeColor = Color.Black;
            btn2.BackColor = Color.MintCream;
            btn2.ForeColor = Color.Black;
            btn3.BackColor = Color.MintCream;
            btn3.ForeColor = Color.Black;
            btn4.BackColor = Color.MintCream;
            btn4.ForeColor = Color.Black;
            btn5.BackColor = Color.MintCream;
            btn5.ForeColor = Color.Black;
            btn6.BackColor = Color.MintCream;
            btn6.ForeColor = Color.Black;
            btn7.BackColor = Color.MintCream;
            btn7.ForeColor = Color.Black;
            btn8.BackColor = Color.MintCream;
            btn8.ForeColor = Color.Black;
            btn9.BackColor = Color.MintCream;
            btn9.ForeColor = Color.Black;
        }

        public void CheckBtn()
        {
            if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "")
            {
                if (btn1.Text == btn2.Text && btn1.Text == btn3.Text)
                {
                    btn1.BackColor = Color.SeaGreen;
                    btn1.ForeColor = Color.White;
                    btn2.BackColor = Color.SeaGreen;
                    btn2.ForeColor = Color.White;
                    btn3.BackColor = Color.SeaGreen;
                    btn3.ForeColor = Color.White;
                    if (btn1.Text == "X")
                    {
                        MessageBox.Show("Gracz 'krzyżyk' wygrywa!", "Koniec tury", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        krzyzyk++;
                        lblScoreX.Text = krzyzyk.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Gracz 'kółko' wygrywa!", "Koniec tury", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        kolko++;
                        lblScoreO.Text = kolko.ToString();
                    }
                    RestartGame();

                }
            }
            if (btn4.Text != "" && btn5.Text != "" && btn6.Text != "")
            {
                if (btn4.Text == btn5.Text && btn4.Text == btn6.Text)
                {
                    btn4.BackColor = Color.SeaGreen;
                    btn4.ForeColor = Color.White;
                    btn5.BackColor = Color.SeaGreen;
                    btn5.ForeColor = Color.White;
                    btn6.BackColor = Color.SeaGreen;
                    btn6.ForeColor = Color.White;
                    if (btn4.Text == "X")
                    {
                        MessageBox.Show("Gracz 'krzyżyk' wygrywa!", "Koniec tury", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        krzyzyk++;
                        lblScoreX.Text = krzyzyk.ToString();

                    }
                    else
                    {
                        MessageBox.Show("Gracz 'kółko' wygrywa!", "Koniec tury", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        kolko++;
                        lblScoreO.Text = kolko.ToString();

                    }
                    RestartGame();
                }
            }
            if (btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
            {
                if (btn7.Text == btn8.Text && btn7.Text == btn9.Text)
                {
                    btn7.BackColor = Color.SeaGreen;
                    btn7.ForeColor = Color.White;
                    btn8.BackColor = Color.SeaGreen;
                    btn8.ForeColor = Color.White;
                    btn9.BackColor = Color.SeaGreen;
                    btn9.ForeColor = Color.White;
                    if (btn7.Text == "X")
                    {
                        MessageBox.Show("Gracz 'krzyżyk' wygrywa!", "Koniec tury", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        krzyzyk++;
                        lblScoreX.Text = krzyzyk.ToString();

                    }
                    else
                    {
                        MessageBox.Show("Gracz 'kółko' wygrywa!", "Koniec tury", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        kolko++;
                        lblScoreO.Text = kolko.ToString();

                    }
                    RestartGame();
                }
            }
            if (btn1.Text != "" && btn4.Text != "" && btn7.Text != "")
            {
                if (btn1.Text == btn4.Text && btn1.Text == btn7.Text)
                {
                    btn1.BackColor = Color.SeaGreen;
                    btn1.ForeColor = Color.White;
                    btn4.BackColor = Color.SeaGreen;
                    btn4.ForeColor = Color.White;
                    btn7.BackColor = Color.SeaGreen;
                    btn7.ForeColor = Color.White;
                    if (btn1.Text == "X")
                    {
                        MessageBox.Show("Gracz 'krzyżyk' wygrywa!", "Koniec tury", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        krzyzyk++;
                        lblScoreX.Text = krzyzyk.ToString();

                    }
                    else
                    {
                        MessageBox.Show("Gracz 'kółko' wygrywa!", "Koniec tury", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        kolko++;
                        lblScoreO.Text = kolko.ToString();

                    }
                    RestartGame();
                }
            }
            if (btn2.Text != "" && btn5.Text != "" && btn8.Text != "")
            {
                if (btn2.Text == btn5.Text && btn2.Text == btn8.Text)
                {
                    btn2.BackColor = Color.SeaGreen;
                    btn2.ForeColor = Color.White;
                    btn5.BackColor = Color.SeaGreen;
                    btn5.ForeColor = Color.White;
                    btn8.BackColor = Color.SeaGreen;
                    btn8.ForeColor = Color.White;
                    if (btn2.Text == "X")
                    {
                        MessageBox.Show("Gracz 'krzyżyk' wygrywa!", "Koniec tury", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        krzyzyk++;
                        lblScoreX.Text = krzyzyk.ToString();

                    }
                    else
                    {
                        MessageBox.Show("Gracz 'kółko' wygrywa!", "Koniec tury", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        kolko++;
                        lblScoreO.Text = kolko.ToString();

                    }
                    RestartGame();
                }
            }
            if (btn3.Text != "" && btn6.Text != "" && btn9.Text != "")
            {
                if (btn3.Text == btn6.Text && btn3.Text == btn9.Text)
                {
                    btn3.BackColor = Color.SeaGreen;
                    btn3.ForeColor = Color.White;
                    btn6.BackColor = Color.SeaGreen;
                    btn6.ForeColor = Color.White;
                    btn9.BackColor = Color.SeaGreen;
                    btn9.ForeColor = Color.White;
                    if (btn3.Text == "X")
                    {
                        MessageBox.Show("Gracz 'krzyżyk' wygrywa!", "Koniec tury", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        krzyzyk++;
                        lblScoreX.Text = krzyzyk.ToString();

                    }
                    else
                    {
                        MessageBox.Show("Gracz 'kółko' wygrywa!", "Koniec tury", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        kolko++;
                        lblScoreO.Text = kolko.ToString();

                    }
                    RestartGame();
                }
            }
            if (btn1.Text != "" && btn5.Text != "" && btn9.Text != "")
            {
                if (btn1.Text == btn5.Text && btn1.Text == btn9.Text)
                {
                    btn1.BackColor = Color.SeaGreen;
                    btn1.ForeColor = Color.White;
                    btn5.BackColor = Color.SeaGreen;
                    btn5.ForeColor = Color.White;
                    btn9.BackColor = Color.SeaGreen;
                    btn9.ForeColor = Color.White;
                    if (btn1.Text == "X")
                    {
                        MessageBox.Show("Gracz 'krzyżyk' wygrywa!", "Koniec tury", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        krzyzyk++;
                        lblScoreX.Text = krzyzyk.ToString();

                    }
                    else
                    {
                        MessageBox.Show("Gracz 'kółko' wygrywa!", "Koniec tury", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        kolko++;
                        lblScoreO.Text = kolko.ToString();

                    }
                    RestartGame();
                }
            }
            if (btn3.Text != "" && btn5.Text != "" && btn7.Text != "")
            {
                if (btn3.Text == btn5.Text && btn3.Text == btn7.Text)
                {
                    btn3.BackColor = Color.SeaGreen;
                    btn3.ForeColor = Color.White;
                    btn5.BackColor = Color.SeaGreen;
                    btn5.ForeColor = Color.White;
                    btn7.BackColor = Color.SeaGreen;
                    btn7.ForeColor = Color.White;
                    if (btn3.Text == "X")
                    {
                        MessageBox.Show("Gracz 'krzyżyk' wygrywa!", "Koniec tury", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        krzyzyk++;
                        lblScoreX.Text = krzyzyk.ToString();

                    }
                    else
                    {
                        MessageBox.Show("Gracz 'kółko' wygrywa!", "Koniec tury", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        kolko++;
                        lblScoreO.Text = kolko.ToString();

                    }
                    RestartGame();
                }
            }
        }

        public void btn1_Click(object sender, EventArgs e)
            {
                if (btnClicked1 == 0)
                {
                    if (kolejka % 2 != 0)
                    {
                        btn1.Text = "X";
                        btnClicked1++;
                    }
                    else
                    {
                        btn1.Text = "O";
                        btnClicked1++;
                    }
                    kolejka++;
                }
                else
                {
                    btn1.Text = btn1.Text;
                }
                ChangeBtn();
                CheckBtn();
        }

        public void btn2_Click(object sender, EventArgs e)
        {
            if (btnClicked2 == 0)
            {
                if (kolejka % 2 != 0)
                {
                    btn2.Text = "X";
                    btnClicked2++;
                }
                else
                {
                    btn2.Text = "O";
                    btnClicked2++;
                }
                kolejka++;
            }
            else
            {
                btn2.Text = btn2.Text;
            }
            ChangeBtn();
            CheckBtn();
        }
        public void btn3_Click(object sender, EventArgs e)
        {
            if (btnClicked3 == 0)
            {
                if (kolejka % 2 != 0)
                {
                    btn3.Text = "X";
                    btnClicked3++;
                }
                else
                {
                    btn3.Text = "O";
                    btnClicked3++;
                }
                kolejka++;
            }
            else
            {
                btn3.Text = btn3.Text;
            }
            ChangeBtn();
            CheckBtn();
        }
        public void btn4_Click(object sender, EventArgs e)
        {
            if (btnClicked4 == 0)
            {
                if (kolejka % 2 != 0)
                {
                    btn4.Text = "X";
                    btnClicked4++;
                }
                else
                {
                    btn4.Text = "O";
                    btnClicked4++;
                }
                kolejka++;
            }
            else
            {
                btn4.Text = btn4.Text;
            }
            ChangeBtn();
            CheckBtn();
        }
        public void btn5_Click(object sender, EventArgs e)
        {
            if (btnClicked5 == 0)
            {
                if (kolejka % 2 != 0)
                {
                    btn5.Text = "X";
                    btnClicked5++;
                }
                else
                {
                    btn5.Text = "O";
                    btnClicked5++;
                }
                kolejka++;
            }
            else
            {
                btn5.Text = btn5.Text;
            }
            ChangeBtn();
            CheckBtn();
        }
        public void btn6_Click(object sender, EventArgs e)
        {
            if (btnClicked6 == 0)
            {
                if (kolejka % 2 != 0)
                {
                    btn6.Text = "X";
                    btnClicked6++;
                }
                else
                {
                    btn6.Text = "O";
                    btnClicked6++;
                }
                kolejka++;
            }
            else
            {
                btn6.Text = btn6.Text;
            }
            ChangeBtn();
            CheckBtn();
        }
        public void btn7_Click(object sender, EventArgs e)
        {
            if (btnClicked7 == 0)
            {
                if (kolejka % 2 != 0)
                {
                    btn7.Text = "X";
                    btnClicked7++;
                }
                else
                {
                    btn7.Text = "O";
                    btnClicked7++;
                }
                kolejka++;
            }
            else
            {
                btn7.Text = btn7.Text;
            }
            ChangeBtn();
            CheckBtn();
        }
        public void btn8_Click(object sender, EventArgs e)
        {
            if (btnClicked8 == 0)
            {
                if (kolejka % 2 != 0)
                {
                    btn8.Text = "X";
                    btnClicked8++;
                }
                else
                {
                    btn8.Text = "O";
                    btnClicked8++;
                }
                kolejka++;
            }
            else
            {
                btn8.Text = btn8.Text;
            }
            ChangeBtn();
            CheckBtn();
        }
        public void btn9_Click(object sender, EventArgs e)
        {
            if (btnClicked9 == 0)
            {
                if (kolejka % 2 != 0)
                {
                    btn9.Text = "X";
                    btnClicked9++;
                }
                else
                {
                    btn9.Text = "O";
                    btnClicked9++;
                }
                kolejka++;
            }
            else
            {
                btn9.Text = btn9.Text;
            }
            ChangeBtn();
            CheckBtn();
        }

        public void btnPlayAgain_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        public void btnRestart_Click(object sender, EventArgs e)
        {
            lblScoreO.Text = "";
            lblScoreX.Text = "";
            kolko = 0;
            krzyzyk = 0;
            RestartGame();
        }

    }

}

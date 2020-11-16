using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 三目並べ
{
    public partial class Form1 : Form
    {
        bool turn = true;// trueはXのターン falseはYのターン
        int turn_count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)//ボタンクリック時のアクション
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;//変更不可にする
            turn_count++;
            checkWinner();
        }
        bool baguboushi = true;//バグ防止策
        bool hikiwakebagu = true;//バグ防止策
        private void checkWinner()//3マスそろっているか
        {
            bool winner_Hakken = false;

            //横のチェック
            if ((B1.Text == B2.Text) && (B2.Text == B3.Text)&&(!B1.Enabled))
                winner_Hakken = true;
            else if ((B4.Text == B5.Text) && (B5.Text == B6.Text)&&(!B4.Enabled))
                winner_Hakken = true;
            else if ((B7.Text == B8.Text) && (B8.Text == B9.Text)&&(!B7.Enabled))
                winner_Hakken = true;
            //縦のチェック
            if ((B1.Text == B4.Text) && (B4.Text == B7.Text) && (!B1.Enabled))
                winner_Hakken = true;
            else if ((B2.Text == B5.Text) && (B5.Text == B8.Text) && (!B2.Enabled))
                winner_Hakken = true;
            else if ((B3.Text == B6.Text) && (B6.Text == B9.Text) && (!B3.Enabled))
                winner_Hakken = true;
            //斜めのチェック
            if ((B1.Text == B5.Text) && (B5.Text == B9.Text) && (!B1.Enabled))
                winner_Hakken = true;
            else if ((B3.Text == B5.Text) && (B5.Text == B7.Text) && (!B3.Enabled))
                winner_Hakken = true;

            if (winner_Hakken&&baguboushi)
            {
                disableButtons();

                String winner = "";
                if (turn)
                {
                    winner = "O";
                    o_win_count.Text = (Int32.Parse(o_win_count.Text) + 1).ToString();
                    baguboushi = false;
                    hikiwakebagu = false;
                    
                }
                else
                {
                    winner = "X";
                    x_win_count.Text = (Int32.Parse(x_win_count.Text) + 1).ToString();
                    baguboushi = false;
                    hikiwakebagu = false;

                }
                MessageBox.Show(winner + "の勝利！","おめでとう！");
            }//endif
            else
            {
                if (turn_count == 9 && hikiwakebagu)
                {
                    
                    draw_count.Text = (Int32.Parse(draw_count.Text) + 1).ToString();
                    MessageBox.Show("引き分け！！", "いい勝負ですね");
                    baguboushi = false;
                    hikiwakebagu = false;

                }
            }


        }//end checkWinner

        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }//endforeach
            }//endtry
            catch { }
        }

        private void ニューゲームToolStripMenuItem_Click(object sender, EventArgs e)//リセット
        {
            turn = true;
            turn_count = 0;
            baguboushi = true;
            hikiwakebagu = true;


            foreach (Control c in Controls)
                {
                    try
                    {
                        Button b = (Button)c;
                        b.Enabled = true;
                        b.Text = "";
                    }//endtry
                    catch { }
                }//endforeach
            
            

        }

        private void button_enter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)
                    b.Text = "X";
                else
                    b.Text = "O";
            }//endif
            
        }

        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }//endif
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void カウントリセットToolStripMenuItem_Click(object sender, EventArgs e)
        {
            o_win_count.Text = "0";
            x_win_count.Text = "0";
            draw_count.Text = "0";



        }
    }
}

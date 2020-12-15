using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class BINGO : Form
    {
        /*
        FHD
        label1.Fontsize=46
        label2.Fontsize=52
        label3.Fontsize=16
        label4.Fontsize=28
        */
        //フォントサイズ
        const int fontsize = 46;

        Random rnd = new Random();
        //bingoの最大値
        const int bingo = 75;
        //生成された乱数を格納する配列の宣言
        int[] s = new int[bingo];
        //乱数の個数
        int i = 0;
        //bingoした人
        int h = 0;
        public BINGO()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                label4.Text = "0人";
            }
            //bingo個目の乱数を表示し終わったあとクリックされたときメモリエラーを防ぐため強制終了させる
            if (i > (bingo - 1))
            {
                Environment.Exit(0);
            }
            int num = 0;
            bool n;
            do
            {
                //1からconst int bingoの値までの乱数を生成
                int r = rnd.Next(1, (bingo+1));
                n = false;
                for (int j = 0; j < i + 1; j++)
                {
                    //もし今までに出たのならbool nをtrueにし、乱数を生成し直す(配列で評価)
                    if (r == s[j])
                    {
                        n = true;
                    }
                    //int numに生成した乱数を代入する
                    num = r;
                }
            } while (n);
            //配列のi番目に生成した乱数を入れる
            s[i] = num;
            label1.Text += s[i].ToString() + "   ";
            i++;
            label2.Text = i.ToString() + "個目";
            label3.Text = "残り" + (bingo - i).ToString() + "個";
        }

        private void BINGO_Load(object sender, EventArgs e)
        {
            //windowsの設定
            this.WindowState = FormWindowState.Maximized;
        }
        //再起動ボタン
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        //終了ボタン
        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        //人数カウント
        private void button4_Click(object sender, EventArgs e)
        {
            h++;
            label4.Text = h.ToString() + "人";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            h--;
            label4.Text = h.ToString() + "人";
        }
        //フォントサイズ変更
        private void button6_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.FontFamily, fontsize);
            label2.Font = new Font(label1.Font.FontFamily, fontsize * 52 / 46);
            label3.Font = new Font(label1.Font.FontFamily, fontsize * 16 / 46);
            label4.Font = new Font(label1.Font.FontFamily, fontsize * 28 / 46);
        }//FHD

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.FontFamily, fontsize * 1280 / 1920);
            label2.Font = new Font(label1.Font.FontFamily, fontsize * 52 / 46 * 1280 / 1920);
            label3.Font = new Font(label1.Font.FontFamily, fontsize * 16 / 46 * 1280 / 1920);
            label4.Font = new Font(label1.Font.FontFamily, fontsize * 28 / 46 * 1280 / 1920);
        }//HD
    }
}

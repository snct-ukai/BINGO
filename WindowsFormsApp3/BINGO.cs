using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class BINGO : Form
    {
        Random rnd = new System.Random();
        const int bingo = 75;
        int[] s = new int[bingo];
        int i = 0;
        int l = 0;
        const int line = 14;
        public BINGO()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (i > (bingo - 1))
            {
                Environment.Exit(0);
            }
            int num = 0;
            bool n = false;
            do
            {
                int r = rnd.Next(1, (bingo+1));
                n = false;
                for (int j = 0; j < i + 1; j++)
                {
                    if (r == s[j])
                    {
                        n = true;
                    }
                    num = r;
                }
            } while (n);
            s[i] = num;
            label1.Text += (s[i].ToString());
            label1.Text += "   ";
            i++;
            l++;
            if (l == line)
            {
                label1.Text += '\n';
                label1.Text += '\n';
                l = 0;
            }
            label2.Text = (i.ToString());
            label2.Text += "個目";
        }

        private void BINGO_Load(object sender, EventArgs e)
        {

        }
    }
}

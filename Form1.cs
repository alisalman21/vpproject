using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Piano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Console.Beep(200, 500);
            }
            if (radioButton2.Checked == true)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.C);
                player.Load();
                player.PlaySync();
            }
            if (radioButton3.Checked == true)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.C_Drum);
                player.Load();
                player.PlaySync();
            }

           
            {
                }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Console.Beep(250, 500);
            }
            if (radioButton2.Checked == true)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.D);
                player.Load();
                player.PlaySync();
            }
            if (radioButton3.Checked == true)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.D_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Console.Beep(300, 500);
            }
            if (radioButton2.Checked == true)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.E);
                player.Load();
                player.PlaySync();
            }
            if (radioButton3.Checked == true)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.E_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Console.Beep(350, 500);
            }
            if (radioButton2.Checked == true)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.F);
                player.Load();
                player.PlaySync();
            }
            if (radioButton3.Checked == true)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.F_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Console.Beep(400, 500);
            }
            if (radioButton2.Checked == true)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.G);
                player.Load();
                player.PlaySync();
            }
            if (radioButton3.Checked == true)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.G_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Console.Beep(450, 500);
            }
            if (radioButton2.Checked == true)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.A);
                player.Load();
                player.PlaySync();
            }
            if (radioButton3.Checked == true)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.A_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Console.Beep(500, 500);
            }
            if (radioButton2.Checked == true)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.B);
                player.Load();
                player.PlaySync();
            }
            if (radioButton3.Checked == true)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.B_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Console.Beep(550, 500);
            }
            if (radioButton2.Checked == true)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.C1);
                player.Load();
                player.PlaySync();
            }
            if (radioButton3.Checked == true)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.C1_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Console.Beep(600, 500);
            }
            if (radioButton2.Checked == true)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.D1);
                player.Load();
                player.PlaySync();
            }
            if (radioButton3.Checked == true)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.D1_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Console.Beep(650, 500);
            }
            if (radioButton2.Checked == true)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.E1);
                player.Load();
                player.PlaySync();
            }
            if (radioButton3.Checked == true)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.E1_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Console.Beep(700, 500);
            }
            if (radioButton2.Checked == true)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.F1);
                player.Load();
                player.PlaySync();
            }
            if (radioButton3.Checked == true)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.F1_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Console.Beep(700, 500);
            }
            if (radioButton2.Checked == true)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.C_s);
                player.Load();
                player.PlaySync();
            }
            if (radioButton3.Checked == true)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Cq_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Console.Beep(650, 500);
            }
            if (radioButton2.Checked == true)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.D_s);
                player.Load();
                player.PlaySync();
            }
            if (radioButton3.Checked == true)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Dq_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Console.Beep(600, 500);
            }
            if (radioButton2.Checked == true)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.F_s);
                player.Load();
                player.PlaySync();
            }
            if (radioButton3.Checked == true)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Fq_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Console.Beep(550, 500);
            }
            if (radioButton2.Checked == true)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.G_s);
                player.Load();
                player.PlaySync();
            }
            if (radioButton3.Checked == true)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Gq_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Console.Beep(500, 500);
            }
            if (radioButton2.Checked == true)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Bb);
                player.Load();
                player.PlaySync();
            }
            if (radioButton3.Checked == true)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Bb_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Console.Beep(450, 500);
            }
            if (radioButton2.Checked == true)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.C_s1);
                player.Load();
                player.PlaySync();
            }
            if (radioButton3.Checked == true)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Cq1_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Console.Beep(400, 500);
            }
            if (radioButton2.Checked == true)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.D_s1);
                player.Load();
                player.PlaySync();
            }
            if (radioButton3.Checked == true)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Dq1_Drum);
                player.Load();
                player.PlaySync();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minecraft_checklist
{
    public partial class MinecraftTracker : Form
    {
        public int food = 0;
        public int enemies = 0;
        public int biomes = 0;
        public int animals = 0;
        public MinecraftTracker()
        {
            InitializeComponent();
        }
        public void Reset()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            checkBox19.Checked = false;
            checkBox20.Checked = false;
            checkBox21.Checked = false;
            checkBox22.Checked = false;
            checkBox23.Checked = false;
            checkBox24.Checked = false;
            checkBox25.Checked = false;
            checkBox26.Checked = false;
            checkBox27.Checked = false;
            checkBox28.Checked = false;
            checkBox29.Checked = false;
            checkBox30.Checked = false;
            checkBox31.Checked = false;
            checkBox32.Checked = false;
            checkBox33.Checked = false;
            checkBox34.Checked = false;
            checkBox35.Checked = false;
            checkBox36.Checked = false;
            checkBox37.Checked = false;
            checkBox38.Checked = false;
            checkBox39.Checked = false;
            checkBox40.Checked = false;
            checkBox41.Checked = false;
            checkBox42.Checked = false;
            checkBox43.Checked = false;
            checkBox44.Checked = false;
            checkBox45.Checked = false;
            checkBox46.Checked = false;
            checkBox47.Checked = false;
            checkBox48.Checked = false;
            /*
            checkBox49.Checked = false;
            checkBox50.Checked = false;
            checkBox51.Checked = false;
            checkBox52.Checked = false;
            checkBox53.Checked = false;
            checkBox54.Checked = false;
            checkBox55.Checked = false;
            checkBox56.Checked = false;
            checkBox57.Checked = false;
            checkBox58.Checked = false;
            checkBox59.Checked = false;
            checkBox60.Checked = false;
            checkBox61.Checked = false;
            checkBox62.Checked = false;
            checkBox63.Checked = false;
            checkBox64.Checked = false;
            checkBox65.Checked = false;
            checkBox66.Checked = false;
            checkBox67.Checked = false;
            checkBox68.Checked = false;
            checkBox69.Checked = false;
            checkBox70.Checked = false;
            checkBox71.Checked = false;
            checkBox72.Checked = false;
            checkBox73.Checked = false;
            checkBox74.Checked = false;
            checkBox75.Checked = false;
            checkBox76.Checked = false;
            checkBox77.Checked = false;
            checkBox78.Checked = false;
            checkBox79.Checked = false;
            checkBox80.Checked = false;
            checkBox81.Checked = false;
            checkBox82.Checked = false;
            checkBox83.Checked = false;
            checkBox84.Checked = false;
            checkBox85.Checked = false;
            checkBox86.Checked = false;
            checkBox87.Checked = false;
            checkBox88.Checked = false;
            checkBox89.Checked = false;
            checkBox90.Checked = false;
            checkBox91.Checked = false;
            checkBox92.Checked = false;
            checkBox93.Checked = false;
            checkBox94.Checked = false;
            checkBox95.Checked = false;
            checkBox96.Checked = false;
            checkBox97.Checked = false;
            checkBox98.Checked = false;
            checkBox99.Checked = false;
            checkBox100.Checked = false;
            checkBox101.Checked = false;
            checkBox102.Checked = false;
            */
        }

        private void change()
        {
            foodCount.Text = food + "";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton43_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                food++;
            }
            else
            {
                food--;
            }
            change();
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                food++;
            }
            else
            {
                food--;
            }
            change();
        }

        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                food++;
            }
            else
            {
                food--;
            }
            change();
        }

        private void checkBox5_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                food++;
            }
            else
            {
                food--;
            }
            change();
        }

        private void checkBox6_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                food++;
            }
            else
            {
                food--;
            }
            change();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                food++;
            }
            else
            {
                food--;
            }
            change();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                food++;
            }
            else
            {
                food--;
            }
            change();
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                food++;
            }
            else
            {
                food--;
            }
            change();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                food++;
            }
            else
            {
                food--;
            }
            change();
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
            {
                food++;
            }
            else
            {
                food--;
            }
            change();
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true)
            {
                food++;
            }
            else
            {
                food--;
            }
            change();
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true)
            {
                food++;
            }
            else
            {
                food--;
            }
            change();
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked == true)
            {
                food++;
            }
            else
            {
                food--;
            }
            change();
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked == true)
            {
                food++;
            }
            else
            {
                food--;
            }
            change();
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked == true)
            {
                food++;
            }
            else
            {
                food--;
            }
            change();
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked == true)
            {
                food++;
            }
            else
            {
                food--;
            }
            change();
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked == true)
            {
                food++;
            }
            else
            {
                food--;
            }
            change();
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox19.Checked == true)
            {
                food++;
            }
            else
            {
                food--;
            }
            change();
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox20.Checked == true)
            {
                food++;
            }
            else
            {
                food--;
            }
            change();
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox21.Checked == true)
            {
                food++;
            }
            else
            {
                food--;
            }
            change();

        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox22.Checked == true)
            {
                food++;
            }
            else
            {
                food--;
            }
            change();

        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox23.Checked == true)
            {
                food++;
            }
            else
            {
                food--;
            }
            change();
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox24.Checked == true)
            {
                food++;
            }
            else
            {
                food--;
            }
            change();
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox25.Checked == true)
            {
                food++;
            }
            else
            {
                food--;
            }
            change();
        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox26.Checked == true)
            {
                food++;
            }
            else
            {
                food--;
            }
            change();
        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox27.Checked == true)
            {
                food++;
            }
            else
            {
                food--;
            }
            change();
        }

        private void checkBox36_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox36.Checked == true)
            {
                food++;
            }
            else
            {
                food--;
            }
            change();
        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox28.Checked == true)
            {
                food++;
            }
            else
            {
                food--;
            }
            change();
        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox29.Checked == true)
            {
                food++;
            }
            else
            {
                food--;
            }
            change();
        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox30.Checked == true)
            {
                food++;
            }
            else
            {
                food--;
            }
            change();
        }

        private void checkBox31_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox31.Checked == true)
            {
                food++;
            }
            else
            {
                food--;
            }
            change();
        }

        private void checkBox32_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox32.Checked == true)
            {
                food++;
            }
            else
            {
                food--;
            }
            change();
        }

        private void checkBox33_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox33.Checked == true)
            {
                food++;
            }
            else
            {
                food--;
            }
            change();
        }

        private void checkBox34_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox34.Checked == true)
            {
                food++;
            }
            else
            {
                food--;
            }
            change();
        }

        private void checkBox35_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox35.Checked == true)
            {
                food++;
            }
            else
            {
                food--;
            }
            change();
        }

        private void MinecraftTracker_Load(object sender, EventArgs e)
        {

        }
    }
}

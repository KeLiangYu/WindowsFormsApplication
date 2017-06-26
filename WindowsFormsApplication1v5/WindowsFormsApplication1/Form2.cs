using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void HeroInf(string lolname, string enname, string lolclass,float life,float lifere,float magic,float magicre,float speed,float physicalattack, float attackspeed, float attackdistance, float physicaldefense, float magicdefense)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile(@"..\\..\\LOL\\" + enname + ".png");
            label1.Text = lolname +"\n"+ enname+"\n"+ lolclass;
            textBox1.Text = life.ToString();
            textBox2.Text = lifere.ToString();
            textBox3.Text = magic.ToString();
            textBox4.Text = magicre.ToString();
            textBox5.Text = speed.ToString();
            textBox6.Text = physicalattack.ToString();
            textBox7.Text = attackspeed.ToString();
            textBox8.Text = attackdistance.ToString();
            textBox9.Text = physicaldefense.ToString();
            textBox10.Text = magicdefense.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 建立cnstr連接字串用來連接ch17DB.mdf資料庫
        string cnstr = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|LOLDB.mdf;" +
                    "Integrated Security=True";

        // 定義ShowData()方法將聯盟資料表對應的所有記錄顯示於flowLayoutPanel1上
        void ShowData(string selectCmd)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = cnstr;
                cn.Open();  // 連接資料庫
                // 建立SqlCommand物件cmd
                SqlCommand cmd = new SqlCommand(selectCmd, cn);
                // 傳回查詢結果的SqlDataRadedr物件dr
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string ENname = dr["英文名稱"].ToString();
                    PictureBox pb = new PictureBox();
                    pb.BorderStyle = BorderStyle.FixedSingle;
                    pb.Dock = DockStyle.Top;
                    pb.Location = new Point(0, 0);
                    pb.Size = new Size(100, 100);
                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                    pb.Name = ENname;
                    pb.Image = Image.FromFile(@"..\\..\\LOL\\" + ENname + ".png");
                    pb.Click += new EventHandler(pb_Click);
                    Label lb = new Label();
                    lb.Text = dr["英雄名稱"].ToString();
                    lb.TextAlign = ContentAlignment.MiddleCenter;
                    lb.Location = new Point(0, 104);
                    lb.Size = new Size(101, 12);
                    Panel pl = new Panel();
                    pl.Size = new Size(101, 120);
                    pl.Controls.Add(pb);
                    pl.Controls.Add(lb);
                    flowLayoutPanel1.Controls.Add(pl);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = cnstr;
                cn.Open();  // 連接資料庫

                string selectCmd = "SELECT * FROM 聯盟";
                
                ShowData(selectCmd);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = cnstr;
                cn.Open();  // 連接資料庫
                // 將輸入的姓名指定給searchName字串變數
                string searchName = textBox1.Text;
                // SELECT敘述的查詢條件為姓名等於searchName
                string selectCmd = "SELECT * FROM 聯盟 WHERE (英雄名稱 LIKE N'" + "%" + searchName + "%')";
                
                ShowData(selectCmd);
            }
        }

        private void Check_Clicked(object sender, EventArgs e)
        {
            string chkStr = "";
            flowLayoutPanel1.Controls.Clear();

            if (chkAssassin.Checked) chkStr += chkAssassin.Text;
            if (chkTank.Checked) chkStr += chkTank.Text;
            if (chkMaster.Checked) chkStr += chkMaster.Text;
            if (chkAid.Checked) chkStr += chkAid.Text;
            if (chkFighters.Checked) chkStr += chkFighters.Text;
            if (chkArcher.Checked) chkStr += chkArcher.Text;
            
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = cnstr;
                cn.Open();  // 連接資料庫
                string selectCmd = "SELECT * FROM 聯盟 WHERE (英雄類別 LIKE N'" + "%" + chkStr + "%')";
                
                ShowData(selectCmd);
            }
        }
        private void pb_Click(object sender, EventArgs e)
        {
            // 將sender轉型成PictureBox
            PictureBox pic = (PictureBox)sender;
            if (null == pic) return;
            // 取出pictureBox的名稱
            string name = pic.Name;
            // 以下就你讀取到的名稱去處理你要做的事情
            string lolname = "", enname = "", lolclass = "";
            float life = 0, lifere = 0, magic = 0, magicre = 0, speed = 0,
                  physicalattack = 0, attackspeed = 0, attackdistance = 0, physicaldefense = 0, magicdefense = 0;
            
            Form2 f = new Form2();
            f.Show();

            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = cnstr;
                cn.Open();  // 連接資料庫
                string selectCmd = "SELECT * FROM 聯盟 WHERE (英文名稱 LIKE N'" + "%" + name + "%')";
                SqlCommand cmd = new SqlCommand(selectCmd, cn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    lolname = dr["英雄名稱"].ToString();
                    enname = dr["英文名稱"].ToString();
                    lolclass = dr["英雄類別"].ToString();
                    life = Convert.ToSingle(dr["生命"]);
                    lifere = Convert.ToSingle(dr["生命回復"]);
                    magic = Convert.ToSingle(dr["魔力"]);
                    magicre = Convert.ToSingle(dr["魔力回復"]);
                    speed = Convert.ToSingle(dr["移動速度"]);
                    physicalattack = Convert.ToSingle(dr["物理攻擊"]);
                    attackspeed = Convert.ToSingle(dr["攻擊速度"]);
                    attackdistance = Convert.ToSingle(dr["攻擊距離"]);
                    physicaldefense = Convert.ToSingle(dr["物理防禦"]);
                    magicdefense = Convert.ToSingle(dr["魔法防禦"]);
                }
            }
            f.HeroInf(lolname, enname, lolclass, life, lifere, magic, magicre, speed, physicalattack, attackspeed, attackdistance, physicaldefense, magicdefense);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login fg = new Login();
            fg.ShowDialog();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        // 建立cnstr連接字串用來連接ch17DB.mdf資料庫
        string cnstr = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|LOLDB.mdf;" +
                    "Integrated Security=True";

        string oldFileName = "";
        string newFileName = "";

        private void Login_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = cnstr;
                cn.Open();  // 連接資料庫

                // SELECT敘述的查詢條件為姓名等於searchName
                string selectCmd = "SELECT * FROM 管理員";
                SqlCommand cmd = new SqlCommand(selectCmd, cn);
                // 傳回查詢結果的SqlDataRadedr物件dr
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if(textBox1.Text.ToString()== dr["帳號"].ToString())
                    {
                        if(textBox2.Text.ToString() == dr["密碼"].ToString())
                        {
                            panel1.Visible = true;
                        }
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try  //使用try...catch...敘述來補捉異動資料可能發生的例外 
            {
                using (SqlConnection cn = new SqlConnection())
                {
                    cn.ConnectionString = cnstr;
                    cn.Open();
                    string sqlStr = "INSERT INTO 聯盟(英雄名稱,英文名稱,英雄類別,生命,生命回復,魔力,魔力回復,移動速度,物理攻擊,攻擊速度,攻擊距離,物理防禦,魔法防禦) VALUES('" + textBox3.Text.Replace("'", "''") + "','" + textBox4.Text.Replace("'", "''") + "','" + textBox5.Text.Replace("'", "''") + "'," + float.Parse(textBox6.Text) + "," + float.Parse(textBox7.Text) + "," + float.Parse(textBox8.Text) + "," + float.Parse(textBox9.Text) + "," + float.Parse(textBox10.Text) + "," + float.Parse(textBox11.Text) + "," + float.Parse(textBox12.Text) + "," + float.Parse(textBox13.Text) + "," + float.Parse(textBox14.Text) + "," + float.Parse(textBox15.Text) + ")";
                    SqlCommand Cmd = new SqlCommand(sqlStr, cn);
                    Cmd.ExecuteNonQuery();
                }
                File.Copy(oldFileName, newFileName, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", 新增資料發生錯誤");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try	//使用try...catch...敘述來補捉異動資料可能發生的例外
            {
                using (SqlConnection cn = new SqlConnection())
                {
                    cn.ConnectionString = cnstr;
                    cn.Open();
                    string sqlStr = "UPDATE 聯盟 SET 英文名稱 = '" + textBox4.Text.Replace("'", "''") + "',英雄類別 = '" + textBox5.Text.Replace("'", "''") + "', 生命 = " + float.Parse(textBox6.Text) + ", 生命回復 = " + float.Parse(textBox7.Text) + ", 魔力 = " + float.Parse(textBox8.Text) + ", 魔力回復 = " + float.Parse(textBox9.Text) + ", 移動速度 = " + float.Parse(textBox10.Text) + ", 物理攻擊 = " + float.Parse(textBox11.Text) + ", 攻擊速度 = " + float.Parse(textBox12.Text) + ", 攻擊距離 = " + float.Parse(textBox13.Text) + ", 物理防禦 = " + float.Parse(textBox14.Text) + ", 魔法防禦 = " + float.Parse(textBox15.Text) + " WHERE 英雄名稱 = '" + textBox3.Text.Replace("'", "''") + "'";
                    SqlCommand Cmd = new SqlCommand(sqlStr, cn);
                    Cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ", 修改資料發生錯誤");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = cnstr;
                cn.Open();
                string sqlStr = "DELETE FROM 聯盟 WHERE 英雄名稱 = '" + textBox3.Text.Replace("'", "''") + "'";
                SqlCommand Cmd = new SqlCommand(sqlStr, cn);
                Cmd.ExecuteNonQuery();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "PNG Files (*.png)|*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = bmp;
            }
            oldFileName= openFileDialog1.FileName;
            newFileName = @"..\\..\\LOL\\"+ Path.GetFileName(openFileDialog1.FileName);
            textBox4.Text = Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
        }
    }
}

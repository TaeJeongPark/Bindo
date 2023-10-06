using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strConn;
        SqlConnection conn;
        SqlCommand cmd;

        private void btn_count_Click(object sender, EventArgs e)
        {
            if(tb_content.Text == "")
            {
                MessageBox.Show("한글 문장을 반드시 입력하세요");
                tb_content.Focus();
                return;
            }

            strConn = "Server=LINO\\SQLEXPRESS;Database=inhaDB;Trusted_Connection=True;";
            conn = new SqlConnection(strConn);
            conn.Open();

            cmd = new SqlCommand();
            cmd.Connection = conn;

            string sql;
            SqlDataReader reader;
            string text = tb_content.Text;

            foreach(char ch in text)
            {
                if('가' <= ch && ch <= '힣')
                {
                    sql = "SELECT * FROM countTable WHERE onechar='" + ch + "';";
                    cmd.CommandText = sql;
                    reader = cmd.ExecuteReader();

                    if(reader.Read())
                    {
                        int cnt = reader.GetInt32(1);
                        reader.Close();
                        sql = "UPDATE countTable SET count=" + (cnt + 1) + "WHERE onechar = '" + ch + "';";
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                    } else
                    {
                        reader.Close();
                        sql = "INSERT INTO countTable VALUES('" + ch + "', 1)";
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            sql = "SELECT * FROM countTable ORDER BY onechar asc;";
            cmd.CommandText = sql;
            reader = cmd.ExecuteReader();
            label1.Text = "";
            while(reader.Read())
            {
                label1.Text += "[" + reader.GetString(0) + "]는(은) [" + reader.GetInt32(1).ToString() + "]회\n";
            }
            reader.Close();
            conn.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            strConn = "Server=LINO\\SQLEXPRESS;Database=inhaDB;Trusted_Connection=True;";
            conn = new SqlConnection(strConn);
            conn.Open();

            cmd = new SqlCommand();
            cmd.Connection = conn;

            string sql;
            sql = "DELETE FROM countTable;";
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

            label1.Text = "";

            tb_content.Text = "";
            tb_content.Focus();

            conn.Close();

            MessageBox.Show("메시지 창에 모든 빈도에 대한 정보가 삭제되었습니다.");
        }
    }
}

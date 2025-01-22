using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppKTX
{
    public partial class Themphong : Form
    {
        function fn = new function();//
        string query;//

        public Themphong()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Themphong_Load(object sender, EventArgs e)
        {
            this.Location = new Point(469, 114);
            labelPhong.Visible = false;
            labelPhongExist.Visible = false;

            query = "SELECT * FROM PHONG";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void btnThemphong_Click(object sender, EventArgs e)
        {
            query = "SELECT * From PHONG WHERE MA_PHONG = " + txtSophong1.Text + "";
            DataSet ds = new DataSet(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                string status;
                if (checkBox1.Checked)
                {
                    status = "Yes";
                }
                else
                {
                    status = "No";
                }
                labelPhongExist.Visible = false;
                query = "insert into PHONG(MA_PHONG, TEN_PHONG) values (" + txtSophong1.Text + "," + status + ")";
                // insert into : truyền dữ liệu vào bảng PHONG với các trường MA_PHONG, TEN_PHONG, có giá trị tương ứng là MA_PHONG = txtSophong1.Text và TEN_PHONG = status.
                fn.setData(query, " Đã thêm phòng");
                Themphong_Load(this, null);
            }
            else
            {
                labelPhongExist.Text = "Phòng đã tồn tại.";
                labelPhongExist.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
<<<<<<< HEAD
}
=======
}
//Tai vừa sửa 
>>>>>>> 901abb5de273a497abbe646a5d53bad9c8a32cb1

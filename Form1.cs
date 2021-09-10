using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace necessities_list
{
    public partial class FormMain : Form
    {
        DataTable tb = new DataTable("NhuYeuPham");
        BUS_NYP bus = new BUS_NYP();
        Nhu_yeu_pham findNYP;
        int row_to_change;

        public FormMain()
        {
            InitializeComponent();

            Make_table();
            LoadData();

            List<string> type = new List<string>() { "Thức_ăn", "Đồ_dùng_sinh_hoạt", "Thiết_bị_hỗ_trợ", "Dược_phẩm", "Nước"};
            cbType.DataSource = type;
        }

        void Make_table()
        {
            tb.Columns.Add("Id", typeof(long));
            tb.Columns.Add("Tên", typeof(string));
            tb.Columns.Add("Nhà sản xuất", typeof(string));
            tb.Columns.Add("Giá", typeof(int));
            tb.Columns.Add("Loại", typeof(string));
            tb.PrimaryKey = new DataColumn[] { tb.Columns["ID"] };

            //null value in column
            DataColumn NSX = new DataColumn("NSX", typeof(DateTime));
            NSX.AllowDBNull = true;
            tb.Columns.Add(NSX);
            DataColumn HSD = new DataColumn("HSD", typeof(DateTime));
            NSX.AllowDBNull = true;
            tb.Columns.Add(HSD);
        }

        void LoadData(Nhu_yeu_pham NYP = null, int min = int.MinValue, int max = int.MaxValue)
        {
            tb.Rows.Clear();
            if(NYP == null)
            {
                dgvMain.DataSource = bus.DataQuery(tb);
            }
            else
            {
                dgvMain.DataSource = bus.DataQuery(tb, NYP, min, max);
            }

            for (int i = 0; i < dgvMain.Columns.Count; i++)
            {
                dgvMain.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            editToolStripMenuItem.Enabled = false;
            delToolStripMenuItem.Enabled = false;
        }

        #region checkboxInfor
        private void chboxPrice_CheckedChanged(object sender, EventArgs e)
        {
            numUDFrom.Enabled = !numUDFrom.Enabled;
            numUDTo.Enabled = !numUDTo.Enabled;
        }

        private void chbProducer_CheckedChanged(object sender, EventArgs e)
        {
            txtProducer.Enabled = !txtProducer.Enabled;
        }

        private void chbType_CheckedChanged(object sender, EventArgs e)
        {
            cbType.Enabled = !cbType.Enabled;
        }

        private void chbName_CheckedChanged(object sender, EventArgs e)
        {
            txtName.Enabled = !txtName.Enabled;
        }
        #endregion

        #region Control
        private void btnFind_Click(object sender, EventArgs e)
        {
            int default_min = int.MinValue;
            int default_max = int.MaxValue;
            int min = (int)numUDFrom.Value * 1000;
            int max = (int)numUDTo.Value * 1000;
            if (chbName.Checked)
            {
                if (!chbType.Checked && !chbProducer.Checked && !chboxPrice.Checked)
                {
                    findNYP = new Nhu_yeu_pham() { 
                        Name = txtName.Text.ToLower() };
                }
                else if(chbType.Checked && !chbProducer.Checked && !chboxPrice.Checked)
                {
                    findNYP = new Nhu_yeu_pham() { 
                        Name = txtName.Text.ToLower(),
                        TypeProduct = cbType.Text };
                }
                else if (!chbType.Checked && chbProducer.Checked && !chboxPrice.Checked)
                {
                    findNYP = new Nhu_yeu_pham() { 
                        Name = txtName.Text.ToLower(),
                        Producer = txtProducer.Text.ToLower() };
                }
                else if (!chbType.Checked && !chbProducer.Checked && chboxPrice.Checked)
                {
                    findNYP = new Nhu_yeu_pham() { 
                        Name = txtName.Text.ToLower()};
                    default_min = min;
                    default_max = max;
                }
                else if (chbType.Checked && chbProducer.Checked && !chboxPrice.Checked)
                {
                    findNYP = new Nhu_yeu_pham() { 
                        Name = txtName.Text.ToLower(),
                        TypeProduct = cbType.Text,
                        Producer = txtProducer.Text.ToLower()};
                }
                else if(chbType.Checked && !chbProducer.Checked && chboxPrice.Checked)
                {
                    findNYP = new Nhu_yeu_pham() {
                        Name = txtName.Text.ToLower(),
                        TypeProduct = cbType.Text};
                    default_min = min;
                    default_max = max;
                }
                else if (!chbType.Checked && chbProducer.Checked && chboxPrice.Checked)
                {
                    findNYP = new Nhu_yeu_pham() {
                        Name = txtName.Text.ToLower(),
                        Producer = txtProducer.Text.ToLower()};
                    default_min = min;
                    default_max = max;
                }
                else
                {
                    findNYP = new Nhu_yeu_pham()
                    {
                        Name = txtName.Text.ToLower(),
                        TypeProduct = cbType.Text,
                        Producer = txtProducer.Text.ToLower()
                    };
                    default_min = min;
                    default_max = max;
                }
            }
            else
            {
                if (chbType.Checked)
                {
                    if (!chbProducer.Checked && !chboxPrice.Checked)
                    {

                        findNYP = new Nhu_yeu_pham()
                        {
                            TypeProduct = cbType.Text,
                        };
                    }
                    else if (chbProducer.Checked && !chboxPrice.Checked)
                    {

                        findNYP = new Nhu_yeu_pham()
                        {
                            TypeProduct = cbType.Text,
                            Producer = txtProducer.Text.ToLower()
                        };
                    }
                    else if (!chbProducer.Checked && chboxPrice.Checked)
                    {

                        findNYP = new Nhu_yeu_pham()
                        {
                            TypeProduct = cbType.Text
                        };
                        default_min = min;
                        default_max = max;
                    }
                    else
                    {

                        findNYP = new Nhu_yeu_pham()
                        {
                            TypeProduct = cbType.Text,
                            Producer = txtProducer.Text.ToLower()
                        };
                        default_min = min;
                        default_max = max;
                    }
                }
                else
                {
                    if (chbProducer.Checked)
                    {
                        findNYP = new Nhu_yeu_pham()
                        {
                            Producer = txtProducer.Text.ToLower()
                        };
                        if (chboxPrice.Checked)
                        {
                            default_min = min;
                            default_max = max;
                        }
                    }
                    else {
                        findNYP = new Nhu_yeu_pham();
                        default_min = min;
                        default_max = max; ;
                    }
                }
            }
            LoadData(findNYP, default_min, default_max);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        #region exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            Exit_Program();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit_Program();
        }

        void Exit_Program()
        {
            if (MessageBox.Show("Thoát khỏi chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
        #endregion

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Information().ShowDialog();
            LoadData();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool Add_more = false;

            Nhu_yeu_pham NYP = new Nhu_yeu_pham()
            {
                Id = Convert.ToInt64(dgvMain.Rows[row_to_change].Cells[0].Value.ToString()),
                Name = dgvMain.Rows[row_to_change].Cells[1].Value.ToString(),
                Producer = dgvMain.Rows[row_to_change].Cells[2].Value.ToString(),
                Price = Convert.ToInt32(dgvMain.Rows[row_to_change].Cells[3].Value.ToString()),
                TypeProduct = dgvMain.Rows[row_to_change].Cells[4].Value.ToString()
            };

            if (dgvMain.Rows[row_to_change].Cells[5].Value.ToString() == "")
                NYP.Date_of_manufacture = null;
            else { NYP.Date_of_manufacture = (DateTime)dgvMain.Rows[row_to_change].Cells[5].Value; }

            if (dgvMain.Rows[row_to_change].Cells[6].Value.ToString() == "")
                NYP.Expiry = null;
            else { NYP.Expiry = (DateTime)dgvMain.Rows[row_to_change].Cells[6].Value; }

            new Information(Add_more, NYP).ShowDialog();
            LoadData();
        }

        private void delToolStripMenuItem_Click(object sender, EventArgs e)
        {
            long id_del = long.Parse(dgvMain.Rows[row_to_change].Cells[0].Value.ToString());
            string nameNYP = dgvMain.Rows[row_to_change].Cells[1].Value.ToString();
            if (MessageBox.Show($"Bạn có thực sự muốn xóa thông tin {nameNYP} không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bus.Delete(id_del);
                LoadData();
            }
        }
        private void inforToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://linktr.ee/phi.fine");
        }

        private void zaloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://chat.zalo.me/?null");
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sản phẩm là đồ tự chế của Võ Nhật Phi\n" +
                            "email liên lạc: nhatphi1598753@gmail.com", 
                            "Thông tin chung",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
        #endregion

        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row_to_change = dgvMain.CurrentCell.RowIndex;
            editToolStripMenuItem.Enabled = true;
            delToolStripMenuItem.Enabled = true;
        }
    }
}

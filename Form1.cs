using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace necessities_list
{
    public partial class FormMain : Form
    {
        DataTable tb = new DataTable("NhuYeuPham");
        int row_to_change;
        string path = Application.StartupPath + "\\data_source.xml"; // lấy đường dẫn trong máy
        private ListNhuYeuPham lstNYP;

        public ListNhuYeuPham LstNYP { get => lstNYP; set => lstNYP = value; }

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
            tb.Columns.Add("Id", typeof(int));
            tb.Columns.Add("Tên", typeof(string));
            tb.Columns.Add("Nhà sản xuất", typeof(string));
            tb.Columns.Add("Giá", typeof(int));
            tb.Columns.Add("Loại", typeof(TypeProduct));
            tb.PrimaryKey = new DataColumn[] { tb.Columns["ID"] };

            //null value in column
            DataColumn NSX = new DataColumn("NSX", typeof(DateTime));
            NSX.AllowDBNull = true;
            tb.Columns.Add(NSX);
            DataColumn HSD = new DataColumn("HSD", typeof(DateTime));
            NSX.AllowDBNull = true;
            tb.Columns.Add(HSD);
        }

        void LoadData(List<Nhu_yeu_pham> lstNYPnew = null, IEnumerable<XElement> lst = null)
        {
            tb.Rows.Clear();

            if(lst == null)
            {
                tb.ReadXml(path);

                foreach (DataRow dr in tb.Rows)
                {
                    DataRow row = tb.NewRow();
                    row["Id"] = int.Parse(dr["Id"].ToString());
                    row["Tên"] = dr["Tên"].ToString();

                    row["NSX"] = dr.IsNull("NSX") ? (Object)DBNull.Value : Convert.ToDateTime(dr["NSX"].ToString());
                    row["HSD"] = dr.IsNull("HSD") ? (Object)DBNull.Value : Convert.ToDateTime(dr["HSD"].ToString());
                    
                    row["Giá"] = dr["Giá"].ToString();
                    row["Loại"] = dr["Loại"].ToString();
                    row["Nhà sản xuất"] = dr["Nhà sản xuất"].ToString();
                }
            }
            else
            {
                tb.ReadXmlSchema(lst.ToString());

                foreach (DataRow dr in tb.Rows)
                {
                    DataRow row = tb.NewRow();
                    row["Id"] = int.Parse(dr["Id"].ToString());
                    row["Tên"] = dr["Tên"].ToString();

                    row["NSX"] = dr.IsNull("NSX") ? (Object)DBNull.Value : Convert.ToDateTime(dr["NSX"].ToString());
                    row["HSD"] = dr.IsNull("HSD") ? (Object)DBNull.Value : Convert.ToDateTime(dr["HSD"].ToString());

                    row["Giá"] = dr["Giá"].ToString();
                    row["Loại"] = dr["Loại"].ToString();
                    row["Nhà sản xuất"] = dr["Nhà sản xuất"].ToString();
                }
            }


            dgvMain.DataSource = tb;
            for (int i = 0; i < dgvMain.Columns.Count; i++)
            {
                dgvMain.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        #region search_list
        List<Nhu_yeu_pham> Name_NYP()
        {
            List<Nhu_yeu_pham> lst = lstNYP.LstNYP.Where(p => p.Name.ToLower().Contains(txtName.Text.ToLower())).ToList();
            return lst;
        }
        List<Nhu_yeu_pham> Type_NYP()
        {
            List<Nhu_yeu_pham> lst = lstNYP.LstNYP.Where(p => p.Tp.ToString() == cbType.Text).ToList();
            return lst;
        }
        List<Nhu_yeu_pham> Producer_NYP()
        {
            List<Nhu_yeu_pham> lst = lstNYP.LstNYP.Where(p => p.Producer.ToLower().Contains(txtProducer.Text.ToLower())).ToList();
            return lst;
        }
        List<Nhu_yeu_pham> Price_NYP()
        {
            List<Nhu_yeu_pham> lst = lstNYP.LstNYP.Where(p => p.Price >= (int)numUDFrom.Value*1000 && 
                                                              p.Price <= (int)numUDTo.Value*1000).ToList();
            return lst;
        }
        List<Nhu_yeu_pham> Name_Type_NYP()
        {
            List<Nhu_yeu_pham> lst = lstNYP.LstNYP.Where(p => p.Name.ToLower().Contains(txtName.Text.ToLower()) &&
                                                              p.Tp.ToString() == cbType.Text).ToList();
            return lst;
        }
        List<Nhu_yeu_pham> Name_Produce_NYP()
        {
            List<Nhu_yeu_pham> lst = lstNYP.LstNYP.Where(p => p.Name.ToLower().Contains(txtName.Text.ToLower()) &&
                                                              p.Producer.ToLower().Contains(txtProducer.Text.ToLower())).ToList();
            return lst;
        }
        List<Nhu_yeu_pham> Name_Price_NYP()
        {
            List<Nhu_yeu_pham> lst = lstNYP.LstNYP.Where(p => p.Name.ToLower().Contains(txtName.Text.ToLower()) &&
                                                              p.Price >= (int)numUDFrom.Value * 1000 &&
                                                              p.Price <= (int)numUDTo.Value * 1000).ToList();
            return lst;
        }
        List<Nhu_yeu_pham> Name_Type_Produce_NYP()
        {
            List<Nhu_yeu_pham> lst = lstNYP.LstNYP.Where(p => p.Name.ToLower().Contains(txtName.Text.ToLower()) &&
                                                              p.Tp.ToString() == cbType.Text &&
                                                              p.Producer.ToLower().Contains(txtProducer.Text.ToLower())).ToList();
            return lst;
        }
        List<Nhu_yeu_pham> Name_Type_Price_NYP()
        {
            List<Nhu_yeu_pham> lst = lstNYP.LstNYP.Where(p => p.Name.ToLower().Contains(txtName.Text.ToLower()) &&
                                                              p.Tp.ToString() == cbType.Text &&
                                                              p.Price >= (int)numUDFrom.Value * 1000 &&
                                                              p.Price <= (int)numUDTo.Value * 1000).ToList();
            return lst;
        }
        List<Nhu_yeu_pham> Name_Producer_Price_NYP()
        {
            List<Nhu_yeu_pham> lst = lstNYP.LstNYP.Where(p => p.Name.ToLower().Contains(txtName.Text.ToLower()) &&
                                                              p.Producer.ToLower().Contains(txtProducer.Text.ToLower()) &&
                                                              p.Price >= (int)numUDFrom.Value * 1000 &&
                                                              p.Price <= (int)numUDTo.Value * 1000).ToList();
            return lst;
        }
        List<Nhu_yeu_pham> Type_Price_NYP()
        {
            List<Nhu_yeu_pham> lst = lstNYP.LstNYP.Where(p => p.Tp.ToString() == cbType.Text &&
                                                              p.Price >= (int)numUDFrom.Value * 1000 &&
                                                              p.Price <= (int)numUDTo.Value * 1000).ToList();
            return lst;
        }
        List<Nhu_yeu_pham> Type_Producer_NYP()
        {
            List<Nhu_yeu_pham> lst = lstNYP.LstNYP.Where(p => p.Tp.ToString() == cbType.Text &&
                                                              p.Producer.ToLower().Contains(txtProducer.Text.ToLower())).ToList();
            return lst;
        }
        List<Nhu_yeu_pham> Type_Price_Producer_NYP()
        {
            List<Nhu_yeu_pham> lst = lstNYP.LstNYP.Where(p => p.Tp.ToString() == cbType.Text &&
                                                              p.Producer.ToLower().Contains(txtProducer.Text.ToLower()) &&
                                                              p.Price >= (int)numUDFrom.Value * 1000 &&
                                                              p.Price <= (int)numUDTo.Value * 1000).ToList();
            return lst;
        }
        List<Nhu_yeu_pham> Price_Producer_NYP()
        {
            List<Nhu_yeu_pham> lst = lstNYP.LstNYP.Where(p => p.Producer.ToLower().Contains(txtProducer.Text.ToLower()) &&
                                                              p.Price >= (int)numUDFrom.Value * 1000 &&
                                                              p.Price <= (int)numUDTo.Value * 1000).ToList();
            return lst;
        }
        List<Nhu_yeu_pham> All_NYP()
        {
            List<Nhu_yeu_pham> lst = lstNYP.LstNYP.Where(p => p.Name.ToLower().Contains(txtName.Text.ToLower()) &&
                                                              p.Tp.ToString() == cbType.Text &&
                                                              p.Producer.ToLower().Contains(txtProducer.Text.ToLower()) &&
                                                              p.Price >= (int)numUDFrom.Value * 1000 &&
                                                              p.Price <= (int)numUDTo.Value * 1000).ToList();
            return lst;
        }
        #endregion

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
            List<Nhu_yeu_pham> result = new List<Nhu_yeu_pham>();

            if (chbName.Checked)
            {
                if (!chbType.Checked && !chbProducer.Checked && !chboxPrice.Checked)
                {
                    result = Name_NYP();
                }
                else if(chbType.Checked && !chbProducer.Checked && !chboxPrice.Checked)
                {
                    result = Name_Type_NYP();
                }
                else if (!chbType.Checked && chbProducer.Checked && !chboxPrice.Checked)
                {
                    result = Name_Produce_NYP();
                }
                else if (!chbType.Checked && !chbProducer.Checked && chboxPrice.Checked)
                {
                    result = Name_Price_NYP();
                }
                else if (chbType.Checked && chbProducer.Checked && !chboxPrice.Checked)
                {
                    result = Name_Type_Produce_NYP();
                }
                else if(chbType.Checked && !chbProducer.Checked && chboxPrice.Checked)
                {
                    result = Name_Type_Price_NYP();
                }
                else if (!chbType.Checked && chbProducer.Checked && chboxPrice.Checked)
                {
                    result = Name_Producer_Price_NYP();
                }
                else
                {
                    result = All_NYP();
                }
            }
            else
            {
                if (chbType.Checked)
                {
                    if (!chbProducer.Checked && !chboxPrice.Checked)
                    {
                        result = Type_NYP();
                    }
                    else if (chbProducer.Checked && !chboxPrice.Checked)
                    {
                        result = Type_Producer_NYP(); 
                    }
                    else if (!chbProducer.Checked && chboxPrice.Checked)
                    {
                        result = Type_Price_NYP();
                    }
                    else
                    {
                        result = Type_Price_Producer_NYP();
                    }
                }
                else
                {
                    if (chbProducer.Checked)
                    {
                        result = (chboxPrice.Checked) ? Price_Producer_NYP() : Producer_NYP();
                    }
                    else result = Price_NYP();
                }
            }
            LoadData(result);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();// lstNYP.LstNYP);
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
            int id_edit = int.Parse(dgvMain.Rows[row_to_change].Cells[0].Value.ToString());
            new Information(Add_more, id_edit).ShowDialog();
            LoadData();
        }

        private void delToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Bạn có thực sự muốn xóa thông tin có id là {row_to_change} không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                XDocument xmlNYP = XDocument.Load(path);
                XElement cNYP = xmlNYP.Descendants("NhuYeuPham").Where(c => c.Element("Id").Value.Equals(row_to_change.ToString())).FirstOrDefault();
                cNYP.Remove();
                xmlNYP.Save(path);
            }
            LoadData();
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
            delToolStripMenuItem.Enabled = true;
        }
    }
}

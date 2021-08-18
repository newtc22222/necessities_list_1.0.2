using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace necessities_list
{
    public partial class Information : Form
    {
        string path = Application.StartupPath + "\\data_source.xml";
        bool add;
        int ID_edit;
        public Information(bool Add = true, int id_edit = int.MaxValue)
        {
            InitializeComponent();
            add = Add;
            ID_edit = id_edit;
            List<string> type = new List<string>() { "Thức_ăn", "Đồ_dùng_sinh_hoạt", "Thiết_bị_hỗ_trợ", "Dược_phẩm", "Nước" };
            cbTypeProduct.DataSource = type;

            if(add == false)
            {
                txtID.Text = ID_edit.ToString();
                txtID.ReadOnly = true;
                XDocument xmlNYP = XDocument.Load(path);
                XElement NYP = xmlNYP.Descendants("NhuYeuPham").Where(c => c.Element("Id").Value.Equals(ID_edit)).FirstOrDefault();
                txtName.Text = NYP.Element("Tên").Value;
                txtProducer.Text = NYP.Element("Nhà sản xuất").Value;
                cbTypeProduct.Text = NYP.Element("Loại").Value;

                int price = int.Parse(NYP.Element("Giá").Value);
                numUDMillions.Value = price / 1000000;
                numUDThousands.Value = price / 1000 % 1000;
                numUDCost.Value = price % 1000;
            }
            else
            {
                txtID.ReadOnly = false;
            }
        }

        private void chbDoM_CheckedChanged(object sender, EventArgs e)
        {
            dtPickerDoM.Enabled = !dtPickerDoM.Enabled;
        }

        private void chbExp_CheckedChanged(object sender, EventArgs e)
        {
            dtPickerExp.Enabled = !dtPickerExp.Enabled;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (add)
            {
                if (FullInfor())
                {
                    try
                    {
                        XDocument xmlNYP = XDocument.Load(path);
                        XElement newNYP = new XElement("NhuYeuPham",
                        new XElement("Id", txtID.Text),
                        new XElement("Tên", txtName.Text),
                        new XElement("Nhà_x0020_sản_x0020_xuất", txtProducer.Text),
                        new XElement("Giá", txtPrice_String.Text.Replace(" ", string.Empty)),
                        new XElement("Loại", cbTypeProduct.Text)
                        );

                        if (chbDoM.Checked)
                        {
                            newNYP.SetElementValue("NXS", dtPickerDoM.Value.ToString());
                        }
                        if (chbExp.Checked)
                        {
                            newNYP.SetElementValue("HSD", dtPickerExp.Value.ToString());
                        }

                        //xmlNYP.Element("NhuYeuPham").Add(newNYP);
                        xmlNYP.Add(newNYP);
                        xmlNYP.Save(path);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show($"Lỗi ID hoặc sự cố khác!\n" + err.Message);
                    }
                }
                else { MessageBox.Show("Vui lòng điền đầy đủ thông tin!"); }
            }
            else
            {
                if (FullInfor())
                {
                    try
                    {
                        XDocument xmlNYP = XDocument.Load(path);
                        XElement newNYP = xmlNYP.Descendants("NhuYeuPham").Where(c => c.Element("Id").Value.Equals(ID_edit)).FirstOrDefault();
                        newNYP.Element("Tên").Value = txtName.Text;
                        newNYP.Element("Nhà sản xuất").Value = txtProducer.Text;
                        newNYP.Element("Giá").Value = txtPrice_String.Text.Replace(" ", string.Empty);
                        if (chbDoM.Checked)
                        {
                            newNYP.Element("NSX").Value = dtPickerDoM.Value.ToString();
                        }
                        if (chbExp.Checked)
                        {
                            newNYP.Element("HSD").Value = dtPickerExp.Value.ToString();
                        }
                        xmlNYP.Save(path);

                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                }
                else { MessageBox.Show("Vui lòng điền đầy đủ thông tin!"); }
            }
        }

        private void numUDMillions_ValueChanged(object sender, EventArgs e)
        {
            if ((int)numUDMillions.Value > 0)
            {
                txtPrice_String.Text = numUDMillions.Value.ToString() + " " +
                                       textPrice((int)numUDThousands.Value) + " " +
                                       textPrice((int)numUDCost.Value);
            }
            else
            {
                txtPrice_String.Text = numUDThousands.Value.ToString() + " " + textPrice((int)numUDCost.Value);
            }
        }

        private string textPrice(int x)
        {
            if (x < 10)
            {
                return "00" + x.ToString();
            }
            else if (x < 100)
            {
                return "0" + x.ToString();
            }
            return x.ToString();
        }

        bool FullInfor()
        {
            if (txtID.Text == null || txtName.Text == null || txtProducer.Text == null || cbTypeProduct.Text == null)
                return false;
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace necessities_list
{
    public partial class Information : Form
    {
        BUS_NYP bus = new BUS_NYP();
        bool add;
        Nhu_yeu_pham nhuyeupham = null;

        public Information(bool Add = true, Nhu_yeu_pham oldNYP = null)
        {
            InitializeComponent();
            add = Add;
            nhuyeupham = oldNYP;
            List<string> type = new List<string>() { "Thức_ăn", "Đồ_dùng_sinh_hoạt", "Thiết_bị_hỗ_trợ", "Dược_phẩm", "Nước" };
            cbTypeProduct.DataSource = type;

            if(add == false)
            {
                txtID.Text = nhuyeupham.Id.ToString();

                txtName.Text = nhuyeupham.Name;
                txtProducer.Text = nhuyeupham.Producer;
                cbTypeProduct.Text = nhuyeupham.TypeProduct;

                int price = int.Parse(nhuyeupham.Price.ToString());
                numUDMillions.Value = price / 1000000;
                numUDThousands.Value = price / 1000 % 1000;
                numUDCost.Value = price % 1000;

                if(nhuyeupham.Date_of_manufacture == null)
                {
                    chbDoM.Checked = false;
                }
                else
                {
                    dtPickerDoM.Value = (DateTime)nhuyeupham.Date_of_manufacture;
                }

                if (nhuyeupham.Expiry == null)
                {
                    chbExp.Checked = false;
                }
                else
                {
                    dtPickerExp.Value = (DateTime)nhuyeupham.Expiry;
                }
            }
            else
            {
                string id_num = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() +
                                DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();

                txtID.Text = id_num;
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
                    bus.Add(TakeData());
                    this.Close();
                }
                else { MessageBox.Show("Vui lòng điền đầy đủ thông tin!"); }
            }
            else
            {
                if (FullInfor())
                {
                    bus.Edit(TakeData());
                    this.Close();
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
            if (txtID.Text == "" || txtName.Text == "" || txtProducer.Text == "" || cbTypeProduct.Text == "")
                return false;
            return true;
        }

        Nhu_yeu_pham TakeData()
        {
            Nhu_yeu_pham newNYP = new Nhu_yeu_pham()
            {
                Id = long.Parse(txtID.Text),
                Name = txtName.Text,
                Producer = txtProducer.Text,
                TypeProduct = cbTypeProduct.Text,
                Price = int.Parse(txtPrice_String.Text.Replace(" ", string.Empty))
            };

            if (chbDoM.Checked)
                newNYP.Date_of_manufacture = dtPickerDoM.Value.Date;
            else
                newNYP.Date_of_manufacture = null;

            if (chbExp.Checked)
                newNYP.Expiry = dtPickerExp.Value.Date;
            else
                newNYP.Expiry = null;

            return newNYP;
        }
    }
}

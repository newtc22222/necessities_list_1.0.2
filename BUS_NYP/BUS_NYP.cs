using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace necessities_list
{
    public class BUS_NYP
    {
        private XmlDocument doc = new XmlDocument();
        private XmlElement root;
        private string path = Application.StartupPath + "\\data_source.xml";

        public BUS_NYP()
        {
            doc.Load(path);
            root = doc.DocumentElement;
        }

        public void Add(Nhu_yeu_pham NYP)
        {
            // tạo nút nhu yếu phẩm
            XmlNode newNYP = doc.CreateElement("NhuYeuPham");

            // tạo nút con của nhu yếu phẩm
            XmlElement id = doc.CreateElement("Id");
            id.InnerText = NYP.Id.ToString(); // gán giá trị
            newNYP.AppendChild(id); // thêm con vào node

            XmlElement name = doc.CreateElement("Tên");
            name.InnerText = NYP.Name; 
            newNYP.AppendChild(name);

            XmlElement producer = doc.CreateElement("Nhà_x0020_sản_x0020_xuất");
            producer.InnerText = NYP.Producer;
            newNYP.AppendChild(producer);

            XmlElement type = doc.CreateElement("Loại");
            type.InnerText = NYP.TypeProduct;
            newNYP.AppendChild(type);

            if(NYP.Date_of_manufacture != null)
            {
                XmlElement DoM = doc.CreateElement("NSX");
                DoM.InnerText = NYP.Date_of_manufacture.ToString();
                newNYP.AppendChild(DoM);
            }

            if(NYP.Expiry != null)
            {
                XmlElement Exp = doc.CreateElement("HSD");
                Exp.InnerText = NYP.Expiry.ToString();
                newNYP.AppendChild(Exp);
            }

            XmlElement price = doc.CreateElement("Giá");
            price.InnerText = NYP.Price.ToString();
            newNYP.AppendChild(price);

            // thêm nhu yếu phẩm vừa tạo vào root
            root.AppendChild(newNYP);
            doc.Save(path);
        }

        public void Edit(Nhu_yeu_pham NYPnew)
        {
            XmlNode oldNYP = root.SelectSingleNode($"NhuYeuPham[Id = {NYPnew.Id}]");
            if(oldNYP != null)
            {
                XmlNode newNYP = doc.CreateElement("NhuYeuPham");
                // tạo nút con của nhu yếu phẩm
                XmlElement id = doc.CreateElement("Id");
                id.InnerText = NYPnew.Id.ToString(); // gán giá trị
                newNYP.AppendChild(id); // thêm con vào node

                XmlElement name = doc.CreateElement("Tên");
                name.InnerText = NYPnew.Name;
                newNYP.AppendChild(name);

                XmlElement producer = doc.CreateElement("Nhà_x0020_sản_x0020_xuất");
                producer.InnerText = NYPnew.Producer;
                newNYP.AppendChild(producer);

                XmlElement type = doc.CreateElement("Loại");
                type.InnerText = NYPnew.TypeProduct;
                newNYP.AppendChild(type);

                if (NYPnew.Date_of_manufacture != null)
                {
                    XmlElement DoM = doc.CreateElement("NSX");
                    DoM.InnerText = NYPnew.Date_of_manufacture.ToString();
                    newNYP.AppendChild(DoM);
                }

                if (NYPnew.Expiry != null)
                {
                    XmlElement Exp = doc.CreateElement("HSD");
                    Exp.InnerText = NYPnew.Expiry.ToString();
                    newNYP.AppendChild(Exp);
                }

                XmlElement price = doc.CreateElement("Giá");
                price.InnerText = NYPnew.Price.ToString();
                newNYP.AppendChild(price);

                // thay thế nhu yếu phẩm vừa tạo vào root
                root.ReplaceChild(newNYP, oldNYP);
                doc.Save(path);
            }
        }

        public void Delete(long id)
        {
            XmlNode nyp = root.SelectSingleNode($"NhuYeuPham[Id = '{id}']");
            if(nyp != null)
            {
                root.RemoveChild(nyp);
                doc.Save(path);
            }
        }

        public DataTable DataQuery(DataTable tb, Nhu_yeu_pham NYP = null, int min = int.MinValue, int max = int.MaxValue)
        {
            XElement xml = XElement.Load(path); // Tải file dưới định dang các element
            IEnumerable<XElement> data = null; // list lưu trữ element
            if (NYP == null)
            {
                data = xml.Elements();
            }
            else
            {
                if (NYP.Name != null && NYP.Producer == null && NYP.TypeProduct == null)
                {
                    data = from nyp in xml.Elements("NhuYeuPham")
                           where nyp.Element("Tên").Value.ToLower().Contains(NYP.Name)
                           && (int)nyp.Element("Giá") >= min && (int)nyp.Element("Giá") <= max
                           select nyp;
                }
                else if (NYP.Name != null && NYP.Producer != null && NYP.TypeProduct == null)
                {
                    data = from nyp in xml.Elements("NhuYeuPham")
                           where nyp.Element("Tên").Value.ToLower().Contains(NYP.Name)
                           && nyp.Element("Nhà_x0020_sản_x0020_xuất").Value.ToLower().Contains(NYP.Producer)
                           && (int)nyp.Element("Giá") >= min && (int)nyp.Element("Giá") <= max
                           select nyp;
                }
                else if (NYP.Name != null && NYP.Producer != null && NYP.TypeProduct != null)
                {
                    data = from nyp in xml.Elements("NhuYeuPham")
                           where nyp.Element("Tên").Value.ToLower().Contains(NYP.Name)
                           && nyp.Element("Nhà_x0020_sản_x0020_xuất").Value.ToLower().Contains(NYP.Producer)
                           && (string)nyp.Element("Loại").Value == NYP.TypeProduct
                           && (int)nyp.Element("Giá") >= min && (int)nyp.Element("Giá") <= max
                           select nyp;
                }
                else if (NYP.Name == null && NYP.Producer != null && NYP.TypeProduct == null)
                {
                    data = from nyp in xml.Elements("NhuYeuPham")
                           where nyp.Element("Nhà_x0020_sản_x0020_xuất").Value.ToLower().Contains(NYP.Producer)
                           && (int)nyp.Element("Giá") >= min && (int)nyp.Element("Giá") <= max
                           select nyp;
                }
                else if (NYP.Name == null && NYP.Producer != null && NYP.TypeProduct != null)
                {
                    data = from nyp in xml.Elements("NhuYeuPham")
                           where nyp.Element("Nhà_x0020_sản_x0020_xuất").Value.ToLower().Contains(NYP.Producer)
                           && (string)nyp.Element("Loại").Value == NYP.TypeProduct
                           && (int)nyp.Element("Giá") >= min && (int)nyp.Element("Giá") <= max
                           select nyp;
                }
                else if (NYP.Name == null && NYP.Producer == null && NYP.TypeProduct != null)
                {
                    data = from nyp in xml.Elements("NhuYeuPham")
                           where (string)nyp.Element("Loại").Value == NYP.TypeProduct
                           && (int)nyp.Element("Giá") >= min && (int)nyp.Element("Giá") <= max
                           select nyp;
                }
                else if (NYP.Name == null && NYP.Producer == null && NYP.TypeProduct == null)
                {
                    data = from nyp in xml.Elements("NhuYeuPham")
                           where (int)nyp.Element("Giá") >= min && (int)nyp.Element("Giá") <= max
                           select nyp;
                }
            }
           
            foreach(var item in data)
            {
                DataRow row = tb.NewRow();
                row["Id"] = item.Element("Id").Value;
                row["Tên"] = item.Element("Tên").Value;

                if (item.Element("NSX") != null)
                {
                    row["NSX"] = item.Element("NSX").Value;
                }
                if (item.Element("HSD") != null)
                {
                    row["HSD"] = item.Element("HSD").Value;
                }

                row["Giá"] = item.Element("Giá").Value;
                row["Loại"] = item.Element("Loại").Value; 
                row["Nhà sản xuất"] = item.Element("Nhà_x0020_sản_x0020_xuất").Value;
                tb.Rows.Add(row);
            }
            return tb;
        }
    }
}

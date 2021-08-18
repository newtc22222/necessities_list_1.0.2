using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace necessities_list
{
    public class Nhu_yeu_pham
    {
        private int id;
        private string name;
        private TypeProduct tp;
        private string producer;
        private DateTime? date_of_manufacture;
        private DateTime? expiry;
        private int price;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public TypeProduct Tp { get => tp; set => tp = value; }
        public string Producer { get => producer; set => producer = value; }
        public DateTime? Date_of_manufacture { get => date_of_manufacture; set => date_of_manufacture = value; }
        public DateTime? Expiry { get => expiry; set => expiry = value; }
        public int Price { get => price; set => price = value; }
    }

    public enum TypeProduct
    {
        Thức_ăn,
        Đồ_dùng_sinh_hoạt,
        Thiết_bị_hỗ_trợ,
        Dược_phẩm,
        Nước
    }
}

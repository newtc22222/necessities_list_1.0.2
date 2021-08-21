using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace necessities_list
{
    public class Nhu_yeu_pham
    {
        private long id;
        private string name;
        private string typeProduct;
        private string producer;
        private DateTime? date_of_manufacture;
        private DateTime? expiry;
        private int price;

        public long Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string TypeProduct { get => typeProduct; set => typeProduct = value; }
        public string Producer { get => producer; set => producer = value; }
        public DateTime? Date_of_manufacture { get => date_of_manufacture; set => date_of_manufacture = value; }
        public DateTime? Expiry { get => expiry; set => expiry = value; }
        public int Price { get => price; set => price = value; }
    }
}

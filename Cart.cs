using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_BO
{
    public class Cart
    {
        string itemName;
        int ord_id;
        static int a = 999;
        int quan_need;
        string cusname;
        long cuscont;
        string cusemail;
        public Cart(string itemName,int quan_need,string cusname, long cuscont, string cusemail)
        {
            this.itemName = itemName;
            this.quan_need = quan_need;
            this.cusname = cusname;
            this.cuscont = cuscont;
            this.cusemail = cusemail;
            this.ord_id = a++;
        }

        public string ItemName
        {
            get
            {
                return itemName;
            }

            set
            {
                itemName = value;
            }
        }

        public string Cusname
        {
            get
            {
                return cusname;
            }

            set
            {
                cusname = value;
            }
        }

        public long Cuscont
        {
            get
            {
                return cuscont;
            }

            set
            {
                cuscont = value;
            }
        }

        public string Cusemail
        {
            get
            {
                return cusemail;
            }

            set
            {
                cusemail = value;
            }
        }

        public int Quan_need
        {
            get
            {
                return quan_need;
            }

            set
            {
                quan_need = value;
            }
        }

        public int Ord_id
        {
            get
            {
                return ord_id;
            }

            set
            {
                ord_id = value;
            }
        }
    }
}

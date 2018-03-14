using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Order_BO;
using System.Data;

namespace Order_DAL
{
    public class Operations
    {
        public int OrderItem(Cart c)
        {
            SqlConnection con = new SqlConnection("server=intvmsql01;user id= pj01tms55_1718;password=tcstvm;database=db01tms55_1718");
            con.Open();
            SqlCommand cmd = new SqlCommand("ord_cart_insert31", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DateTime dt = DateTime.Now;
            cmd.Parameters.AddWithValue("@item_name", c.ItemName);
            cmd.Parameters.AddWithValue("@custname", c.Cusname);
            cmd.Parameters.AddWithValue("@custcont", c.Cuscont);
            cmd.Parameters.AddWithValue("@cust_email", c.Cusemail);
            cmd.Parameters.AddWithValue("@Orderdate", dt);
            cmd.Parameters.AddWithValue("@ord_id", 0);
            cmd.Parameters["@ord_id"].Direction = ParameterDirection.Output;
            if (c.ItemName == "Power Bank" && c.Quan_need <= 10)
            {
                cmd.Parameters.AddWithValue("@QuantitiyNeeded", c.Quan_need);
                cmd.Parameters.AddWithValue("@totalPrice", c.Quan_need*5500 );
            }
            if(c.ItemName == "Memory Card" && c.Quan_need <= 10)
            {
                cmd.Parameters.AddWithValue("@QuantitiyNeeded", c.Quan_need);
                cmd.Parameters.AddWithValue("@totalPrice", c.Quan_need * 2000);
            }
            if(c.ItemName == "Wallet" && c.Quan_need <= 5)
            {
                cmd.Parameters.AddWithValue("@QuantitiyNeeded", c.Quan_need);
                cmd.Parameters.AddWithValue("@totalPrice", c.Quan_need * 1000);

            }
            if (c.ItemName == "Laptop" && c.Quan_need <= 3)
            {
                cmd.Parameters.AddWithValue("@QuantitiyNeeded", c.Quan_need);
                cmd.Parameters.AddWithValue("@totalPrice", c.Quan_need * 35000);
            }
            int ra = cmd.ExecuteNonQuery();
            if (ra > 0)
            {
                int id = Convert.ToInt32(cmd.Parameters["@ord_id"].Value);
                return id;
            }
            else
                return 0;


        }
        public object ViewDetails()
        {
            SqlConnection con = new SqlConnection("server=intvmsql01;user id= pj01tms55_1718;password=tcstvm;database=db01tms55_1718");
            con.Open();
            SqlDataAdapter adp1 = new SqlDataAdapter("viw_orderdtls_36", con);
            DataTable dt = new DataTable();
            adp1.Fill(dt);
            return dt;

        }
        public int DeleteDetails(int id)
        {
            SqlConnection con = new SqlConnection("server=intvmsql01;user id= pj01tms55_1718;password=tcstvm;database=db01tms55_1718");
            con.Open();
            SqlCommand cmd = new SqlCommand("cncl_ordr_356", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ord_id", id);
            int ra3 = cmd.ExecuteNonQuery();
            if (ra3 > 0)
            {
                return id;
            }
            else
                return 0;
        }
    }
}

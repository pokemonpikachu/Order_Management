using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Order_BO;
using Order_DAL;

namespace Order_Management
{
    public partial class Order_Item : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string itemName = TextBox1.Text;
            int quan_need = Convert.ToInt32(TextBox2.Text);
            string cusname = TextBox3.Text;
            long cuscont = Convert.ToInt64(TextBox4.Text);
            string cusemail = TextBox5.Text;
            Cart c = new Cart(itemName, quan_need, cusname, cuscont, cusemail);
            Operations op = new Operations();
            int x=op.OrderItem(c);
            if(x>0)
            {
                Response.Write("<script>alert('Added Successfully')</script>");
            }
            else
                Response.Write("<script>alert('Enter Proper details')</script>");

        }
    }
}

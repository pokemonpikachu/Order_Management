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
    public partial class View_Order_Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Operations op = new Operations();
            GridView1.DataSource = op.ViewDetails();
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            Operations op1 = new Operations();
            int x = op1.DeleteDetails(id);
            if(x>0)
            {
                Response.Write("<script>alert('Dleted Successfully')</script>");
            }
            else
                Response.Write("<script>alert('Enter Proper Id')</script>");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationDB
{
    public partial class ListData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            this.GridView1.DataSource = DataBaseExecutor.SelectTableDT();
            this.GridView1.DataBind();
        }
    } 
}
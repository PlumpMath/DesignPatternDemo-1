using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class SingletonDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            // Constructor is protected -- cannot use new
            Singleton s1 = Singleton.getInstance();
            Singleton s2 = Singleton.getInstance();
            if (s1 == s2)
            {
                Response.Write("the same instance");
            }
            else
            {
                Response.Write("different instance");
            }

        }
    }
}
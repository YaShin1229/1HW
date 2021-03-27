using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1HW
{
    public partial class Prime : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int prime = 80;
            bool j = true;
            if (prime == 1)
            {
                Response.Write("NO");
            }
            else if (prime == 2)
            {
                Response.Write("Yes");
            }
            else if (prime > 2)
            {
                for (int i = 2; i < prime; i++)
                {
                    if (prime % i == 0)
                    {
                        Response.Write("NO");
                        j = false;
                        break;
                    }
                }
                if (j == true)
                    Response.Write("Yes");
            }
        }
    }
}
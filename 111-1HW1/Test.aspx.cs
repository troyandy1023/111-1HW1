﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1HW1
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Hallo App");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Hallo Button");
            Label1.Text = "Hallo Button";
        }
    }
}
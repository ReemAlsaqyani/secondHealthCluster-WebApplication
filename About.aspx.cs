using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SecondHealthCluster
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Response.Clear();
                //project box
                Response.Write("<div style='max-width:900px;margin:50px auto; padding:70px; font-family:Arial,sans-serif;line-height4.6;background-color:#f4f4f4;border-radius:10px;'>");
                //Project title
                Response.Write("<h2 style='text-align:center;color:#333;'>About secondHealthCluster</h2><br/>");

                //Intro paragraph
                Response.Write("<p style='font-size:25px;color:#555;'>");
                Response.Write("secondHealthCluster is a Comprehensive System Designed To Manage All Employee-Related Data Within a Health Complex." +
                                "It Provides an Easy-To-Use Interface and Secure Connection To The Database.");
                Response.Write("</p>");


                //feature list
                Response.Write("<ul style='font-size:23px;color:#555;'>");
                Response.Write("<li>Add, Update, and Delete Employee Records.</li>");
                Response.Write("<li>Display Employee Information Clearly.</li>");
                Response.Write("<li>Secure Connection with Microsoft SQL Server.</li>");
                Response.Write("<li>User-Friendly Interface Using ASP.NET Web Forms, without using JavaScript.</li>");
                Response.Write("<li>Supports Administrative Tasks and Reporting.</li>");
                Response.Write("</ul>");

                //conclusion
                Response.Write("<p style='font-size:23px;color:#555;'><br>");
                Response.Write("The System aims To Simplify Employee Data Management and Enhance Efficiency For The Staff and Administrators.");
                Response.Write("</p>");

                Response.Write("</div>");

            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BonusAssignment
{
    public partial class CoordinatePart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();
                
                if (Page.IsValid)
                {
                   
                    int user_x_cord = Convert.ToInt32(user_x_axis.Text);
                    int user_y_cord = Convert.ToInt32(user_y_axis.Text);
                    //Check if the user enters any zeros to give them an error
                    if (user_x_cord == 0 || user_y_cord == 0)
                    {
                        zero_box.Visible = true;
                        zero_box.InnerHtml = "Please do not use 0s";
                    }
                    if (user_x_cord.GetType() = true ||user_y_cord.GetType() = true)
                    {
                        zero_box.Visible = true;
                        zero_box.InnerHtml = "Please enter a integer";
                    }
                    else
                    {
                        zero_box.Visible = false;
                        output_box.InnerHtml = "";
                        if (user_x_cord > 0)
                        {
                            if (user_y_cord > 0)
                            {
                                output_box.InnerHtml += "(" + user_x_cord + "," + user_y_cord + ") falls in quadrant 1";
                            }
                            else
                            {
                                output_box.InnerHtml += "(" + user_x_cord + "," + user_y_cord + ") falls in quadrant 4";
                            }
                        }
                        else if (user_x_cord < 0)
                        {
                            if (user_y_cord > 0)
                            {
                                output_box.InnerHtml += "(" + user_x_cord + "," + user_y_cord + ") falls in quadrant 2";
                            }
                            else
                            {
                                output_box.InnerHtml += "(" + user_x_cord + "," + user_y_cord + ") falls in quadrant 3";
                            }
                        }
                    }

                }
            }
        }
    }
}
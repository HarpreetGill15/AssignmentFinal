using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BonusAssignment
{
    public partial class CalenderPart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();

                if (Page.IsValid)
                {
                    output.InnerHtml = "";

                    for (int i = 1; i< 32;i++)
                    {
                       
                            if (user_days_working.Items[2].Selected)
                            {
                                output.InnerHtml += "Oct " + (i) + " is a Tuesday! Time to work</br>";
                            }
                            else
                            {
                                output.InnerHtml += "Oct " + (i) + " is a Tuesday! Time to have fun!</br>";
                            }
                            i++;
                            if (user_days_working.Items[3].Selected)
                            {
                                output.InnerHtml += "Oct " + (i) + " is a Wednesday! Time to work</br>";
                            }
                            else
                            {
                                output.InnerHtml += "Oct " + (i) + " is a Wednesday! Time to have fun!</br>";
                            }
                            i++;
                            if (user_days_working.Items[4].Selected)
                            {
                                output.InnerHtml += "Oct " + (i) + " is a Thursday! Time to work</br>";
                            }
                            else
                            {
                                output.InnerHtml += "Oct " + (i) + " is a Thursday! Time to have fun!</br>";
                            }
                            i++;
                            if (user_days_working.Items[5].Selected)
                            {
                                output.InnerHtml += "Oct " + (i) + " is a Friday! Time to work</br>";
                            }
                            else
                            {
                                output.InnerHtml += "Oct " + (i) + " is a Friday! Time to have fun!</br>";
                            }
                            i++;
                            if (user_days_working.Items[6].Selected)
                            {
                                output.InnerHtml += "Oct " + (i) + " is a Saturday! Time to work</br>";
                            }
                            else
                            {
                                output.InnerHtml += "Oct " + (i) + " is a Saturday! Time to have fun!</br>";
                            }
                            i++;
                            if (user_days_working.Items[0].Selected)
                            {
                                output.InnerHtml += "Oct " + (i) + " is a Sunday! Time to work</br>";
                            }
                            else
                            {
                                output.InnerHtml += "Oct " + (i) + " is a Sunday! Time to have fun!</br>";
                            }
                            i++;
                            if (user_days_working.Items[1].Selected)
                            {
                                output.InnerHtml += "Oct " + (i) + " is a Monday! Time to work</br>";
                            }
                            else
                            {
                                output.InnerHtml += "Oct " + (i) + " is a Monday! Time to have fun!</br>";
                            }
                            i++;
                            if(i >= 32)
                            {
                                break;
                            }

                    }// End of For loop

                    
                }
            }
        }
    }
}
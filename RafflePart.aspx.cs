using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BonusAssignment
{
    public partial class RafflePart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Validate();
            if (Page.IsValid)
            {
                int user_tickets = Convert.ToInt32(user_amun_tickets.Text);
                double total = user_tickets * 0.25;
                int leftover;

                output.InnerHtml = "";
                if (user_tickets <= 50)
                {
                    for (int i = 1; i <= user_tickets; i++)
                    {
                        output.InnerHtml += "<div class='line'>";
                        output.InnerHtml += "You received a bundle of 1! That's " + (i) + " ticket(s)!</div>";
                    }

                    output.InnerHtml += "<div class='line'>Your total ticket(s) is " + user_tickets + " and your cost is $" + total + "</div>";
                }
                else if (user_tickets <= 150 && user_tickets >= 51)
                {
                    loop(user_tickets, 2);
                    //for (int i = 2; i <= user_tickets; i = i + 2)
                    //{
                    //    output.InnerHtml += "<div class='line'>";
                    //    output.InnerHtml += "You received a bundle of 2! That's " + (i) + " ticket(s)!</div>";
                    //}
                    //if (user_tickets % 2 != 0)
                    //{
                    //    leftover = user_tickets % 2;
                    //    output.InnerHtml += "<div class='line'>";
                    //    output.InnerHtml += "Your leftover is " + leftover + ". That's " + user_tickets + " ticket(s)!</div>";
                    //}
                    //output.InnerHtml += "<div class='line'>Your total ticket(s) is " + user_tickets + " and your cost is $" + total + "</div>";
                }
                else if (user_tickets <= 300 && user_tickets >= 151)
                {
                    loop(user_tickets, 3);
                    //for (int i = 3; i <= user_tickets; i = i + 3)
                    //{
                    //    output.InnerHtml += "<div class='line'>";
                    //    output.InnerHtml += "You received a bundle of 3! That's " + (i) + " ticket(s)!</div>";
                    //}
                    //if (user_tickets % 3 != 0)
                    //{
                    //    leftover = user_tickets % 3;
                    //    output.InnerHtml += "<div class='line'>";
                    //    output.InnerHtml += "Your leftover is " + leftover + ". That's " + user_tickets + " ticket(s)!</div>";
                    //}
                    //output.InnerHtml += "<div class='line'>Your total ticket(s) is " + user_tickets + " and your cost is " + total;
                }
                else if (user_tickets >= 301)
                {
                    loop(user_tickets, 5);
                    //for (int i = 5; i <= user_tickets; i = i + 5)
                    //{
                    //    output.InnerHtml += "<div class='line'>";
                    //    output.InnerHtml += "You received a bundle of 5! That's" + (i) + " ticket(s)!</div>";
                    //}
                    //if (user_tickets % 5 != 0)
                    //{
                    //    leftover = user_tickets % 5;
                    //    output.InnerHtml += "<div class='line'>";
                    //    output.InnerHtml += "Your leftover is " + leftover + ". That's " + user_tickets + " ticket(s)!</div>";
                    //}
                    //output.InnerHtml += "<div class='line'>Your total ticket(s) is " + user_tickets + " and your cost is " + total;
                }

            }


        }
        public void loop (int tickets,int bundle){
            for (int i = bundle; i <= user_tickets; i = i + bundle)
            {
                output.InnerHtml += "<div class='line'>";
                output.InnerHtml += "You received a bundle of 5! That's" + (i) + " ticket(s)!</div>";
            }
            if (user_tickets % bundle != 0)
            {
                leftover = user_tickets % bundle;
                output.InnerHtml += "<div class='line'>";
                output.InnerHtml += "Your leftover is " + leftover + ". That's " + user_tickets + " ticket(s)!</div>";
            }
            output.InnerHtml += "<div class='line'>Your total ticket(s) is " + user_tickets + " and your cost is " + total;
        }

    }
}
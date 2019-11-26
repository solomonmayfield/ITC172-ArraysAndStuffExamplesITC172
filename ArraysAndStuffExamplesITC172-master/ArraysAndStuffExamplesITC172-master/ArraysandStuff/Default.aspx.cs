using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string[,] product = new string[5, 2];
    


    protected void Page_Load(object sender, EventArgs e)
    {
       
            product[0, 0] = "Lettuce";
            product[0, 1] = ".99";
            product[1, 0] = "Carrots";
            product[1, 1] = "2.98";
            product[2, 0] = "Eggplants";
            product[2, 1] = "2.25";
            product[3, 0] = "Tomatoes";
            product[3, 1] = "1.98";
            product[4, 0] = "Onions";
            product[4, 1] = ".12";

        if (!IsPostBack)
        {
            GetProduce();
        }
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        // string birthday = "5/9/2017";
        DateTime birthday = DateTime.Parse("5/9/2017");
        Label1.Text = Calendar1.SelectedDate.ToShortDateString();
        if (Calendar1.SelectedDate==birthday)
        {
            Label1.Text += " Happy Birthday";
        }
    }

    protected void GetProduce()
    {
        for(int i=0; i<5;i++)
        {
            ListItem item = new ListItem();
            item.Text = product[i, 0];
            ProduceCheckBoxList.Items.Add(item);
        }
    }

    protected void TotalButton_Click(object sender, EventArgs e)
    {
       
        int counter = 0;
        double total = 0;
        foreach(ListItem item in ProduceCheckBoxList.Items)
        {
            //string productName = product[counter, 0];
            if (item.Selected)
            {
                if (item.Text.Equals(product[counter, 0]))
                {
                    total += double.Parse(product[counter, 1]);
                }
            }
            counter++;
        }
        Label2.Text = "Your Total is " + total.ToString("C");
    }
}
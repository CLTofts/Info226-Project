using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Add : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            addId.Text = Session["ID"].ToString();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        /*
        if (!((string.IsNullOrEmpty(addName.Text)) && (string.IsNullOrEmpty(addJob.Text) && (string.IsNullOrEmpty(addInfo.Text)))))
        {
            if (!Storage.jobs.Keys.Contains(addName.Text))
            {
                Storage.jobs.Add(addName.Text, new Tuple<String, String, String>(addJob.Text, addInfo.Text, addCity.SelectedItem.Text));
                Responce.Text = "The Job for " + addName.Text + " has been added.";
            }
            else
            {
                Responce.Text = "Sorry the name " + addName.Text + " has been taken";
            }


        }
        else
        {
            Responce.Text = "Please fill in all of the boxes";
        }

        Responce.Visible = true;
        */
        if (!(string.IsNullOrEmpty(addId.Text)) && !(string.IsNullOrEmpty(addName.Text)) && !(string.IsNullOrEmpty(addAddress.Text)) &&
        !(string.IsNullOrEmpty(addBuilding.Text)) && !(string.IsNullOrEmpty(addJob.Text)) && !(string.IsNullOrEmpty(addInfo.Text)))
        {
            List<String> names = new List<String>();
            foreach (Organisation org in Storage.database)
            {
                names.Add(org.name);
            }
                if (!names.Contains(addName.Text))
                {
                    int number;
                    if (int.TryParse(addId.Text, out number))
                    {
                        Storage.database.Add(new Organisation(number, addName.Text, addAddress.Text, addBuilding.Text,
                            addJob.Text, addInfo.Text, addCity.SelectedItem.ToString()));
                        Server.Transfer("Browse.aspx");
                    }
                    else
                    {
                        Response.Text = "ID needs to be a number";
                    }
                }
                else
                {
                    Response.Text = "That Building is already being worked on.";
                    Response.Visible = true;
                }
            
        }
        else
        {
            Response.Text = "Please fill in all of the boxes.";
            Response.Visible = true;
            }
    }
    protected void addJob_TextChanged(object sender, EventArgs e)
    {

    }
}

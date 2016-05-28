using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Edit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            /*
            TextBox1.Text = Session["name"].ToString();
            TextBox2.Text = Session["job"].ToString();
            TextBox3.Text = Session["info"].ToString();
            DropDownList1.SelectedIndex = DropDownList1.Items.IndexOf(DropDownList1.Items.FindByText(Session["city"].ToString()));
            */
            foreach (Organisation org in Storage.database)
            {
                if (Session["Org"].Equals(org.name))
                {
                    addId.Text = org.id.ToString();
                    addName.Text = org.name;
                    addAddress.Text = org.address;
                    addBuilding.Text = org.building;
                    addJob.Text = org.job;
                    addInfo.Text = org.info;
                    addCity.SelectedIndex = addCity.Items.IndexOf(addCity.Items.FindByText(org.city));
                }
            }
        }
    }

 void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (!((string.IsNullOrEmpty(addId.Text)) && (string.IsNullOrEmpty(addName.Text)) &&  (string.IsNullOrEmpty(addAddress.Text)) &&
            (string.IsNullOrEmpty(addBuilding.Text)) && (string.IsNullOrEmpty(addJob.Text)) && (string.IsNullOrEmpty(addInfo.Text))))
        {
            foreach(Organisation org in Storage.database){
                if(Session["Org"].Equals(org.name)){
                    int number;
                        if(int.TryParse(addId.Text, out number)){
                            org.id = number;
                            org.name = addName.Text;
                            org.address = addAddress.Text;
                            org.building = addBuilding.Text;
                            org.job = addJob.Text;
                            org.info = addInfo.Text;
                            org.city = addCity.SelectedItem.ToString();
                            Server.Transfer("Browse.aspx");
                        }
                        else{
                            Label5.Text = "ID needs to be a number";
                        }
                }
            }
        }
            
        else
        {
            Label5.Text = "Please fill in all of the boxes.";
            Label5.Visible = true;
        }
    }
}
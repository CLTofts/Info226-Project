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
            TextBox1.Text = Session["name"].ToString();
            TextBox2.Text = Session["job"].ToString();
            TextBox3.Text = Session["info"].ToString();
            DropDownList1.SelectedIndex = DropDownList1.Items.IndexOf(DropDownList1.Items.FindByText(Session["city"].ToString()));

        }
    }
    protected

 void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (!((string.IsNullOrEmpty(TextBox1.Text)) && (string.IsNullOrEmpty(TextBox2.Text) && (string.IsNullOrEmpty(TextBox3.Text)))))
        {
            Storage.jobs.Remove(Session["name"].ToString());
            Storage.jobs.Add(TextBox1.Text, new Tuple<string, string, string>(TextBox2.Text, TextBox3.Text, DropDownList1.SelectedItem.ToString()));
            Server.Transfer("Browse.aspx");
        }
        else
        {
            Label5.Text = "Please fill in all of the boxes.";
            Label5.Visible = true;
        }
    }
}
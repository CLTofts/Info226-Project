using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class registerNew : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (!(string.IsNullOrEmpty(TextBox1.Text)) && !(string.IsNullOrEmpty(TextBox2.Text) && !(String.IsNullOrEmpty(id.Text))))
        {
            //if(TextBox1.Text.Equals(key)){

            int newId = 0;

            if (int.TryParse(id.Text, out newId))
            {
                List<int> idList = new List<int>();
                foreach (UserLogin user in Storage.login)
                {
                    idList.Add(user.id);
                }
                if (!idList.Contains(newId))
                {
                    if (Admin.Checked == true)
                    {
                        UserLogin newLogin = new UserLogin(TextBox1.Text, TextBox2.Text, newId, true);
                        Storage.login.Add(newLogin);
                    }
                    else
                    {
                        UserLogin newLogin = new UserLogin(TextBox1.Text, TextBox2.Text, newId, false);
                        Storage.login.Add(newLogin);
                    }
                    Server.Transfer("Login.aspx");
                }
                else
                {
                    Label6.Text = "Sorry, that ID is taken";
                    Label6.Visible = true;
                }
            }
            else
            {
                Label6.Text = "ID needs to be a number";
                Label6.Visible = true;
            }
        }
        else
        {
            Label6.Text = "You need to have all of the boxes filled in.";
            Label6.Visible = true;
        }
    }


    protected void Admin_CheckedChanged(object sender, EventArgs e)
    {

    }
}
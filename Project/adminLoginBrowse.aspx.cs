using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class adminLoginBrowse : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            foreach (UserLogin user in Storage.login)
            {
                ListBox1.Items.Add(user.name);
            }
        }
    }
    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        ListBox1.Items.Clear();
        foreach(UserLogin user in Storage.login)
        {
            ListBox1.Items.Add(user.name);
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        if (!(string.IsNullOrEmpty(TextBox1.Text)))
        {
            ListBox1.Items.Clear();
            foreach (UserLogin user in Storage.login)
            {
                if (user.name.ToLower().IndexOf(TextBox1.Text.ToLower()) != -1)
                {
                    ListBox1.Items.Add(user.name);
                }
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        UserLogin toRemove = null;
        foreach (UserLogin user in Storage.login)
        {
            if (user.name.Equals(ListBox1.SelectedItem.ToString()))
            {
                toRemove = user;
            }
        }
        if (toRemove != null)
        {
            Storage.login.Remove(toRemove);
        }
        ListBox1.Items.Remove(ListBox1.SelectedItem);
    }
}
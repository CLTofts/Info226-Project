using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Browse : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            List<String> names = new List<String>();
            foreach (String key in Storage.jobs.Keys)
            {
                names.Add(key);
            }
            ListBox1.DataSource = names;
            ListBox1.DataBind();
        }
    }
    protected void browseButton_Click(object sender, EventArgs e)
    {

    }
    protected void editButton_Click(object sender, EventArgs e)
    {
       if(Storage.jobs.ContainsKey(ListBox1.SelectedItem.ToString())){
            String name = ListBox1.SelectedItem.ToString();
            String job = Storage.jobs[name].Item1;
            String info = Storage.jobs[name].Item2;
            String city = Storage.jobs[name].Item3;
            Session["name"] = name;
            Session["job"] = job;
            Session["info"] = info;
            Session["city"] = city;
            Server.Transfer("Edit.aspx");
        }


    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        System.Diagnostics.Debug.WriteLine("I have been changed");
    }
}
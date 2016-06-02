using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Storage.login.Add(new UserLogin("admin", "admin", 1, true));
            Storage.login.Add(new UserLogin("notadmin", "notadmin", 2,  false));
            
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //foreach(String key in Storage.logins.key){
        if (!(string.IsNullOrEmpty(TextBox1.Text)) && !(string.IsNullOrEmpty(TextBox2.Text)) && !(string.IsNullOrEmpty(id.Text)))
        {
            int newId;
            if (int.TryParse(id.Text, out newId))
            {
                foreach (UserLogin log in Storage.login)
                {
                    if (log.id == newId)
                    {
                        Session["ID"] = log.id;
                        if (log.admin == true)
                        {
                            Session["admin"] = true;
                            Server.Transfer("adminMainNew.aspx");
                        }
                        else
                        {
                            Session["admin"] = false;
                            Server.Transfer("Main.aspx");
                        }
                    }
                }
            }
            else
            {
                Label5.Text = "ID has to be a number";
                Label5.Visible = true;
            }
        }
        else
        {
            Label5.Text = "You must fill in all the boxes";
            Label5.Visible = true;
        }
        Label5.Text = "We could not find a login, please try again.";
        Label5.Visible = true;


              
         
        
}
    protected void Button2_Click(object sender, EventArgs e)
    {
      //  if (!((string.IsNullOrEmpty(TextBox1.Text)) && (string.IsNullOrEmpty(TextBox2.Text))))
        //{
            //Storage.login.Add(TextBox1.Text, TextBox2.Text);
            Server.Transfer("registerNew.aspx");
       // }

    }
  
}
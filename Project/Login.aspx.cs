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

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        foreach(String key in Storage.login.Keys){

            if(TextBox1.Text.Equals(key)){
                if(Storage.login[key].Equals(TextBox2.Text)){
                    Session["Username"] = TextBox1.Text;
                    Session["Password"] = TextBox2.Text;
                    Server.Transfer("Main.aspx");

            }
        }
        }
    
        
}
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (!((string.IsNullOrEmpty(TextBox1.Text)) && (string.IsNullOrEmpty(TextBox2.Text))))
        {
            Storage.login.Add(TextBox1.Text, TextBox2.Text);
            Server.Transfer("Login.aspx");
        }

    }
}
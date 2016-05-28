using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class Browse : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            /*           List<String> names = new List<String>();
                       foreach (String key in Storage.jobs.Keys)
                       {
                           names.Add(key);
                       }
                       ListBox1.DataSource = names;
                       ListBox1.DataBind();
             */
            if (!Storage.isLoaded)
            {
                XmlDocument doc = new XmlDocument();
                try
                {
                    string file = @"\XMLFile.xml";
                    string rel_dir = HttpContext.Current.ApplicationInstance.Server.MapPath("~/XML_Data");
                    string absolute_path = rel_dir + file;


                    if (File.Exists(absolute_path))
                    {
                        doc.Load(absolute_path);
                    }
                    else
                    {
                        Response.Write("No XML Document");
                    }
                    XmlNodeList ids = doc.GetElementsByTagName("ID");
                    XmlNodeList names = doc.GetElementsByTagName("Name");
                    XmlNodeList addresses = doc.GetElementsByTagName("Address");
                    XmlNodeList buildings = doc.GetElementsByTagName("Building");
                    XmlNodeList jobs = doc.GetElementsByTagName("Job");
                    XmlNodeList informations = doc.GetElementsByTagName("Info");
                    XmlNodeList cities = doc.GetElementsByTagName("City");

                    for (int i = 0; i < ids.Count; i++)
                    {
                        Organisation org = new Organisation(int.Parse(ids[i].InnerText), names[i].InnerText, addresses[i].InnerText,
                            buildings[i].InnerText, jobs[i].InnerText, informations[i].InnerText, cities[i].InnerText);
                        Storage.database.Add(org);
                    }

                    Storage.isLoaded = true;

                }
                catch
                {
                    Response.Write("Error reading from XML File");
                }
            }
            foreach (Organisation org in Storage.database)
            {
                ListBox1.Items.Add(org.name);
            }
        }
    }
    protected void browseButton_Click(object sender, EventArgs e)
    {

    }
    protected void editButton_Click(object sender, EventArgs e)
    {
        if (ListBox1.SelectedItem != null)
        {
            Session["Org"] = ListBox1.SelectedItem.ToString();
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
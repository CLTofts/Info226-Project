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
                    XmlNodeList company = doc.GetElementsByTagName("Company");
                    XmlNodeList jobs = doc.GetElementsByTagName("Job");
                    XmlNodeList images = doc.GetElementsByTagName("Image");
                    XmlNodeList informations = doc.GetElementsByTagName("Info");
                    XmlNodeList cities = doc.GetElementsByTagName("City");
                    int j = 0;
                    for (int i = 0; i < ids.Count; i++)
                    {
                        Organisation org = new Organisation(int.Parse(ids[i].InnerText), names[i].InnerText, addresses[i].InnerText,
                            company[i].InnerText, jobs[i].InnerText, images[i].InnerText, informations[i].InnerText, cities[i].InnerText);
                        Storage.database.Add(org);
                        j = j + 1;
                    }

                    Storage.isLoaded = true;

                }
                catch
                {
                    Response.Write("Error reading from XML File");
                }
            }
            else
            {

                try
                {
                    string file = @"\XMLFile.xml";
                    string rel_dir = HttpContext.Current.ApplicationInstance.Server.MapPath("~/XML_Data");
                    string absolute_path = rel_dir + file;

                    if (File.Exists(absolute_path))
                    {
                        File.Delete(absolute_path);
                    }
                    StreamWriter newFile = File.CreateText(absolute_path);

                    XmlDocument doc = new XmlDocument();
                    XmlNode rootNode = doc.CreateElement("Data");

                    foreach (Organisation org in Storage.database)
                    {
                        XmlNode orgNode = doc.CreateElement("Organisation");

                        XmlNode idNode = doc.CreateElement("ID");
                        idNode.InnerText = org.id.ToString();

                        XmlNode nameNode = doc.CreateElement("Name");
                        nameNode.InnerText = org.name;

                        XmlNode addressNode = doc.CreateElement("Address");
                        addressNode.InnerText = org.address;

                        XmlNode companyNode = doc.CreateElement("Company");
                        companyNode.InnerText = org.company;

                        XmlNode jobNode = doc.CreateElement("Job");
                        jobNode.InnerText = org.job;

                        XmlNode imageNode = doc.CreateElement("Image");
                        imageNode.InnerText = org.image;

                        XmlNode infoNode = doc.CreateElement("Info");
                        infoNode.InnerText = org.info;

                        XmlNode cityNode = doc.CreateElement("City");
                        cityNode.InnerText = org.city;

                        orgNode.AppendChild(idNode);
                        orgNode.AppendChild(nameNode);
                        orgNode.AppendChild(addressNode);
                        orgNode.AppendChild(companyNode);
                        orgNode.AppendChild(jobNode);
                        orgNode.AppendChild(imageNode);
                        orgNode.AppendChild(infoNode);
                        orgNode.AppendChild(cityNode);

                        rootNode.AppendChild(orgNode);
                    }

                    doc.AppendChild(rootNode);
                    doc.Save(newFile);

                    newFile.Close();
                }
                catch
                {
                    Response.Write("ERROR");
                }
            }
            foreach (Organisation org in Storage.database)
            {
                ListBox1.Items.Add(org.name);
            }
            deleteButton.Visible = false;
            editButton.Visible = false;

        }
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
        String name = ListBox1.SelectedItem.ToString();
        bool found = false;
        foreach (Organisation org in Storage.database)
        {
            if (org.name == name)
            {
                if (int.Parse(Session["ID"].ToString()) == org.id)
                {
                    deleteButton.Visible = true;
                    editButton.Visible = true;
                    found = true;
                    break;
                }
            }
        }
        if (!found)
        {
            deleteButton.Visible = false;
            editButton.Visible = false;
        }

        

    }
    protected void DeleteButton_Click1(object sender, EventArgs e)
    {
        Organisation toRemove = null;
        foreach (Organisation org in Storage.database)
        {
            if (org.name.Equals(ListBox1.SelectedItem.ToString()))
            {
                toRemove = org;
            }
        }
        if (toRemove != null)
        {
            Storage.database.Remove(toRemove);
        }
        ListBox1.Items.Remove(ListBox1.SelectedItem);
        deleteButton.Visible = false;
        editButton.Visible = false;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ListBox1.Items.ToString();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        ListBox1.Items.Clear();
        foreach (Organisation org in Storage.database)
        {
            ListBox1.Items.Add(org.name);
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        if (!(string.IsNullOrEmpty(TextBox1.Text)))
        {
            ListBox1.Items.Clear();
            foreach (Organisation org in Storage.database)
            {
                if (org.name.ToLower().IndexOf(TextBox1.Text.ToLower()) != -1)
                {
                    ListBox1.Items.Add(org.name);
                }
            }
        }
 
    }
}
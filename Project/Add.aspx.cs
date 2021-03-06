﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Add : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
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
        number.Text = "There are " + Storage.jobs.Count + " items inside database.";
        number.Visible = true;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class UserLogin{
    public String name;
    public String password;
    public int id;
    public Boolean admin;
    

    public UserLogin(String name, String password, int id, Boolean admin)
	{

        this.name = name;
        this.password = password;
        this.admin = admin;
        this.id = id;
		//
		// TODO: Add constructor logic here
		//
	}

}


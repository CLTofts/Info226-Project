using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Organisation
/// </summary>
public class Organisation
{
    public int id;
    public String name;
    public String address;
    public String company;
    public String job;
    public String image;
    public String info;
    public String city;

	public Organisation(int id, String name, String address, String company, String job,String image, String info, String city)
	{
        this.id = id;
        this.name = name;
        this.address = address;
        this.company = company;
        this.job = job;
        this.image = image;
        this.info = info;
        this.city = city;
		//
		// TODO: Add constructor logic here
		//
	}

}
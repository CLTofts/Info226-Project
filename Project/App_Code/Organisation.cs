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
    public String building;
    public String job;
    public String info;
    public String city;

	public Organisation(int id, String name, String address, String building, String job, String info, String city)
	{
        this.id = id;
        this.name = name;
        this.address = address;
        this.building = building;
        this.job = job;
        this.info = info;
        this.city = city;
		//
		// TODO: Add constructor logic here
		//
	}

}
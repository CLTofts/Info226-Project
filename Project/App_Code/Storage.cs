using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Storage
/// </summary>
public static class Storage
{


   public static List<UserLogin> login = new List<UserLogin>();

   public static List<Organisation> database = new List<Organisation>();

   public static Boolean isLoaded = false;
}
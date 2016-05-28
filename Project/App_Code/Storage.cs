using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Storage
/// </summary>
public static class Storage
{


   public static Dictionary<String, String> login = new Dictionary<String, String>()
        {
            { "admin", "admin"}
        };
   public static Dictionary<String, Tuple<String, String, String>> jobs = new Dictionary<String, Tuple<String, String, String>>();

   public static List<Organisation> database = new List<Organisation>();

   public static Boolean isLoaded = false;
}
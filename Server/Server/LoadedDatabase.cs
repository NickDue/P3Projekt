using System;
using System.Collections.Generic;

namespace Server
{
    public class LoadedDatabase
    {
        public static List<Picklist> AllPicklists = new List<Picklist>();
        public static List<Employee> Employees = new List<Employee>();
        public static Dictionary<String, Product> AllProducts = new Dictionary<String, Product>();


        public static Picklist FindPicklist(int id)
        {
            foreach (Picklist picklist in AllPicklists)
            {
                if (picklist.picklistID == id)
                    return picklist;
            }
            return null;
        }
    }
}
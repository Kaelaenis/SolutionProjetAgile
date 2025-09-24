using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App_tp.Models
{
    public class Activity
    {
        public string Name { get; set; }
        public string Category { get; set; }

        public Activity(string name, string category)
        {
            Name = name;
            Category = category;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_tp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Role { get; set; }

        public User() { }

        public User(string name, string firstName, string role)
        {
            Name = name;
            FirstName = firstName;
            Role = role;
        }
        public User(int id, string name, string firstName, string role)
        {
            Id = id;
            Name = name;
            FirstName = firstName;
            Role = role;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, FirstName: {FirstName}, Role: {Role}";

        }
    }
}

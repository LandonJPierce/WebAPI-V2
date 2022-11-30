using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAPI_V2.Models
{
    public class UserContext : DbContext
    {
        public UserContext()
            : base("UsersDatabase")
        { }

        public partial class Users
            {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Office { get; set; }
        public string Manager { get; set; }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

using System.Web;

namespace sybatnetwork.Models
{
    public class Sales
    {
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Organisation { get; set; }
        public string OrganisationType { get; set; }
        public string Country { get; set; }
        public string Message { get; set; }
        public DateTime JoiningDate { get; set; }
    }
    public class EmpDBContext : DbContext
    {
        public EmpDBContext()
        { }
        public DbSet<Sales> sales { get; set; }
    }
}

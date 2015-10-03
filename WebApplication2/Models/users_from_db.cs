using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;



namespace WebApplication2.Models
{
    public class users_from_db:DbContext
    {
        public users_from_db()
            : base("DefaultConnection")
        { }
  
    }
}
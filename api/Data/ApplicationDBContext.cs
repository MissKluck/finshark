using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Data
{//a class that allows you to search individual database tables
    public class ApplicationDBContext : DbContext
    {//this code creates the database for us after it is done searching for the tables
        public applicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        //here we're linking up the database to the code, like how you wire stuff to the back of your tv
        //the tables
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
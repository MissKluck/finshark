using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using api.Models;

namespace api.Data
{//a class that allows you to search individual database tables
    public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
    {//this code creates the database for us after it is done searching for the tables

        //here we're linking up the database to the code, like how you wire stuff to the back of your tv
        //the tables
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<ArticleModel> ArticleModel { get; set; }
    }
    
}
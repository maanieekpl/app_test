using app_test.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app_test.Repository
{
    public class DBContext:DbContext
    {
        public DBContext(DbContextOptions<DBContext>options) : base(options)
        {

        }
        
        DbSet<Test> Test { get; set; }
        
    }
}

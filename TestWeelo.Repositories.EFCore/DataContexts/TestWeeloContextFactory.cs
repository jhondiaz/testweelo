using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeelo.Repositories.EFCore.DataContexts
{

 public class TestWeeloContextFactory : IDesignTimeDbContextFactory<TestWeeloContext>
    {
        
        public TestWeeloContext CreateDbContext(string[] args)
        {
                DbContextOptionsBuilder<TestWeeloContext> OptionsBuilder = new DbContextOptionsBuilder<TestWeeloContext>();
               OptionsBuilder.UseSqlServer("Server=72.167.36.118;Database=TestWeeloDB;User Id=UserBase;Password=Diaz.15171399%;");
            return new TestWeeloContext(OptionsBuilder.Options);
        }
    }

}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace DataAccess
{
    public class StackContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Server=127.0.0.1; Port=5432;Database=PmpTool;User Id=postgres;Password=283501;CommandTimeout=32767;Timeout=1024;");
        }
    }
}

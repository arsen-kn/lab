using Lab6;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Lab6
{
    public class Lab6Context : DbContext
    {
        public Lab6Context() : base("name=DefaultConnection") { }

        public DbSet<People> People { get; set; }
    }
}

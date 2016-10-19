namespace COMP229_F2016_MidTerm_300852792.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ToDocontext : DbContext
    {
        public ToDocontext()
            : base("name=ToDoconnection")
        {
        }

        public virtual DbSet<Todo> Todos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

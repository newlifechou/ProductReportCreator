namespace OldVHP
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBNew : DbContext
    {
        public DBNew()
            : base("name=DBNew")
        {
        }

        public virtual DbSet<tb_Order> tb_Order { get; set; }
        public virtual DbSet<tb_Plan> tb_Plan { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

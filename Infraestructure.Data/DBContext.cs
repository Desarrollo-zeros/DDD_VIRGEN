using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Domain.Entities;
using Infraestructure.Data.Base;

namespace Infraestructure.Data
{
    public class DBContext : DbContextBase
    {

        
        public DBContext() : base("name=MysqlContext") {}
       
        protected DBContext(DbConnection connection) : base(connection) { }

       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public void Seed(DbContext context)
        {
            context.SaveChanges();
        }
    }
    public class CreateInitializer : CreateDatabaseIfNotExists<DBContext>
    {
        protected override void Seed(DBContext context)
        {
            context.Seed(context);
            base.Seed(context);
        }
    }


    public class DropCreateIfChangeInitializer : DropCreateDatabaseIfModelChanges<DBContext>
    {
        protected override void Seed(DBContext context)
        {
            context.Seed(context);
            base.Seed(context);
        }
    }

    public class AlwaysCreateInitializer : DropCreateDatabaseAlways<DBContext>
    {
        protected override void Seed(DBContext context)
        {
            context.Seed(context);
            base.Seed(context);
        }
    }


}

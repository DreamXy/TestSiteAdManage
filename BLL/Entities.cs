using BLL.Models;
using BLL.Models.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public partial class Entities : DbContext
    {
        static Entities()
        {
            Database.SetInitializer<Entities>(null);
        }

        public Entities()
            : base("Name=Entities")
        {
            // Get the ObjectContext related to this DbContext
            var objectContext = (this as IObjectContextAdapter).ObjectContext;

            // Sets the command timeout for all the commands（two minutes)
            objectContext.CommandTimeout = 120;
        }

        /// <summary>
        /// 对已经载入了的实体完全从Context剥离,不跟踪它的状态
        /// </summary>
        /// <param name="entity"></param>
        public void Detach(object entity)
        {
            this.Entry(entity).State = EntityState.Detached;
        }


        public DbSet<SalaryAccount> SalaryAccounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new SalaryAccountMap());
        }
    }
}

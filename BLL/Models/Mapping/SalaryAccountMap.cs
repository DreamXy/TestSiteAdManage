using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models.Mapping
{
    public class SalaryAccountMap : EntityTypeConfiguration<SalaryAccount>
    {
        public SalaryAccountMap()
        {

            this.HasKey(n => n.id);

            this.ToTable("salary_account");
            this.Property(n => n.id).HasColumnName("id");
            this.Property(n => n.account_name).HasColumnName("account_name");
            this.Property(n => n.account_pwd).HasColumnName("account_pwd");
            this.Property(n => n.creat_date).HasColumnName("creat_date");
            this.Property(n => n.up_date).HasColumnName("up_date");
            this.Property(n => n.account_role).HasColumnName("account_role");
            this.Property(n => n.account_remark).HasColumnName("account_remark");
            this.Property(n => n.account_state).HasColumnName("account_state");

            //this.HasOptional(n => n.Admin)
            //    .WithMany(n => n.AccounLoginRecords)
            //    .HasForeignKey(n => n.AdminId);

            //this.HasOptional(n => n.Advertiser)
            //    .WithMany(n => n.AccounLoginRecords)
            //    .HasForeignKey(n => n.AdvertiserId);

            //this.HasOptional(n => n.Publisher)
            //    .WithMany(n => n.AccounLoginRecords)
            //    .HasForeignKey(n => n.PublisherId);
        }
    }
}

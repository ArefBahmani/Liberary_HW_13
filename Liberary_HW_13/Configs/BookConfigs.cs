using Liberary_HW_13.Entityes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liberary_HW_13.Configs
{
    public class BookConfigs : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(w => w.Writer).IsRequired().HasMaxLength(20);
            builder.Property(p => p.Pages).IsRequired();
            builder.Property(x=>x.Discription).IsRequired();
            builder.HasOne(x=>x.User).WithMany(y=>y.Books).HasForeignKey(d => d.UserId);
            
           
        }
    }
}

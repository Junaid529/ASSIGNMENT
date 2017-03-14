using Business.Model;
using System.Data.Entity.ModelConfiguration;

namespace Business.Data.Access.Configuration
{
    public class OrderConfig : EntityTypeConfiguration<ORDER_WAREHOUSE>
    {
        public OrderConfig()
        {
            //Primary Key
            HasKey(k => k.Id);
            //Properties
            Property(r => r.OrderDescription).HasMaxLength(50).IsRequired();
            HasRequired(o => o.TblCountry).WithMany().HasForeignKey(o => o.CountryID).WillCascadeOnDelete(false);
            HasRequired(r => r.references).WithMany().HasForeignKey(r => r.ReferenceID).WillCascadeOnDelete(false);
            HasRequired(c => c.citation).WithMany().HasForeignKey(c => c.CitationID).WillCascadeOnDelete(false);
        }
    }
}

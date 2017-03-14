using Business.Model;
using System.Data.Entity.ModelConfiguration;

namespace Business.Data.Access.Configuration
{
    public class RegistationConfig : EntityTypeConfiguration<REGISTRATION>
    {
        public RegistationConfig()
        {
            //Primary Key
            HasKey(r => r.ID);
            //Properties
            HasRequired(o => o.TblCountry).WithMany().HasForeignKey(o => o.CountryID).WillCascadeOnDelete(false);
            HasRequired(h => h.how_you_know).WithMany().HasForeignKey(h => h.How_You_KnowID).WillCascadeOnDelete(false);
        }
    }
}

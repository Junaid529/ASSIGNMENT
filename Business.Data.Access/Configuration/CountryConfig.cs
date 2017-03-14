using Business.Model;
using System.Data.Entity.ModelConfiguration;

namespace Business.Data.Access.Configuration
{
    public class CountryConfig : EntityTypeConfiguration<TBL_COUNTRY>
        {
        public CountryConfig(){
            HasKey(p => p.ID);
        }

    }
}

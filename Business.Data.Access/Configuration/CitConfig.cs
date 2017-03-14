using Business.Model;
using System.Data.Entity.ModelConfiguration;

namespace Business.Data.Access.Configuration
{
    public class CitConfig : EntityTypeConfiguration<CITATION>
    {
        public CitConfig()
        {
            //Primary Key
            HasKey(c => c.ID);
        }
    }
}

using Business.Model;
using System.Data.Entity.ModelConfiguration;

namespace Business.Data.Access.Configuration
{
    public class ReferenceConfig : EntityTypeConfiguration<REFERENCES>
    {
        public ReferenceConfig()
        {
            //Primary Key
            HasKey(r => r.ID);
            //Properties
        }
    }
}

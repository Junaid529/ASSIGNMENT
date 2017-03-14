using Business.Model;
using System.Data.Entity.ModelConfiguration;

namespace Business.Data.Access.Configuration
{
    public class LanguageConfig : EntityTypeConfiguration<LANGUAGE>
    {
        public LanguageConfig()
        {
            //Primary Key
            HasKey(l => l.ID);
        }
    }
}

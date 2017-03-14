using Business.Model;
using System.Data.Entity.ModelConfiguration;

namespace Business.Data.Access.Configuration
{
    public class HowYouKnowConfig : EntityTypeConfiguration<HOW_YOU_KNOW>
    {
        public HowYouKnowConfig()
        {
            //Primary Key
            HasKey(h => h.ID);
            //Properties

        }
    }
}

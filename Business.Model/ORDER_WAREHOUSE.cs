using System.ComponentModel.DataAnnotations;

namespace Business.Model
{
    public class ORDER_WAREHOUSE
    {
        [Key]
        public int Id { get; set; }
        public string TypeOfDocument { get; set; }
        public string Urgency { get; set; }
        public string Quality { get; set; }
        public string Spacing { get; set; }
        public string NumberofPages { get; set; }
        public string AcademicLevel { get; set; }
        public string SubjectArea { get; set; }
        public string Style { get; set; }
        public string NumberofSources { get; set; }
        public string Dictionary { get; set; }
        public string OrderDescription { get; set; }
        public int? CountryID { get; set; }
        public virtual TBL_COUNTRY TblCountry { get; set; }
        public int? ReferenceID { get; set; }
        public virtual REFERENCES references { get; set; }
        public int? CitationID { get; set; }
        public virtual CITATION citation { get; set; }
        public int? LanguageID { get; set; }
        public virtual LANGUAGE language { get; set; }


    }
}

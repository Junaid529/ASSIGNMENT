using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment.Models
{
    public class Order_warehouse
    {
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
        public virtual Countries Countries { get; set; }
        public int? Reference_ID { get; set; }
        public virtual References references { get; set; }
        public int? Citation_ID { get; set; }
        public virtual Citation citation { get; set; }
        public int LanguageID { get; set; }
        public virtual Language language { get; set; }
    }
}
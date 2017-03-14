using System.ComponentModel.DataAnnotations;


namespace Business.Model
{
    public class REGISTRATION
    {
        public int ID { get; set; }
        public string Full_Name { get; set; }
        public string Email_Address { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int? CountryID { get; set; }
        public virtual TBL_COUNTRY TblCountry { get; set; }
        public string Phone_Number { get; set; }
        public int? How_You_KnowID { get; set; }
        public virtual HOW_YOU_KNOW how_you_know { get; set; }
        //public bool IsNewsletter { get; set; }
        //public bool IsAgree { get; set; }
    }
}

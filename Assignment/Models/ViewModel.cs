using Business.Data;
using System.Collections.Generic;
using System.Linq;

namespace Assignment.Models
{
    public class ViewModel
    {
        Context db = new Context();
        public List<string> CountryList(string name)
        {
            var x = db.country.Where(p => p.COUNTRY_NAME.StartsWith(name)).Select(p => p.COUNTRY_NAME).ToList();
            return x;
        }
    }
}
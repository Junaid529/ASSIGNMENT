using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Model;

namespace Business.Data.Services
{
    public class ModelServices
    {
        private readonly Context db = new Context();

        public IEnumerable<TBL_COUNTRY> GetCountryList()
        {
            return db.country.ToList();
        }
        //public IEnumerable<State> GetStateByCountry(int CountryID)
        //{
        //    return entities.State.Where(s => s.CountryID == CountryID).ToList();
        //}

        //public IList<EmployeeRegInfo> GetAllEmployeeList()
        //{
        //    var myQuery = (from e in entities.Employees
        //                   join c in entities.Country on e.Country equals c.ID
        //                   join s in entities.State on e.State equals s.ID
        //                   select new EmployeeRegInfo()
        //                   {
        //                       Id = e.ID,
        //                       Emp_ID = e.Emp_ID,
        //                       Dept = e.Dept,
        //                       Name = e.Name,
        //                       CountryName = c.Country_Name,
        //                       StateName = s.State_Name,
        //                       City = e.City,
        //                       Mobile = e.Mobile
        //                   });

        //    return myQuery.ToList();
        //}

        //public bool IsEmpAlreadyExist(string EMP_CODE)
        //{
        //    bool IsRecordExist = false;

        //    var result = (from t in entities.Employees
        //                  where t.Emp_ID == EMP_CODE
        //                  select t).SingleOrDefault();

        //    if (result != null)
        //    {
        //        IsRecordExist = true;
        //    }
        //    return IsRecordExist;
        //}

        //public void AddNewEmployee(Employee emp)
        //{
        //    entities.Employees.Add(emp);
        //    entities.SaveChanges();
        //}
    }
}

using SimpleDapperExample.Model;
using System.Collections.Generic;

namespace SimpleDapperExample.DataLayer
{
    public interface IEmployeeRepo
    {
        IEnumerable<EmployeeModel> GetEmployees();
        bool Insert(EmployeeModel employee);
        bool Update(EmployeeModel employee);
        bool delete(string EmployeeId);
    }
}
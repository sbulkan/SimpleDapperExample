using SimpleDapperExample.Model;
using System;
using System.Collections.Generic;
using Dapper;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

namespace SimpleDapperExample.DataLayer
{
    public class EmployeeRepo : IEmployeeRepo
    {
        public bool delete(string EmployeeId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeModel> GetEmployees()
        {

            using (IDbConnection db = new SqlConnection(ApplicationConnection.ConnectionString))
            {

                if (db.State == ConnectionState.Closed)
                    db.Open();
                return db.Query<EmployeeModel>("select EmployeeId, EmployeeFullName," +
                    " Age, City from Employees", commandType: CommandType.Text);
            }
        }

        public bool Insert(EmployeeModel employee)
        {
            throw new NotImplementedException();
        }

        public bool Update(EmployeeModel employee)
        {
            throw new NotImplementedException();
        }
    }
}

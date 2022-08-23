using Crud_With_Sp_EF.Models;
using Microsoft.EntityFrameworkCore;

namespace Crud_With_Sp_EF.Services
{
    public class EmployeeService : IEmployee
    {
        private readonly ApplicationDbContext _dbContext;

        public EmployeeService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Create(Employee employee)
        {
            _dbContext.Database.ExecuteSqlRaw("AddNewEmpDetails {0}, {1},{2}", employee.Name, employee.City, employee.Address);
        }

        public void Delete(int id)
        {
            _dbContext.Database.ExecuteSqlRaw("DeleteEmpById {0}", id);
        }

        public Employee GetEmpById(int id)
        {
            Employee employee = new Employee();
            var list = _dbContext.Employee.FromSqlRaw("GetEmpById {0}",id);
            foreach (var item in list)
            {
                employee.Empid = item.Empid;
                employee.Name = item.Name;
                employee.City = item.City;
                employee.Address = item.Address;
            }
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            var list = _dbContext.Employee.FromSqlRaw($"GetEmployees").ToList();
            return list;
        }

        public void Update(Employee employee)
        {
             _dbContext.Database.ExecuteSqlRawAsync("UpdateEmpDetails {0},{1},{2},{3}", employee.Empid, employee.Name, employee.City, employee.Address);
        }
    }
}

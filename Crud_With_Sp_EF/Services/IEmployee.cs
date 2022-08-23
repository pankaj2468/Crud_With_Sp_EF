using Crud_With_Sp_EF.Models;

namespace Crud_With_Sp_EF.Services
{
    public interface IEmployee
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmpById(int id);
        void Create(Employee employee);

        void Update(Employee employee);
        void Delete(int id);

    }
}

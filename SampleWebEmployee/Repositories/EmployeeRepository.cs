using SampleWebEmployee.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWebEmployee.Repositories
{
    public class IEmployeeRepository : IEmployeeRepository
    {
        RepositoryContext context;
        public IEmployeeRepository(RepositoryContext context) //DI
        {
            this.context = context;
        }

        public int AddEmployee(Employee prod)
        {
            context.Employee.Add(prod);
            context.SaveChanges(); // update the data in DB
            return 1;
        }

        public int DeleteEmployee(int id)
        {
            var Emp = context.Employee.Where(p => p.Id == id).SingleOrDefault();
            if (Emp != null)
            {
                context.Employee.Remove(Emp);
                context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public IEnumerable<Employee> GetAllProducts()
        {
            return context.Employee.ToList();
        }

        public int ModifyProduct(Employee Emp)
        {
            var Employee= context.Employee.Where(p => p.Id ==Emp.Id).SingleOrDefault();
            if (Employee != null)
            {
                Employee.Name = Emp.Name;
                Employee.Id = Emp.Id;
                context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }

        }
    }
}

using EMSApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EMSApi.Data
{
    public static class SeedData
    {
        public static void InsertDepartments(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department
                {
                    DepartmentId = 1,
                    Name = "IT"
                },
                new Department
                {
                    DepartmentId = 2,
                    Name = "HR"
                });
        }

        public static void InsertEmployees(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name="vijay",
                    Age =12,
                    DepartmentId=1
                });
        }
    }
}

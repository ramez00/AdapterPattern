
namespace PayrollSystem.Core;

public class EmployeesDataReader
{
    public IEnumerable<Employee> GetEmployees()
    {
        // Simulate reading from a data source
        return new List<Employee>
        {
            new Employee
            {
                FullName = "John Doe",
                PayItems = new List<PayItem>
                {
                    new PayItem { Name = "Salary", Value = 50000 },
                    new PayItem { Name = "Bonus", Value = 5000 },
                    new PayItem { Name = "Commission", Value = 2000 },
                    new PayItem { Name = "Medical Insurance", Value = -450 }
                }
            },
            new Employee
            {
                FullName = "Jane Smith",
                PayItems = new List<PayItem>
                {
                    new PayItem { Name = "Salary", Value = 60000 },
                    new PayItem { Name = "Bonus", Value = 7000 },
                    new PayItem { Name = "Commission", Value = 3000 },
                    new PayItem { Name = "Medical Insurance", Value = -500 }
                }
            }
        };
    }

}

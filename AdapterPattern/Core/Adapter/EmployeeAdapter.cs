using PayrollSystem.Core;

namespace AdapterPattern.Core.Adapter;
public class EmployeeAdapter
{
    private readonly Employee _employee;
    private readonly IEnumerable<PayItemAdapter> _payItems;
    public EmployeeAdapter(Employee employee)
    {
        _employee = employee;
        _payItems = employee.PayItems.Select(p => new PayItemAdapter(p)).ToList();
    }
    public string FullName => _employee.FullName;
    public IEnumerable<PayItemAdapter> PayItems => _payItems;
}

using System.Diagnostics;

namespace PayrollSystem.Core;

public class PayrollCalculator
{
    public decimal Calculate(Employee employee)
    {
        if (employee == null || employee.PayItems == null)
            throw new ArgumentNullException("Employee or PayItems cannot be null.");
        
        Debug.WriteLine($"Calculating payroll for {employee.FullName}");

        if (!employee.PayItems.Any())
            return 0;

        var totalPay = employee.PayItems.Sum(payItem => payItem.Value);

        return Math.Round(totalPay / DateTime.DaysInMonth(DateTime.Today.Year,DateTime.Today.Month) * DateTime.Today.Day, 2);

    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PayrollSystem.Core;

namespace PayrollSystem.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PayrollCalculatorController : ControllerBase
{
    [HttpPost]
    [Route("")]

    public ActionResult<decimal> Calculate(Employee employee)
    {
        if (employee == null)
        {
            return BadRequest("Employee data is required.");
        }
        var payrollCalculator = new PayrollCalculator();
        var totalPay = payrollCalculator.Calculate(employee);
        return Ok(totalPay);
    }
}

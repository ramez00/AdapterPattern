
using PayrollSystem.Core;
using System.Text;
using System.Text.Json;

var PayrollCalculatorUrl = "https://localhost:7282/api/PayrollCalculator";

var reader = new EmployeesDataReader();
var employees = reader.GetEmployees();

var client = new HttpClient();

foreach (var employee in employees)
{
    var request = new HttpRequestMessage(HttpMethod.Post, PayrollCalculatorUrl);
    request.Content = new StringContent(JsonSerializer.Serialize(employee), Encoding.UTF8, "application/json");
  
    var response = await client.SendAsync(request);
    var responseJson = await response.Content.ReadAsStringAsync();
    var Salary = decimal.Parse(responseJson);
    Console.WriteLine($"Employee: {employee.FullName}, Salary: {Salary}");
}
Console.ReadLine();
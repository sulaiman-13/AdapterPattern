

using AdapterPattern.Core;
using System.Text;
using System.Text.Json;

var PayrollCalculatorUrl = "https://localhost:7008/payrollcalculator";
var reader = new EmployeeDataReader();
var emps = reader.GetEmployees();
var client = new HttpClient();
foreach(var emp in emps)
{
    var request = new HttpRequestMessage(HttpMethod.Post, PayrollCalculatorUrl);
    var empAdapter = new PayrollEmployeeAdapter(emp);
    request.Content = new StringContent(JsonSerializer.Serialize(empAdapter), Encoding.UTF8, "application/json");
var response =await client.SendAsync(request);
    var jsonResponse =await  response.Content.ReadAsStringAsync();
    var salary = decimal.Parse(jsonResponse);
    Console.WriteLine($"salary for employee `{emp.FullName}` for today is: {salary}");
}
Console.ReadKey();
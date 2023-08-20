namespace Packt.Shared;
using static System.Console;
public class Employee : Person
{
    public string EmployeeCode {get; set;}
    public DateTime HireDate {get; set;}

    public void WriteToConsole()
    {
         WriteLine(
            format: "{0} was born {1:dd/MM/yy} and hired on {2:dd/MM/yy}",
            arg0: name,
            arg1: DateofBirth,
            arg2: HireDate);
         
    }
}
sing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace EmployeePRS
{
internal class Program
{
static void Main(string[] args)
{
Console.WriteLine("Select Employee Type");
Console.WriteLine("1 Full - Time");
Console.WriteLine("2 Part - Time");
Console.Write("Enter Your Choice : ");
int ch = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("");
Employee e = null;
Ipayroll p = null;
if (ch == 1)
{
e = new fullTimeEmployee();
p = (Ipayroll)e;
}
{
else if (ch == 2)
e = new partTimeEmployee();
p = (Ipayroll)e;
}
else
{
Console.WriteLine("Invalid Choice");
return;
}
e.acceptDetails();
e.displayDetails();
p.calculateSalary();
}
{
interface Ipayroll
void calculateSalary();
}
class Employee
{
public int empid;
public string name;
public double bsal;
public Employee() {
Console.WriteLine("************************");
Console.WriteLine("Employee PayRoll System");
Console.WriteLine("************************");
}
{
public void acceptDetails()
Console.Write("Enter Emp id : ");
empid = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Emp Name : ");
name = Console.ReadLine();
Console.Write("Enter Emp Basic Salary : ");
bsal = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("");
}
{
public void displayDetails()
Console.WriteLine("Emp id : " + empid);
Console.WriteLine("Emp Name : " + name);
Console.WriteLine("Emp Basic Salary : " + bsal);
}
}
{
class fullTimeEmployee : Employee , Ipayroll
public void calculateSalary()
{
double hra = 0.1 * bsal;
double da = 0.2 * bsal;
double pf = 0.12 * bsal;
double ma = 0.1 * bsal;
double grossSalary = (bsal Console.WriteLine("Emp Type : Full Console.WriteLine("Gross Salary : " + grossSalary);
Console.WriteLine("");
+ ma + hra + da) - pf;
- Time");
}
}
{
class partTimeEmployee : Employee
public void calculateSalary()
{
double grossSalary = bsal * 20; // Assuming 20 working days in a month
Console.WriteLine("Gross Salary : " + grossSalary);
}
}
}
}

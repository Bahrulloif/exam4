﻿var emp=new Employee(1, "Safarov", "Bahhrom", 5000);
System.Console.WriteLine(emp.GetID());
System.Console.WriteLine(emp.GetFirstName());
System.Console.WriteLine(emp.GetLastName());
System.Console.WriteLine(emp.GetName());
System.Console.WriteLine(emp.GetSalary());
emp.SetSalary(6000);
System.Console.WriteLine(emp.GetAnnualSalary());
System.Console.WriteLine(emp.RaiseSalary(20));
System.Console.WriteLine(emp.ToString());
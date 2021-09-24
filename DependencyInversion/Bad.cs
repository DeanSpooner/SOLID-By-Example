using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion
{
    // DIP states that code should depend on abstractions.
    // The goal of Dependency Inversion is to couple to something abstract rather than concrete. 
    // Although you will need to create a concrete object at some point we would want to as far up the chain as possible.
    // One of the goals of DIP is to choose objects at runtime time, not at compile time.
    // Another way to think about DIP is that higher-level modules should not depend on lower level modules.
    // The example below breaks DIP as the higher-level class EmployeeDetails is directly coupled lower level SalaryCalculator class, rather than being coupled to an abstraction.
    public class SalaryCalculator
    {
        public float CalculateSalary(int hoursWorked, float hourlyRate)
        {
            return hoursWorked * hourlyRate;
        }
    }

    public class EmployeeDetails
    {
        public int HoursWorked { get; set; }
        public int HourlyRate { get; set; }
        public float GetSalary()
        {
            var salaryCalculator = new SalaryCalculator();
            return salaryCalculator.CalculateSalary(HoursWorked, HourlyRate);
        }
    }
}

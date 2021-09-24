using System;

namespace DependencyInversion
{
    // Dependency Inversion = The principle of inverting the dependencies.
    // Dependency Injection = The act of inverting the dependencies.
    // Constructor Injection = Performing Depedency Injection via the Constructor.
    // Parameter Injection = Performing Dependency Injection via the Parameter or a Method, like a Setter.
    // In the below example we only depend upon the ISalaryCalculator interface which is an abstraction , and not the concrete class.
    // In addition, the details of the CalculateSalary function are hidden from the EmployeeDetailsModified class and any changes to this function will not affect the interface being used.
    // In this new design the higher-level module (class) does not depend upon the lower level class but on an abstraction, and the abstractio ndoes not depend upon the concrete implementation.
    public interface ISalaryCalculator
    {
        float CalculateSalary(int hoursWorked, float hourlyRate);
    }

    public class SalaryCalculatorModified : ISalaryCalculator
    {
        public float CalculateSalary(int hoursWorked, float hourlyRate)
        {
            return hoursWorked * hourlyRate;
        }
    }

    public class EmployeeDetailsModified
    {
        private readonly ISalaryCalculator _salaryCalculator;
        public int HoursWorked { get; set; }
        public int HourlyRate { get; set; }

        public EmployeeDetailsModified(ISalaryCalculator salaryCalculator)
        {
            _salaryCalculator = salaryCalculator;
        }

        public float GetSalary()
        {
            return _salaryCalculator.CalculateSalary(HoursWorked, HourlyRate);
        }
    }
}

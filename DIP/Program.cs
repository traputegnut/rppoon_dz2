using System;

namespace DIP
{
    class Program
    {
        static void Main(string[] args)
        {
            public class SalaryCalculator /*viša klasa EmployeeDetails direktno ovisi o klasi SalaryCalculator,ispravno bi bilo napraviti
                                           sučelje ISalaryCalc kojeg bi klasa EmployeeDetails nasljeđivala*/
        {
            public float CalculateSalary(int hoursWorked, float hourlyRate);
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
    }
}

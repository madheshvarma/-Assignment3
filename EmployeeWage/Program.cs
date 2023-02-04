using System;

namespace EmployeeWage
{
    public class EmployeeCheck
    {
        public static void CheckAttendence()
        {
            int partTime = 1;
            int fullTIME = 2;
            int perHOUR = 20;
            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();
            int empCheck = random.Next(2);

            if (empCheck == partTime)
            {

                empHrs = 4;
            }
            else if (empCheck == fullTIME)
            {
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            empWage = empHrs * perHOUR;
            Console.WriteLine("Employee Wage: " + empWage);
        }
    }
}


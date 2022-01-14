using System;

namespace Day9_EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(" Welcome to Employee Wage Computation Program on Main Branch");
            Console.WriteLine("_____________________________________________________________\n");

            //UC1_CheckEmployee uc1 = new UC1_CheckEmployee();
            //uc1.GetAttendance();

            //Day9_EmployeeWageComputation.UC2_EmployeeDailyWage uc2 = new UC2_EmployeeDailyWage();
            //uc2.EmpDailyWage();

            //Day9_EmployeeWageComputation.UC3_PartTimeEmployeeWage uc3 = new UC3_PartTimeEmployeeWage();
            //uc3.PartTimeEmpWage();

            //Day9_EmployeeWageComputation.UC4_UsingSwitchCase uc4 = new UC4_UsingSwitchCase();
            //uc4.EmpWageUsingSwitch();

            //Day9_EmployeeWageComputation.UC5_MonthlyWages uc5 = new UC5_MonthlyWages();
            //uc5.CalculateWages();

            //Day9_EmployeeWageComputation.UC6_TotalWorkingHours uc6 = new UC6_TotalWorkingHours();
            //uc6.CalculateWageTill100HrsOr20IsReached();

            //UC7_RefactorTheCodeUsingClassMethod.ComputeEmpWage();

            //ComputeEmpWageClass computeEmpWageClass = new ComputeEmpWageClass();
            //computeEmpWageClass.computeEmpWage("Dmart", 20, 2, 10);

            //computeEmpWageClass.computeEmpWage("Reliance", 10, 4, 20);



            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter the program number which is to be executed \n 1.UC-1, \n 2.UC-2, \n 3.UC-3, \n 4.UC-4, \n 5.UC-5, \n 6.UC-6, \n 7.UC-7, \n 8.UC-8, \n 9.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        UC1_CheckEmployee uc1 = new UC1_CheckEmployee();
                        uc1.GetAttendance();
                        break;
                    case 2:
                        Day9_EmployeeWageComputation.UC2_EmployeeDailyWage uc2 = new UC2_EmployeeDailyWage();
                        uc2.EmpDailyWage();
                        break;
                    case 3:
                        Day9_EmployeeWageComputation.UC3_PartTimeEmployeeWage uc3 = new UC3_PartTimeEmployeeWage();
                        uc3.PartTimeEmpWage();
                        break;
                    case 4:
                        Day9_EmployeeWageComputation.UC4_UsingSwitchCase uc4 = new UC4_UsingSwitchCase();
                        uc4.EmpWageUsingSwitch();
                        break;
                    case 5:
                        Day9_EmployeeWageComputation.UC5_MonthlyWages uc5 = new UC5_MonthlyWages();
                        uc5.CalculateWages();
                        break;
                    case 6:
                        Day9_EmployeeWageComputation.UC6_TotalWorkingHours uc6 = new UC6_TotalWorkingHours();
                        uc6.CalculateWageTill100HrsOr20IsReached();
                        break;
                    case 7:
                        UC7_RefactorTheCodeUsingClassMethod.ComputeEmpWage();
                        break;
                    case 8:
                        ComputeEmpWageClass computeEmpWageClass = new ComputeEmpWageClass();
                        computeEmpWageClass.computeEmpWage("Dmart", 20, 2, 10);

                        computeEmpWageClass.computeEmpWage("Reliance", 10, 4, 20);
                        break;
                    case 9:
                        flag = false;
                        break;
                }
            }
        }
    }
}

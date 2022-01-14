using System;
using System.Collections.Generic;
using System.Text;

namespace Day9_EmployeeWageComputation
{
    interface UC8_MultipleCompany
    {
        public int computeEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int MaxHoursPerMonth);
    }
}
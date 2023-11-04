﻿using System.Diagnostics;

namespace PayrollSystem.Core
{
    public class PayrollCalculator
    {
        public decimal Calculate(Employee employee)
        {
            Debug.WriteLine($"calculate payroll for `{employee.FullName}`");
            if (employee.PayItems.Any() == false)
            {
                return 0;
            }
            var monthTotal = employee.PayItems.Sum(p => p.Value);
            return Math.Round(monthTotal / DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month) * DateTime.Today.Day, 2);
        }
    }
}

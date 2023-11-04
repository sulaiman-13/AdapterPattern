using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Core
{
    public class PayrollEmployeeAdapter
    {
        private Employee _employee;
        private IEnumerable<PayrollPayItemAdapter> _payItems;

        public PayrollEmployeeAdapter(Employee employee)
        {
            _employee = employee;
            _payItems = employee.PayItems.Select(i => new PayrollPayItemAdapter(i)).ToList();
        }
        public string FullName => _employee.FullName;
        public IEnumerable<PayrollPayItemAdapter> PayItems =>  _payItems;
    }
}

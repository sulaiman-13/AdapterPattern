using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Core
{
    public class PayrollPayItemAdapter
    {
        private PayItem _payItem;

        public PayrollPayItemAdapter(PayItem payItem)
        {
            _payItem = payItem;
        }
        public string Name => _payItem.Name;
        public decimal Value => _payItem.IsDeduction ? _payItem.Value * -1 : _payItem.Value;
    }
}

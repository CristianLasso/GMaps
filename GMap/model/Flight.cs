using System;
using System.Collections.Generic;
using System.Text;

namespace model
{
    class Flight
    {
        private Int32 month;
        private Int32 depDelayMinute;

        public Flight(int m, int dDl)
        {

            month = m;
            depDelayMinute = dDl;
        }

        public Int32 Month { get; set; }
        public Int32 DepDelayMinute { get; set; }

    }
}

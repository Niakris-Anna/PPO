using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountingOfOverwork
{
    //начисленные бонусы за конкретную переработку
    class CompensatoryRate
    {
        private String title;
        private double paymentCoef;
        private double holidayCoef;

        public CompensatoryRate()
        {
            title = "";
            paymentCoef = 1;
            holidayCoef = 0;
        }

        public CompensatoryRate(String _title, double _paymentCoef, double _holidayRate)
        {
            title = _title;
            paymentCoef = _paymentCoef;
            holidayCoef = _holidayRate;
        }

        public String getTitle()
        {
            return title;
        }
        public double getPaymentCoef()
        {
            return paymentCoef;
        }
        public double getholidayCoef()
        {
            return holidayCoef;
        }

        public void setTitle(String _title)
        {
            title = _title;
        }
        public void setPaymentCoef(double _payment)
        {
            paymentCoef = _payment;
        }
        public void setHolidayCoef(double _holiday)
        {
            holidayCoef = _holiday;
        }
    }
}

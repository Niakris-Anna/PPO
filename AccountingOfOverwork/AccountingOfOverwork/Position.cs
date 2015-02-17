using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccountingOfOverwork
{
    class Position
    {
        private String title;
        private double hourlyRate;

        public String getTitle()
        {
            return title;
        }

        public void setTitle(String _title)
        {
            title = _title;
        }

        public double getHourlyRate()
        {
            return hourlyRate;
        }

        public void setHourlyRate(double _rate)
        {
            hourlyRate = _rate;
        }

        public Position(String _title, double _hourlyRate)
        {
            title = _title;
            hourlyRate = _hourlyRate;
        }

        public Position()
        {
            title = "";
            hourlyRate = 0.0;
        }
    }
}

using System;

namespace Course
{
    class ConversorDeMoeda
    {
        public static double valorDolar = 3.10;

        public static double CotaçãoDolar(double iof)
        {
            iof = 6.0 / 100.0;
            return valorDolar + iof;
        }
    
    }
}

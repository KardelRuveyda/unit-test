using System;

namespace FinanceApp
{
    public class FinancialManager
    {
        public double Capital { get; set; }
        public double InterestRate { get; set; }

        public void SetCapital(double v)
        {
            if (v <= 0)
            {
                this.Capital = 0;

            }
            else
            {
                this.Capital = v;
            }
        }

        public void SetInterestRate(int p)
        {
            if (Capital <= 0 || p <= 0)
            {
                InterestRate = 0;
            }
            else
            {
                this.InterestRate = p;
            }
        }

        public void SetInterestGreatRate (int p)
        {
            if(Capital >= 25 )
            {
                InterestRate = 0;
            }  else
            {
                this.InterestRate = 0;
            }
        }
    }
}
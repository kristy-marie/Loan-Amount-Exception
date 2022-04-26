using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11C
{
    public class MyRangeException
    {

        // create method to check for loanAmount exception
        public static void MyLoanAmount(double loan)
        {
            if (loan < 50000)
            {
                throw new ArgumentOutOfRangeException("The loan amount must be greater than $50,000.\n");
            }

        }

        public static void MyLoanInterest(double interest)
        {
            if (interest <= 0)
            {
                throw new ArgumentOutOfRangeException("The interest rate must be at least 1%.\n");
            }
        }

        public static void NumOfYears(double years)
        {
            if (years < 6)
            {
                throw new ArgumentOutOfRangeException("The loan must be at least 6 years.\n");
            }
        }
    }
}

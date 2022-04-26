namespace Assignment11C
{
    public class Program
    {
        static void Main(string[]args)
        {

            bool keepGoing = true;

            MyRangeException re = new MyRangeException();

            double loanInterest;
            double years;
            double loanAmount;

            do
            {
                try
                {
                    Console.WriteLine("Please enter the loan amount: ");
                    loanAmount = Convert.ToDouble(Console.ReadLine);
                    MyRangeException.MyLoanAmount(loanAmount);
                    keepGoing = false;

                }
                catch (FormatException formatException)
                {
                    Console.WriteLine("\n" + formatException.Message);
                    Console.WriteLine("Double values only please.");

                }
                catch (ArgumentOutOfRangeException negativeNumberException)
                {
                    Console.Write("\n" + negativeNumberException.Message);

                }


            } while (keepGoing);

            do
            {
                try
                {
                    Console.Write("Please enter the amount of years for the loan.");
                    years = Convert.ToDouble(Console.ReadLine);
                    MyRangeException.NumOfYears(years);
                    keepGoing = false;
                }
                catch (FormatException formatException)
                {
                    Console.WriteLine(formatException.Message);
                    Console.WriteLine("Please enter double numbers only.");

                }
                catch (ArgumentOutOfRangeException negativeNumbersException)
                {
                    Console.WriteLine(negativeNumbersException.Message);
                    Console.WriteLine("Please enter positive numbers only.");
                }
            } while (keepGoing);

            do
            {
                try
                {
                    Console.Write("Please enter the interest rate: ");
                    loanInterest = Convert.ToDouble(Console.ReadLine);
                    MyRangeException.MyLoanInterest(loanInterest);
                    keepGoing = false;

                }
                catch (FormatException formatException)
                {
                    Console.WriteLine(formatException.Message);
                    Console.WriteLine("Please enter only double numbers.");

                }
                catch (ArgumentOutOfRangeException negativeNumbersException)
                {
                    Console.WriteLine(negativeNumbersException.Message);
                    Console.WriteLine("Positive numbers only.");
                }




            } while (keepGoing);
    }
    } }





        
    

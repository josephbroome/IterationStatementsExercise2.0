using System.Text;
using System.Threading.Tasks;


namespace IterationStatementsExercise2._0
{
    public class Program
    {
        

           
            static void Main(string[] args)
            {
            //    for (int i = 1; i < 15; i++)
            //    {
            //        Console.WriteLine(i);
            //    }

         ;

            //    PrintRangeHighToLow(60, 20);
            //NumbersByThree();

            //Console.WriteLine(AreNumbersEqual(7, 7));


            //Console.WriteLine(Even(7));
            IsNumberEven();
            LegalVotingAge();
        
        }

        public static void PrintRangeHighToLow(double ceiling, double floor)
        {
            for (double i = ceiling; i >= floor; i--)
            {
                Console.WriteLine(i);
            }


        }

        public static void NumbersByThree()
        {
            for(int a=3; a<1000; a+=3)
            {
                Console.WriteLine(a);
            }
        }
        

        public static bool AreNumbersEqual(int x, int y)
        {
            bool isEqual = true;
            if(x == y)
            {
                return isEqual;
            }

            else
                return false;

        }
    
        public static bool Even(int x)
        {
            bool isEven = true;

            if (x % 2 == 0)
            {
                return isEven;
               
            }

            else
                return false;

        }
    
       public static void IsNumberEven()
        {
            Console.WriteLine("Give me a number and i will tell you if its odd or even");
            var number = int.Parse(Console.ReadLine());

            if(number >=0)
            {
                Console.WriteLine($"The number {number} is positive");
            }
            else
            {
                Console.WriteLine($"The number {number} is negative");
            }

        }
    
       public static void LegalVotingAge()
        {
            bool legalVote;
            do
            {
                Console.WriteLine("Welcome to our voting age webiste, you must be over 18 to enter, please give me your age");
                
                var userAge=int.Parse(Console.ReadLine());

                if(userAge>=18)
                {
                    Console.WriteLine($"Welcome to our website!");
                    legalVote=true;
                }
                else
                {
                    Console.WriteLine(("You are not old enough to enter try again in ")+(18-userAge)+(" years."));
                    legalVote=false;
                }
            }while(legalVote==false);
        }
    
    }
}
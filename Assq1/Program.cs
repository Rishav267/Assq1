using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assq1
{
    class Program1
    {
        static void Main(string[] args)
        {
            int AccNo;
            int year;
            string Acctype;
            string AccCat;
            Console.WriteLine("enter the account number");
            AccNo = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the time account is held in years");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the account type Savings or Current in caps");
            Acctype = Console.ReadLine();
            Console.WriteLine("enter the account category Regular or gold or premium in caps");
            AccCat = Console.ReadLine();

            double SR = 5000;
            double SG = 25000;
            double SP = 100000;
            double CR = 25000;
            double CG = 100000;
            double CP = 300000;

            if(year<=5)
            {
                if(Acctype =="SAVINGS" && AccCat == "REGULAR")
                {
                     Console.WriteLine("Minimum balance for your Account is 5000");
                }
                else if(Acctype == "SAVINGS" && AccCat == "GOLD")
                {
                    Console.WriteLine("Minimum balance for your Account is 25000");
                }
                else if (Acctype == "SAVINGS" && AccCat == "PREMIUM")
                {
                    Console.WriteLine("Minimum balance for your Account is 100000");
                }
                else if (Acctype == "CURRENT" && AccCat == "PREMIUM")
                {
                    Console.WriteLine("Minimum balance for your Account is 300000");
                }
                else if (Acctype == "CURRENT" && AccCat == "GOLD")
                {
                    Console.WriteLine("Minimum balance for your Account is 100000");
                }
                else if (Acctype == "CURRENT" && AccCat == "REGULAR")
                {
                    Console.WriteLine("Minimum balance for your Account is 25000");
                }

            }
            else
            {
                int tot = year - 5;
                if(Acctype == "SAVINGS" && AccCat == "REGULAR")
                {
                    for(int i=1;i<=tot;i++)
                    {
                        SR = (SR - ((SR * 5) / 100));
                    }
                    Console.WriteLine($"minimum balance for your account is {SR}");
                }
                else if (Acctype == "SAVINGS" && AccCat == "GOLD")
                {
                    for (int i = 1; i <= tot; i++)
                    {
                        SG = (SG - ((SG * 5) / 100));
                    }
                    Console.WriteLine($"minimum balance for your account is {SG}");
                }
                else if (Acctype == "SAVINGS" && AccCat == "PREMIUM")
                {
                    for (int i = 1; i <= tot; i++)
                    {
                        SP = (SP - ((SP * 5) / 100));
                    }
                    Console.WriteLine($"minimum balance for your account is {SP}");
                }
                else if (Acctype == "CURRENT" && AccCat == "PREMIUM")
                {
                    for (int i = 1; i <= tot; i++)
                    {
                        CP = (CP - ((CP * 5) / 100));
                    }
                    Console.WriteLine($"minimum balance for your account is {CP}");
                }
                else if (Acctype == "CURRENT" && AccCat == "GOLD")
                {
                    for (int i = 1; i <= tot; i++)
                    {
                        CG = (CG - ((CG * 5) / 100));
                    }
                    Console.WriteLine($"minimum balance for your account is {CG}");
                }
                else if (Acctype == "CURRENT" && AccCat == "REGULAR")
                {
                    for (int i = 1; i <= tot; i++)
                    {
                        CR = (CR - ((CR * 5) / 100));
                    }
                    Console.WriteLine($"minimum balance for your account is {CR}");
                }
            }

        }
    }
}

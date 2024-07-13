using System.Runtime.CompilerServices;

namespace FinalProject_Alba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string zodiac;
            string[] birthMonth = { "--------",
                                    "January",
                                    "February",
                                    "March",
                                    "April",
                                    "May",
                                    "June",
                                    "July",
                                    "August",
                                    "September",
                                    "October",
                                    "November",
                                    "December",};
            string YesNo = "No";
            string Astro = "";
            string Characteristics = "";
            List<string> AstrologyList = new List<string>();


            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to Astrology".PadLeft(30));
                Console.WriteLine();


                Console.Write("What is your name: ");
                string name = Console.ReadLine();
              

                Console.Clear();
                Console.WriteLine($"(1){birthMonth[1]} (2){birthMonth[2]} (3){birthMonth[3]} (4){birthMonth[4]} (5){birthMonth[5]} (6){birthMonth[6]} (7){birthMonth[7]}");
                Console.WriteLine($" (8){birthMonth[8]} (9){birthMonth[9]} (10){birthMonth[10]} (11){birthMonth[11]} (12){birthMonth[12]} ");

                Console.WriteLine();
                Console.Write("When is your birthmonth:     "  );
                int BMonth = Convert.ToInt32(Console.ReadLine());

                Console.Write("Write your birthdate:        " );
                int BDate = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter your birthyear:        " );
                int BYear = Convert.ToInt32(Console.ReadLine());

                string Bday = ($"{birthMonth[BMonth].PadRight(7)}  {BDate}  {BYear}");

                Console.Clear();
                Console.WriteLine($"Hi {name}");
                Console.WriteLine($"Your Birthday is: {birthMonth [BMonth]} {BDate},{BYear}");
                int age = 2024 - BYear;
                Console.WriteLine($"Your Age is: {age}");
               
                if (BDate < 31)
                {
                    switch (BMonth)
                    {
                        case 1:
                            if (BDate >= 20)
                            { Astro = ZodiacSign.Aquarius(Astro, Characteristics); }
                            else Astro = ZodiacSign.Capiricorn(Astro, Characteristics);

                            break;

                        case 2:
                            if (BDate >= 19)
                            { Astro = ZodiacSign.Pisces(Astro, Characteristics); }
                            else Astro = ZodiacSign.Aquarius(Astro, Characteristics);
                            break;

                        case 3:
                            if (BDate >= 21)
                            { Astro = ZodiacSign.Aries(Astro, Characteristics); }
                            else Astro = ZodiacSign.Pisces(Astro, Characteristics);
                            break;

                        case 4:
                            if (BDate >= 20)
                            { Astro = ZodiacSign.Taurus(Astro, Characteristics); }
                            else Astro = ZodiacSign.Aries(Astro, Characteristics);
                            break;

                        case 5:
                            if (BDate >= 21)
                            { Astro = ZodiacSign.Gemini(Astro, Characteristics); }
                            else Astro = ZodiacSign.Taurus(Astro, Characteristics);
                            break;

                        case 6:
                            if (BDate >= 22)
                            { Astro = ZodiacSign.Cancer(Astro, Characteristics); }
                            else Astro = ZodiacSign.Gemini(Astro, Characteristics);
                            break;

                        case 7:
                            if (BDate >= 23)
                            { Astro = ZodiacSign.Leo(Astro, Characteristics); }
                            else Astro = ZodiacSign.Gemini(Astro, Characteristics);
                            break;

                        case 8:
                            if (BDate >= 23)
                            { Astro = ZodiacSign.Virgo(Astro, Characteristics); }
                            else Astro = ZodiacSign.Leo(Astro, Characteristics);

                            break;

                        case 9:
                            if (BDate >= 23)
                            { Astro = ZodiacSign.Libra(Astro, Characteristics); }
                            else Astro = ZodiacSign.Virgo(Astro, Characteristics);

                            break;

                        case 10:
                            if (BDate >= 23)
                            { Astro = ZodiacSign.Scorpio(Astro, Characteristics); }
                            else Astro = ZodiacSign.Libra(Astro, Characteristics);
                            break;

                        case 11:
                            if (BDate >= 22)
                            { Astro = ZodiacSign.Sagittarius(Astro, Characteristics); }
                            else Astro = ZodiacSign.Scorpio(Astro, Characteristics);
                            break;
                        case 12:
                            if (BDate >= 22)
                            { Astro = ZodiacSign.Capiricorn(Astro, Characteristics); }
                            else Astro = ZodiacSign.Sagittarius(Astro, Characteristics);
                            break;
                    }
                }
                else { Console.WriteLine("Invalid Birthdate!!!"); }

                AstrologyList.Add($"{name.ToString().PadRight(10)}  {age.ToString().PadRight(16)} {Bday.ToString().PadRight(19)} {Astro}");

                Console.Write("Wanna Input Again (Yes/No) : ");
                YesNo = Console.ReadLine().ToUpper();

            } while (YesNo != "NO");
            Console.Clear();
            Console.WriteLine("Name".PadRight(12) + "Age".PadRight(17) + "BDate".PadRight(20) + "Zodiac Sign".PadRight(32) + "Characteristics".PadLeft(15));

            foreach (var item in AstrologyList) { Console.WriteLine(item); }
        }
    }
}

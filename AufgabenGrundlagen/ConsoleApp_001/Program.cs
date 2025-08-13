using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string RepeatLoop = "y";

            while (RepeatLoop != "n" && RepeatLoop != "N")
            {
                Console.WriteLine("Was möchtest du berechnen? 'ggT'/'kgV'/'mittel'");
                string UserInput = Console.ReadLine();

                switch (UserInput)
                {
                    case "ggt":
                    case "ggT":
                    case "gGt":
                    case "gGT":
                    case "Ggt":
                    case "GgT":
                    case "GGt":
                    case "GGT":
                        {
                            int a = MyMath.ReadInt();
                            int b = MyMath.ReadInt();

                            Console.WriteLine($"Der ggT von {a} und {b} ist {MyMath.Calc_ggT(a, b)}");
                        }

                        break;

                    case "kgv":
                    case "kgV":
                    case "kGv":
                    case "kGV":
                    case "Kgv":
                    case "KgV":
                    case "KGv":
                    case "KGV":
                        {
                            int a = MyMath.ReadInt();
                            int b = MyMath.ReadInt();

                            Console.WriteLine($"Das kgV von {a} und {b} ist {MyMath.Calc_kgV(a, b)}");
                        }

                        break;

                    case "mittel":
                    case "m":
                    case "Mittel":
                    case "M":
                        {
                            int[] UserNumbers = [];
                            int? CurrentUserNumber = null;

                            while (CurrentUserNumber != 0)
                            {
                                Console.WriteLine("Bitte gib eine Zahl ein: (Abbrechen mit '0')");

                                CurrentUserNumber = Convert.ToInt32(Console.ReadLine());
                            }
                        }

                        break;
                }

                Console.WriteLine("Möchtest du eine weitere Berechnung machen? 'y'/'n'");
                RepeatLoop = Console.ReadLine();
            }
        }
    }
}

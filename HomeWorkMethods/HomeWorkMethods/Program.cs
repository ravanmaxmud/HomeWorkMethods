using System;

namespace HomeWorkMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //============================= BiggLetter =============================================================
            string command1 = "Change The Big Letter";
            string command2 = "Change The Small Letter";
            string command3 = "Choose The Letter";
            Console.WriteLine(command1);
            Console.WriteLine(command2);
            Console.WriteLine(command3);
            Console.WriteLine();
            while (true)
            {
                Console.Write("Please Enter Command :");
              string requierdName = Console.ReadLine();
                Console.WriteLine();
                if (requierdName == command1)
                {
                    char[] TargetBiggLetter = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
                    char[] TargetSmallLetter = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
                    Console.Write("Istediyiniz Metini Daxil Edin : ");
                    string TargetTXT = Console.ReadLine();
                    string Result = TextBigLetter(TargetTXT, TargetSmallLetter, TargetBiggLetter);
                    Console.WriteLine(Result);
                }
                ////============================SmallLatter=======================================================================
                if (requierdName == command2)
                {
                    char[] TargetSmallLetter = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
                    char[] TargetBiggLetter = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
                    Console.Write("Istediyiniz Metini daxil Edin : ");
                    string TargedTXT = Console.ReadLine();
                    string Result = TextSmallLetter(TargedTXT, TargetBiggLetter, TargetSmallLetter);
                    Console.WriteLine(Result);
                }
                //========================LetterInformation=======================================
                if (requierdName == command3)
                {
                Console.Write("Istediyiniz adi(Metini) Daxil edin : ");
                string TargedName = Console.ReadLine();
                //TargedName = TargedName.ToLower();
                Console.Write("Istediyiniz BIR Herif(Elementi) Daxil edin : ");
                string TargedLetter = Console.ReadLine();
                //TargedLetter = TargedLetter.ToLower();
                bool result = TargedName.IndexOf(TargedLetter, StringComparison.OrdinalIgnoreCase) >= 0;
                if (result == true)
                {
                    Console.WriteLine("{0} is present in {1}", TargedLetter, TargedName);
                }
                else
                {
                    Console.WriteLine("{0} is not present in {1}", TargedLetter, TargedName);
                }

                Console.WriteLine(IsLetterExist(TargedName, TargedLetter));
                }
            }
        }
        //=============================BiggLetter=============================================================
        public static string TextBigLetter(string TargetTXT, char[] TargetBiggLetter, char[] TargetSmallLetter)
        {
            for (int i = 0; i < TargetBiggLetter.Length; i++)
            {
                TargetTXT = TargetTXT.Replace(TargetBiggLetter[i], TargetSmallLetter[i]);
            }
            return TargetTXT;
        }
        //=================================SmallLetter==============================================================
        public static string TextSmallLetter(string TargetTXT, char[] TargetBiggLetter, char[] TargetSmallLetter)
        {
            for (int i = 0; i < TargetSmallLetter.Length; i++)
            {
                TargetTXT = TargetTXT.Replace(TargetBiggLetter[i], TargetSmallLetter[i]);

            }
            return TargetTXT;
        }
        //===========================LetterInformation====================================
        public static bool IsLetterExist(string TargedName, string TargedLetter)
        {
            for (int i = 0; i < TargedName.Length; i++)
            {
                if (TargedName[i] == TargedLetter[0])
                {
                    Console.Write("COMPATIBLE : ");
                    return true;
                }
            }
            Console.Write("NOT COMPATIBLE : ");
            return false;
        }
    }
}


using System;

namespace HomeWorkMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //=============================BiggLetter=============================================================
            //while (true)
            //{
            //    Console.Write("Istediyiniz Metini Daxil Edin : ");
            //    string TargetTXT = Console.ReadLine();
            //    char[] TargetBiggLetter = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            //    char[] TargetSmallLetter = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            //    string Result = TextBigLetter(TargetTXT, TargetSmallLetter, TargetBiggLetter);
            //    Console.WriteLine(Result);
            //}
            //============================SmallLatter=======================================================================
            //while (true)
            //{
            //    char[] TargetSmallLetter = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            //    char[] TargetBiggLetter = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            //    Console.Write("Istediyiniz Metini daxil Edin : ");
            //    string TargedTXT = Console.ReadLine();
            //    string Result = TextSmallLetter(TargedTXT, TargetBiggLetter, TargetSmallLetter);
            //    Console.WriteLine(Result);
            //}
            //========================LetterInformation=======================================
            //while (true)
            //{
            //    Console.Write("Istediyiniz adi(Metini) Daxil edin : ");
            //    string TargedName = Console.ReadLine();
            //    TargedName = TargedName.ToLower();
            //    Console.Write("Istediyiniz Herif(Elementi) Daxil edin : ");
            //    string TargedLetter = Console.ReadLine();
            //    TargedLetter = TargedLetter.ToLower();

            //    Console.WriteLine(IsLetterExist(TargedName, TargedLetter));
            //}
        }
        //=============================BiggLetter=============================================================
        //public static string TextBigLetter(string TargetTXT, char[] TargetBiggLetter, char[] TargetSmallLetter)
        //{
        //    for (int i = 0; i < TargetBiggLetter.Length; i++)
        //    {
        //        TargetTXT = TargetTXT.Replace(TargetBiggLetter[i], TargetSmallLetter[i]);
        //    }
        //    return TargetTXT;
        //}
        //=================================SmallLetter==============================================================
        //public static string TextSmallLetter(string TargetTXT, char[] TargetBiggLetter, char[] TargetSmallLetter)
        //{
        //    for (int i = 0; i < TargetSmallLetter.Length; i++)
        //    {
        //        TargetTXT = TargetTXT.Replace(TargetBiggLetter[i], TargetSmallLetter[i]);

        //    }
        //    return TargetTXT;
        //}
        //===========================LetterInformation====================================
        ////public static bool IsLetterExist(string TargedName, string TargedLetter)
        ////{
        ////    for (int i = 0; i < TargedName.Length; i++)
        ////    {
        ////        if (TargedName[i] == TargedLetter[0])
        ////        {
        ////            Console.WriteLine($"Beli burada {TargedLetter[0]} var.");
        ////            return true;
        ////        }
        ////    }
        ////    Console.WriteLine($"Xeyir Burada {TargedLetter[0]} yoxdur.");
        ////    return false;
        ////}
    }
}


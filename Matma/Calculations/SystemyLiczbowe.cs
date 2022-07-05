namespace Matma.Calculations
{
    public static class SystemyLiczbowe
    {
        //15XF jest ok
        public static string Przekonwertuj(string liczba, string system)
        {
            string odPowiedzZwrotna="";
            long liczbaDziesietna;
            switch (system)
            {
                case "":
                    odPowiedzZwrotna="Wybierz system liczbowy";
                    break;
                case "2":
                   liczbaDziesietna = BinNaDec(liczba);
                   odPowiedzZwrotna = DecNaReszte(liczbaDziesietna);
                    break;
                case "8":
                   liczbaDziesietna = OctNaDec(liczba);
                   odPowiedzZwrotna = DecNaReszte(liczbaDziesietna);
                    break;
                case "10":
                   liczbaDziesietna = CzyJestDec(liczba);
                   odPowiedzZwrotna = DecNaReszte(liczbaDziesietna);
                    break;
                case "16":
                   liczbaDziesietna = HexNaDec(liczba);
                   odPowiedzZwrotna = DecNaReszte(liczbaDziesietna);
                    break;
                default:
                    break;
            }
            
            return odPowiedzZwrotna;
        }
        private static long BinNaDec(string wartosc)
        {
            long dziesietny;
            if (IsDigitsOnly(wartosc,'0','1'))
               dziesietny = Convert.ToInt64(wartosc,2);
            else
                dziesietny=long.MinValue; 
            return dziesietny;
        }
        private static long OctNaDec(string wartosc)
        {
            long dziesietny;
            if (IsDigitsOnly(wartosc,'0','8'))
               dziesietny = Convert.ToInt64(wartosc,8);
            else
                dziesietny=long.MinValue; 
            return dziesietny;
        }
        private static long CzyJestDec(string wartosc)
        {
            long dziesietny;
            if (IsDigitsOnly(wartosc,'0','9'))
            {
                dziesietny=long.Parse(wartosc);
            }
            else
            {
                dziesietny = long.MinValue;
            }
            return dziesietny;
        }
        private static long HexNaDec(string wartosc)
        {
            long dziesietny;
            if (OnlyHexInString(wartosc))
               dziesietny = Convert.ToInt64(wartosc,16);
            else
                dziesietny=long.MinValue; 
            return dziesietny;
        }
        private static string DecNaReszte(long value)
        {
            string doZwrotu="";
            if(value == long.MinValue)
            {
                doZwrotu = "Wprowadź poprawną wartość";
            }
            else
            {
                doZwrotu += $"System binarny: {Convert.ToString(value, 2)}\n";
                doZwrotu += $"System ósemkowy: {Convert.ToString(value, 8)}\n";
                doZwrotu += $"System dziesiętny: {value}\n";
                doZwrotu += $"System szesnastkowy: {Convert.ToString(value, 16)}";
            }
            return doZwrotu;
        }
        private static bool IsDigitsOnly(string str, char min, char max)
        {
            foreach (char c in str)
            {
                if (c < min || c > max)
                    return false;
            }
            return true;
        }
        private static bool OnlyHexInString(string test)
        {
            bool isHex; 
            foreach(var c in test)
            {
                isHex = ((c >= '0' && c <= '9') || 
                        (c >= 'a' && c <= 'f') || 
                        (c >= 'A' && c <= 'F'));

                if(!isHex)
                    return false;
            }
            return true;
            //return System.Text.RegularExpressions.Regex.IsMatch(test, @"\A\b[0-9a-fA-F]+\b\Z");
        }
    
    }
}
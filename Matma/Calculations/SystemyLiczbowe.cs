namespace Matma.Calculations
{
    public static class SystemyLiczbowe
    {

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
            if (wartosc.Length<64)
            {
            if (IsDigitsOnly(wartosc,'0','1'))
               dziesietny = Convert.ToInt64(wartosc,2);
            else
                dziesietny=long.MinValue; 
            }
            else
                dziesietny=long.MinValue; 
            return dziesietny;
        }
        private static long OctNaDec(string wartosc)
        {
            long dziesietny;
            if (wartosc.Length<22)
            {
                if (IsDigitsOnly(wartosc,'0','8'))
                dziesietny = Convert.ToInt64(wartosc,8);
                else
                    dziesietny=long.MinValue; 
                
            }
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
                if (dziesietny==long.MaxValue)
                    dziesietny = long.MinValue;
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
            if (wartosc.Length<16)
            {
                if (OnlyHexInString(wartosc))
                dziesietny = Convert.ToInt64(wartosc,16);
                else
                    dziesietny=long.MinValue; 
            }
            else
                dziesietny=long.MinValue; 
            return dziesietny;
        }
        private static string DecNaReszte(long value)
        {
            string doZwrotu="";
            if(value == long.MinValue)
            {
                doZwrotu = "Wprowadzono niepoprawne znaki lub podana liczba jest za wysoka";
            }
            else
            {
                doZwrotu += $"Binarny: {Convert.ToString(value, 2)}\n";
                doZwrotu += $"Ósemkowy: {Convert.ToString(value, 8)}\n";
                doZwrotu += $"Dziesiętny: {value}\n";
                doZwrotu += $"Szesnastkowy: {Convert.ToString(value, 16)}";
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
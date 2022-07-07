namespace Matma.Calculations
{
    public static class Geometria
    {
        //Kwadrat
        private static float PoleKwBok(float bok) => (float)Math.Pow(bok,2);
        private static float PoleKwPrzek(float przekatna) => (float)(0.5*Math.Pow(przekatna,2));
        private static float ObwKw(float bok) => bok*4;
        private static float PrzekatnaKw(float bok) => (float)(bok*Math.Sqrt(2));
        public static string WynikKwadrat(float bok, float przekatna)
        {
            string wynik;
            if (bok<=0 && przekatna<=0)
                wynik = "Nie wprowadzono wartości lub wprowadzone wartości są niepoprawne";

            else if(bok==0 && przekatna>0)
                wynik = $"Przekątna = {przekatna}\nPole = {PoleKwPrzek(przekatna)}";

            else if(bok>0 && przekatna==0)
                wynik = $"Przekątna = {PrzekatnaKw(bok)} \nPole = {PoleKwBok(bok)} \nObwód = {ObwKw(bok)}";

            else
            {
                if(PoleKwBok(bok) != PoleKwPrzek(przekatna))
                    wynik = "Wartość boku i przekątnej nie mogą stworzyć kwadratu";

                else
                wynik = $"Przekątna = {PrzekatnaKw(bok)} \nPole = {PoleKwBok(bok)} \nObwód = {ObwKw(bok)}";
            }
            return wynik;            
        }
    
        //Prostokąt
        private static float PoleProstokata(float bokA, float bokB) => bokA*bokB;
        private static float ObwProstokata(float bokA, float bokB) => 2*bokA+2*bokB;
        private static float PrzekatnaProstokata(float bokA, float bokB) => (float)Math.Sqrt(Math.Pow(bokA,2)+Math.Pow(bokB,2));
        private static float DlugDrugBokProstokat(float bokA, float przekatna) => (float)Math.Sqrt(Math.Pow(przekatna,2)-Math.Pow(bokA,2));
        public static string WynikProstokat(float bokA, float bokB, float przekatna)
        {
            string wynik ="";
            float brakujaca = 0;
            if(bokA<=0 && bokB<=0)
            {
                wynik= "brak wprowadzonych wartości, lub podane wartości są niepoprawne";
            }
            else if(bokA>0 && bokB>0 )
            {
                wynik = $"Przekątna = {PrzekatnaProstokata(bokA,bokB)}\nPole = {PoleProstokata(bokA,bokB)} \n Obwód = {ObwProstokata(bokA,bokB)}";
            }
            else if(bokA>0 && bokB<=0 &&(przekatna>0))
            {
                brakujaca = DlugDrugBokProstokat(bokA,przekatna);
                wynik = $"Przekątna = {przekatna}\nPole = {PoleProstokata(bokA,brakujaca)} \n Obwód = {ObwProstokata(bokA,brakujaca)}";
            }
            else if(bokA<=0 && bokB>0 &&(przekatna>0 ))
            {
                brakujaca = DlugDrugBokProstokat(bokB,przekatna);
                wynik = $"Przekątna = {przekatna}\nPole = {PoleProstokata(bokB,brakujaca)} \n Obwód = {ObwProstokata(bokB,brakujaca)}";
            }
            else
            {
                wynik = "Brak przekątnej, lub podana przekątna nie może utworzyć prostokąta z podanym bokiem";
            }
            return wynik;
        }

        //Koło
        private static float PoleKolaBezPi(float promien) => (float)Math.Pow(promien,2);
        private static float PoleKolaZPi(float promien) => (float)(PoleKolaBezPi(promien)*Math.PI);
        private static float ObwodKolaBezPi(float promien) => 2*promien;
        private static float ObwodKolaZPi(float promien) => (float)(ObwodKolaBezPi(promien)*Math.PI);
        public static string WynikKolo(float promien)
        {
            string wynik ="";
            if (promien<=0)
            {
             wynik ="podano niepoprawną wartość";
            }
            else
            {
                wynik = $"Pole = {PoleKolaBezPi(promien)}\u03A0 ({PoleKolaZPi(promien)}) \nObwód = {ObwodKolaBezPi(promien)}\u03A0 ({ObwodKolaZPi(promien)}) ";
            }
            return wynik;
        }
        //Trapez
        private static float PoleTrapezu(float podstawaA, float podstawaB, float wysokosc) => ((podstawaA+podstawaB)*wysokosc)/2; 
        private static float ObwodTrapezu(float podstawaA, float podstawaB, float bokA, float bokB) => podstawaA+podstawaB+bokA+bokB; 
        public static string WynikTrapez(float podstawaA, float podstawaB, float bokA, float bokB,float wysokosc)
        {
            string wynik="";
            if(podstawaA<=0 ||podstawaB <=0 || wysokosc<=0)
            {
                wynik = "Nie można obliczyć pola trapezu";
            }
            else
            {
                wynik = $"Pole = {PoleTrapezu(podstawaA,podstawaB,wysokosc)}";
                if(bokA<=0 || bokB<=0)
                    wynik +="\nNie można obliczyć obwodu trapezu";

                else
                    wynik +=$"\nObwód = {ObwodTrapezu(podstawaA,podstawaB,bokA,bokB)}";

            }
            return wynik;
        }
        //Romb
        private static float PoleRombu(float bok, float wysokosc) => bok*wysokosc;
        private static float PoleRombuPrzekatne(float przekatnaA, float przekatnaB) => (przekatnaA*przekatnaB)/2;
        private static float PoleRombuAlpha(float bok, float alpha) => (float)(Math.Pow(bok,2)*Math.Sin(alpha));
        private static float ObwodRombu(float bok) => bok*4;
        public static string WynikRomb(float bok, float wysokosc, float przekatnaA, float przekatnaB, float alpha)
        {
            string wynik = "";
            if(bok<=0)
            {
                if (przekatnaA<=0 || przekatnaB <=0)
                    wynik ="Nie można obliczyć pola trapezu";

                else
                    wynik += $"Dla przekątnej = {przekatnaA} i {przekatnaB}\nPole = {PoleRombuPrzekatne(przekatnaA, przekatnaB)}";

                wynik += "\nNie można obliczyć obwodu";
            }
            else
            {
                if (wysokosc<=0)
                {
                    if (alpha<=0)
                        wynik = "Nie można obliczyć pola trapezu";

                    else
                        wynik = $"(Dla Bok = {bok} Kąt alpha = {alpha})\nPole = {PoleRombuAlpha(bok,alpha)}";
                }
                else
                    wynik = $"(Dla Bok = {bok} Wysokość = {wysokosc})\nPole = {PoleRombu(bok,wysokosc)}";
                
                wynik += $"\nObwód = {ObwodRombu(bok)}";
            }
            return wynik;
        }
        //Sześcian
        private static float PcSzescian(float a) =>(float)(6*Math.Pow(a,2));
        private static float ObjSzescian(float a) =>(float)Math.Pow(a,3);
        private static float PrzekatnaSzescian(float a) =>(float)(a*Math.Sqrt(3));
        private static float PromienKuliWSzescianie(float a) =>a/2;
        private static float PromienKuliNaSzescianie(float a) =>PrzekatnaSzescian(a)/2;
        public static string WynikSzescian(float bok)
        {
            string wynik ="";
            if(bok<=0)
                wynik = "Brak lub niepoprawna wartość";
            else
            {
                wynik = $"Pc = {PcSzescian(bok)} \nV = {ObjSzescian(bok)} \nPrzekątna = {PrzekatnaSzescian(bok)} \nPromień kuli w sześcianie = {PromienKuliWSzescianie(bok)}" +
                $"\nPromień kuli na sześcianie = {PromienKuliNaSzescianie(bok)}";
            }
            return wynik;
        }


    }
}
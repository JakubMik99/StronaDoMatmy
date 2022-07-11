namespace Matma.Calculations
{
    public static class Geometria
    {
        private static string Pi = "\u03A0";
        //Kwadrat
        private static float PoleKwBok(float? bok) => (float)Math.Pow(bok??0,2);
        private static float PoleKwPrzek(float? przekatna) => (float)(0.5*Math.Pow((przekatna??0),2));
        private static float ObwKw(float? bok) => (bok??0)*4;
        private static float PrzekatnaKw(float? bok) => (float)((bok??0)*Math.Sqrt(2));
        public static string WynikKwadrat(float? bok, float? przekatna)
        {
            string wynik;
            if (!(bok== null && przekatna == null))
            {
                if (bok<=0 && przekatna<=0)
                    wynik = "Nie wprowadzono wartości lub wprowadzone wartości są niepoprawne";

                else if(bok>0)
                    wynik = $"Przekątna = {PrzekatnaKw(bok)} \nPole = {PoleKwBok(bok)} \nObwód = {ObwKw(bok)}";

                else if(przekatna>0)
                    wynik = $"Przekątna = {przekatna}\nPole = {PoleKwPrzek(przekatna)}";

                else
                {

                    wynik = $"Przekątna = {PrzekatnaKw(bok)} \nPole = {PoleKwBok(bok)} \nObwód = {ObwKw(bok)}";
                }
                
            }
            else
            wynik ="Nie wprowadzono wartości";
            return wynik;            
        }
    
        //Prostokąt
        private static float PoleProstokata(float? bokA, float? bokB) => (bokA??0)*(bokB??0);
        private static float ObwProstokata(float? bokA, float? bokB) => 2*(bokA??0)+2*(bokB??0);
        private static float PrzekatnaProstokata(float? bokA, float? bokB) => (float)Math.Sqrt(Math.Pow((bokA??0),2)+Math.Pow((bokB??0),2));
        private static float DlugDrugBokProstokat(float? bokA, float? przekatna) => (float)Math.Sqrt(Math.Pow((przekatna??0),2)-Math.Pow((bokA??0),2));
        public static string WynikProstokat(float? bokA, float? bokB, float? przekatna)
        {
            string wynik ="";
            float brakujaca = 0;
            if (!(bokA==null && bokB==null && przekatna==null))
            {
                if(bokA<=0 && bokB<=0)
                {
                    wynik= "brak wprowadzonych wartości, lub podane wartości są niepoprawne";
                }
                else if(bokA>0 && bokB>0 )
                {
                    wynik = $"Przekątna = {PrzekatnaProstokata(bokA,bokB)}\nPole = {PoleProstokata(bokA,bokB)} \n Obwód = {ObwProstokata(bokA,bokB)}";
                }
                else if(bokA>0 && (bokB<=0 || bokB==null) &&(przekatna>bokA))
                {
                    brakujaca = DlugDrugBokProstokat(bokA,przekatna);
                    wynik = $"Przekątna = {przekatna}\nPole = {PoleProstokata(bokA,brakujaca)} \n Obwód = {ObwProstokata(bokA,brakujaca)}";
                }
                else if((bokA<=0 || bokA==null) && bokB>0 &&(przekatna>bokB ))
                {
                    brakujaca = DlugDrugBokProstokat(bokB,przekatna);
                    wynik = $"Przekątna = {przekatna}\nPole = {PoleProstokata(bokB,brakujaca)} \n Obwód = {ObwProstokata(bokB,brakujaca)}";
                }
                else
                {
                    wynik = "Brak przekątnej, lub podana przekątna nie może utworzyć prostokąta z podanym bokiem";
                }
            }
            else
                wynik = "brak wprowadzonych wartości";
            
            return wynik;
        }

        //Koło
        private static float PoleKolaBezPi(float? promien) => (float)Math.Pow(promien??0,2);
        private static float PoleKolaZPi(float? promien) => (float)(PoleKolaBezPi(promien)*Math.PI);
        private static float ObwodKolaBezPi(float? promien) => (2*promien) ??0;
        private static float ObwodKolaZPi(float? promien) => (float)(ObwodKolaBezPi(promien)*Math.PI);
        public static string WynikKolo(float? promien)
        {
            string wynik ="";
            if (promien<=0)
            {
             wynik ="podano niepoprawną wartość";
            }
            else
            {
                if (promien.HasValue)
                wynik = $"Pole = {PoleKolaBezPi(promien)}{Pi} ({PoleKolaZPi(promien)}) \nObwód = {ObwodKolaBezPi(promien)}{Pi} ({ObwodKolaZPi(promien)}) ";
                else
                wynik = "Nie wprowadzono wartości";
            }
            return wynik;
        }
        //Trapez
        private static float PoleTrapezu(float? podstawaA, float? podstawaB, float? wysokosc) => (((podstawaA??0)+(podstawaB??0))*(wysokosc??0))/2; 
        private static float ObwodTrapezu(float? podstawaA, float? podstawaB, float? bokA, float? bokB) => (podstawaA??0)+(podstawaB??0)+(bokA??0)+(bokB??0); 
        public static string WynikTrapez(float? podstawaA, float? podstawaB, float? bokA, float? bokB,float? wysokosc)
        {
            string wynik="";
            if((podstawaA<=0||podstawaA==null) ||(podstawaB <=0||podstawaB==null) || (wysokosc<=0||wysokosc==null))
            {
                wynik = "Nie można obliczyć pola trapezu";
            }
            else
            {
                wynik = $"Pole = {PoleTrapezu(podstawaA,podstawaB,wysokosc)}";
                if(bokA<=0 ||bokA==null || bokB<=0 || bokB==null)
                    wynik +="\nNie można obliczyć obwodu trapezu";

                else
                    wynik +=$"\nObwód = {ObwodTrapezu(podstawaA,podstawaB,bokA,bokB)}";

            }
            return wynik;
        }
        //Romb
        private static float PoleRombu(float? bok, float? wysokosc) => (bok??0)*(wysokosc??0);
        private static float PoleRombuPrzekatne(float? przekatnaA, float? przekatnaB) => ((przekatnaA??0)*(przekatnaB??0))/2;
        private static float PoleRombuAlpha(float? bok, float? alpha) => (float)(Math.Pow((bok??0),2)*Math.Sin((alpha??0)));
        private static float ObwodRombu(float? bok) => (bok??0)*4;
        public static string WynikRomb(float? bok, float? wysokosc, float? przekatnaA, float? przekatnaB, float? alpha)
        {
            string wynik = "";
            if(bok<=0 || bok ==null)
            {
                if ((przekatnaA<=0 ||przekatnaA==null) || (przekatnaB <=0||przekatnaB==null))
                    wynik ="Nie można obliczyć pola trapezu";

                else
                    wynik += $"Dla przekątnej = {przekatnaA} i {przekatnaB}\nPole = {PoleRombuPrzekatne(przekatnaA, przekatnaB)}";

                wynik += "\nNie można obliczyć obwodu";
            }
            else
            {
                if (wysokosc<=0 || wysokosc==null)
                {
                    if (alpha<=0 || alpha==null)
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
        private static float PcSzescian(float? a) =>(float)(6*Math.Pow((a??0),2));
        private static float ObjSzescian(float? a) =>(float)Math.Pow((a??0),3);
        private static float PrzekatnaSzescian(float? a) =>(float)((a??0)*Math.Sqrt(3));
        private static float PromienKuliWSzescianie(float? a) =>(a??0)/2;
        private static float PromienKuliNaSzescianie(float? a) =>PrzekatnaSzescian(a)/2;
        public static string WynikSzescian(float? bok)
        {
            string wynik ="";
            if(bok<=0 || bok==null)
                wynik = "Brak lub niepoprawna wartość";
            else
            {
                wynik = $"Pc = {PcSzescian(bok)} \nV = {ObjSzescian(bok)} \nPrzekątna = {PrzekatnaSzescian(bok)} \nPromień kuli w sześcianie = {PromienKuliWSzescianie(bok)}" +
                $"\nPromień kuli na sześcianie = {PromienKuliNaSzescianie(bok)}";
            }
            return wynik;
        }
        //Prostopadłościan
        private static float PcProstopadloscian(float? bokA, float? bokB, float? bokC) 
        =>(bokA==null|| bokB==null || bokC==null)? 0 : 2*((bokA??0)*(bokB??0) +(bokA??0)*(bokC??0)+(bokB??0)*(bokC??0));
        private static float ObjProstopadloscianu(float? bokA, float? bokB, float? bokC) => (bokA??0)*(bokB??0)*(bokC??0);
        private static float PrzekatnaProstopadloscian(float? bokA, float? bokB, float? bokC) 
        =>(bokA==null|| bokB==null || bokC==null)? 0 : (float)Math.Sqrt(Math.Pow((bokA??0),2)+Math.Pow((bokB??0),2)+Math.Pow((bokC??0),2));
        public static string WynikProstopadloscian(float? a, float? b, float? c)
        {
            string wynik = "";
            if ((a<=0||a==null)||(b<=0||b==null)||(c<=0||c==null))
                wynik ="Brak lub niepoprawna wartość";
            else
              wynik = $"Przekątna = {PrzekatnaProstopadloscian(a,b,c)}\nPc = {PcProstopadloscian(a,b,c)}\nV = {ObjProstopadloscianu(a,b,c)}";       
            return wynik;
        }
        //Walec
        private static float PolePodstawyWalec(float? promien, bool pi) =>pi ? PoleKolaZPi(promien) : PoleKolaBezPi(promien);
        private static float PoleBoczneWalec(float? promien, float? wysokosc, bool pi) => pi? (float)(2*Math.PI*(promien??0)*(wysokosc??0)):2*(promien??0)*(wysokosc??0) ;
        private static float PcWalec(float? promien, float? wysokosc, bool pi)=>2* PolePodstawyWalec(promien, pi) + PoleBoczneWalec(promien, wysokosc, pi);
        private static float ObjWalec(float? promien, float? wysokosc, bool pi) =>PolePodstawyWalec((promien??0),pi)*(wysokosc??0);
        public static string WynikWalec(float? promien, float? wysokosc)
        {
            string wynik ="";
            if ((promien<=0 || promien==null) || (wysokosc<=0 || wysokosc==null))
                wynik = "Nie wprowadzono wartości lub została ona wprowadzona niepoprawnie";
            else
                wynik = $"Pp = {PolePodstawyWalec(promien,false)}{Pi}({PolePodstawyWalec(promien,true)})"+
                $"\n Pb = {PoleBoczneWalec(promien, wysokosc, false)}{Pi}({PoleBoczneWalec(promien, wysokosc, true)})"+
                $"\n Pc = {PcWalec(promien,wysokosc,false)}{Pi}({PcWalec(promien,wysokosc, true)})\nV = {ObjWalec(promien, wysokosc, false)}{Pi}({ObjWalec(promien, wysokosc, true)})";
            return wynik;
        }
        //Kula
        private static float PoleKuli(float? promien, bool pi) =>pi?(float)(4*Math.PI*Math.Pow((promien??0),2)):(float)(4*Math.Pow((promien??0),2));
        private static float ObjKuli(float? promien, bool pi) =>pi? (float)(4/3f*Math.PI*Math.Pow((promien??0),3)):(float)(4/3f*Math.Pow((promien??0),3));
        public static string WynikKula(float? promien)
        {
            string wynik ="";
            if (promien<=0 || promien == null)
                wynik = "Nie wprowadzono wartości lub została ona wprowadzona niepoprawnie";
            else
                wynik = $"Pc = {PoleKuli(promien,false)}{Pi}({PoleKuli(promien,true)})"+
                $"\nV = {ObjKuli(promien, false)}{Pi}({ObjKuli(promien, true)})";
            return wynik;
        }
        //Stożek
        private static float PoleBoczneStozek(float? promien, float? tworzaca, bool pi) => pi? (float)((promien??0)*(tworzaca??0)*Math.PI):(promien??0)*(tworzaca??0);
        private static float PoleStozek(float? promien, float? tworzaca, bool pi) => pi? PoleKolaZPi(promien) + PoleBoczneStozek(promien, tworzaca, true) 
        :PoleKolaBezPi(promien) + PoleBoczneStozek(promien,tworzaca,false);
        private static float ObjStozek(float? promien, float? tworzaca, float? wysokosc, bool pi) => pi? 1/3f*(PoleKolaZPi(promien??0)*(wysokosc??0)) 
        : 1/3f*(PoleKolaBezPi(promien??0)*(wysokosc??0));
        public static string WynikStozek(float? promien, float? tworzaca, float? wysokosc)
        {
            string wynik ="";
            if ((promien <=0 || promien == null) || (tworzaca<=0 || tworzaca == null))
            {
                wynik = "Nie wprowadzono wartości lub została ona wprowadzona niepoprawnie";
            }
            else
            {
                wynik += $"Pb = {PoleBoczneStozek(promien, tworzaca,false)}{Pi}({PoleBoczneStozek(promien,tworzaca, true)})"+
                $"\nPp = {PoleKolaBezPi(promien)}{Pi}({PoleKolaZPi(promien)}) \nPc = {PoleStozek(promien,tworzaca,false)}{Pi}({PoleStozek(promien,tworzaca,true)})";
                if (wysokosc<=0 || wysokosc == null)
                    wynik +="\n Nie wprowadzono wysokości lub została ona wprowadzona niepoprawnie";

                else
                    wynik += $"\nV = {ObjStozek(promien,tworzaca,wysokosc,false)}{Pi}({ObjStozek(promien,tworzaca,wysokosc,true)})";
            }
            return wynik;
        }

    }
}
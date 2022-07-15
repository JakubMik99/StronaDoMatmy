using Matma.Models;

namespace Matma.Calculations
{
    public class ObliczMatrix
    {
        
        public int[] MatrixAWLinijce { get; set; }
        public int[] MatrixBWLinijce { get; set; }
        
        
        public ObliczMatrix(int[] macierz)
        {
            MatrixAWLinijce = macierz;
        }
        private int[,] DoMacierzy(out int[,] macierzB)
        {
            int[,] macierzA;
            int dlugosc = MatrixAWLinijce.Length;
            switch(dlugosc)
            {
                case 1:
                macierzA = new int[1,1];
                macierzB = new int[1,1];
                break;

                case 4:
                macierzA = WypelnijMacierz(MatrixAWLinijce,2);
                macierzB = WypelnijMacierz(MatrixBWLinijce,2);
                break;

                case 9:
                macierzA = WypelnijMacierz(MatrixAWLinijce,3);
                macierzB = WypelnijMacierz(MatrixBWLinijce,3);
                break;

                case 16:
                macierzA = WypelnijMacierz(MatrixAWLinijce,4);
                macierzB = WypelnijMacierz(MatrixBWLinijce,4);
                break;


                case 25:
                macierzA = WypelnijMacierz(MatrixAWLinijce,5);
                macierzB = WypelnijMacierz(MatrixBWLinijce,5);
                break;
                default:
                macierzA = new int[1,1];
                macierzB = new int[1,1];
                break;
            }
            return macierzA;
            
        }
        private int[,] WynikDodawania(int[,] macierzA, int[,] macierzB)
        {
            byte dlugosc = (byte)macierzA.GetLength(0);
            int[,] wynik = new int[dlugosc,dlugosc];
            for (var i = 0; i < dlugosc; i++)
            {
                for (var j = 0; j < dlugosc; j++)
                {
                    wynik[i,j] = macierzA[i,j] + macierzB[i,j];
                }
            }
            return wynik;
        }
        private int[,] WynikOdejmowania(int[,] macierzA, int[,] macierzB)
        {
            byte dlugosc = (byte)macierzA.GetLength(0);
            int[,] wynik = new int[dlugosc,dlugosc];
            for (var i = 0; i < dlugosc; i++)
            {
                for (var j = 0; j < dlugosc; j++)
                {
                    wynik[i,j] = macierzA[i,j] - macierzB[i,j];
                }
            }
            return wynik;

        }
        private int[,] WypelnijMacierz(int[] lista, int rozmiar)
        {
            int[,] macierz = new int[rozmiar,rozmiar];
            int k=0;
            for (var i = 0; i < rozmiar; i++)
            {
                for (var j = 0; j < rozmiar; j++)
                {
                    macierz[i,j]=lista[k++];
                }
            }
            return macierz;
        }

        // public string[] Linijki()
        // {
        //     string[] lines = Macierz.Matrix.Split(
        //     new string[] { Environment.NewLine },
        //     StringSplitOptions.None);
        //     return lines;
        // }
        // private bool CzyWierszeSaRowne(out int licznik)
        // {
        //     licznik = 0;
        //     bool czyToPierwszy= true;
        //     foreach (var item in Linijki())
        //     {
        //         var cell = item.Split(' ');
        //         if (czyToPierwszy)
        //         {
        //             licznik = cell.Count();
        //             czyToPierwszy = false;
        //         }
        //         else
        //         {
        //             if (licznik !=cell.Count())
        //             {
        //              return false;   
        //             }
        //         }
        //     }
        //     return true;
        // }

        // private static int CountLines(string str)
        // {
        //     if (str == null)
        //         throw new ArgumentNullException("str");
        //     if (str == string.Empty)
        //         return 0;
        //     int index = -1;
        //     int count = 0;
        //     while (-1 != (index = str.IndexOf(Environment.NewLine, index + 1)))
        //         count++;

        //     return count + 1;
        // }
                

    }
}


namespace Matma.Calculations
{
    public class ObliczMatrix
    {
        
        //public int[] MatrixAWLinijce { get; set; }
       // public int[] MatrixBWLinijce { get; set; }
        
        
        // public ObliczMatrix(int[] macierzA, int[] macierzB)
        // {
        //     MatrixAWLinijce = macierzA;
        //     MatrixAWLinijce = macierzB;
        // }
        public string WszystkieWyniki(int[] tab1, int[] tab2,out string dodawanie,out string odejmowanie, out string macierzA, out string macierzB)
        {
            string mnozenie =""; dodawanie =""; odejmowanie =""; macierzA = ""; macierzB= "";
            int[,] matA = DoMacierzy(tab1 );
            int[,] matB = DoMacierzy(tab2);
            int dlugosc = matB.GetLength(0);
            for (var i = 0; i < dlugosc; i++)
            {
                for (var j = 0; j < dlugosc; j++)
                {
                    dodawanie+= $"{WynikDodawania(matA,matB)[i,j]} ";
                    odejmowanie+=  $"{WynikOdejmowania(matA,matB)[i,j]} ";
                    mnozenie+= $"{WynikMnozenia(matA,matB)[i,j]} ";
                    macierzA+= $"{matA[i,j]} ";
                    macierzB+= $"{matB[i,j]} ";
                }
                dodawanie +="\n";
                odejmowanie +="\n";
                mnozenie +="\n";
                macierzA +="\n";
                macierzB +="\n";
            }
            return mnozenie;
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
        int[,] WynikMnozenia(int[,] A, int[,] B)
    {
        int dlugosc = A.GetLength(0);
        int temp = 0;
        int[,] wynik = new int[dlugosc, dlugosc];
            for (int i = 0; i < dlugosc; i++)
            {
                for (int j = 0; j < dlugosc; j++)
                {
                    temp = 0;
                    for (int k = 0; k < dlugosc; k++)
                    {
                        temp += A[i, k] * B[k, j];
                    }
                    wynik[i, j] = temp;
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

        private int[,] DoMacierzy(int[] macierz)
        {
            int[,] macierzA;
            int dlugosc = macierz.Length;
            switch(dlugosc)
            {
                case 1:
                macierzA = new int[1,1];
                break;

                case 4:
                macierzA = WypelnijMacierz(macierz,2);
                break;

                case 9:
                macierzA = WypelnijMacierz(macierz,3);
                break;

                case 16:
                macierzA = WypelnijMacierz(macierz,4);
                break;


                case 25:
                macierzA = WypelnijMacierz(macierz,5);
                break;
                default:
                macierzA = new int[1,1];
                break;
            }
            return macierzA;
            
        }
    }
}

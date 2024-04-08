namespace Les_tabeaux
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tabEntier1 = new int[5];
            int [] tabEntier2=new int[5];
            int[] tabEntier3 = new int[10];




            for (int i = 0; i < tabEntier1.Length; i++)
            {
                tabEntier1[i] = i;
                tabEntier2[i] = i;
            }
            
                Array.Copy(tabEntier1,0,tabEntier3,0,tabEntier1.Length);

                Array.Copy(tabEntier2,0, tabEntier3,5, tabEntier2.Length);

        }
    }
}

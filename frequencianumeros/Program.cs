using System;

namespace frequencianumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            do
            {

                Console.WriteLine("Digite N para informar os numeros ou digite S para sair: ");
                opcao = Console.ReadLine();


                if (opcao == "s" || opcao == "S")
                {
                    break;
                }

                Console.WriteLine("Quantos valores deseja informar? ");
                int quantvalores = Convert.ToInt32(Console.ReadLine());

                int[] tdsnumeros = new int[quantvalores];
               

                for (int i = 1; i <= quantvalores ; i++)
                {
                   
                    Console.WriteLine("Informe o " + i + "° número: ");
                    int numeros = Convert.ToInt32(Console.ReadLine());



                    
                        tdsnumeros[i - 1]= numeros;
  
                }

                Array.Sort<int>(tdsnumeros, new Comparison<int>(
                    (i1, i2) => i1.CompareTo(i2)));

                foreach (var item in tdsnumeros)
                {
                    Console.WriteLine(item + "");
                }





                Console.ReadLine();
            } while (opcao == "n" || opcao == "N");
        }
    }
}

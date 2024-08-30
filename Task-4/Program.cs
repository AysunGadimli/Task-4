using System.Drawing;

namespace Task_4;

class Program
{
    static void Main(string[] args)
    {






        //1. Ədədlərdən ibarət arrayın ən kiçik elementini tapın

        int[] arry = { 15, 22, 38, 4, 5, 66, 2, 1, };

        int temp = arry[0];

        for (int i = 1; i < arry.Length; i++)
        {
            if (arry[i] < temp)
            {
                temp = arry[i];
            }
        }
        Console.WriteLine(temp);



        // 2.Sozlerden ibaret arrayde uzunlugu 4 - den boyuk olan sozleri ekrana çap edin

        string[] arrystring = { "Ali", "Aysun", "Ada", "Murad", "Alina" };

        for (int i = 0; i < arrystring.Length; i++)
        {
            if (arrystring[i].Length > 4)
            {
                Console.WriteLine(arrystring[i]);
            }
        }




        //3.Ədədlərdən ibarət arrayda neçə rəqəm olduğunu ekrana çap edin(Məs: { 1,77,6,14}
        //arrayında 2 rəqəm var )

        int[] arrint = { 23, 4, 67, 8, 9, 35, 7, 10 };


        for (int i = 0; i < arrint.Length; i++)
        {
            if (arrint[i] < 10)
            {
                Console.WriteLine(arrint[i]);
            }
        }



        //4.Verilmish sozde 'a' herfi olub olmadigini tapan alqoritm


        string name = "aysun";
      

        for (int i = 0; i < name.Length; i++)
        {
            if (name[i] =='a')
            {
                Console.WriteLine($"{name}---> bu sozde a herifi var");
            }
           
        }








    }
}

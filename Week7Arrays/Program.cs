using System;

namespace Week7Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab kasutajale hommikusöögi menüüd
            //programm palub kasutajal teha valikut
            //programm kuvab kasutaja valikut konsoolis

            string[] menüü = { "omlett", "pannkoogid", "keedumuna", "neljaviljapuder", "singivõileib" };
            Console.WriteLine($"Meie menüüs on {menüü.Length} valikut.");
           
            menüü[3] = "kaerapuder";
            menüü[4] = "juustuvõileib";
            

            Console.WriteLine("Tänases menüüs:");

            for (int i = 0; i < menüü.Length; i++)
           
            {
                if (menüü[i] == "neljaviljapuder")
                {
                    menüü[i] = "kaerapuder";
                }
                else if (menüü[i] == "singivõileib") 
                {
                menüü[i] = "juustuvõileib";
                }


                Console.WriteLine(menüü[i]);
            }

            Console.WriteLine("Tee oma valikut (sisesta numbrid 1-5):");
            int userChoice = Convert.ToInt32(Console.ReadLine())-1;

            Console.WriteLine($"Olete valinud: {menüü[userChoice]}");


            /*foreach(string menüüElement in menüü)
            {
               
                Console.WriteLine(menüüElement);
            }*/

        }
    }
}

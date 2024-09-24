
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    static void Main(string[] args)
    {
        TransactionList transl = new TransactionList();

        while (true)
        {
            Console.WriteLine("1) Read 2) Print 3) Quit");
            string option = Console.ReadLine();

            if (option == "1")
            {
                transl.Read();
            }
            else if (option == "2")
            {
                transl.Write();
            }
            else if (option == "3")
            {
                break;
            }
        }
    }

}
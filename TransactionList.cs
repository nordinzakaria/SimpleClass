using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TransactionList
{
    const int TRANSACTION_SZ = 5;
    Transaction[] dataset = new Transaction[TRANSACTION_SZ];

    public void Read()
    {
        Console.WriteLine("Enter " + TRANSACTION_SZ + " transaction values:");

        for (int i = 0; i < TRANSACTION_SZ; i++)
        {
            Console.Write("Val: ");
            string val = Console.ReadLine();
            dataset[i] = new Transaction();

            dataset[i].data = int.Parse(val);

            dataset[i].date = new Date();
            Console.Write("Day: ");
            val = Console.ReadLine();
            dataset[i].date.day = int.Parse(val);

            Console.Write("Month: ");
            val = Console.ReadLine();
            dataset[i].date.month = int.Parse(val);

            Console.Write("Year: ");
            val = Console.ReadLine();
            dataset[i].date.year = int.Parse(val);
        }

    }

    public void Write()
    {
        Console.WriteLine("Transaction values:");
        for (int i = 0; i < TRANSACTION_SZ; i++)
        {
            Console.WriteLine("Val: " + dataset[i].data);
            Console.WriteLine("Day: " + dataset[i].date.day);
            Console.WriteLine("Month: " + dataset[i].date.month);
            Console.WriteLine("Year: " + dataset[i].date.year);
        }
    }

}


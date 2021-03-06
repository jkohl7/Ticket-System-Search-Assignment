﻿using System;
using System.IO;
using System.Collections;
using System.Linq;

namespace TIcketObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //create array and read file
            ArrayList TDArray = new ArrayList();
            string file = "tickets.csv";
            StreamReader sr = new StreamReader(file);
           
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] arr = line.Split(",");
                TDArray.Add(arr);
            }
            sr.Close();
            StreamWriter sw = new StreamWriter(file);

            //Promt the user
            
            string choice = null;
            Console.WriteLine("Would you like to search or enter a ticket?");
            Console.WriteLine("1. Search ticket");
            Console.WriteLine("2. Add ticket");
            choice = Console.ReadLine();

            if (choice == "1"){
            Console.WriteLine("What do you want to search?");
            Console.WriteLine("1. Status");
            Console.WriteLine("2. Priority");
            Console.WriteLine("3. Submitter");
            string option = Console.ReadLine();

            if (option == "1"){
            Console.WriteLine("Type what you want to search for:");
            var search = Console.ReadLine();

            var status = file.Tickets.Where(t => t.status.Contains(search)).Select(t => t.status);
            // LINQ - Count aggregation method
            Console.WriteLine($"There are {status.Count()} movies with " + search + " in the title:");
            foreach(string t in status)
            {
                Console.WriteLine($"  {t}");
            }

            }
            else if (option == "2"){

            Console.WriteLine("Type what you want to search for:");
            var search = Console.ReadLine();
                  
            var priority = file.Tickets.Where(t => t.status.Contains(search)).Select(t => t.priority);
            // LINQ - Count aggregation method
            Console.WriteLine($"There are {priority.Count()} movies with " + search + " in the title:");
            foreach(string t in priority)
            {
                Console.WriteLine($"  {t}");
            }

            }else if (option == "3"){

            Console.WriteLine("Type what you want to search for:");
            var search = Console.ReadLine();
                  
            var submiter = file.Tickets.Where(t => t.submiter.Contains(search)).Select(t => t.submiter);
            // LINQ - Count aggregation method
            Console.WriteLine($"There are {submiter.Count()} movies with " + search + " in the title:");
            foreach(string t in submiter)
            {
                Console.WriteLine($"  {t}");
            }



            }else{
    
                Console.WriteLine("No option was selected");
            }
            


            

            }else if (choice == "2"){

            Console.WriteLine("Enter TicketID");
            string id = Console.ReadLine();
           
            string summ = Console.ReadLine();
            Console.WriteLine("Enter the status of the ticket");
            string status = Console.ReadLine();
            Console.WriteLine("Enter the priority of the ticket");
            string prio = Console.ReadLine();
            Console.WriteLine("Enter the submiter of the ticket");
            string submit = Console.ReadLine();
            Console.WriteLine("Enter the assigner of the ticket");
            string assn = Console.ReadLine();


            //Asks and gets data for multiple users
            Console.WriteLine("Is anyone watching the ticket? (Y/N)");
            string reply = Console.ReadLine().ToUpper();

            bool whosWatching = true;
            if (reply.Equals("N")) whosWatching = false;
            string watch = "";
            while (whosWatching)
            {
                Console.WriteLine("Who is watching?");
                watch += Console.ReadLine();
                watch += "|";
                Console.WriteLine("Is there anyone else? (Y/N)");
                reply = Console.ReadLine().ToUpper();
                if (reply.Equals("N")) whosWatching = false;
            }
            String[] userInput = new string[] { id, summ, status, prio, submit, assn, watch };
              TDArray.Add(userInput);

            //Create an instance of the ticket object
            
           //   Ticket made = new Ticket(id, summ,status, prio, submit, assn, watch);

            foreach (string[] l in TDArray)
            {
                for (int x = 0; x < 7; x++)
                {
                    sw.Write(l[x] + ",");

                }
                sw.WriteLine();

            }

            }
            sw.Close();
    

        }
    }
}


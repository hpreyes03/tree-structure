using System;

class Program
{
    static void Main(string[] args)
    {
        string userChoice = "";
        bool exit = false;

    Home:
        if (!exit)
        {
            Console.WriteLine("Home");
            Console.WriteLine("a. Network Security Measures");
            Console.WriteLine("b. Cloud Service Models");
            Console.WriteLine("c. Close");
            Console.Write("Enter your choice (a/b/c): ");
            userChoice = Console.ReadLine().ToLower();

            if (userChoice == "a")
                goto NetworkSecurityMeasures;
            else if (userChoice == "b")
                goto CloudServiceModels;
            else if (userChoice == "c")
            {
                exit = true;
                goto End;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                goto Home;
            }

            Console.WriteLine();
        }

    NetworkSecurityMeasures:
        Console.WriteLine("Network Security Measures");
        Console.WriteLine("a. Preventive");
        Console.WriteLine("b. Detective");
        Console.WriteLine("c. Back");
        Console.Write("Enter your choice (a/b/c): ");
        userChoice = Console.ReadLine().ToLower();

        if (userChoice == "a")
            goto Preventive;
        else if (userChoice == "b")
            goto Detective;
        else if (userChoice == "c")
            goto Home;
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            goto NetworkSecurityMeasures;
        }

    Preventive:
        Console.WriteLine("Preventive");
        Console.WriteLine("a. Firewalls");
        Console.WriteLine("b. Intrusion Detection Systems");
        Console.WriteLine("c. Back");
        Console.Write("Enter your choice (a/b/c): ");
        userChoice = Console.ReadLine().ToLower();

        if (userChoice == "a")
            goto Preventive;
        else if (userChoice == "b")
            goto Preventive;
        else if (userChoice == "c")
            goto NetworkSecurityMeasures;
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            goto Preventive;
        }

    Detective:
        Console.WriteLine("Detective");
        Console.WriteLine("a. Security Information and Event Management (SIEM)");
        Console.WriteLine("b. Network Traffic Analysis");
        Console.WriteLine("c. Back");
        Console.Write("Enter your choice (a/b/c): ");
        userChoice = Console.ReadLine().ToLower();

        if (userChoice == "a")
            goto Detective;
        else if (userChoice == "b")
            goto Detective;
        else if (userChoice == "c")
            goto NetworkSecurityMeasures;
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            goto Detective;
        }

    CloudServiceModels:
        Console.WriteLine("Cloud Service Models");
        Console.WriteLine("a. Infrastructure");
        Console.WriteLine("b. Application");
        Console.WriteLine("c. Back");
        Console.Write("Enter your choice (a/b/c): ");
        userChoice = Console.ReadLine().ToLower();

        if (userChoice == "a")
            goto Infrastructure;
        else if (userChoice == "b")
            goto Application;
        else if (userChoice == "c")
            goto Home;
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            goto CloudServiceModels;
        }

    Infrastructure:
        Console.WriteLine("Infrastructure");
        Console.WriteLine("a. Infrastructure as a Service (IaaS)");
        Console.WriteLine("b. Platform as a Service (PaaS)");
        Console.WriteLine("c. Back");
        Console.Write("Enter your choice (a/b/c): ");
        userChoice = Console.ReadLine().ToLower();

        if (userChoice == "a")
            goto Infrastructure;
        else if (userChoice == "b")
            goto Infrastructure;
        else if (userChoice == "c")
            goto CloudServiceModels;
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            goto Infrastructure;
        }

    Application:
        Console.WriteLine("Application");
        Console.WriteLine("a. Software as a Service (SaaS)");
        Console.WriteLine("b. Function as a Service (FaaS)");
        Console.WriteLine("c. Back");
        Console.Write("Enter your choice (a/b/c): ");
        userChoice = Console.ReadLine().ToLower();

        if (userChoice == "a")
            goto Application;
        else if (userChoice == "b")
            goto Application;
        else if (userChoice == "c")
            goto CloudServiceModels;
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
            goto Application;
        }

    End:
        Console.WriteLine("Closing the program...");
    }
}


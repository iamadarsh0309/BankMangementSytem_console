class Program
{
    static void Main()
    {
        System.Console.WriteLine("------------ABC BANK------------------");
        System.Console.WriteLine("Login Page :");

        string username = null;
        string password = null;

        System.Console.WriteLine("Enter Username");
        username = System.Console.ReadLine();

        if (username != "")
        {
            System.Console.WriteLine("Enter Password");
            password = System.Console.ReadLine();
        }

        if(username=="system" && password=="manager")
        {
            System.Console.WriteLine();
        }

        System.Console.WriteLine("Thank you");
        System.Console.ReadKey();
        
    }
}

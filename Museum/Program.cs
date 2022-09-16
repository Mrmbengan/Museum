internal class Program
{
    private static void Main(string[] args)
    {
        bool menue = true;

        string menueChoice;


        while (menue == true)

        {

            Console.BackgroundColor = ConsoleColor.DarkGray;

            Console.ForegroundColor = ConsoleColor.White;

            Console.Clear();

            Console.WriteLine("Welcome to Tobacco and Salt Museum");

            Console.WriteLine("You are now in the Entrance, from here you can go to the following:");

            Console.WriteLine("[1] - Gift Shop");

            Console.WriteLine("[2] - Cafe");

            Console.WriteLine("[3] - Exhibition Hall 1");

            Console.WriteLine("[4] - Exhibition Hall 2");

            Console.WriteLine("[5] - WC");

            Console.WriteLine("[Q] - Exit the Museum");


            do

            {

                menueChoice = Console.ReadLine().ToUpper();

                Console.Clear();

                break;

            }


            while (true);


            switch (menueChoice)

            {

                case "1":

                    Console.WriteLine("This is the gift shop, here you can buy souvenirs: ");

                    Console.WriteLine("Do you want to go to Cafe? Press yes or no");


                    string goToCafe = Console.ReadLine();


                    if (goToCafe == "yes")

                    {

                        Console.WriteLine("This is the Cafe, here you can buy Coffee! ");

                    }


                    else if (goToCafe == "no")

                    {

                        Console.WriteLine("You can only go to the Cafe from the Gift Shop!");

                    }


                    Thread.Sleep(5000);

                    break;


                case "2":

                    Console.WriteLine("This is the Cafe, here you can buy Coffe! ");

                    Console.WriteLine("Would you like to go back to the gift shop or move on to exhibition hall 1?\nPress '1' for gift shop and '2' for exhibition hall 1");


                    string cafeChoice = Console.ReadLine().ToUpper();

                    switch (cafeChoice)

                    {

                        case "1":

                            Console.WriteLine("You are now back in the gift shop");

                            break;


                        case "2":

                            Console.WriteLine("You are now in exhibition hall 1");

                            break;

                    }

                    Thread.Sleep(5000);

                    break;


                case "3":

                    Console.WriteLine("This is the Exhibition Hall 1, here you can observe the Saltwater evaporate! ");
                    Console.WriteLine("Would you like to go back to the Cafe?\nPress '1' for Cafe and '2' for going back to Enterance");


                    string exHallOneChoice = Console.ReadLine().ToUpper();

                    switch (exHallOneChoice)

                    {

                        case "1":

                            Console.WriteLine("You are now back in the Cafe, here you can get a cup of coffe");

                            break;


                        case "2":

                            Console.WriteLine("going back to enterance");
                            
                            break;
                    
                    }

                    Thread.Sleep(5000);

                    break;



                case "4":

                    Console.WriteLine("This is the Exhibition Hall 2, here you can observe Pipes and pictures from Himalaya! ");

                    Thread.Sleep(5000);

                    break;




                case "5":

                    Console.WriteLine("This is the toilet, do what you need! ");

                    Thread.Sleep(5000);

                    break;


                case "Q":

                default:

                    menue = false;

                    break;

            }

        }
    }
}
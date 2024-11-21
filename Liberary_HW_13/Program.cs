using Colors.Net.StringColorExtensions;
using Colors.Net;
using Liberary_HW_13.Services;
using System.Threading.Tasks;
using Liberary_HW_13.Autentication;
using Liberary_HW_13.RoleEnum;

bool isExist = false;
while (true)
{
    Autentication autentication = new Autentication();
    BookService bookService = new BookService();

    Console.Clear();
    ColoredConsole.WriteLine("                                   *********   Welcome ToDo List  *********".DarkYellow());
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    ColoredConsole.WriteLine("1.Register".Green());
    Console.WriteLine("");
    ColoredConsole.WriteLine("2.Login".Green());
    Console.WriteLine("");
    ColoredConsole.WriteLine("3.Exit".Red());

    ColoredConsole.WriteLine("--------------------------------------------------------".Green());



    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            ColoredConsole.Write("Enter Firstname : ".Gray());
            string firstname = Console.ReadLine();
            ColoredConsole.Write("Enter LastName : ".Gray());
            string lastname = Console.ReadLine();
            ColoredConsole.Write("Enter UserName : ".Gray());
            string username = Console.ReadLine();
            ColoredConsole.Write("Enter Password : ".Gray());
            string password = Console.ReadLine();
            Console.WriteLine("Enter your Role :");
            int roleEnum = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (roleEnum == 1)
                {
                    autentication.Register(firstname, lastname, username, password, RoleEnum.User);
                    ColoredConsole.WriteLine("Successful".DarkGreen());

                }
                else if (roleEnum == 2)
                {
                    autentication.Register(firstname, lastname, username, password, RoleEnum.Admin);
                    ColoredConsole.WriteLine("Successful".DarkGreen());
                }
                else
                {
                    ColoredConsole.WriteLine("Your Role Chosseing Most be 1=User or 2=Admin".DarkRed());
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
            }

            Console.ReadKey();
            break;

        case "2":
            ColoredConsole.Write("Enter Username : ".Gray());
            string userName = Console.ReadLine();
            ColoredConsole.Write("Enter Password : ".Gray());
            string pass = Console.ReadLine();

            try
            {
                autentication.Login(userName, pass);
                var currentUser = autentication.GetCurrentUser();
                if (currentUser == null)
                {
                    ColoredConsole.WriteLine("User Not Logged".Red());
                    Console.ReadKey();
                    break;
                }
                else if (currentUser.RoleEnum == RoleEnum.User)
                {
                    bool usermenu = true;
                    while (usermenu)

                    {
                        try
                        {
                            Console.Clear();
                            var currentuser = autentication.GetCurrentUser();


                            Console.WriteLine("Please select the desired option");
                            ColoredConsole.WriteLine("1. Borrowed Book :".Blue());
                            ColoredConsole.WriteLine("2. Return Book :".Blue());
                            ColoredConsole.WriteLine("3. My Liberary".Blue());
                            ColoredConsole.WriteLine("4. Liberary :".Blue());
                            ColoredConsole.WriteLine("5. LogOut".DarkRed());
                            ColoredConsole.WriteLine("--------------------------------------------------------".DarkRed());

                            int option = Convert.ToInt32(Console.ReadLine());
                            switch (option)
                            {
                                

                                case 1:
                                    var item = bookService.AllBooks();
                                    foreach (var book in item)
                                    {
                                        if (book.IsBorrowed == false)
                                        {
                                            ColoredConsole.WriteLine($"Id = {book.Id} - Titel = {book.Titel} - Discription =  {book.Discription} - Writer = {book.Writer} - Pages = {book.Pages}".DarkGreen());
                                            ColoredConsole.WriteLine("------------------------------------------------------------------------------------------------------------".DarkMagenta());
                                        }
                                    }
                                    ColoredConsole.Write("Select Id Book To Boroow :".DarkGray());
                                    var id = Convert.ToInt32(Console.ReadLine());
                                    bookService.BorrowedBook(id, currentUser.Id);
                                    ColoredConsole.WriteLine("Borrowed Successfully".DarkGreen());
                                    Console.ReadKey();

                                    break;
                                case 2:
                                    var item2 = bookService.ShowAllBrrowed(currentUser.Id);
                                    foreach (var book in item2)
                                    {
                                        ColoredConsole.WriteLine($"Id = {book.Id} - Titel = {book.Titel} - Discription =  {book.Discription} - Writer = {book.Writer} - Pages = {book.Pages}".DarkGreen());
                                        ColoredConsole.WriteLine("------------------------------------------------------------------------------------------------------------".DarkMagenta());
                                    }

                                    ColoredConsole.WriteLine("Select id Book to Return :".DarkGray());
                                    int select = Convert.ToInt32(Console.ReadLine());
                                    bookService.ReturnBook(select, currentUser.Id);
                                    ColoredConsole.WriteLine("Returned Book SuccessFully".Green());
                                    Console.ReadKey();

                                    break;
                                case 3:

                                    var item3 = bookService.ShowAllBrrowed(currentUser.Id);
                                    foreach (var book in item3)
                                    {
                                        ColoredConsole.WriteLine($"Id = {book.Id} - Titel = {book.Titel} - Discription =  {book.Discription} - Writer = {book.Writer} - Pages = {book.Pages}".DarkGreen());
                                        ColoredConsole.WriteLine("------------------------------------------------------------------------------------------------------------".DarkMagenta());
                                    }
                                    Console.ReadKey();

                                    break;
                                case 4:
                                    var item1 = bookService.AllBooks();
                                    foreach (var book in item1)
                                    {
                                        if (book.IsBorrowed == false)
                                        {


                                            ColoredConsole.WriteLine($"Id = {book.Id} - Titel = {book.Titel} - Discription =  {book.Discription} - Writer = {book.Writer} - Pages = {book.Pages} - Borrowed = {book.IsBorrowed}".DarkGreen());
                                            ColoredConsole.WriteLine("------------------------------------------------------------------------------------------------------------".DarkMagenta());
                                        }
                                    }
                                    Console.ReadKey();


                                    break;
                                case 5:
                                    currentUser = null;
                                    usermenu = false;
                                    isExist = false;

                                    break;

                            }

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Unexpected Error: {ex.Message}");
                            Console.ReadKey();
                        }




                    }

                }
                else if (currentUser.RoleEnum == RoleEnum.Admin)
                {
                    ColoredConsole.WriteLine("--------------------------------------------------------".DarkRed());
                    Adminmenu();

                }


            }

            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.ReadKey();
            break;

        case "3":
            return;

        default:
            ColoredConsole.WriteLine("Invalid".DarkRed());
            Console.ReadKey();
            break;

    }

    static void Adminmenu()
    {
        bool isExist = true;
        Console.Clear();
        while (isExist)
        {

            Console.WriteLine("1.Show Detail Liberary : ");
            Console.WriteLine("2.Show Detail Users : ");
            Console.WriteLine("");

            ColoredConsole.WriteLine("3.Exit ".Red());
            string showdetail = Console.ReadLine();

            BookService bookService = new BookService();
            UserService userService = new UserService();

            switch (showdetail)
            {


                case "1":
                    var item = bookService.AllBooks();
                    foreach (var book in item)
                    {
                        ColoredConsole.WriteLine($"Id = {book.Id} - Titel = {book.Titel} - Discription =  {book.Discription} - Writer = {book.Writer} - Pages = {book.Pages} - Borrowed = {book.IsBorrowed}".DarkGreen());
                        ColoredConsole.WriteLine("------------------------------------------------------------------------------------------------------------".DarkMagenta());
                    }

                    break;
                case "2":
                    var user = userService.AllUser();
                    foreach (var users in user)
                    {
                        Console.WriteLine($"Id = {users.Id} - FullName = {users.FirstName} {users.LastName} - UserName = {users.UserName} - Role = {users.RoleEnum}");
                        ColoredConsole.WriteLine("------------------------------------------------------------------------------------------------------------".DarkMagenta());
                    }

                    break;

                case "3":
                    isExist = false;
                    return;
            }
        }

    }
}
using ClassLibrary1.DataBase;
using ClassLibrary1.Models;

namespace ConsoleApp5
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            AppDbContext database = new AppDbContext();
            bool f=false;
            do
            {
                Console.WriteLine("1.Enter to system  2.Exit");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        bool f1=false;
                        do
                        {

                            Console.WriteLine("1. Create a hotel");
                            Console.WriteLine("2. Show all hotels");
                            Console.WriteLine("3. Choose the hotel by name");
                            Console.WriteLine("4. Exit");
                            Console.WriteLine();

                            choice = int.Parse(Console.ReadLine());
                            switch (choice)
                            {
                                case 1:
                                    Console.Write("Enter hotel name: ");
                                    string name=Console.ReadLine();

                                    Hotel hotel = new Hotel(name);
                                    Console.WriteLine("Hotel is created");

                                    database.AddHotel(hotel);
                                    break;

                                case 2:
                                    database.GetAllHotels();
                                        break;

                                case 3:
                                    Console.Write("Enter hotel name that you want to get: ");
                                    string hotelname=Console.ReadLine();

                                    bool f2=false;
                                    do
                                    {
                                        Console.WriteLine("1. Create a room");
                                        Console.WriteLine("2. Show all rooms");
                                        Console.WriteLine("3. make reservetion");
                                        Console.WriteLine("4. go to comeback");
                                        Console.WriteLine("0. Exit");
                                        Console.WriteLine();

                                        choice=int.Parse(Console.ReadLine());

                                        switch (choice)
                                        {
                                            case 1:
                                                Console.Write("Enter room name: ");
                                                string roomname=Console.ReadLine();

                                                Console.Write("Enter room price: ");
                                                double roomprice=double.Parse(Console.ReadLine());

                                                Console.WriteLine("Enter room capacity");
                                                int roomcapacity=int.Parse(Console.ReadLine());

                                                Room room=new Room(roomname, roomprice, roomcapacity);

                                                Console.WriteLine("Room is created.");

                                                database.AddRoom(room);
                                                break;

                                            case 2:
                                                database.GetAllRooms();
                                                break;

                                            case 3:
                                                Console.Write("Enter ID of room: ");
                                                int roomId=int.Parse(Console.ReadLine());

                                                Console.Write("Enter customers number: ");
                                                int amountofcustoms=int.Parse(Console.ReadLine());

                                                database.MakeReservation(roomId, amountofcustoms);
                                                break;

                                            case 4:
                                                f2=true;
                                                break;

                                            case 0:
                                                f2 = true;
                                                f1 = true;
                                                f=true;

                                                break;
                                        } 

                                    } while (!f2);
                                    break;

                                case 4:
                                    break;


                            }

                        } while (!f1);
                        break;

                    case 2:
                        f=true;
                        break;
                }
            } while (!f);
            
        }
    }
}

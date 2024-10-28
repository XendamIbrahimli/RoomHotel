using ClassLibrary1.Helper.Exceptions;
using ClassLibrary1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.DataBase
{
    public class AppDbContext
    {
        static List<Room> rooms = new List<Room>();
        static List<Hotel> hotels = new List<Hotel>();

        public void AddRoom(Room room)
        {
            rooms.Add(room);
        }

        public void GetAllRooms()
        {
            foreach (Room room in rooms)
            {
                Console.WriteLine(room.ToString());
            }

        }

        public List<Room> FindAllRoom(string name) 
        {
            List<Room> newRooms= new List<Room>();
            foreach (Room room in rooms)
            {
                if(room.Name == name)
                {
                    newRooms.Add(room);
                }
            }
            return newRooms;
        }

        //- MakeReservation() - Parametr olaraq nullable int tipindən bir roomId ve musteri sayi qəbul edir
        //əgər roomId null olaraq geriyə NullReferanceException qaytarır əks halda göndərilən
        //roomId-li otaq tapılır IsAvailable dəyəri ve Personal Capacity yoxlanılır
        //əgər IsAvailable dəyəri false-dusa geriyə yuxarıda yaratdığınız NotAvailableException qaytarılır
        //əgər true-dursa Personal Capacityde uygun gelirse həmin room-un IsAvailable dəyəri true olur.
        public void MakeReservation(int? id, int customer)
        {
            if(id == null)
            {
                throw new NullReferenceException("Id cannot be null");
            }
            else
            {
                Room foundedRoom = rooms.Find(x=>x.Id == id);
                if(foundedRoom  == null)
                {

                    throw new NullReferenceException("Room not found.");
                    
                }
                else
                {
                     if (!foundedRoom.IsAvialable)
                     {
                        throw new NotAvailableException("Room isnot available");
                     }
                     if(foundedRoom.PersonCapacity < customer) 
                     {
                        Console.WriteLine("Customers is many from person capacity.");
                     }
                }
                foundedRoom.IsAvialable = false;
                Console.WriteLine($"Reservation make for room: {foundedRoom.Id}, for {customer} customers.");
                
            }

        }

        public void AddHotel(Hotel hotel)
        {
            hotels.Add(hotel);
        }

        public void GetAllHotels()
        {
            foreach(Hotel hotel in hotels)
            {
                Console.WriteLine(hotel.ToString());
            }
        }
    }
}

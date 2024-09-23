using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    public class Program
    {
        public static List<Cars> carList = new List<Cars>();
        static Connection conn = new Connection();
        public static void feladat1() 
        {
            conn.connection.Open();

            string sqltemp = "SELECT * FROM `cars`";
            MySqlCommand cmd = new MySqlCommand(sqltemp,conn.connection);

            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();

            do {
                Cars car = new Cars();
                car.Id = dr.GetInt32(0);
                car.Brand = dr.GetString(1);
                car.Type = dr.GetString(2);
                car.License = dr.GetString(3);
                car.Date = dr.GetInt16(4);

                carList.Add(car);
            }while (dr.Read());

            dr.Close();

            conn.connection.Close();
        }
        static void Main(string[] args)
        {
            feladat1();
            for (int i = 0; i < carList.Count; i++)
            {
                Console.WriteLine(carList[i].Id + "," + carList[i].Brand + "," + carList[i].Type + "," + carList[i].Date);
            }
            Console.ReadKey();
        }
    }
}
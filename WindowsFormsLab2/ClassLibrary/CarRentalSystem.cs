using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class CarRentalSystem
    {
        static public List<Order> orders = new List<Order>(); // 12,
        static public List<CarForOrder> cars = new List<CarForOrder>(); // 12
        public Administrator admin = new Administrator();

        static public void LoadCars()// 11
        {
            cars.Clear();

            using (StreamReader stream = new StreamReader("Cars.txt"))
            {
                string[] str = new string[9];
                CarForOrder tmp_car = new CarForOrder();

                while (!stream.EndOfStream)
                {
                    str = stream.ReadLine().Split(' ');
                    tmp_car = new CarForOrder(Convert.ToInt32(str[0]), str[1], Convert.ToInt32(str[2]), str[3], 
                        str[4], Convert.ToInt32(str[5]), str[6], Convert.ToBoolean(str[7]), Convert.ToBoolean(str[8]));

                    cars.Add(tmp_car);

                } 
            }
        }
        static public void LoadOrders()// 11
        {
            orders.Clear();
            using (StreamReader stream = new StreamReader("Orders.txt"))
            {
                string[] str = new string[8];
                Order order = new Order();

                while (!stream.EndOfStream)
                {
                    str = stream.ReadLine().Split(' ');
                    order = new Order(str[1], str[2], str[3], str[4], str[5], Convert.ToInt32(str[0]), Convert.ToInt32(str[6]), Convert.ToInt32(str[7]));
                    orders.Add(order);

                }
            }
        }

    }

}

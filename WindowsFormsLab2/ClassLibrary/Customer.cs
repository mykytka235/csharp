using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Customer
    {
        string passport_id;
        int driving_experience;
        bool driver_license;
        bool criminal_record;
        int age;
        public string Passport_id
        {
            private get => passport_id;
            set => passport_id = value;
        }
        public int Driving_experience
        {
            private get => driving_experience;
            set => driving_experience = value;
        }
        public bool Driver_license
        {
            private get => driver_license;
            set => driver_license = value;
        }
        public bool Criminal_record 
        {
            private get => criminal_record;
            set => criminal_record = value;
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 18)
                    age = 18;
                else if (value > 75)
                    age = 75;
                else
                    age = value;
            }
        }

        public string name;
        public string surname;
        public string phone;

        public Customer() 
        {
            
        }
        public Customer(string name, string surname, int age, string passport_id, int driving_experience, 
                        bool driver_license, bool criminal_record, string phone)
        {
            this.name = name;
            this.surname = surname;
            Age = age; 
            Passport_id = passport_id;
            this.driving_experience = driving_experience;
            this.driver_license = driver_license;
            this.criminal_record = criminal_record;
            this.phone = phone;
        }
        public void MakeOrder(ref Order order, int car_ID, int order_time_in_months)
        {
            double total_price = order_time_in_months * CarRentalSystem.cars[car_ID-1].price_per_month;
            order = new Order(name, surname, phone, CarRentalSystem.cars[car_ID - 1].car_firm, CarRentalSystem.cars[car_ID - 1].car_condition, CarRentalSystem.orders.Count+1, order_time_in_months, total_price);

            CarRentalSystem.orders.Add(order);

            using (StreamWriter stream = new StreamWriter("Orders.txt", true))
            {
                stream.WriteLine($"{order.order_index} {order.Customer_name} {order.Customer_surname} " +
                    $"{order.Customer_phone} {order.type_of_chosen_car} {order.car_condition} " +
                    $"{order.time_in_month} {order.total_price}");
            }
        }
    }
}

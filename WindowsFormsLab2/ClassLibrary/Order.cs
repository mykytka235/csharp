using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Order
    {
        string customer_name;
        string customer_surname;
        string customer_phone;
        public string Customer_name
        {
            get => customer_name;
            set => customer_name = value;
        }
        public string Customer_surname
        {
            get => customer_surname;
            set => customer_surname = value;
        }
        
        public string Customer_phone
        {
            get => customer_phone;
            set => customer_phone = value;
        }
        
        public string type_of_chosen_car;
        public string car_condition;
        public int order_index;
        public int time_in_month;
        public double total_price;
        public bool is_agree;

        public Order() { }
        public Order(string customer_name, string customer_surname, string customer_phone, string type_of_chosen_car, string car_condition,
           int order_index, int time_in_month, double total_price) 
        {
            Customer_name = customer_name;
            Customer_surname = customer_surname;
            Customer_phone = customer_phone;
            this.type_of_chosen_car = type_of_chosen_car;
            this.car_condition = car_condition;
            this.order_index = order_index;
            this.time_in_month = time_in_month;
            this.total_price = total_price;

            this.is_agree = false;
        }
    }
}

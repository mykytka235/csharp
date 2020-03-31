using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
	public class CarForOrder : Car
	{
		bool car_is_ordered;
		public bool Car_is_ordered
		{
			get => car_is_ordered;
			set => car_is_ordered = value;
		}
		public new string Corpus_color // 5
		{
			get => corpus_color;
			set => corpus_color = value;
		}

		public int car_ID;
		public int price_per_month;

		public CarForOrder() { } // 2 
		public CarForOrder(int car_ID, string car_firm, int price_per_month,
						string car_condition, string car_registration, int count_of_wheels,
						string corpus_color, bool engine_is_work, bool car_is_ordered) : 
			base(engine_is_work, count_of_wheels, corpus_color, car_registration, car_firm, car_condition)// 2, 6
		{
			this.car_ID = car_ID;
			this.price_per_month = price_per_month;
			Car_is_ordered = car_is_ordered;
		}
		public override sealed string virtualInfo() // 7, 8, 9
		{
			if (Car_is_ordered == true)
				return "This car is ordered";
			else 
				return "This car is available";
		}
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{

	public class Car : Vehicle
	{
		string car_registration;
		public string Car_registration // 3
		{
			protected get => car_registration;
			set => car_registration = value;
		}
		public new string Corpus_color // 5
		{
			get => "Corpus color: " + corpus_color ;
			set => corpus_color = value;
		}


		public string car_firm;
		public string car_condition;



		public Car() {}// 2

		public Car(bool engine_is_work, int count_of_wheels, string corpus_color, string car_registration, string car_firm, string car_condition)
			:base(engine_is_work, count_of_wheels, corpus_color) // 2, 6
		{
			Car_registration = car_registration;
			this.car_firm = car_firm;
			this.car_condition = car_condition;
		}
	
		public new bool Info() // 5
		{
			if (car_condition != "Bad")
				return true;
			return false;
		}
		public override string virtualInfo()// 8, 9
		{
			return car_firm + " " + car_condition + " " + Car_registration;
		}
	}
}

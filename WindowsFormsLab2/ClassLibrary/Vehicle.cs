using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
	public class Vehicle
	{

		protected bool engine_is_work;
		protected int count_of_wheels;
		protected string corpus_color;
		public bool Engine_is_work // 3
		{
			get => engine_is_work;
			set => engine_is_work = value;
		}
		public int Count_of_wheels // 3
		{
			get => count_of_wheels;
			set => count_of_wheels = value;
		}
		public string Corpus_color // 3
		{
			get => corpus_color;
			set => corpus_color = value;
		}


		public Vehicle() { }
		public Vehicle(bool engine_is_work, int count_of_wheels, string corpus_color)
		{
			Engine_is_work = engine_is_work;
			Count_of_wheels = count_of_wheels;
			Corpus_color = corpus_color;
		}
		public bool Info()
		{
			return Engine_is_work;
		}
		public virtual string virtualInfo() // 9
		{
			return " ";
		}
		//void setEngine(bool is_work);
		//void setWheels(int count);
		//void setColor(string color);

		//bool engineWork();
		//int getWheels();
		//string getColor();
	}
}

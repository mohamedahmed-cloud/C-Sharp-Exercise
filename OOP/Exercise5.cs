using System;
using System.Collections.Generic;

namespace Lab7
{
	class Student 
	{
		public int id { get; set; }
		public string name { get; set; }
		public int age { get; set; }
		public Student(int id = 0, string name = "", int age = 0)
		{
			this.id = id;
			this.name = name;
			this.age = age;
		}
		 public override string ToString()
		{
			return $"Student id ==> {id} and his ==> {name} his age ==> {age}";
		}
	}
	class Subject
	{
		public int id { get; set; }
		public string name { get; set; }
		public int duration { get; set; }
		public Subject(int id = 0, string name = "", int duration = 0)
		{
			this.id = id;
			this.name = name;
			this.duration = duration;
		}
		public override string ToString()
		{
			return $"Subject id ==> {id} and it's Name ==> {name} and it's Duration ==> {duration}";
		}
	}

	class Lab7
	{
		static void Main(string[] args)
		{
			Dictionary <Student,List<Subject>> Academic_Repeater = new Dictionary<Student,List<Subject>>();
			System.Console.Write("Enter Number of Student You Want to Enter: ");
			int x = int.Parse(Console.ReadLine());
			for (int i = 0; i < x; i++)
			{
				System.Console.Write($"Enter Id of Student {i + 1}: ");
				int iid = int.Parse(Console.ReadLine());

				System.Console.Write($"Enter Name of Student {i + 1}: ");
				string iname = (Console.ReadLine());

				System.Console.Write($"Enter age of Student {i + 1}: ");
				int iage = int.Parse(Console.ReadLine());
				List<Subject> listOfObject = new List<Subject>();
				System.Console.Write("Enter Number of Subject: ");
				int sn = int.Parse(Console.ReadLine());
				for (int si = 0; si < sn; si++)
				{
					System.Console.Write($"Enter Id of Subject {si + 1}: ");
					int sid = int.Parse(Console.ReadLine());

					System.Console.Write($"Enter Name of  Subject  {si + 1}: ");
					string sname = Console.ReadLine();

					System.Console.Write($"Enter duration Of Subject {si + 1}: ");
					int sduration = int.Parse(Console.ReadLine());
					listOfObject.Add(new Subject(sid, sname, sduration));
				}
				Academic_Repeater.Add(
					new Student(){id = iid, name = iname, age = iage},
					listOfObject

				);
				
			}



			foreach (var item in Academic_Repeater)
			{
				System.Console.WriteLine(item.Key.ToString());
				foreach (var i in item.Value)
				{
					System.Console.WriteLine($"   {i.ToString()}");	
				}
				System.Console.WriteLine();
				
			}
		}
	}
}
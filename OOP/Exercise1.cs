using System;

namespace OOP
{
	public class Person 
	{
		public int age{get; set;}

		public void Greet()
		{
			System.Console.WriteLine("Hello Man/Women.");
		}
	}

	public class Student : Person
	{
		public Student()
		{
			
		}
		public void GoToClasses()
		{
			System.Console.WriteLine("I’m going to class.");
		}
		public void ShowAge()
		{
			System.Console.WriteLine($"Your Age is {age}");
		}

	}


	public class Teacher : Person
	{
		private string subject;

		public Teacher()
		{
			
		}
		public void Explain()
		{
			System.Console.WriteLine("Explanation begins");
		}
		public void ShowAge()
		{
			System.Console.WriteLine($"your age is {age}");
		}
	}


	class OOP
	{
		public static void sMain(string[] args)
		{
			System.Console.WriteLine("hello");
			Student s = new Student();
			s.age = 30;
			System.Console.WriteLine(s.age);
			s.Greet();
			System.Console.WriteLine("###############################");
			Teacher t = new Teacher();
			t.age = 56;
			System.Console.WriteLine(t.age);
			t.Greet();
		}
	}
}
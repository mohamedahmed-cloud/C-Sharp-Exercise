using System;
namespace Name
{
	
	class Student
	{
		#region property
		public int id { get; set; }
		public string name { get; set; }
		public int age { get; set; }
		#endregion

		#region constructor
		public Student(int id = 0, string name = "", int age = 0)
		{
			this.id = id;
			this.name = name;
			this.age = age;
		}
		#endregion
		#region operator

		public static bool  operator ==(Student s1, Student s2)
		{
			return s1.age == s2.age;
		}

		public static bool  operator !=(Student s1, Student s2)
		{
			return s1.age != s2.age;
		}
		public static bool operator >(Student s1, Student s2)
		{
			return s1.age > s2.age;
		}
		public static bool operator <(Student s1, Student s2)
		{
			return s1.age < s2.age;
		}
		#endregion
		#region casting
		public static implicit operator int(Student s1)
		{
			return s1.age;
		}
		public static implicit operator string(Student s1)
		{
			return s1.name;
		}

		#endregion

	}
	class Complex
	{
		public int real { get; set; }
		public int img { get; set; }

		public Complex(int real = 0, int img = 0)
		{
			this.real = real;
			this.img = img;
		}
		#region operator
		public static Complex   operator +(Complex c1, Complex c2)
		{
			Complex x = new Complex();
			x.real = c1.real + c2.real;
			x.img = c1.img + c2.img;
			return x;
		}

		public static Complex  operator -(Complex c1, Complex c2)
		{
			Complex x = new Complex();
			x.real = c1.real - c2.real;
			x.img = c1.img - c2.img;
			return x;
		}
		public static bool  operator ==(Complex c1, Complex c2)
		{
			
			return  ((c1.real == c2.real) && (c1.img == c2.img) ) ;
			
		}
		public static bool  operator !=(Complex c1, Complex c2)
		{
			
			return  ((c1.real != c2.real) && (c1.img != c2.img) ) ;
			
		}
		public static bool  operator >(Complex c1, Complex c2)
		{
			return  ((c1.real > c2.real) && (c1.img > c2.img) ) ;
		}
		public static bool  operator <(Complex c1, Complex c2)
		{
			return  ((c1.real < c2.real) && (c1.img < c2.img) ) ;
		}
		#endregion
	}
    class PS {
        static void Main(string[] args) {
			Student s1 = new Student(name: "Yousef", age: 23, id: 1);
			Student s2 = new Student();
			#region  operator
			System.Console.WriteLine("Start Operator Operation For Class Student");
			if (s1 == s2)
			{
				System.Console.WriteLine("  Age of student 1 and two are Equal");
			}else if (s1 > s2)
			{
				System.Console.WriteLine($"  First Student Age is {s1.age}, Second Student Age is {s2.age}");
				System.Console.WriteLine("  Age of student 1 is Greater Than Age of Student 2");

			}else if (s1 < s2)
			{
				System.Console.WriteLine($"  First Student Age is {s1.age}, Second Student Age is {s2.age}");
				System.Console.WriteLine("  Age of student 1 is Less Than Age of Student 2");
			}
			System.Console.WriteLine();
			#endregion
			
			#region casting
			System.Console.WriteLine("\nStart Casting Operation of Class Student");
			string str = s1;
			int currAge = s1;
			System.Console.WriteLine($"  name From Implicit Casing is {str}");
			System.Console.WriteLine($"  Age From Implicit Casing is {currAge}");
			System.Console.WriteLine();
			#endregion	

			#region classComplex
			Complex c1 = new Complex(4,1);
			Complex c2 = new Complex(2,2);
			Complex c3 = c1 + c2;
			System.Console.WriteLine($"{c3.real} {c3.img} {c1 == c2}");
			if (c1 == c2)
				System.Console.WriteLine("Complex C1 == C2");
			else if (c1 > c2)
				System.Console.WriteLine("Complex C1 > C2");
			else if (c1 < c2)
				System.Console.WriteLine("Complex C1 < C2");
			else if (c1 != c2)
				System.Console.WriteLine("Complext C1 != C2");
			else
				System.Console.WriteLine("There is no operation");
			

			
			
			#endregion


        }
    }
}
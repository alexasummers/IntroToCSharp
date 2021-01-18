using System;

					
public class Program
{
	public static void Main()
	{
		
		//Declaring, setting and displaying variable
		string className = "Game Programming I";
		Console.WriteLine(className);
		
		//Declaring variable
		string programName;
		
		//Setting and displaying variable based on user input
		Console.WriteLine("Enter program: ");
		programName = Console.ReadLine();
		Console.WriteLine("The program is: " + programName);
		
		//Declaring variable
		string date;
		
		//Setting and displaying current date
		date = DateTime.Now.ToString(); //getting date information as integers and converting to string
		Console.WriteLine(date);
		
		int tempInFahrenheit = 54;
		double tempInCelsius = (tempInFahrenheit - 32) / 1.8;

		
		Console.WriteLine("Fahrenheit: " + tempInFahrenheit);
		Console.WriteLine("Celsius: " + tempInCelsius);
	}
}
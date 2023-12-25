using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine(FindFactorial(6));
	}
	
	public static int FindFactorial(int num){
		if(num == 0){
			return 1;
		}
		return num * FindFactorial(num-1);
	}
}
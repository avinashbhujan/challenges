using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine(IsStringPalindrome("nitiN"));
	}
	
	public static bool IsStringPalindrome(string str){
		if(str == ""){
			return true;
		}
		//convert to char array
		char[] charArray = str.ToLower().Trim().ToCharArray();
		//loop through the char array starting from last element
		string reversedString = "";
		for(int i=charArray.Length-1; i >= 0; i--){
			//for each element, concatenate it to a string
			reversedString = reversedString + charArray[i];
		}
		//compare if new string is equal to str; is a palindrome; otherwisw not a palindrome
		if(str == reversedString){
			return true;
		}
		else{
			return false;
		}		
	}
}
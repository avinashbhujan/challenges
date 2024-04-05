using System;

public class LengthOfLastWord
{
	public static int GetLengthOfLastWord(string s)
	{
		s = s.Trim();

		return s.Length - 1 - s.LastIndexOf(" ");
	}
}

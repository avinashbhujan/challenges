using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class RomanToIntConverter
{
    public static int RomanToInt(string s)
    {
        //convert string to char Array
        List<int> list = new List<int>();
        for (int i = 0; i < s.Length; i++)
        { //MCMXCIV Explanation: M = 1000, CM = 900, XC = 90 and IV = 4. III
            if (s[i] == 'I')
            {
                if (i == s.Length - 1)
                {
                    list.Add(1);
                }
                else {
                    if (s[i + 1] == 'V')
                    {
                        list.Add(4);
                        i++;
                        continue;
                    }
                    else if (s[i + 1] == 'X')
                    {
                        list.Add(9);
                        i++;
                        continue;
                    }
                    else
                    {
                        list.Add(1);
                    }
                }
            }
            if (s[i] == 'X')
            {
                if (i == s.Length - 1)
                {
                    list.Add(1);
                }
                else
                {
                    if (s[i + 1] == 'L')
                    {
                        list.Add(40);
                        i++;
                        continue;
                    }
                    else if (s[i + 1] == 'C')
                    {
                        list.Add(90);
                        i++;
                        continue;
                    }
                    else
                    {
                        list.Add(1);
                    }
                }
            }
            if (s[i] == 'C')
            {
                if (i == s.Length - 1)
                {
                    list.Add(1);
                }
                else
                {
                    if (s[i + 1] == 'D')
                    {
                        list.Add(400);
                        i++;
                        continue;
                    }
                    else if (s[i + 1] == 'M')
                    {
                        list.Add(900);
                        i++;
                        continue;
                    }
                    else
                    {
                        list.Add(1);
                    }
                }
            }

            if (s[i] == 'V')
            {
                list.Add(5);
            }
            else if (s[i] == 'L')
            {
                list.Add(50);
            }
            else if (s[i] == 'D')
            {
                list.Add(500);
            }
            else if (s[i] == 'M')
            {
                list.Add(1000);
            }

        }
        int total = list.Sum(x => x);
        return total;
    }
}
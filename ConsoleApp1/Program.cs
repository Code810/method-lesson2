#region task1


using System.Globalization;
using System.Reflection;

int sum(int n, int m)
{
	int result = default;
	for (int i = n; i <= m; i++)
	{
		if (i % 2 == 1)
		{
			result += i;
		}
	}
	return result;
}
#endregion

#region task2
int sumarr(params int[] array)
{
	int result= default;
	foreach (int item in array)
	{
		if (item%2 == 1)
		{
			result += item;
		}
	}
	return result;
}

#endregion

#region task3
int countarr(params int[] array)
{
	int count= default;	
	foreach (var item in array)
	{
		if ((item%2) == 0) 
		{
			count++;
		}
	}
	return count;
}
#endregion

#region task4
string simple(int n)
{
	if (n > 1)
	{
		for (int i = 2; i < n; i++)
		{
			if (n % i == 0)
			{
				return "Murekkeb ededdir";
			}
			
		}
        return "Sade ededdir";
    }
	
	return "1-den boyuk eded daxil edin";
}
#endregion

#region task5
string square(int n)
{ 
	int i = 2;
	int count = 1;
	if (n <= 1||n%2!=0) 
	{
		return "2-nin quvveti deyil";
	}
	else if (n>1) 
	{
		for (int j= 2; j <= n; j=j*2)
		{
			if (j==n)
			{
				return $"daxil edilen eded 2^{count} quvvetindedir"; 
			}
			count++;
		}
		
	}
    return "2-nin quvveti deyil";
}
#endregion

#region task6
int powerarr(params int[] array)
{
	int result = 1;
	foreach (int item in array)
	{
		if (item>=1&&item<=20) 
		{
			result = result * item;
		}
	}
	if (result == 1)
	{
		return 0;
	}
	return result;
}
#endregion

#region task7
string squarearr(params int[] array)
{
    int sum = 0;
    foreach (int item in array)
	{
		if (item%2==0)
		{
			sum += item;
		}
	}
	if (sum == 0)
	{
		return "massivde cut eded yoxdur";
	}
	return $"{sum * sum}";
}
#endregion

#region task8
void arraychange( int[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i]<0)
		{
			array[i] = array[i] * (-1);

        }
		
	}
}
#endregion
Console.WriteLine(sum(3, 7));
Console.WriteLine(sumarr(1, 3, 12, 4, 5, 7, 8, 2));
Console.WriteLine(countarr(2, 3, 6, 7, 9, 12, 14));
Console.WriteLine(simple(2));
Console.WriteLine(square(16));
Console.WriteLine(powerarr(1, 3, 22, 25, 26, 29, 4, 5));
Console.WriteLine(squarearr(1, 5, 3, 7, 2, 6));

 int[] array = { -1, 3, -6, 7, -15, 11 };
arraychange(array);
for (int i = 0; i < array.Length; i++)
{
	Console.Write($"{array[i]} ");
}

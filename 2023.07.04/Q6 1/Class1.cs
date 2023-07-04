using System;

public class ArrayClass
{
	public int[] arrayMethod(int size)
	{
		int[] array = new int[size];
		for(int i=0;i<array.length;i+=2)
		{
			console.WriteLine("Enter a value:");
			int value = Convert.ToInt32(console.ReadLine());

			array[i] = value;
			array[ ] =(int)value ;
		}
	}
}

using System;
namespace DataStructuresBinarySearch
{
	public class BinarySearch
	{
		private int[] arrayvalue;
		private int valuetofind;

		public BinarySearch(int[] arrayvalue, int valuetofind)
		{
			this.arrayvalue = arrayvalue;
			this.valuetofind = valuetofind;
        }
		

		public static int Binarysearch(int[] arrayvalue, int valuetofind)
		{
            Array.Sort(arrayvalue);

            int start = 0;
			int end = arrayvalue.Length - 1;

			while(start <= end)
			{
				int mid = (start + end) / 2;

				if (arrayvalue[mid] == valuetofind)
				{
					return(mid);
				}
				else if (arrayvalue[mid] > valuetofind)
				{
					start = mid - 1;
				}
				else if (arrayvalue[mid] < valuetofind)
				{
                    start = mid + 1;
                }
				else
				{
					end = mid - 1;
				}
			}
			Console.WriteLine("DIDNT FIND ANYTHING");
			return -1;

		}
	}
}


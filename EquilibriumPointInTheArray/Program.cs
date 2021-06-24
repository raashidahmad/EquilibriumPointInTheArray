using System;

namespace EquilibriumPointInTheArray
{
    class Program
    {
		public static int FindEquilibrium(int[] arr)
		{
			int n = arr.Length;
			int sum = 0; // initialize sum of whole array 
			int leftsum = 0; // initialize leftsum 

			/* Find sum of the whole array */
			for (int i = 0; i < n; ++i)
				sum += arr[i];

			for (int i = 0; i < n; ++i)
			{
				sum -= arr[i]; // sum is now right sum for index i 

				if (leftsum == sum)
					return i;

				leftsum += arr[i];
			}

			/* If no equilibrium index found, then return 0 */
			return -1;
		}

		public static int FindEquilibriumTwo(int[] arr)
        {
			int arraySum = 0;
			int leftSum = 0;

			for(int i = 0; i < arr.Length; i++)
            {
				arraySum += arr[i];
            }

			for(int i = 0; i < arr.Length; i++)
            {
				arraySum -= arr[i];
				if (leftSum == arraySum)
                {
					return i;
                }
				leftSum += arr[i];
            }
			return -1;
        }

		static void Main(string[] args)
        {
			int[] arr = new int[] {1, 2, 6, 4, 0, -1 };
            Console.WriteLine("Index is: " + FindEquilibriumTwo(arr));
        }
    }
}

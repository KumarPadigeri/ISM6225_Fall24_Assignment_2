using System;
using System.Collections.Generic;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1: Find Missing Numbers in Array
            Console.WriteLine("Question 1:");
            int[] nums1 = { 4, 3, 2, 7, 8, 2, 3, 1 };
            IList<int> missingNumbers = FindMissingNumbers(nums1);
            Console.WriteLine(string.Join(",", missingNumbers));

            // Question 2: Sort Array by Parity
            Console.WriteLine("Question 2:");
            int[] nums2 = { 3, 1, 2, 4 };
            int[] sortedArray = SortArrayByParity(nums2);
            Console.WriteLine(string.Join(",", sortedArray));

            // Question 3: Two Sum
            Console.WriteLine("Question 3:");
            int[] nums3 = { 2, 7, 11, 15 };
            int target = 9;
            int[] indices = TwoSum(nums3, target);
            Console.WriteLine(string.Join(",", indices));

            // Question 4: Find Maximum Product of Three Numbers
            Console.WriteLine("Question 4:");
            int[] nums4 = { 1, 2, 3, 4 };
            int maxProduct = MaximumProduct(nums4);
            Console.WriteLine(maxProduct);

            // Question 5: Decimal to Binary Conversion
            Console.WriteLine("Question 5:");
            int decimalNumber = 42;
            string binary = DecimalToBinary(decimalNumber);
            Console.WriteLine(binary);

            // Question 6: Find Minimum in Rotated Sorted Array
            Console.WriteLine("Question 6:");
            int[] nums5 = { 3, 4, 5, 1, 2 };
            int minElement = FindMin(nums5);
            Console.WriteLine(minElement);

            // Question 7: Palindrome Number
            Console.WriteLine("Question 7:");
            int palindromeNumber = 121;
            bool isPalindrome = IsPalindrome(palindromeNumber);
            Console.WriteLine(isPalindrome);

            // Question 8: Fibonacci Number
            Console.WriteLine("Question 8:");
            int n = 4;
            int fibonacciNumber = Fibonacci(n);
            Console.WriteLine(fibonacciNumber);
        }

        // Question 1: Find Missing Numbers in Array
        public static IList<int> FindMissingNumbers(int[] nums)
        {
            try
            {
                List<int> missingNums = new List<int>();
                for (int i = 1; i <= nums.Length; i++)
                {
                    // capturing only missing nums
                    if (!nums.Contains(i))
                        missingNums.Add(i);
                }
                // Write your code here
                return new List<int>(missingNums); // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 2: Sort Array by Parity
        public static int[] SortArrayByParity(int[] nums)
        {
            try
            {
                List<int> evens = new List<int>();
                List<int> odds = new List<int>();

                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] % 2 == 0)
                        evens.Add(nums[i]);
                    else
                        odds.Add(nums[i]);
                }
                //merging both evens and odds
                evens.AddRange(odds);
                // Write your code here
                return [.. evens]; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 3: Two Sum
        public static int[] TwoSum(int[] nums, int target)
        {
            try
            {
                List<int> targets = new List<int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = 1; j < nums.Length - 1; j++)
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            targets.Add(i);
                            targets.Add(j);
                        }
                    }
                }
                // Write your code here
                return [.. targets]; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 4: Find Maximum Product of Three Numbers
        public static int MaximumProduct(int[] nums)
        {
            try
            {
                int maxProduct = 1;
                for (int i = 0; i < nums.Length; i++)
                    maxProduct *= nums[i];
                // Write your code here
                return maxProduct; // Placeholder
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 5: Decimal to Binary Conversion
        public static string DecimalToBinary(int decimalNumber)
        {
            try
            {
                // Handling the case where number is zero
                if (decimalNumber == 0) return "0";
                string binary = "";
                // Keep dividing the number by 2 and takes the remainder
                while (decimalNumber > 0)
                {
                    int remainder = decimalNumber % 2;
                    binary = remainder + binary;
                    decimalNumber /= 2;
                }
                return binary;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 6: Find Minimum in Rotated Sorted Array
        public static int FindMin(int[] nums)
        {
            try
            { // Set initial left and right pointers
                int left = 0;
                int right = nums.Length - 1;

                // If the array has not been rotated, the smallest element is at the beginning
                if (nums[left] < nums[right])
                    return nums[left];
                // Perform binary search
                while (left < right)
                {
                    int mid = left + (right - left) / 2;

                    // If mid element is greater than right, the smallest element is to the right
                    if (nums[mid] > nums[right])
                        left = mid + 1;
                    else
                        // The smallest element could be mid or to the left of mid
                        right = mid;
                }

                // After the loop, left should point to the minimum element
                return nums[left];
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 7: Palindrome Number
        public static bool IsPalindrome(int x)
        {
            try
            {
                // Convert num to a string
                string str = x.ToString();

                // Reverse the string
                char[] charArray = str.ToCharArray();
                Array.Reverse(charArray);
                string reversedStr = new(charArray);

                // Check if original and reversed stringa are the same
                return str == reversedStr;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 8: Fibonacci Number
        public static int Fibonacci(int n)
        {
            try
            {
                // checking base cases if n is 0 or 1
                if (n == 0) return 0;
                if (n == 1) return 1;
                // Recursive case calling same method
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}


// Self-reflection:
// While solving these problems, I improved my understanding of handling edge cases, such as empty arrays 
// or negative inputs, and I learned to structure my code more modularly by organizing the logic into separate methods.
// I found ways to reduce redundant calculations. In the future, I would explore using more advanced data structures to improve performance further. 
// Overall, I gained valuable insights into writing more maintainable and robust code.

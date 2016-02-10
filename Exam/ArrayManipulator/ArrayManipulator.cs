namespace ArrayManipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ArrayManipulator
    {
        public static void Main()
        {
            int[] array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandArgs = command.Split(' ');
                string commandName = commandArgs[0];

                switch (commandName)
                {
                    case "exchange":
                        int splitIndex = int.Parse(commandArgs[1]);
                        if (splitIndex < 0 || splitIndex > array.Length - 1)
                        {
                            Console.WriteLine("Invalid index");
                        }

                        array = ShuffleArray(array, splitIndex);

                        break;
                    case "max":
                        if (commandArgs[1] == "odd")
                        {
                            int maxOddIndex = GetMaxOddIndex(array);
                            if (maxOddIndex == -1)
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                Console.WriteLine(maxOddIndex);
                            }
                        }
                        else if (commandArgs[1] == "even")
                        {
                            int maxEvenIndex = GetMaxEvenIndex(array);
                            if (maxEvenIndex == -1)
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                Console.WriteLine(maxEvenIndex);
                            }
                        }

                        break;
                    case "min":
                        if (commandArgs[1] =="odd")
                        {
                            int minOddIndex = GetMinOddIndex(array);
                            if (minOddIndex == -1)
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                Console.WriteLine(minOddIndex);
                            }
                        }
                        else if (commandArgs[1] == "even")
                        {
                            int minEvenIndex = GetMinEvenIndex(array);
                            if (minEvenIndex == -1)
                            {
                                Console.WriteLine("No matches");
                            }
                            else
                            {
                                Console.WriteLine(minEvenIndex);
                            }
                        }

                        break;
                    case "first":
                        if (commandArgs[2] == "odd")
                        {
                            int firstOddElementsCount = int.Parse(commandArgs[1]);
                            if (firstOddElementsCount < 0 || firstOddElementsCount > array.Length)
                            {
                                Console.WriteLine("Invalid count");
                                break;
                            }

                            int[] oddElements = GetOddElements(array, firstOddElementsCount);

                            if (oddElements == null)
                            {
                                Console.WriteLine("[]");
                            }
                            else
                            {
                                Console.WriteLine("[{0}]", string.Join(", ", oddElements));
                            }
                        }
                        else if (commandArgs[2] == "even")
                        {
                            int firstEvenElementsCount = int.Parse(commandArgs[1]);
                            if (firstEvenElementsCount < 0 || firstEvenElementsCount > array.Length)
                            {
                                Console.WriteLine("Invalid count");
                                break;
                            }

                            int[] evenElements = GetEvenElements(array, firstEvenElementsCount);

                            if (evenElements == null)
                            {
                                Console.WriteLine("[]");
                            }
                            else
                            {
                                Console.WriteLine("[{0}]", string.Join(", ", evenElements));
                            }
                        }

                        break;
                    case "last":
                        if (commandArgs[2] =="odd")
                        {
                            int lastOddElementsCount = int.Parse(commandArgs[1]);
                            if (lastOddElementsCount < 0 || lastOddElementsCount > array.Length)
                            {
                                Console.WriteLine("Invalid count");
                                break;
                            }

                            var lastOddElements = GetLastOddElements(array, lastOddElementsCount);

                            if (lastOddElements == null)
                            {
                                Console.WriteLine("[]");
                            }
                            else
                            {
                                Console.WriteLine("[{0}]", string.Join(", ", lastOddElements));
                            }
                        }
                        else if (commandArgs[2] == "even")
                        {
                            int lastEvenElementsCount = int.Parse(commandArgs[1]);
                            if (lastEvenElementsCount < 0 || lastEvenElementsCount > array.Length)
                            {
                                Console.WriteLine("Invalid count");
                                break;
                            }

                            var lastEvenElements = GetLastEvenElements(array, lastEvenElementsCount);

                            if (lastEvenElements == null)
                            {
                                Console.WriteLine("[]");
                            }
                            else
                            {
                                Console.WriteLine("[{0}]", string.Join(", ", lastEvenElements));
                            }
                        }

                        break;
                    case "end":
                        Environment.Exit(0);
                        break;
                }
                
                command = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", array)}]");
        }

        private static int[] GetLastEvenElements(int[] array, int lastEvenElementsCount)
        {
            if (array.Any(n => n % 2 == 0))
            {
                var evenElements = array
                    .Where(n => n % 2 == 0)
                    .ToArray();

                var lastEvenElements = evenElements
                    .Skip(evenElements.Length - lastEvenElementsCount)
                    .ToArray();

                return lastEvenElements;
            }

            return null;
        }

        // returns last N odd elements, or null if there are none.
        private static int[] GetLastOddElements(int[] array, int lastOddElementsCount)
        {
            if (array.Any(n => n % 2 != 0))
            {
                var oddElements = array
                    .Where(n => n % 2 != 0)
                    .ToArray();

                var lastOddElements = oddElements
                    .Skip(oddElements.Length - lastOddElementsCount)
                    .ToArray();

                return lastOddElements;
            }
            
            return null;
        }

        // returns first N even elements from given array, or null if there are none.
        private static int[] GetEvenElements(int[] array, int count)
        {
            if (array.Any(n => n % 2 == 0))
            {
                var evenElements = array
                    .Where(n => n % 2 == 0)
                    .Take(count)
                    .ToArray();

                return evenElements;
            }

            return null;
        }

        // returns first N odd elements from given array, or null if there are none.
        private static int[] GetOddElements(int[] array, int count)
        {
            if (array.Any(n => n % 2 != 0))
            {
                var oddElements = array
                    .Where(n => n % 2 != 0)
                    .Take(count)
                    .ToArray();

                return oddElements;
            }

            return null;
        }

        // returns the index of the rightmost smallest even number, or -1 if there are none.
        private static int GetMinEvenIndex(int[] array)
        {
            int minIndex = -1;
            if (array.Any(n => n % 2 == 0))
            {
                int minEvenElement = array.Where(n => n % 2 == 0).Min();
                minIndex = Array.LastIndexOf(array, minEvenElement);
            }

            return minIndex;
        }

        // returns the index of the rightmost smallest odd number, or -1 if there are none.
        private static int GetMinOddIndex(int[] array)
        {
            int minIndex = -1;
            if (array.Any(n => n % 2 != 0))
            {
                int minOddElement = array.Where(n => n % 2 != 0).Min();
                minIndex = Array.LastIndexOf(array, minOddElement);
            }

            return minIndex;
        }

        // returns the index of the rightmost biggest even number, or -1 if there are none.
        private static int GetMaxEvenIndex(int[] array) // 1 8 3 8
        {
            int maxIndex = -1;
            if (array.Any(n => n % 2 == 0))
            {
                int maxEvenElement = array.Where(n => n % 2 == 0).Max();
                maxIndex = Array.LastIndexOf(array, maxEvenElement);
            }

            return maxIndex;
        }

        // returns the index of the rightmost biggest odd number, or -1 if there are none.
        private static int GetMaxOddIndex(int[] array)
        {
            int maxIndex = -1;
            if (array.Any(n => n % 2 != 0))
            {
                int maxOddElement = array.Where(n => n % 2 != 0).Max();
                maxIndex = Array.LastIndexOf(array, maxOddElement);
            }
           
            return maxIndex;
        }

        /// <summary>
        /// Splits the array after the given index,
        /// and exchanges the places of the two resulting sub-arrays
        /// </summary>
        /// <param name="array"> The original array </param>
        /// <param name="splitIndex"> Split index (inclusive) </param>
        /// <returns> Resulting array, composed of the rearranged sub-arrays</returns>
        private static int[] ShuffleArray(int[] array, int splitIndex)
        {
            var rightArray = array.Skip(splitIndex + 1);
            var leftArray = array.Take(splitIndex + 1);

            var final = new List<int>();
            final.AddRange(rightArray);
            final.AddRange(leftArray);

            return final.ToArray();
        }
    }
}

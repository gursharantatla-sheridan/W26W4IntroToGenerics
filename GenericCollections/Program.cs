using System.Collections;

namespace GenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array
            // GOOD - type safe
            // BAD - static in size

            int[] myArray = new int[3];
            myArray[0] = 10;
            myArray[1] = 20;
            myArray[2] = 30;

            //myArray[2] = "hello";
            //myArray[3] = 40;

            int sum = 0;

            for (int i=0; i<myArray.Length; i++)
            {
                int num = myArray[i];
                sum += num;
            }

            Console.WriteLine("Sum = " + sum);


            // ArrayList
            // GOOD - dynamic in size
            // BAD - boxing/unboxing - performance impact
            // BAD - not type safe

            // DO NOT USE IT

            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(10);
            myArrayList.Add(20);
            myArrayList.Add(30);

            //myArrayList.Add("hello");

            sum = 0;

            for (int i=0; i<myArrayList.Count; i++)
            {
                int num = (int)myArrayList[i];
                sum += num;
            }

            Console.WriteLine("\nSum = " + sum);


            // List
            // GOOD - dynamic in size
            // GOOD - no boxing/unboxing - better performance
            // GOOD - type safe

            List<int> myList = new List<int>(3);

            myList.Add(10);


            myList.Add(20);
            myList.Add(30);

            myList.Add(30);
            Console.WriteLine(myList.Capacity);

            myList.Add(30);

            //myList.Add("hello");

            sum = 0;

            for (int i=0; i<myList.Count; i++)
            {
                int num = myList[i];
                sum += num;
            }

            Console.WriteLine("\nSum = " + sum);
        }
    }
}

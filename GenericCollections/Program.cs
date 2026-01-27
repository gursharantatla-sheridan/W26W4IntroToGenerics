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
        }
    }
}

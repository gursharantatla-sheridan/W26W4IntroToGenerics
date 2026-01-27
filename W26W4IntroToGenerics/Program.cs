namespace W26W4IntroToGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // boxing - assigning value-type to ref-type
            int i = 5;
            object o = i;
            //o = "hello";

            // unboxing - assigning ref-type to value
            if (o is int)
                i = (int)o;


            //if (AreEqual(5.4, "5.4"))
            if (AreEqual<int>(3, 3))
                Console.WriteLine("Both are equal");
            else
                Console.WriteLine("Both are not equal");
        }

        // normal, non-generic method
        // not type-safe
        // boxing - performance issue
        static bool AreEqual(object value1, object value2)
        {
            return value1.Equals(value2);
        }

        // generic method
        // type-safe
        // no boxing - better performance
        static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}

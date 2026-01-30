using ListExercise;

namespace DictionaryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(101, "John", 5000);
            Employee emp2 = new Employee(102, "Anne", 7000);
            Employee emp3 = new Employee(103, "Mark", 3000);

            Dictionary<int, Employee> dictEmps = new Dictionary<int, Employee>();
            dictEmps.Add(emp1.Id, emp1);
            dictEmps.Add(emp2.Id, emp2);
            dictEmps.Add(emp3.Id, emp3);

            //dictEmps.Add(emp1.Id, emp1);

            //Console.Write("Enter key: ");
            //int key = Convert.ToInt32(Console.ReadLine());

            //if (dictEmps.ContainsKey(key))
            //{
            //    Employee emp = dictEmps[key];
            //    Console.WriteLine(emp);
            //}
            //else
            //    Console.WriteLine("Invalid Key. Please try again.");


            foreach (KeyValuePair<int, Employee> kvp in dictEmps)
            {
                int key = kvp.Key;
                Employee emp = kvp.Value;

                Console.WriteLine("\nKey = " + key + "\n");
                Console.WriteLine(emp);
            }
        }
    }
}

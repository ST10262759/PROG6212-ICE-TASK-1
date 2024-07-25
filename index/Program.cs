namespace index
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product emp = new Product(40000, "Manager", "Charles", "Mathews", "EMP0111");

            Console.WriteLine(emp[0]);
            Console.WriteLine(emp[1]);
            Console.WriteLine(emp[2]);
            Console.WriteLine(emp[3]);
            Console.WriteLine(emp[4]);

            // Accessing using string attrName
            Console.WriteLine("employee Salary: " + emp["Salary"]);
            Console.WriteLine("employee Number: " + emp["empNumber"]);
            Console.WriteLine("employee JobTitle: " + emp["jobTitle"]);
            Console.WriteLine("employee Name: " + emp["Name"]);
            Console.WriteLine("employee Surname: " + emp["surname"]);
        }
    }
}

namespace StudentDatabase_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void CreateStudentData()

        {
            string[] studentName = { "Jess", "Bob", "Danny", "Stella" }; // Index: Jess (0), Bob (1), Danny (2), Stella (3)
            string[] studentTown = { "Detroit", "Redford", "Novi", "Milan" };
            string[] studentFood = { "Pizza", "Apples", "Hummous", "Ice Cream" };


            Console.WriteLine("Hello! Please enter a number 1-4: ");
            int userInput = int.Parse(Console.ReadLine());


            if (userInput == 1)
            {
                Console.WriteLine($"Student 1 is {studentName[0]}");
            }
            else if (userInput == 2)
            {
                Console.WriteLine($"Student 2 is {studentName[1]}");
            }
            else if (userInput == 3)
            {
                Console.WriteLine($"Student 3 is {studentName[2]}");
            }
            else if (userInput == 4)
            {
                Console.WriteLine($"Student 4 is {studentName[3]}");
            } 

        }
    }
}
// Student Grades
#nullable disable
Console.Clear();

// Title
Console.WriteLine("Organize your students grades here!");

// Initialze Array
int[] students = new int[35];

// Generate random Object
Random rnd = new Random();

// Global Variables
int honorCount = 0;
int sum = 0;

// Min and Max Grades
int Min = 0;
int Max = 100;


// Produce Grades Function
void addGrades()
{
    for (int i = 0; i < students.Length; i++)
    {
        students[i] = rnd.Next(Min, Max);
    }
}

// Call Functin to Produce Grades
addGrades();

// Loop Menu Options
bool loop = true;
while (loop)
{
    // Looped Menu
    Console.WriteLine("\nMain Menu");
    Console.WriteLine("1. Display All Grades");
    Console.WriteLine("2. Display Honours");
    Console.WriteLine("3. Stats");
    Console.WriteLine("4. Randomize Grades");
    Console.WriteLine("5. Exit");
    {
        // Looped Instructions
        Console.Write("Choose an option or exit.");
        string menuOption = Console.ReadLine().ToLower();


        // Display Grades Function
        void displayAllGrades()
        {
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i] + "%");
            }
        }

        // Display Honours Function
        void displayHonours()
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] > 79)
                {
                    Console.WriteLine(students[i] + "%");
                    honorCount++;
                }
            }
            Console.WriteLine($"There are {honorCount} students that have honours (80% or higher)");
        }

        // Display Highest, Lowest, and Average Grade Function
        void stats()
        {
            for (int i = 0; i < students.Length; i++)
            {
                sum += students[i];
            }
            Console.WriteLine($"The highest grade is {students.Max()}%, the lowest grades is {students.Min()}%, and the average grade is {sum / 35}%");
        }
        // Randomize Grades Function
        void rndGrades()
        {
            addGrades();
            Console.WriteLine("Grades have been randomized");
        }


        // Test Input
        if (menuOption == "1")
        {
            displayAllGrades();
        }
        else if (menuOption == "2")
        {
            displayHonours();
        }
        else if (menuOption == "3")
        {
            stats();
        }
        else if (menuOption == "4")
        {
            rndGrades();
        }
        else if (menuOption == "5")
        {
            Console.WriteLine("Goodbye");
            break;
        }

    }
}
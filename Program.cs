using System;

class Program
{
    static void Main()
    {
        // Guided Project1: GPA Calculator
        // initialize variables - graded assignments
        int examAssignments = 5;

        // Student names
        string[] studentNames = new string[] { "Sophia", "Andrew" };
        //, "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor"

        int[] studentScores = new int[examAssignments];

        // Declare the variable outside the loop
        string currentStudentLetterGrade = "";

        // Write the Report Header to the console
        Console.WriteLine("Student\t\tGrade\n");

        foreach (string name in studentNames)
        {
            string currentStudent = name;

            Console.WriteLine($"Enter scores for {currentStudent}:");
            for (int i = 0; i < examAssignments; i++)
            {
                Console.Write($"Enter score for Exam {i + 1}: ");
                int score;
                if (int.TryParse(Console.ReadLine(), out score))
                {
                    studentScores[i] = score;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    i--;
                }
            }

            // initialize/reset the sum of scored assignments
            int sumAssignmentScores = 0;

            // initialize/reset the calculated average of exam + extra credit scores
            decimal currentStudentGrade = 0;

            // initialize/reset a counter for the number of assignment 
            int gradedAssignments = 0;

            // loop through the scores array and complete calculations for currentStudent
            foreach (int score in studentScores)
            {
                // increment the assignment counter
                gradedAssignments += 1;

                if (gradedAssignments <= examAssignments)
                {
                    sumAssignmentScores += score;
                }
                else
                {
                    // add the extra credit points to the sum - bonus points equal to 10% of an exam score
                    sumAssignmentScores += score / 10;
                }
            }

            currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

            if (currentStudentGrade >= 97)
            {
                currentStudentLetterGrade = "A+";
            }
            else if (currentStudentGrade >= 93)
            {
                currentStudentLetterGrade = "A";
            }
            else if (currentStudentGrade >= 90)
            {
                currentStudentLetterGrade = "A-";
            }
            else if (currentStudentGrade >= 87)
            {
                currentStudentLetterGrade = "B+";
            }
            else if (currentStudentGrade >= 83)
            {
                currentStudentLetterGrade = "B";
            }
            else if (currentStudentGrade >= 80)
            {
                currentStudentLetterGrade = "B-";
            }
            else if (currentStudentGrade >= 77)
            {
                currentStudentLetterGrade = "C+";
            }
            else if (currentStudentGrade >= 73)
            {
                currentStudentLetterGrade = "C";
            }
            else if (currentStudentGrade >= 70)
            {
                currentStudentLetterGrade = "C-";
            }
            else if (currentStudentGrade >= 67)
            {
                currentStudentLetterGrade = "D+";
            }
            else if (currentStudentGrade >= 63)
            {
                currentStudentLetterGrade = "D";
            }
            else if (currentStudentGrade >= 60)
            {
                currentStudentLetterGrade = "D-";
            }
            else
            {
                currentStudentLetterGrade = "F";
            }

            Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
        }

        // required for running in VS Code (keeps the Output windows open to view results)
        Console.WriteLine("\n\rPress the Enter key to continue");
        Console.ReadLine();
    }
}

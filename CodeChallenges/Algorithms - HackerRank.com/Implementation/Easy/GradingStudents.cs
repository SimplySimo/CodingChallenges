using System.Collections.Generic;

namespace CodeChallenges.Algorithms___HackerRank.com.Implementation.Easy { 
/*
HackerLand University has the following grading policy:

Every student receives a in the inclusive range from to .
Any less than is a failing grade.

Sam is a professor at the university and likes to round each student's according to these rules:

If the difference between the and the next multiple of is less than , round up to the next multiple of .
If the value of is less than , no rounding occurs as the result will still be a failing grade.

For example, will be rounded to but will not be rounded because the rounding would result in a number that is less than .

Given the initial value of for each of Sam's students, write code to automate the rounding process. Complete the function solve that takes an integer array of all grades, and return an integer array consisting of the rounded grades. For each , round it according to the rules above and print the result on a new line.

- Input Format

The first line contains a single integer denoting (the number of students).
Each line of the subsequent lines contains a single integer, , denoting student 's grade.

-Output Format

For each of the grades, print the rounded grade on a new line.

-Sample Input 0

4
73
67
38
33

-Sample Output 0

75
67
40
33

*/
public class GradingStudents
    {
        public static int[] gradingStudents(int[] grades)
        {
            List<int> results = new List<int>();
            foreach (int grade in grades)
            {
                int result = grade;
                if (grade >= 38)
                {
                    if ((5 - (grade % 5) + grade) - grade < 3)
                        result = 5 - (grade % 5) + grade;
                }
                results.Add(result);
            }
            return results.ToArray();
        }
    }
}

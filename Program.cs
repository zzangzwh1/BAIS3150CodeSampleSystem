using BAIS3150CodeSampleSystem.Domain;
using System.Data;
using Microsoft.Data.SqlClient;
using BAIS3150CodeSampleSystem.TechService;
using System;

namespace BAIS3150CodeSampleSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Domain.TestStudent t = new Domain.TestStudent();
            Console.WriteLine("");
            Console.WriteLine($"-------------------------- TEST --------------------------------");
            BCS requestDirector = new BCS();
            bool confirmation;



            #region CreateProgram

            /*   Console.WriteLine("");
               Console.WriteLine($"-------------------------- Create Program --------------------------------");
               string createProgramProgramCode = "Friday";
               string createProgramDescription = "Demo114";

               confirmation = requestDirector.CreateProgram(createProgramProgramCode, createProgramDescription);

               if (confirmation)
                   Console.WriteLine("Program is Successfullay Createded");
               else
                   Console.WriteLine("FAILED!!!");*/

            #endregion


            #region EnrollStudent
            /*            Console.WriteLine("");
                        Console.WriteLine($"-------------------------- Enroll Student --------------------------------");
                        string accepetedStudentStudentId = "99";
                        string accepetedStudentFirstName = "Mary";
                        string accepetedStudentLastName = "james";
                        string accepetedStudentEmail = "wcho2@nait.ca";

                        Student accepetedStudent = new()
                        {
                            StudentId = accepetedStudentStudentId,
                            FirstName = accepetedStudentFirstName,
                            lastName = accepetedStudentLastName,
                            Email = accepetedStudentEmail

                        };

                        string enrollStudentProgramCode = "BAIST";

                        confirmation = requestDirector.EnrollStudent(accepetedStudent, enrollStudentProgramCode);

                        if (confirmation)
                            Console.WriteLine("Students Are Successfullay Added");
                        else*/
            //    Console.WriteLine("FAILED!!!");

            #endregion

            #region FindsStudent
            /*
                        Console.WriteLine("");
                        Console.WriteLine("\"-------------------------- Find Student --------------------------");
                        string studentId = "99";

                        Domain.Program enrolledStudent = requestDirector.FindStudent(studentId);



                        Console.WriteLine();
                        foreach (var student in enrolledStudent.EnrolledStudents)
                        {

                            Console.WriteLine($"{student.StudentId} \t\t {student.FirstName} \t\t{student.lastName} \t\t{student.Email} \t\t{enrolledStudent.ProgramCode}");
                        }
            */
            #endregion

            #region ModifyStudent

   /*         Console.WriteLine("");
            Console.WriteLine("\"-------------------------- Modify Student --------------------------");


            string studentId = "99";
            Student enrolledStudent;

            enrolledStudent = requestDirector.FindStudent(studentId);
            Console.WriteLine(enrolledStudent.FirstName);
            Console.WriteLine();
          
            enrolledStudent.FirstName = "Mike3";
            enrolledStudent.lastName = "Cho";
            enrolledStudent.Email =  "wcho2@nait.ca";



            confirmation = requestDirector.ModifyStudent(enrolledStudent);

            if (confirmation)
                Console.WriteLine($"Student is successfully Updated! ");
            else
                Console.WriteLine($"Failed!! ");
*/
            #endregion


            #region RemoveStudent 
/*
            Console.WriteLine("");
            Console.WriteLine("\"-------------------------- Remove Student --------------------------");

            string studentId = "99";
            Student enrolledStudent;
            enrolledStudent = requestDirector.FindStudent(studentId);
            Console.WriteLine();

            Console.WriteLine($" {enrolledStudent.StudentId} \t\t {enrolledStudent.FirstName} \t\t{enrolledStudent.lastName} \t\t{enrolledStudent.Email} \t\t\t");




            confirmation = requestDirector.RemoveStudent(studentId);
            if (confirmation)
                Console.WriteLine($"Student is successfully Removed! ");
            else
                Console.WriteLine($"Failed!! ");*/

            #endregion

            #region FindsProgram
            Console.WriteLine("");
            Console.WriteLine("\"-------------------------- Finds Program --------------------------");


            string programCode = "BAIST3";
            Domain.Program activeProgram = requestDirector.FindProgram(programCode);
            Console.WriteLine(activeProgram.Description);


            foreach (Student enrollStudent in activeProgram.EnrolledStudents)
            {
                Console.WriteLine($"{enrollStudent.StudentId} \t\t\t {enrollStudent.FirstName} \t\t\t {enrollStudent.lastName} \t\t\t {enrollStudent.Email} \t\t\t{activeProgram.ProgramCode}");
            }



            #endregion
            Console.ReadLine();
        }
        private static string? IsStringEmptyOrNull(string? str)
        {
            if (string.IsNullOrEmpty(str))
                return null;

            return str;
        }
    }
}
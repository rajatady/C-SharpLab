using System;

namespace semester7.Program5
{
    public class Program5:IRunner
    {
        public void Run(string[] args)
        {


            Student student = new Student();
            try
            {
                Console.WriteLine("Please enter name ");
                student.SetName(Console.ReadLine());
                Console.WriteLine("Please enter department ");
                student.SetDepartment(Console.ReadLine());
                Console.WriteLine("Please enter mobile ");
                student.SetMobile(Console.ReadLine());
                Console.WriteLine("Please enter usn ");
                student.Usn = Console.ReadLine();
                Console.WriteLine("Please enter address ");
                student.Address = Console.ReadLine();
                Console.WriteLine("Please enter email ");
                student.Email = Console.ReadLine();

                student.Print();
            }
            catch (Exception e)
            {
                Console.WriteLine("Some error occurred. Error details - " + e.Message);
            }


        }
    }
}
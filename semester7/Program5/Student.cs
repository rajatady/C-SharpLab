using System;
using System.Text.RegularExpressions;

namespace semester7.Program5
{
    public class Student
    {
        public string Name { get; set; }
        public string Usn { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }

        public void SetName(string name)
        {
            var regexItem = new Regex("^[a-zA-Z0-9 ]*$");
            if (!regexItem.IsMatch(name))
            {
                throw new Exception("Special characters are not allowed in name.");
            }
            else
            {
                this.Name = name;
            }
        }

        public void SetDepartment(string department)
        {
            var regexItem = new Regex("^[a-zA-Z]*$");
            if (!regexItem.IsMatch(department))
            {
                throw new Exception("Special characters are not allowed in department.");
            }
            else
            {
                this.Department = department;
            }
        }

        public void SetMobile(string mobile)
        {
            // Regex matches a mobile number starting with 7, 8 or 9 followed by 9 other digits.
            var regexItem = new Regex("^[789]/\\d{9}$");
            if (!regexItem.IsMatch(mobile))
            {
                throw new Exception(mobile + " is not valid Indian mobile Number." +
                                    "\nMobile numbers starting with 7, 8 or 9 " +
                                    "\nfollowed by 9 other digits are valid.");
            }
            else
            {
                this.Mobile = mobile;
            }
        }

        public void Print()
        {
            Console.WriteLine("\n\n********* STUDENT ***********");
            Console.WriteLine("Name      \t-\t {0}", this.Name);
            Console.WriteLine("USN       \t-\t {0}", this.Usn);
            Console.WriteLine("Address   \t-\t {0}", this.Address);
            Console.WriteLine("Department\t-\t {0}", this.Department);
            Console.WriteLine("Email     \t-\t {0}", this.Email);
            Console.WriteLine("Mobile    \t-\t {0}", this.Mobile);
            Console.WriteLine("********* END STUDENT ***********");
        }
    }
}
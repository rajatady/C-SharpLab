namespace semester7.Program7
{
    public class Person
    {
        public string Name;
        public int Age;


        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Person()
        {
        }

        public void SetName(string name)
        {
            this.Name = name;
        }


        public void SetAge(int age)
        {
            this.Age = age;
        }

        public string GetName()
        {
            return  this.Name;
        }


        public int GetAge()
        {
            return this.Age;
        }
    }
}
namespace task
{
    // Строитель.
    internal class Worker : IWorker
    {
        String name;
        int age;
        public House house = new House();

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public void GetName()
        {
            Console.WriteLine($"Имя: {name}\nВозраст: {age}");
        }

        public override string ToString()
        {
            return $"Имя: {name}\nВозраст: {age}";
        }
    }
}
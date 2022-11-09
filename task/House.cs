namespace task
{
    // Дом.
    internal class House
    {
        public String houses = "";
        private static String error = "";
        public void Add(String line)
        {
            houses += line + " ";
        }

        public override string ToString()
        {
            return houses;
        }

        public void BuildBasement()
        {
            if (error == "")
            {
                Basement basement = new Basement();
                basement.Build();
                this.Add("1 фундамент");
                error += "фундамент ";
            }
            else { Console.WriteLine("Я не могу заложить два или более фундамента"); }
        }

        public void BuildWall(int num = 1)
        {
            if (error == "фундамент ")
            {
                Wall wall = new Wall();
                wall.Build();
                this.Add(num + " стена");
                error += "стены ";
            }
            else { Console.WriteLine("Я не могу строить стены без фундамента"); }
        }

        public void BuildDoor(int num = 1)
        {
            if (error == "фундамент стены ")
            {
                Door door = new Door();
                door.Build();
                this.Add(num + " дверь");
            }
            else { Console.WriteLine("Я не могу установить дверь без фундамента и стен"); }
        }

        public void BuildWindow(int num = 1)
        {
            if (error == "фундамент стены ")
            {
                Window window = new Window();
                window.Build();
                this.Add(num + " окно");
            }
            else { Console.WriteLine("Я не могу установить окно без фундамента и стен"); }
        }

        public void BuildRoof()
        {
            if (error == "фундамент стены ")
            {
                Roof roof = new Roof();
                roof.Build();
                this.Add("1 крыша");
            }
            else { Console.WriteLine("Я не могу построить крышу без фундамента и стен"); }
        }
    }
}
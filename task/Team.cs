namespace task
{
    // Бригада строителей.
    internal class Team 
    {
        public Worker[] worker = new Worker[5];
        public String result = "";

        public void OutWorkers()
        {
            foreach (var item in worker)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void Write()
        {
            for (int i = 0; i < 5; i++)
            {
                if (worker[i].house.houses != "") Console.WriteLine($"Строитель №{i + 1} построил {worker[i].house.houses}");
            }
            if (worker[4].house.houses != "") result += worker[0].house.houses + worker[1].house.houses + worker[2].house.houses + worker[3].house.houses + worker[4].house.houses;
        }
    }
}

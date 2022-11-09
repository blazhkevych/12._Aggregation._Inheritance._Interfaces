namespace task
{

    // Стены.
    internal class Wall : House, IPart
    {
        public void Build()
        {
            Console.WriteLine("Строим стены...");
        }
    }
}                                                                                                                                                                                                                
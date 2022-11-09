namespace task
{
    // Дверь.
    internal class Door : House, IPart
    {
        public void Build()
        {
            Console.WriteLine("Устанавливаем дверь ...");
        }
    }
}                                                                                                                                                                                                               
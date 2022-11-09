namespace task
{
    // Фундамент.
    internal class Basement : House, IPart
    {
        public void Build()
        {
            Console.WriteLine("Закладываем фундамент ...");
        }
    }
}

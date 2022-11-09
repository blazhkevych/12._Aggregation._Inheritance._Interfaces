namespace task
{
    /// <summary>
    ///             Реализовать программу “Строительство дома”
    /// * Классы
    ///     - House (Дом), Basement (Фундамент), Walls (Стены), Door (Дверь), Window (Окно), Roof (Крыша);
    ///     - Team (Бригада строителей), Worker (Строитель), TeamLeader (Бригадир).
    /// * Интерфейсы
    ///     - IWorker, IPart.
    /// Все части дома должны реализовать интерфейс IPart (Часть дома). Для рабочих и бригадира предоставляется базовый интерфейс IWorker (Рабочий).
    /// Бригада строителей (Team) строит дом (House).
    /// Дом состоит из фундамента (Basement), стен (Wall), окон (Window), дверей (Door), крыши (Part).
    /// В соответствии с проектом дом состоит из одного фундамента, четырёх стен, одной двери, четырёх окон и одной крыши.
    /// Бригада начинает работу, и строители последовательно “строят” дом, начиная с фундамента.
    /// Каждый строитель не знает заранее на чём завершился предыдущий этап строительства, поэтому он “проверяет”, что уже построено и продолжает работу.
    /// Если в игру вступает бригадир (TeamLeader), то он не строит, а формирует отчёт о том, что уже построено и какая часть работы выполнена.
    ///
    /// В конечном итоге на консоль выводится сообщение, что строительство дома завершено и отображается “рисунок дома” (вариант отображения выбрать самостоятельно).
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Team team = new Team();
            team.worker[0] = new Worker { Name = "Иван", Age = 42 };
            team.worker[1] = new Worker { Name = "Игорь", Age = 39 };
            team.worker[2] = new Worker { Name = "Дмитрий", Age = 38 };
            team.worker[3] = new Worker { Name = "Алексей", Age = 37 };
            team.worker[4] = new Worker { Name = "Евгений", Age = 36 };
            team.OutWorkers();
            team.worker[0].house.BuildBasement();

            TeamLeader teamLeader = new TeamLeader() { Name = "БРИГАДИР", Age = 50 };
            teamLeader.GetName();
            teamLeader.WriteReport(team);

            team.worker[2].house.BuildRoof(); // рано строить крышу.

            team.worker[1].house.BuildWall(4);
            team.worker[2].house.BuildDoor();
            team.worker[3].house.BuildWindow(4);
            team.worker[4].house.BuildRoof();

            teamLeader.WriteReport(team);
            Console.WriteLine($"Результат: {team.result}");
        }
    }
}
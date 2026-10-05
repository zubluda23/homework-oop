namespace WorkplaceApp
{
    public class Team
    {
        private List<Worker> _workers;

        public string Name { get; set; }

        public Team(string name)
        {
            Name = name;
            _workers = new List<Worker>();
        }

        public void AddWorker(Worker worker)
        {
            _workers.Add(worker);
        }

        public void ShowTeamInfo()
        {
            Console.WriteLine($"Team: {Name}");
            foreach (Worker worker in _workers)
            {
                Console.WriteLine(worker.Name);
            }
        }

        public void ShowDetailedInfo()
        {
            Console.WriteLine($"Team: {Name}");
            foreach (Worker worker in _workers)
            {
                Console.WriteLine($"{worker.Name} - {worker.Position} - {worker.WorkDay.Trim()}");
            }
        }
    }
}

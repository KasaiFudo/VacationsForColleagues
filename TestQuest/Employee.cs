namespace TestQuest
{
    class Employee
    {
        public int daysVacation { get; set; }
        public string _name { get; set; }
        public List<Vacation> _vacations { get; set; }

        public Employee(string name)
        {
            _vacations = new List<Vacation>();
            _name = name;
        }

        public void AddVacations()
        {
            while (true)
            {
                foreach (var vacation in _vacations)
                {
                    daysVacation += vacation.vacation.Count;
                }

                if (daysVacation == 21)
                {
                    _vacations.Add(new Vacation(true));
                    break;
                }
                else if(daysVacation == 28)
                {
                    break;
                }
                else
                {
                _vacations.Add(new Vacation(false));
                }
                
                daysVacation = 0;
            }
        }
        public void ShowVacations()
        {
            Console.WriteLine("Дни отпуска " + _name + " : ");
            foreach (var vacation in _vacations)
            {
                Console.WriteLine($"{vacation.vacation[0]} - {vacation.vacation[vacation.vacation.Count - 1]}");
            }
        }
    }
}

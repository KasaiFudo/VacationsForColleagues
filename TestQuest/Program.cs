using TestQuest;

namespace PracticTask1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>()
            {
                new Employee("Иванов Иван Иванович"),
                new Employee("Петров Петр Петрович"),
                new Employee("Юлина Юлия Юлиановна"),
                new Employee("Сидоров Сидор Сидорович"),
                new Employee("Павлов Павел Павлович"),
                new Employee("Георгиев Георг Георгиевич"),
            };
            foreach (Employee employee in employees)
            {
                employee.AddVacations();
                employee.ShowVacations();
            }
            Console.ReadKey();
        }
    }
}
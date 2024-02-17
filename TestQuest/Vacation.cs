namespace TestQuest
{
    class Vacation
    {
        public List<DateTime> vacation { get; set; }

        List<string> _aviableWorkingDaysOfWeekWithoutWeekends = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };

        public Vacation(bool isLastVacation) 
        {
            vacation = new List<DateTime>();
            if (isLastVacation == true)
            {
                GenerateVacation(7);
            }
            else if(isLastVacation == false)
            {
                GenerateVacation();
            }
        }

        private void GenerateVacation()
        {
            List<DateTime> dateList = vacation;
            DateTime start = new DateTime(DateTime.Now.Year, 1, 1);
            DateTime end = new DateTime(DateTime.Today.Year, 12, 31);
            int range = (end - start).Days;
            Random gen = new Random();

            while (true)
            {
                var startDate = start.AddDays(gen.Next(range));
                if (_aviableWorkingDaysOfWeekWithoutWeekends.Contains(startDate.DayOfWeek.ToString()))
                {
                    string[] vacationSteps = { "7", "14" };
                    int vacIndex = gen.Next(vacationSteps.Length);
                    var endDateThisVacation = new DateTime(DateTime.Now.Year, 12, 31);
                    if (vacationSteps[vacIndex] == "7")
                    {
                        endDateThisVacation = startDate.AddDays(7);
                    }
                    if (vacationSteps[vacIndex] == "14")
                    {
                        endDateThisVacation = startDate.AddDays(14);
                    }

                    for (DateTime dt = startDate; dt < endDateThisVacation; dt = dt.AddDays(1))
                    {
                        vacation.Add(dt);
                    }
                    break;
                }
            }   
        }
        public void GenerateVacation(int days)
        {
            List<DateTime> dateList = vacation;
            DateTime start = new DateTime(DateTime.Now.Year, 1, 1);
            DateTime end = new DateTime(DateTime.Today.Year, 12, 31);
            int range = (end - start).Days;
            Random gen = new Random();

            while (true)
            {
                var startDate = start.AddDays(gen.Next(range));
                if (_aviableWorkingDaysOfWeekWithoutWeekends.Contains(startDate.DayOfWeek.ToString()))
                {
                    var endDateThisVacation = new DateTime(DateTime.Now.Year, 12, 31);
                    endDateThisVacation = startDate.AddDays(days);

                    for (DateTime dt = startDate; dt < endDateThisVacation; dt = dt.AddDays(1))
                    {
                        vacation.Add(dt);
                    }
                    break;
                }
            }
        }
    }
}

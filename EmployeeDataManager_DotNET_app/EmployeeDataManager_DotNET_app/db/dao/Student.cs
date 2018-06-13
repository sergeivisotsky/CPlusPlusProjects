namespace EmployeeDataManager_DotNET_app.db
{
    public class Student
    {
        private long id;
        private string name;
        private string surname;
        private string age;
        private string srudyProgram;
        private int studyYear;

        public Student(long id, string name, string surname,
                        string age, int studyYear, string srudyProgram)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.StudyYear = studyYear;
            this.SrudyProgram = srudyProgram;
        }

        public long Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Age { get => age; set => age = value; }
        public string SrudyProgram { get => srudyProgram; set => srudyProgram = value; }
        public int StudyYear { get => studyYear; set => studyYear = value; }
    }
}

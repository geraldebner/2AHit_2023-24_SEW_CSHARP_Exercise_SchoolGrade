namespace School;

/*
*Student*: Ein Schüler mit den Attributen: Vorname, Nachname, Geburtsmonat, Geburtsjahr
      Liste von Noten 
    * Such- und Filtermethoden:
        * Rückgabe  nach Fach sortieten Noten
        * Rückgabe  nach Note sortierten Noten
        * Rückgabe einer nach Fach gefilterten Liste der Notennnnn
*/

public class Student
{
    private string firstname = "";
    private string lastname = "";
    private int month;
    private int year;
    private List<Grade> grades = new List<Grade>();

    public string Firstname { get => firstname; set => firstname = value; }
    public string Lastname { get => lastname; set => lastname = value; }
    public int Month { get => month; set => month = value; }
    public int Year { get => year; set => year = value; }

    public Student(string firstname, string lastname, int month, int year, List<Grade> grades)
    {
        this.firstname = firstname;
        this.Lastname = lastname;
        this.Month = month;
        this.Year = year;
        this.grades = grades;
    }

    public Student(string firstname, string lastname, int month, int year)
    {
        this.firstname = firstname;
        this.Lastname = lastname;
        this.Month = month;
        this.Year = year;
    }


    public void AddGrade(Grade grade)
    {
        grades.Add(grade);
    }

    public void AddGrade(int grade, string subject)
    {
        Grade grade1 = new Grade(grade, subject);
        grades.Add(grade1);
    }


    public List<Grade> SortGradeBySubject()
    {
        // Bubble Sort
        for(int i = 0; i < grades.Count(); i++){
            for(int j = 0; j < grades.Count()-1;j++){
                char first = grades[j].Subject.ToCharArray()[0];
                char firstNext = grades[j+1].Subject.ToCharArray()[0];
                if (first > firstNext)
                {
                    Grade temp = grades[j];
                    grades[j] = grades[j + 1];
                    grades[j + 1] = temp;
                }
            }
        }
        return grades;
    }

    public double AverageGrades
    {
        get{
            double sum = 0.0;
            foreach(Grade g in grades)
            {
                sum = sum + g.Grading;
            }

            return sum / grades.Count;
        }
    }

}

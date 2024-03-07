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

    public Student(string firstname, string lastname, int month, int year, List<Grade> grades)
    {
        this.firstname = firstname;
        this.lastname = lastname;
        this.month = month;
        this.year = year;
        this.grades = grades;
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


    public List<Grade> SortGradeBySubject(){
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
}

namespace School;

//*Grade*: Dies stellt eine Note dar mit Fach, Note 
public class Grade
{
    private int grade;
    private string subject = "";

    public Grade(int grade, string subject)
    {
        if ((grade > 5) || (grade < 1))
        {
            this.grade = 5;
        }
        else
        {
            this.grade = grade;
        }
        this.subject = subject;

    }

    
    public string Subject
    {
        get
        {
            return subject;
        }
    }

}

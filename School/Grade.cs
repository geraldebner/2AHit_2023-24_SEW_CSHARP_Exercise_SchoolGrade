namespace School;

//*Grade*: Dies stellt eine Note dar mit Fach, Note 
public class Grade
{
    private int grading = 1;
    private string subject = "";

    public Grade(int grading, string subject)
    {
        if ((grading > 5) || (grading < 1))
        {
            this.grading = 5;
        }
        else
        {
            this.grading = grading;
        }
        this.subject = subject;

    }

    
    public string Subject{ get{ return subject; }}

    public int Grading { get{ return grading;} }
}

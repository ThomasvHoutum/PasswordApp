namespace Domain.Entities;

public class SecurityQuestion
{
    public string Question { get; private set; }
        
    public string Answer { get; private set; }

    public SecurityQuestion(string question, string answer)
    {
        Question = question;
        Answer = answer;
    }
}
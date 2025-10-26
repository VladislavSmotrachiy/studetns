public class Students
{

    string FirstName;
    string LastName;


    public Students(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;

    }
    public string GetFullName()
    {
        return ($"{LastName} {FirstName}");
    }

    


}
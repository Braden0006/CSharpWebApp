namespace CSharpWebAPI;

// This is the model for the users. A model is a class that represents data that the app
// manages. 

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string? Secret { get; set; }
}
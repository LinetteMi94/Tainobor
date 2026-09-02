namespace Tainobor.Characters.Teachers;

public class Teacher : Character
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public Gender CharacterGender { get; set; }
    public int Age { get; private set; }

    public Teacher()
    {
        
    }
}
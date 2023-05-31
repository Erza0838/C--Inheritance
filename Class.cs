public class InfoPerson
{
    public string InheritePersonName = "";
    public string InheritePersonCareer = "";
    public int InheritePersonAge = 0;

    public void ShowInforPerson(string InheritePersonCareer)
    {
      Console.WriteLine("Nama saya adalah " + InheritePersonName);
      Console.WriteLine("Umur saya " + InheritePersonAge);
      Console.WriteLine("Saya disini sebagai " + InheritePersonCareer);
      Console.WriteLine("");
    }
}

public class inforPerson2 : InfoPerson
{
    public void ShowInforPerson2(string InheritePersonCareer2)
    {
      Console.WriteLine("Nama saya adalah " + InheritePersonName);
      Console.WriteLine("Umur saya " + InheritePersonAge);
      Console.WriteLine("Saya disini sebagai " + InheritePersonCareer2);
      Console.WriteLine("");
    }
}

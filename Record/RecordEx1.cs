public class RecordEx1
{
    public record Person(string Name, int Age);

    public static void ComparePerson(){
        Person person1 = new("Testington", 40);
        Person person2 = new("Testington", 40);

        
        bool isEqual = person1.Equals(person2);

        Console.WriteLine(isEqual);

    }



   


}
using AnonymusTypes;

internal class Program
{
    private static void Main(string[] args)
    {
        Employee employee = new Employee();

        //Anonymous types is created by compiler so its Props are readonly and must be assigned when creating the object.
        //Must use 'var' as classname and must leave any classname on the right hand side.
        var anonymType = new { Name = employee.GetEmployeeName(), Age = employee.GetEmployeeId() };

        Console.WriteLine($"Using anonym type props: name {anonymType.Name}, age: {anonymType.Age}");

        //Of course Props can be assigned custom values and it's possible to use nested anonym type in an anonym type.
        //So that means an anonym type's Prop can hold an other anonym type's reference even created at initializing.

        var anonymType2 = new 
        {   
            Name = "Scott",
            NestedAnyonymType = new { Adress = "New street", City = "Tokyo" }
        };

        Console.WriteLine(anonymType2.Name + ", nested City and Adress: " + anonymType2.NestedAnyonymType.City + ", " + anonymType2.NestedAnyonymType.Adress);

        //It's even possible ot create Anonym Arrays, with some rules: all member must have the same Props in same order with same types.
        var anonymArray = new[]
        {
            new { Age = 5, Name = "Emily" },
            new { Age = 8, Name = "Mike"}
        };

        foreach ( var anonym in anonymArray )
        {
            Console.WriteLine(anonym.Age + ", " + anonym.Name);
        }
        
    }
}
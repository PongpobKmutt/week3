public class user{
    public string InuputName(){
        Console.Write("Input Name : ");
        return Console.ReadLine();
    }
    public string InuputSurname(){
        Console.Write("Input Surname : ");
        return Console.ReadLine();
    }
    public string InputNumber(){
        Console.Write("Input Number : ");
        return Console.ReadLine();
    }
    static void PrintInfoGrade(){
        Console.WriteLine("Name : ",InputName);
        Console.WriteLine("Surname : ",InputSurname);
        Console.WriteLine("Number : ",InputNumber);
        Console.WriteLine("Score : ");
        Console.WriteLine("Grade : ");
    }


    
}
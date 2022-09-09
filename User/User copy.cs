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
    public void CreateGrade(){
        
    }
    public void Grade(){
        Console.WriteLine("Grade A >= 80");
        Console.WriteLine("Grade B+ >=75");
        Console.WriteLine("Grade B >= 70");
        Console.WriteLine("Grade C+ >=65");
        Console.WriteLine("Grade C >= 60");
        Console.WriteLine("Grade D+ >=55");
        Console.WriteLine("Grade D >=50");
        Console.WriteLine("Grade F <50");
    }
    static void PrintInfoGrade(){
        Console.WriteLine("Name : ",InputName);
        Console.WriteLine("Surname : ",InputSurname);
        Console.WriteLine("Number : ",InputNumber);
        Console.WriteLine("Score : ");
        Console.WriteLine("Grade : ");
    }


    
}
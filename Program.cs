class Program{

    static void Main (string[] args){


        int result;

        result = Converttoint();
        Console.WriteLine(result);
        
       




    }

    static int Converttoint() {

        string a;
        int input;

        Console.Write("Score = ");
        a = Console.ReadLine(); 
        input = Int32.Parse(a);

        return input;

    }




    

    





}
public class Client {  

    public static int InterpretRoman(string romanNumber) {
        var context = new Context(romanNumber);
        List<Expression> Tree = new List<Expression>();
        Tree.Add(new ThousandExpression());
        Tree.Add(new HundredExpression());
        Tree.Add(new TenExpression());
        Tree.Add(new OneExpression());

        foreach(var branch in Tree) branch.Interpret(context);
        return context.Output;
    }

    public static void Main (string[] args) {
        Console.WriteLine("roman number: ");
        string romanNumber = Console.ReadLine() ?? "";
        while(!string.IsNullOrEmpty(romanNumber)) {
            Console.WriteLine($"{romanNumber} = {InterpretRoman(romanNumber)}");
            Console.WriteLine("roman number(ENTER to close): ");
            romanNumber = Console.ReadLine() ?? "";
        } 
    }
}


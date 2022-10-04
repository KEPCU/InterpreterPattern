public abstract class Expression {
    public string One {get; set;} = " ";
    public string Four {get; set;} = " ";
    public string Five {get; set;} = " ";
    public string Nine {get; set;} = " ";
    public int Multiplier {get; set;} = 1;

    public void Interpret(Context context) {
        if(context.Input.Length == 0) return;
        if(context.Input.StartsWith(Nine)) {
            context.Output += (9*Multiplier);
            context.Input = context.Input.Substring(2);
        }
        else if(context.Input.StartsWith(Four)) {
            context.Output += 4*Multiplier;
            context.Input = context.Input.Substring(2);
        }
         else if(context.Input.StartsWith(Five)) {
            context.Output += 5*Multiplier;
            context.Input = context.Input.Substring(1);
        }
        while(context.Input.StartsWith(One)) {
            context.Output += Multiplier;
            context.Input = context.Input.Substring(1);
        }
    }
}


public class OneExpression : Expression {
    public OneExpression() {
        One = "I";
        Four = "IV";
        Five = "V";
        Nine = "IX";
        Multiplier = 1;
    }
}

public class TenExpression : Expression {
    public TenExpression() {
        One = "X";
        Four = "XL";
        Five = "L";
        Nine = "XC";
        Multiplier = 10;
    }
}

public class HundredExpression : Expression {
    public HundredExpression() {
        One = "C";
        Four = "CD";
        Five = "D";
        Nine = "CM";
        Multiplier = 100;
    }
}

public class ThousandExpression : Expression {
    public ThousandExpression() {
        One = "M";
        Multiplier = 1000;
    }
}


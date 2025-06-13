using System.Text;

string do_math(double a,double b,string op)
{
    string result = "";
    switch(op)
    {
        case "+":
            result = $"{a} + {b}={a + b}";
            break;
        case "-":
            result = a + " - " + b + "=" + (a - b);
            break;
        case "*":
            result = $"{a} * {b}={a * b}";
            break;
        case "/":
            if (b == 0)
                result = "Mẫu số phải khác 0";
            else
                result = $"{a} / {b}={a / b}";
            break;
        default:
            result = "Nhập phép toán tào lao quá";
            break;
    }    
    return result;
}
Console.OutputEncoding=Encoding.UTF8;
double a, b;
Console.WriteLine("Nhập a:");
a=double.Parse(Console.ReadLine());
Console.WriteLine("Nhập b:");
b = double.Parse(Console.ReadLine());
Console.WriteLine("Phép toán +,-,*,/:");
string op=Console.ReadLine();
string result=do_math(a,b,op);
Console.WriteLine(result);
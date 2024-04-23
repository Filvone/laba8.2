class Binary1
{
    static void Razn(string num1, string num2, string num11, string num22)
    {
       double a = todouble(num1,num2);
        double b = todouble(num11, num22);
        double c = a - b;
        string s = tobin(c);
        Console.WriteLine(s);
    }
    static double todouble(string num1, string num2)
    {
        char[] a = num1.ToArray();
        char[] b = num2.ToArray();
        
        double c = 0;
        double d = 0;
   
        for (int i = 0; i <a.Length; i++)
        {
           
           c += Char.GetNumericValue(a[i]) * Math.Pow(2,i);
            
        }
        for (int i = 0; i < b.Length; i++)
        {
            
            d += Char.GetNumericValue(b[i]) * Math.Pow(2, -i-1);
            
        }
        
        return c+d;
    }
    static string tobin(double num)
    {
        string n =num.ToString();
        string[] nums = n.Split(',');
        int a = Convert.ToInt32(nums[0]);
        double b = Convert.ToDouble("0,"+nums[1]);
        string c = Convert.ToString(a,2);
        string d = "";
        string b1 = "0";
        string b2 = nums[1];

        while (b2 != "0")
        {
            b = b * 2;
            string temp = b.ToString();

            string[] temparr = temp.Split(",");

            d += temparr[0];
            if (temparr[0] == "1")
            {
                temparr[0] = "0";

            }
            if (temparr.Length > 1)
            {
                b1 = temparr[0];
                b2 = temparr[1];
            }
            else
            {
                b1 = temparr[0];
                b2 = "0";
            }
            string temp2 = b1 + "," + b2;
            b = Convert.ToDouble(temp2);
        }
        return c+","+d;
    }
    static void Del(string num1, string num2, string num11, string num22)
    {
        double a = todouble(num1, num2);
        double b = todouble(num11, num22);
        double c = a / b;
        string s = tobin(c);
        Console.WriteLine(s);
    }
    public static void Main()
    {
        Start:
        try
        {
            string num1;
            string num2;
            string num11;
            string num22;
            Console.Write("Введите целую часть первого числа: ");
            num1 = Console.ReadLine();
            Console.Write("Введите дробную часть первого числа: ");
            num2 = Console.ReadLine();
            Console.Write("Введите целую часть второго числа: ");
            num11 = Console.ReadLine();
            Console.Write("Введите дробную часть второго числа: ");
            num22 = Console.ReadLine();
            Console.Write("Разность равна: ");
            Razn(num1, num2, num11, num22);


            Console.WriteLine(" ");
            Console.Write("Частное равно: ");
            Del(num1, num2, num11, num22);
        }
        catch
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Неверный формат");
            goto Start;
        }
        

        
    }
}

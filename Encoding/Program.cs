using System.Net.Sockets;

class Encoding
{
   public string repeateString = "";
   public string decodeString = "";
    public string RmString = "";
    public int f = 0;
    public int i = 0;
    public int length = 0;
    public int j=0;
    public int k = 0;
    public int numOfChar;

    public int char_to_int(char c)
    {
        int val = c - '0';
        if (val >= 0 && val <= 9) return val;
        else
        {
            Console.WriteLine("Invalid Input");
            return -1; 
        }
    }
    public string repeat_char(char c, int n)
    {
        if (n < 1) return repeateString;
        else
        {
            repeateString += c;
          return  repeat_char(c, n - 1);
        }
    }
    public string decode(string str)
    {
        if (i == 0)
        {
            length = str.Length;
        }
        if (length <= 0)
        {
            return decodeString;
        }
        else
        {
            char c = str[i];
            int num = char_to_int(str[i+1]);
            Console.WriteLine(c + " " + num);
            repeateString = "";
            decodeString+=repeat_char(c,num);
            i+=2;
            length-=2;
            return decode(str);
        }
    }
    public char int_to_char(int n)
    {
        if(n>=0 && n <= 9)
        {
            n += 48;
            return (char)n;
        }
        else
        {
            Console.WriteLine("Invalid Input.");
            return 'X';
        }
       
           
       
    }
    public int length_char(char c, string str)
    {
       
        if (str == "" || str[0] != c)
        {
            return 0;
        }
        else
        {
            
           return 1+length_char(c, str.Substring(1, str.Length - 1));
        }
    }
    public string drop_char(char c, string str)
    {
        if (str == "" || str[0] != c)
        {
            return str;
        }
        return drop_char(c, str.Substring(1,str.Length-1));

    }

    public string encode(string str)
    {
        if (str == "")
        {
            return "";
        }
        return (str[0] + "" + length_char(str[0], str) + encode(drop_char(str[0], str)));
    }
    /*
    private string EncodeIt(int length,string str,string myString)
    {
        if (length < 1) return str;
        else
        {
            j = 0;
            int n = length_char(str[0], str);
            myString += str[0];
            myString += n;
            length = n;
            return   EncodeIt(length, str.Substring(n), myString);
        }
    }
    */
    public string complex_encode(string str)
    {
        throw new Exception("Remove this and write your code here");
    }
    public string complex_decode(string str)
    {
        throw new Exception("Remove this and write your code here");
    }
}
class Program
{
    static void Main()
    {
Encoding encoding = new Encoding();
        Console.WriteLine(encoding.char_to_int('1'));
        Console.WriteLine(encoding.repeat_char('a',5));
        Console.WriteLine(encoding.decode("w5t6u9"));
        Console.WriteLine(encoding.int_to_char(0));
        Console.WriteLine(encoding.length_char('c',"cccccbbc"));
        Console.WriteLine(encoding.drop_char('c', "cccrwdws"));
        Console.WriteLine(encoding.encode("aaarrrr"));
        Console.ReadLine();

    }
   
}
public class WildCard
{
    public static string wildCard(string str)
    {
        string[] inputs = str.Split(' ');
        string alphabets = "abcdefghijklmnopqrstuvwxyz";
        string numbers = "123456789";
        string input1 = inputs[0];
        string output1 = inputs[1];
        char prevInput = ' ';
        int index = 0;
        int outputIndex = 0;
        while (index < input1.Length)
        {
            if (input1[index] == '+')
            {
                if (alphabets.IndexOf(output1[outputIndex]) < 0)
                    return "false";
                prevInput = input1[index];
                index++;
                outputIndex++;
            }
            else if (input1[index] == '$')
            {
                if (numbers.IndexOf(output1[outputIndex]) < 0)
                    return "false";
                prevInput = input1[index];
                index++;
                outputIndex++;
            }
            else if (input1[index] == '*')
            {
                if (input1[index + 1] == '{' && input1[index + 3] == '}')
                {
                    int indexToGo = int.Parse(input1[index + 2].ToString());
                    for (int i = 0; i < indexToGo; i++)
                    {
                        if (alphabets.IndexOf(output1[outputIndex]) < 0)
                            return "false";
                        outputIndex++;
                    }
                    index += 4;
                }
                else
                {
                    int n = 3;
                    for (int i = 0; i < n; i++)
                    {
                        if (alphabets.IndexOf(output1[outputIndex]) < 0)
                            return "false";
                        outputIndex++;
                    }
                    index++;
                }
            }
        }
        return "true";
    }

    public static void Run()
    {
        string s = "++*{5} jtggggg";
        string result = wildCard(s);
        Console.WriteLine(result);
    }
}
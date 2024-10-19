using System;


//Task 1
class Program
{
    static void Main()
    {
        int[,] array = new int[5, 4];
        Random rand = new Random();
        int maxValue = int.MinValue;
        int minValue = int.MaxValue;

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                array[i, j] = rand.Next(1, 100);
                if (array[i, j] > maxValue)
                    maxValue = array[i, j];
                if (array[i, j] < minValue)
                    minValue = array[i, j];
            }
        }

        Console.WriteLine("Max value: " + maxValue);
        Console.WriteLine("Min value: " + minValue);

        for (int i = 0; i < 5; i++)
        {
            int rowMax = int.MinValue;
            int rowMin = int.MaxValue;
            for (int j = 0; j < 4; j++)
            {
                if (array[i, j] > rowMax)
                    rowMax = array[i, j];
                if (array[i, j] < rowMin)
                    rowMin = array[i, j];
            }
            Console.WriteLine("Row " + i + " - Max: " + rowMax + ", Min: " + rowMin);
        }


        //Task 2
        Console.WriteLine("Enter the string:");
        string input = Console.ReadLine();
        char[] arrayStr = input.ToCharArray();

        for (int i = 0; i < arrayStr.Length; i++)
        {
            if (char.IsUpper(arrayStr[i]))
                arrayStr[i] = char.ToLower(arrayStr[i]);
            else if (char.IsLower(arrayStr[i]))
                arrayStr[i] = char.ToUpper(arrayStr[i]);
        }

        string output = new string(arrayStr);
        Console.WriteLine("Result: " + output);


        //Task 3
        Console.WriteLine("Enter the string:");
        string inputStr = Console.ReadLine();
        string[] words = inputStr.Split(' ');

        foreach (string word in words)
        {
            Console.WriteLine(word);
        }


        //Task 4
        Console.WriteLine("Enter the text:");
        string inputText = Console.ReadLine();
        bool hasFiveInRow = false;

        for (int i = 0; i < inputText.Length - 4; i++)
        {
            if (inputText[i] == inputText[i + 1] && inputText[i] == inputText[i + 2] && inputText[i] == inputText[i + 3] && inputText[i] == inputText[i + 4])
            {
                hasFiveInRow = true;
                break;
            }
        }

        if (hasFiveInRow)
            Console.WriteLine("There are five consecutive identical characters in the text.");
        else
            Console.WriteLine("There are no consecutive identical characters in the text.");


        //Task 5
        Client client = new Client(1, "Ryan Gosling", "Real st 37", "+380974831243", 5, 2200.50);
        client.Print();


        //Task 6
        string[] products = { "First", "Second", "Third" };
        Request request = new Request(1, client, DateTime.Now, products, 300.75);
        request.Print();
    }
}


struct Client
{
    public int ClientCode;
    public string FullName;
    public string Address;
    public string Phone;
    public int OrderCount;
    public double TotalOrderAmount;

    public Client(int clientCode, string fullName, string address, string phone, int orderCount, double totalOrderAmount)
    {
        ClientCode = clientCode;
        FullName = fullName;
        Address = address;
        Phone = phone;
        OrderCount = orderCount;
        TotalOrderAmount = totalOrderAmount;
    }

    public void Print()
    {
        Console.WriteLine($"Client Code: {ClientCode}");
        Console.WriteLine($"Full Name: {FullName}");
        Console.WriteLine($"Address: {Address}");
        Console.WriteLine($"Phone: {Phone}");
        Console.WriteLine($"Order Count: {OrderCount}");
        Console.WriteLine($"Total Order Amount: {TotalOrderAmount}");
    }
}


struct Request
{
    public int RequestCode;
    public Client Client;
    public DateTime OrderDate;
    public string[] ProductList;
    public double OrderAmount;

    public Request(int requestCode, Client client, DateTime orderDate, string[] productList, double orderAmount)
    {
        RequestCode = requestCode;
        Client = client;
        OrderDate = orderDate;
        ProductList = productList;
        OrderAmount = orderAmount;
    }

    public void Print()
    {
        Console.WriteLine($"Request Code: {RequestCode}");
        Console.WriteLine($"Client: {Client.FullName}");
        Console.WriteLine($"Order Date: {OrderDate.ToShortDateString()}");
        Console.WriteLine($"Products: {string.Join(", ", ProductList)}");
        Console.WriteLine($"Order Amount: {OrderAmount}");
    }
}

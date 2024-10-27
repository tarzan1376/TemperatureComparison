class TemperaturesComparison
{
    static void Main()
    {
        const int maxTemperatures = 5;
        double[] temperatures = new double[maxTemperatures];

        for (int i = 0; i < maxTemperatures; i++)
        {

            while (true)
            {
                Console.Write("Enter Temperature (-30 to 130)\n");
                string input = Console.ReadLine();

                if (double.TryParse(input, out double temperature) && temperature >= -30 && temperature <= 130)
                {
                    temperatures[i] = temperature;
                    break;
                }
                else
                {
                    Console.WriteLine($"Temperature {input} is invalid, Please enter a valid temperature between -30 and 130): ");
                }
            }
        }
        string compare;

        if (GettingColder(temperatures))
        {
            compare = "Getting Cooler";
        }
        else if (GettingWarmer(temperatures))
        {
            compare = "Getting Warmer";
        }
        else
        {
            compare = "It's a mixed bag";
        }
        double avgTemp = CalcAvg(temperatures);

        Console.WriteLine("\n5-day Temperature [" + string.Join(", ", temperatures)+"]");


        Console.WriteLine(compare);
        Console.WriteLine($"Average temperature is {avgTemp} degrees");

    }
    static bool GettingColder(double[] temperatures)
    {
        for (int i = 0; i < temperatures.Length - 1; i++)
        {
            if (temperatures[i] < temperatures[i + 1])
                return false;
        }
        return true;
    }

    static bool GettingWarmer(double[] temperatures)
    {
        {
            for (int i = 0; i < temperatures.Length - 1; i++)
            {
                if (temperatures[i] > temperatures[i + 1])
                    return false;
            }
            return true;
        }

    }

        static double CalcAvg(double[] temperatures)
        {
            double sum = 0;
            foreach (double temp in temperatures)
            {
                sum += temp;
            }
            return sum / temperatures.Length;
        }
    
}
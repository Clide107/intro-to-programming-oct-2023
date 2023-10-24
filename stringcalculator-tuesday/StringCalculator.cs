
namespace StringCalculator;

public class StringCalculator
{

    public int Add(string numbers)
    {
        if (numbers.Contains(",") && numbers.Contains("\n"))
        {
            //List<int> list = new List<int>();
            int total = 0;
            List<string> myNums = numbers.Split(',').ToList();
            //for (int i = 0; i < myNums.Count; i++)
            //{
            //string number = myNums[i];
            //if (number.Contains("\n")) 
            //{
            //    int numberNum = number.
            //    list.Add(number.Split(","));
            //}
            //}

            string nNumbers = "";

            for (int i = 0; i < myNums.Count; i++)
            {
                nNumbers += myNums[i];
            }

            List<int> list = nNumbers.Split('\n').Select(int.Parse).ToList();

            for (int i = 0; i < myNums.Count; i++)
            {
                total += list[i];
            }
            return total;
        }

        if (numbers.Contains(","))
        {
            int total = 0;
            List<int> myNums = numbers.Split(',').Select(int.Parse).ToList();
            for (int i = 0; i < myNums.Count; i++)
            {
                total += myNums[i];
            }
            return total;
        }

        if (numbers.Contains("\n"))
        {
            int total = 0;
            List<int> myNums = numbers.Split('\n').Select(int.Parse).ToList();
            for (int i = 0; i < myNums.Count; i++)
            {
                total += myNums[i];
            }
            return total;
        }



        if (numbers == "")
        {
            return 0;

        }
        else
        {
            return int.Parse(numbers);
        }
    }
}

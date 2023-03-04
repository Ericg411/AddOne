namespace AddOne;
public class Class1
{
    public int[] PlusOne(int[] digits)
    {
        if (digits[digits.Length - 1] != 9)
        {
            digits[digits.Length - 1] += 1;
            return digits;
        }
        if (digits.Length == 1)
        {
            int[] oneOff = { 1, 0 };
            return oneOff;
        }

        List<int> numList = new List<int>();

        foreach (int i in digits)
        {
            numList.Add(i);
        }

        int index = numList.Count - 1;
        while (numList[index] == 9 && index >= 0)
        {
            numList[index] = 0;
            index--;
            if (index == 0 && numList[index] == 9)
            {
                numList[index] = 1;
                numList.Add(0);
                break;
            }
            else if (index == 0 && numList[index] != 9)
            {
                numList[index] += 1;
                break;
            }
        }

        if (index != 0)
        {
            numList[index] += 1;
        }
        return numList.ToArray();
    }
}

/*
This is a code representation of an exercise where, in order to correctly identify the code to
disarm a bomb, you must utilize the number of k and add or subtract numbers to change each number
at each interval in the array.

If k is Positive, at every position in the array, you must change that number to the sum of the
next k numbers.

If k is Negative, at every position in the array, you must change that number to the sum of the
former k numbers going backwards.

If k is equal to 0, at every position in the array, you must change that number to 0.

Note: the Key Arrays are hard coded based on K being equal to 3, then - 3, then 0 in order to
correctly disarm the bomb.

*/

int[] bombDisarm = {19, 8, 13, 22, 18, 24};
int[] bombKeyPlus = {43, 53, 64, 61, 51, 40};
int[] bombKeyMinus = {64, 61, 51, 40, 43, 53};
int[] bombKeyZero = {0, 0, 0, 0, 0, 0};
int[] bombCode = {0, 0, 0, 0, 0, 0};
int k = 0;
int p = 0;

if (k > 0)
{
    for (int i = 0; i <= bombDisarm.Length - 1; i++)
    {

        for (int g = 1; g <= k; g++)
        {
            p++;
            if (p == bombDisarm.Length)
            {
                p = 0;
            }

            bombCode[i] += bombDisarm[p];
        }
        p = i + 1;    
        Console.WriteLine(bombCode[i]);
    }
        if (bombKeyPlus.SequenceEqual(bombCode))
        {
            Console.WriteLine("The bomb has been Disarmed!");
        }
        else {
            Console.WriteLine("Bomb Disarm Code Incorrect. You are now dead!");
        }
}
else if (k < 0)
{
    p = bombDisarm.Length - 1;
    for (int i = bombDisarm.Length - 1; i >= 0; i--)
    {

        for (int g = -1; g >= k; g--)
        {
            p--;
            if (p == -1)
            {
                p = bombDisarm.Length - 1;
            }

            bombCode[i] += bombDisarm[p];
        }
        p = i - 1;    
        Console.WriteLine(bombCode[i]);
    }
        if (bombKeyMinus.SequenceEqual(bombCode))
        {
            Console.WriteLine("The bomb has been Disarmed!");
        }
        else {
            Console.WriteLine("Bomb Disarm Code Incorrect. You are now dead!");
        }
}
else if (k == 0)
{
    for (int i = 0; i <= bombDisarm.Length - 1; i++)
    {
        bombCode[i] = 0;
        Console.WriteLine(bombCode[i]);
    }
        if (bombKeyZero.SequenceEqual(bombCode))
        {
            Console.WriteLine("The bomb has been Disarmed!");
        }
        else {
            Console.WriteLine("Bomb Disarm Code Incorrect. You are now dead!");
        }
}

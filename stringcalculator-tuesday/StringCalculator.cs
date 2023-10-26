
namespace StringCalculator;

public class StringCalculator
{

    public int Add(string numbers)
    {
        /*if (numbers.Contains(','))
        {
            String[] nums = numbers.Split(',');
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += int.Parse(nums[i]);
            }
            //return int.Parse(nums[0]) + int.Parse(nums[1]);
            return sum;
        }*/
        if (numbers.Contains('\n') || numbers.Contains(','))
        {
            String[] nums = numbers.Split(new Char[] { ',', '\n' });
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += int.Parse(nums[i]);
            }
            //return int.Parse(nums[0]) + int.Parse(nums[1]);
            return sum;
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

namespace Sum_Of_Two
{
    internal class Program
    {
        public int SumOfTwo(int[] nums, int SumToFind)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int result = 0;

            foreach (int value in nums)
            {
                if (dic.ContainsKey(SumToFind - value) && dic[SumToFind - value] > 0)
                {
                    dic[SumToFind - value] -= 1;

                    result++;
                    continue;
                }
                if (dic.ContainsKey(value))
                {
                    dic[value] += 1;
                }
                else
                {
                    dic.Add(value, 1);
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.SumOfTwo([1, 1, 1, 2, 3, 4, 5, 2], 2);
            Console.ReadKey();
        }
    }
}

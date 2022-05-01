using System;
using System.Collections.Generic;
using System.Linq;

namespace TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<char> encryptedMessage = input.ToCharArray().ToList();

            List<int> nums = new List<int>();

            string message = string.Empty;

            for (int i = 0; i < encryptedMessage.Count; i++)
            {
                if (char.IsDigit(encryptedMessage[i]))
                {
                    nums.Add(int.Parse(encryptedMessage[i].ToString()));
                }
            }

            encryptedMessage.RemoveAll(x => char.IsDigit(x));

            for (int i = 0; i < nums.Count; i += 2)
            {
                bool isFinished = false;

                for (int j = 0; j < nums[i]; j++)
                {
                    if (j >= encryptedMessage.Count)
                    {
                        isFinished = true;
                        break;
                    }
                    message += encryptedMessage[j];
                }

                if (isFinished)
                {
                    break;
                }
                encryptedMessage.RemoveRange(0, nums[i]);

                if (nums[i + 1] < encryptedMessage.Count)
                {
                    encryptedMessage.RemoveRange(0, nums[i + 1]);
                }
            }

            Console.WriteLine(message);
        }
    }
}

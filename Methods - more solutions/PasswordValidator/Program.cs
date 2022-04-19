using System;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            const int passwordMaxLength = 10;
            const int passwordMinLength = 6;
            const int passwordMinDigits = 2;

            string password = Console.ReadLine();

            if (IsPasswordValid(password, passwordMaxLength, passwordMinLength, passwordMinDigits))
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool IsPasswordValid(string password, int passMaxLength, int passMinLength, int passMinDigits)
        {
            bool isValid = true;

            if (!IsPasswordInRange(password, passMaxLength, passMinLength))
            {
                Console.WriteLine($"Password must be between {passMinLength} and {passMaxLength} characters");
                isValid = false;
            }

            if (!IsPasswordAlphaNumerical(password)) // alpha numerical означава да е само с букви и цифри, без специални символи
            {
                Console.WriteLine($"Password must consist only of letters and digits");
                isValid = false;
            }

            if (!IsPasswordDigitsInRange(password, passMinDigits))
            {
                Console.WriteLine($"Password must have at least {passMinDigits} digits");
                isValid = false;
            }

            return isValid;
        }

        static bool IsPasswordInRange(string password, int passMaxLength, int passMinLength)
        {
            if (password.Length >= passMinLength && password.Length <= passMaxLength)
            {
                return true;
            }

            return false;
        }

        static bool IsPasswordAlphaNumerical(string password)
        {
            foreach (char ch in password)
            {
                if (!char.IsLetterOrDigit(ch)) // тази функция проверява всеки символ дали е буква или цифра
                {
                    return false;
                }
            }

            return true;
        }

        static bool IsPasswordDigitsInRange(string password, int passMinDigits)
        {
            int digitsCount = 0; // Проверява всеки символ дали е цифра и ако е увеичава брояча с едно тъй като минималния брой в случая е 2; след тов проверяваме дали сме стигнали минималния брой и връщаме true или false
            foreach (char ch in password)
            {
                if (char.IsDigit(ch))
                {
                    digitsCount++;
                }
            }

            return digitsCount >= passMinDigits;
        }
    }
}

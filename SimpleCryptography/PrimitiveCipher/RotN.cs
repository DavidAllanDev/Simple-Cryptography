namespace SimpleCryptography.PrimitiveCipher
{
    public class RotN
    {
        internal int baseNumber = 1;

        public string Transform(string value)
        {
            char[] array = value.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                int number = array[i];

                array[i] = GetRotatedChar(number);
            }
            return new string(array);
        }

        private char GetRotatedChar(int number)
        {
            if (number >= 'a' && number <= 'z')
            {
                if (number > 'm')
                {
                    number -= baseNumber;
                }
                else
                {
                    number += baseNumber;
                }
            }
            else if (number >= 'A' && number <= 'Z')
            {
                if (number > 'M')
                {
                    number -= baseNumber;
                }
                else
                {
                    number += baseNumber;
                }
            }

            return (char)number;
        }
    }
}

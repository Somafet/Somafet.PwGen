using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Somafet.UnicodePasswordGenerator
{
    public static class PasswordGenerator
    {
        private static Random rng = new Random();

        public static string Next(int passwordLength)
        {
            if (passwordLength <= 0) throw new IndexOutOfRangeException("Invalid password length.");

            string newPassword = String.Empty;

            for (int i = 0; i < passwordLength; i++)
            {
                int block = rng.Next(0, UnicodeBlocks.Blocks.Length);
                int randomPos = rng.Next(0, UnicodeBlocks.Blocks[block].Length);
                string charCode = UnicodeBlocks.Blocks[block][randomPos];

                newPassword += charCode;
            }

            return newPassword;
        }
    }
}

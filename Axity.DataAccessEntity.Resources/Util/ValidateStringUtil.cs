using Axity.DataAccessEntity.Resources.Contansts;
using Axity.DataAccessEntity.Resources.Exceptions;
using System.Reflection;

namespace Axity.DataAccessEntity.Resources.Util
{
    public static class ValidateStringUtil
    {

        public static string MatchTwoWord(string wordFather, string wordSon)
        {
            if (!wordFather.Equals(wordSon))
            {
                return wordFather;
            }

            return wordSon;
        }

        public static bool ValidateTwoWord(string word, string wordToValidate)
        {

            if (word.Equals(wordToValidate))
            {
                return ResultValidateConstants.NOTEQUAL;
            }

            return ResultValidateConstants.AREEQUAL;
        }

        public static void ValdateWordContain(string word, string characters, string message)
        {
            if (!word.Contains(characters))
            {
                throw new BusinessException(message);
            }
        }

        public static void ValidateLengthWord(string word, int count, string message)
        {
            if (word.Length != count)
            {
                throw new BusinessException(message);
            }
        }
    }
}

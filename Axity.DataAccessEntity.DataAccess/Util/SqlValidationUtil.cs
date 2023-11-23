
namespace Axity.DataAccessEntity.DataAccess.Util
{
    using Axity.DataAccessEntity.Resources.Exceptions;
    using System.Collections.Generic;

    public static class SqlValidationUtil<T>
    {
        public static T ValidateRow(T entity, string message)
        {
            if (entity == null)
            {
                throw new NotFoundException($"El dato {message} no existe");
            }
            return entity;
        }

        public static List<T> ValidateCountRow(List<T> entity, string message)
        {
            if (entity.Count == 0)
            {
                throw new NotFoundException($"No se locaiza datos en {message}");
            }
            return entity;
        }

        public static void ValidateExist(string word, string wordToValidate)
        {
            if (word.Equals(wordToValidate, System.StringComparison.CurrentCultureIgnoreCase))
            {
                throw new BusinessException($"El dato: {word} ya se encuentra registrado");
            }
        }
    }
}

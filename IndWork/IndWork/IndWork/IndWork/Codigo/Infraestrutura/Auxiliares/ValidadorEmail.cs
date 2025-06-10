using System.Text.RegularExpressions;

namespace IndWork.Codigo.Infraestrutura.Auxiliares
{
    public class ValidadorEmail
    {
        private static readonly Regex _regex = new Regex(
            @"^[^@\s]+@[^@\s]+\.[^@\s]{2,}$",
            RegexOptions.Compiled | RegexOptions.IgnoreCase
        );

        public static bool EmailValido(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            return _regex.IsMatch(email);
        }
    }
}

using System.Linq;
using System.Text.RegularExpressions;

namespace IndWork.Codigo.Infraestrutura.Auxiliares
{
    internal class ValidadorCpf
    {
        private static readonly Regex _formatRegex =
            new Regex(@"^\d{3}\.?\d{3}\.?\d{3}\-?\d{2}$",
                      RegexOptions.Compiled);

        public static bool CpfValido(string cpf)
        {
            if (string.IsNullOrWhiteSpace(cpf))
                return false;

            if (!_formatRegex.IsMatch(cpf))
                return false;

            var digits = new string(cpf.Where(char.IsDigit).ToArray());
            if (digits.Length != 11)
                return false;

            if (Enumerable.Range(0, 10)
                          .Select(d => new string(char.Parse(d.ToString()), 11))
                          .Any(seq => seq == digits))
                return false;

            if (!ChecagemDigito(digits, length: 9, position: 9))
                return false;

            if (!ChecagemDigito(digits, length: 10, position: 10))
                return false;

            return true;
        }

        private static bool ChecagemDigito(string digits, int length, int position)
        {
            var sum = 0;
            for (int i = 0; i < length; i++)
            {
                sum += (digits[i] - '0') * (length + 1 - i);
            }

            var remainder = sum % 11;
            var expected = (remainder < 2) ? 0 : 11 - remainder;

            return (digits[position] - '0') == expected;
        }
    }
}

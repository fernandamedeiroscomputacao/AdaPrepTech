using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaPrepTech.MockInterviews.Google
{
    public class LicensePlateProblem
    {
        // You are tasked with building a system to compute license plate numbers for cars.
        // 00000 -> 99999
        // A0000 -> A9999
        // B0000 -> B9999
        // Z0000 -> Z9999
        // AA000 -> AA999

        // Let's use the english: ABCDEFGHIJKLMNOPQRSTUVWXYZ -> 26 characters

        // Função auxiliar para adicionar padding de zeros
        public string Pad(int width, char paddingChar, string value)
        {
            return value.PadLeft(width, paddingChar);
        }

        // Função principal para gerar o número da placa
        public string PlateNumber(long n)
        {
            // Se o número for menor ou igual a 99999, apenas converta para uma string com 5 dígitos
            if (n <= 99999)
            {
                return Pad(5, '0', n.ToString());
            }

            // Caso contrário, começamos a adicionar letras
            long baseValue = 99999;
            int lettersCount = 1;
            while (n > baseValue)
            {
                baseValue = baseValue * 26 + 9999;  // Vamos aumentar o intervalo da faixa com letras
                lettersCount++;
            }

            // Calcular as letras que devem aparecer no início da placa
            string result = "";
            for (int i = 0; i < lettersCount; i++)
            {
                long letterIndex = (n / (long)Math.Pow(26, lettersCount - i - 1)) % 26;
                result += (char)('A' + letterIndex);
            }

            // Agora vamos pegar o número restante para completar a parte numérica da placa
            long numberPart = n % 9999;
            result += Pad(4, '0', numberPart.ToString());

            return result;
        }
    }

}


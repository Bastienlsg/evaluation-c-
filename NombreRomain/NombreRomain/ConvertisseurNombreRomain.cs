using System.Diagnostics;

namespace NombreRomain
{
    public class ConvertisseurNombreRomain
    {
        public static string Convertir(int nombre)
        {
            return nombre switch
            {
                <= 3 => new string('I', nombre),
                4 => "IV",
                <= 8 => "V" + new string('I', nombre - 5),
                9 => "IX",
                <= 13 => "X" + new string('I', nombre - 10),
                14 => "XIV",
                <= 18 => "XV" + new string('I', nombre - 15),
                19 => "XIX",
                <= 23 => "XX" + new string('I', nombre - 20),
                24 => "XXIV",
                <= 28 => "XXV" + new string('I', nombre - 25),
                29 => "XXIX",
                _ => throw new NotImplementedException()
            };
        }
    }
}
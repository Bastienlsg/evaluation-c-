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
                <= 13 => detecteDizaine(nombre) + new string('I', nombre - 10),
                14 => detecteDizaine(nombre) + "IV",
                <= 18 => detecteDizaine(nombre) + "V" + new string('I', nombre - 15),
                19 => detecteDizaine(nombre) + "IX",
                <= 23 => detecteDizaine(nombre) + new string('I', nombre - 20),
                24 => detecteDizaine(nombre) + "IV",
                <= 28 => detecteDizaine(nombre) + "V" + new string('I', nombre - 25),
                29 => detecteDizaine(nombre) + "IX",
                <= 33 => detecteDizaine(nombre) + "V" + new string('I', nombre - 25),
                _ => throw new NotImplementedException()
            };
        }

        private static string detecteDizaine(int nombre)
        {
            if (nombre.ToString().Length > 1 && nombre < 20)
            {
                string dizaine = "X";
                return dizaine;
            }
            else
            {
                string dizaine = "XX";
                return dizaine;
            }
        }
    }
}
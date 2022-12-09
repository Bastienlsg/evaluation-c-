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
                5 => "V",
                <= 8 => "V" + new string('I', nombre-5),
                _ => throw new NotImplementedException()
            };
        }
    }
}
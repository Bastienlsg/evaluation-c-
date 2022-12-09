using System.Diagnostics;

namespace NombreRomain
{
    public class ConvertisseurNombreRomain
    {
        public static string Convertir(int nombre)
        {
            switch(nombre) {
                case 1:
                    return "I";
                case 2:
                    return "II";
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
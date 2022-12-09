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
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
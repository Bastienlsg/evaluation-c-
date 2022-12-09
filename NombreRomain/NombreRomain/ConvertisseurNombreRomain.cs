using System.Diagnostics;

namespace NombreRomain
{
    public class ConvertisseurNombreRomain
    {
        public static string Convertir(int nombre)
        {
            switch(nombre) {
                case <=3:
                    return new string('I', nombre);
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
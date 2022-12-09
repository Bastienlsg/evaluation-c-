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
                case 4:
                    return "IV";
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
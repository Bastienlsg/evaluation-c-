using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NombreRomain.Test
{
    public class NombreRomain
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void TestUnités123(int n)
        {
            // ETANT DONNE un nombre <n> compris entre 1 et 3
            // QUAND on les convertit en nombres romains
            var resultat = ConvertisseurNombreRomain.Convertir(n);

            // ALORS on obtient <n> fois 'II'
            var attendu = new string('I', n);
            Assert.Equal(attendu, resultat);
        }

        [Fact]
        public void TestUnité4()
        {
            // ETANT DONNE le nombre 4
            // QUAND on le convertit en nombre romain
            var resultat = ConvertisseurNombreRomain.Convertir(4);

            // ALORS on obtient "IV"
            var attendu = "IV";
            Assert.Equal(attendu, resultat);
        }

        [Fact]
        public void TestUnité5()
        {
            // ETANT DONNE le nombre 5
            // QUAND on le convertit en nombre romain
            var resultat = ConvertisseurNombreRomain.Convertir(5);

            // ALORS on obtient "V"
            var attendu = "V";
            Assert.Equal(attendu, resultat);
        }

        [Theory]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        public void TestUnité678(int n)
        {
            // ETANT DONNE un nombre <n> compris entre 6 et 8
            // QUAND on le convertit en nombre romain
            var resultat = ConvertisseurNombreRomain.Convertir(n);

            // ALORS on obtient "V" suivi de <n> fois 'I'
            var attendu = "V" + new string('I', n-5);
            Assert.Equal(attendu, resultat);
        }
    }
}
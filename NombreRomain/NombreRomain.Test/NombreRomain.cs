using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NombreRomain.Test
{
    public class NombreRomain
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void TestUnit�s123(int n)
        {
            // ETANT DONNE un nombre <n> compris entre 1 et 3
            // QUAND on les convertit en nombres romains
            var resultat = ConvertisseurNombreRomain.Convertir(n);

            // ALORS on obtient <n> fois 'II'
            var attendu = new string('I', n);
            Assert.Equal(attendu, resultat);
        }

        [Fact]
        public void TestUnit�4()
        {
            // ETANT DONNE le nombre 4
            // QUAND on le convertit en nombre romain
            var resultat = ConvertisseurNombreRomain.Convertir(4);

            // ALORS on obtient "IV"
            var attendu = "IV";
            Assert.Equal(attendu, resultat);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        public void TestUnit�5678(int n)
        {
            // ETANT DONNE un nombre <n> compris entre 5 et 8
            // QUAND on le convertit en nombre romain
            var resultat = ConvertisseurNombreRomain.Convertir(n);

            // ALORS on obtient "V" suivi de <n> fois 'I'
            var attendu = "V" + new string('I', n-5);
            Assert.Equal(attendu, resultat);
        }

        [Fact]
        public void TestUnit�9()
        {
            // ETANT DONNE le nombre 9
            // QUAND on le convertit en nombre romain
            var resultat = ConvertisseurNombreRomain.Convertir(9);

            // ALORS on obtient "IX"
            var attendu = "IX";
            Assert.Equal(attendu, resultat);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(11)]
        [InlineData(12)]
        [InlineData(13)]
        public void TestUnit�10111213(int n)
        {
            // ETANT DONNE un nombre <n> compris entre 10 et 13
            // QUAND on le convertit en nombre romain
            var resultat = ConvertisseurNombreRomain.Convertir(n);

            // ALORS on obtient "X" suivi de <n> fois 'I'
            var attendu = "X" + new string('I', n-10);
            Assert.Equal(attendu, resultat);
        }

        [Fact]
        public void TestUnit�14()
        {
            // ETANT DONNE le nombre 14
            // QUAND on le convertit en nombre romain
            var resultat = ConvertisseurNombreRomain.Convertir(14);

            // ALORS on obtient "XIV"
            var attendu = "XIV";
            Assert.Equal(attendu, resultat);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(16)]
        [InlineData(17)]
        [InlineData(18)]
        public void TestUnit�15161718(int n)
        {
            // ETANT DONNE un nombre <n> compris entre 15 et 18
            // QUAND on le convertit en nombre romain
            var resultat = ConvertisseurNombreRomain.Convertir(n);

            // ALORS on obtient "XV" suivi de <n> fois 'I'
            var attendu = "XV" + new string('I', n - 15);
            Assert.Equal(attendu, resultat);
        }

        [Fact]
        public void TestUnit�19()
        {
            // ETANT DONNE le nombre 19
            // QUAND on le convertit en nombre romain
            var resultat = ConvertisseurNombreRomain.Convertir(19);

            // ALORS on obtient "XIX"
            var attendu = "XIX";
            Assert.Equal(attendu, resultat);
        }
    }
}
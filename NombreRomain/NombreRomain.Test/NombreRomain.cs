namespace NombreRomain.Test
{
    public class NombreRomain
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        public void TestUnités(int n)
        {
            // ETANT DONNE un nombre <n> compris entre 1 et 3
            // QUAND on le convertit en nombres romains
            var resultat = ConvertisseurNombreRomain.Convertir(n);

            // ALORS on obtient <n> fois 'II'
            var attendu = new string('I', n);
            Assert.Equal(attendu, resultat);
        }
    }
}
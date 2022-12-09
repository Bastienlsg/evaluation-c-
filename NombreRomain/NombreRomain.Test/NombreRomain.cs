namespace NombreRomain.Test
{
    public class NombreRomain
    {
        [Fact]
        public void TestUnités()
        {
            // ETANT DONNE le nombre 1
            // QUAND on le convertit en nombre romain
            var resultat = ConvertisseurNombreRomain.Convertir(1);

            // ALORS on obtient une fois 'I'
            var attendu = new string('I', 1);
            Assert.Equal(attendu, resultat);
        }
    }
}
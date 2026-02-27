namespace POOAnimal
{
    internal class Cachorro(string nomePopular, string genero, string especie) : 
        Animal(nomePopular, genero, especie)
    {

        public string EmitirSom()
        {
            return "Au-au...";
        }

    }
}

namespace POOAnimal
{
    internal class Gato(string nomePopular, string genero, string especie) : 
        Animal(nomePopular, genero, especie)
    {

        public string EmitirSom()
        {
            return "Miau...";
        }

    }
}

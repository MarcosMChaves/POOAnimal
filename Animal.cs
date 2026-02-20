using System.Text.RegularExpressions;

namespace POOAnimal
{
    internal class Animal
    {
        private string NomePopular;
        private string Genero;
        private string Especie;

        public Animal(string nomePopular, string genero, string especie)
        {
            if (!(EhValido(nomePopular) && EhValido(genero) && EhValido(especie)))
            {
                throw new ArgumentException("Argumentos com conteúdo inválido!");
            }
            NomePopular = Sanitizar(nomePopular.ToLower());
            Genero = Sanitizar(genero.Substring(0,1).ToUpper() + genero.Substring(1).ToLower());
            Especie = Sanitizar(especie.ToLower());
        }

        private bool EhValido(string textToValidade)
        {
            if (String.IsNullOrWhiteSpace(textToValidade) || 
                String.IsNullOrEmpty(textToValidade))
            {
                return false;                
            }

            return true;
        }
        private string Sanitizar(string textToSanitize)
        {
            string patternA = @"[!#$%¨&*()_+=`´^~{}:;><,|\/?'0-9]";
            // Remove símbolos/dígitos da string
            textToSanitize = Regex.Replace(textToSanitize, patternA, String.Empty);

            string patternB = @"(^\W+)|(\W+$)"; 
            // Remove símbolos do início e fim da string
            return Regex.Replace(textToSanitize, patternB, String.Empty).Replace("spp","spp.").Trim();

        }
        public string GetNomePopular()
        {
            return NomePopular;
        }
        public string GetNomeCientifico()
        {
            return Genero + " " + Especie;
        }

        public string EmitirSom()
        {
            return "rrrrr..."; 
        }
    }
}

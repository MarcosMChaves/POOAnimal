using static System.Console;
using POOAnimal;

const string ITALICS = "\u001b[3m";
const string RESET = "\u001b[0m";


Gato romeo = new Gato("Gato-Comum.1", "Fe%lis", "Catus32&# spp.");

WriteLine($"Nome popular= {romeo.GetNomePopular()}");
Write($"Nome científico= '");
ForegroundColor = ConsoleColor.Blue;
Write($"{ITALICS}{romeo.GetNomeCientifico()}{RESET}");
ResetColor();
WriteLine($"'");
WriteLine($"o gato está bravo '{romeo.EmitirSom()}'");

Cachorro caramelo = new Cachorro("vira-lata", "Canis ", "lupus familiaris");

WriteLine($"Nome popular= {caramelo.GetNomePopular()}");
Write($"Nome científico= '");
ForegroundColor = ConsoleColor.Blue;
Write($"{ITALICS}{caramelo.GetNomeCientifico()}{RESET}");
ResetColor();
WriteLine($"'");
WriteLine($"o cão está bravo '{caramelo.EmitirSom()}'");

Animal minhoca = new Animal("minhocuçu", "Rhinodrilus", "alatus");

WriteLine($"Nome popular= {minhoca.GetNomePopular()}");
Write($"Nome científico= '");
ForegroundColor = ConsoleColor.Blue;
Write($"{ITALICS}{minhoca.GetNomeCientifico()}{RESET}");
ResetColor();
WriteLine($"'");
WriteLine($"a minhoca está brava '{minhoca.EmitirSom()}'");

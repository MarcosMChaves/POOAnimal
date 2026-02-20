using static System.Console;
using POOAnimal;

const string ITALICS = "\u001b[3m";
const string RESET = "\u001b[0m";


Animal gato = new Animal("Gato-Comum.1", "Fe%lis", "Catus32&# spp.");

WriteLine($"Nome popular= {gato.GetNomePopular()}");
Write($"Nome científico= '");
ForegroundColor = ConsoleColor.Blue;
Write($"{ITALICS}{gato.GetNomeCientifico()}{RESET}");
ResetColor();
WriteLine($"'");
WriteLine($"o gato está bravo '{gato.EmitirSom()}'");


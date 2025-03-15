Console.Clear();
string nomeDaPessoa;
string sobrenome;
string seriefavorita;
string genero;

Console.WriteLine("Escreva o seu nome");

 Console.Write("nome:"); 
 nomeDaPessoa= Console.ReadLine()!;
 Console.Write("sobrenome:");
sobrenome= Console.ReadLine()!;

Console.WriteLine($"Ola {nomeDaPessoa.ToUpper()} {sobrenome.ToUpper()}"!);
Console .WriteLine();
Console .WriteLine(@"coloque um nome de uma serie que goste ");

Console .WriteLine();
Console.ForegroundColor= ConsoleColor.Blue;
Console.Write("Serie Favorita: ");
Console.ResetColor();

seriefavorita= Console.ReadLine()! .Replace("a","@") .Replace("e","#");
Console.ForegroundColor= ConsoleColor.Blue;
Console.Write("Genero: ");
Console.ResetColor();

genero= Console.ReadLine()! .Replace("a","@") .Replace("e","#");
Console.WriteLine();
Console.Write($"A sua serie favorita é:{seriefavorita} /e o genero é: {genero}");

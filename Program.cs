
Console.Write("Insira sua altura.............. ");
string alturaImput = Console.ReadLine();
double altura = double.Parse(alturaImput);
Console.Write("Insira seu sexo.................");
string sexo = Console.ReadLine();

double pesoIdeal;

if (sexo.ToUpper() == "M")
{
pesoIdeal = altura * 72.7 - 58.0;
Console.WriteLine($"Seu peso ideal é {pesoIdeal:F1}Kg"); 

}
else if (sexo.ToUpper() == "F")
{
pesoIdeal = altura * 62.1 - 44.7;
Console.WriteLine($"Seu peso ideal é {pesoIdeal:F1}Kg"); 
}
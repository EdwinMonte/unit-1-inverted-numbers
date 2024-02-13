int num, aux, centena, dec, uni;
int uni2, dec2, aux2;
string linea;
Console.WriteLine("Enter your three-digit number");
linea = Console.ReadLine();
num = int.Parse(linea);
centena = num / 100;
dec = num % 100;
dec2 = dec / 10;
uni2 = dec % 10;
aux2 = (uni2 * 10) + dec2;
aux = (aux2 * 10) + centena;
Console.WriteLine("The inverted three-digit number is : " + aux);

Console.ReadKey();

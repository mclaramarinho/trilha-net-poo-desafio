using DesafioPOO.Models;


// (string numero, string modelo, string imei, int memoria)


Nokia n1 = new Nokia("(33) 2241-7527", "Nokia G42", "352069110084190", 250);
Nokia n2 = new Nokia("(81) 2411-9462", "Nokia Tijolo", "307575960624956", 5);

Iphone ip1 = new Iphone("(13) 3011-6035", "iPhone de Botao", "917260449280215", 64);
Iphone ip2 = new Iphone("(14) 3874-6108", "iPhone Normal", "502161739107418", 250);

ip1.InstalarAplicativo("BetNacional");
ip2.InstalarAplicativo("Tinder");
n1.InstalarAplicativo("PetZ");
n2.InstalarAplicativo("Facebook");

Console.WriteLine(n1.Numero);
n1.ReceberLigacao();
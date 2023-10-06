Console.WriteLine("Vyberte: 1 - mocnina, odmocnina; 2  - +,-,/,*");
int operace = Convert.ToInt32(Console.ReadLine());
if (operace == 1) 
{
    Console.WriteLine("Zadejte číslo");
    int o = Convert.ToInt32(Console.ReadLine());
    int ans1 = 1;
    
    Console.WriteLine("Vyber si operaci(mocnina, odmocnina)");
    string symb1 = Console.ReadLine();
    switch (symb1)
    {
        case "mocnina":
            Console.WriteLine("kolikátá mocnina");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int x = 0; x < n; x++)
            {
                ans1 = ans1 * o;
            }
            Console.WriteLine("Vysledek:" + ans1);
            break;
        case "odmocnina":
            {
                
                double r = 1;
                int i = 0;
                //Babylonská metoda výpočtu odmocnin
                while (true)
                {
                    i = i + 1;
                    r = (o / r + r) / 2;
                    if (i == o + 1)
                    {
                        break;
                    }
                }
                Console.WriteLine("Vysledek: " + r);

                
            }
            break;








        default:
            Console.WriteLine("Neplatné");
            break;
    }
}
else
{
    Console.WriteLine("První číslo:");
    int n1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Druhý číslo");
    int n2 = Convert.ToInt32(Console.ReadLine());
    int ans = 0;

    Console.WriteLine("Vyber si operaci(+,-,/,*)");
    string symb = Console.ReadLine();
    switch (symb)
    {
        case "+":
            ans = n1 + n2;
            Console.WriteLine("Vysledek:" + ans);
            break;
        case "-":
            ans = n1 - n2;
            Console.WriteLine("Vysledek:" + ans);
            break;
        case "*":
            ans = n1 * n2;
            Console.WriteLine("Vysledek:" + ans);
            break;
        case "/":
            ans = n1 / n2;
            Console.WriteLine("Vysledek:" + ans);
            break;
        
            



        default:
            Console.WriteLine("Neplatné");
            break;

    }







}
Console.ReadKey();

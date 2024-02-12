using System.Text.RegularExpressions;

bool correcte = false;
string[] productesBotiga = null; //Nom productes
double[] preusArray = new double[0]; // Preus dels prodcutes
int[] nElemBotiga = new int[2]; // Numero Elements de prodcutes

while (!correcte)
{
    Console.WriteLine("+--------------------------------+");
    Console.WriteLine("|          Que farem?            |");
    Console.WriteLine("+--------------------------------+");
    Console.WriteLine("| 1. Botiga                      |");
    Console.WriteLine("| 2. Cistella                    |");
    Console.WriteLine("| 3. Sortir                      |");
    Console.WriteLine("+--------------------------------+");
    int num = Int32.Parse(Console.ReadLine());
    Console.Clear();
    switch (num)
    {
        case 1:
            BotigaMenu(correcte, nElemBotiga, preusArray, productesBotiga);
            TornarMenu();
            break;
        case 2:

            break;
        case 3:
            correcte = true;
            break;
    }
}
static int TornarMenu()
{
    for (int i = 5; i > 0; i--)
    {
        Console.Write("\r" + "Tornant al menú: " + i + "s");
        Thread.Sleep(1000);
    }
    Console.Clear();
    return 0;
}
static bool BotigaMenu(bool correcte, int[] nElemBotiga, double[] preusArray, string[] productesBotiga)
{
    Console.WriteLine("+-----------------------------------------------------+");
    Console.WriteLine("|               Benvolgut a la botiga                 |");
    Console.WriteLine("+-----------------------------------------------------+");
    Console.WriteLine("| 1. Afegir producte                                  |");
    Console.WriteLine("| 2. Ampliar botiga                                   |");
    Console.WriteLine("| 3. Modificar preu                                   |");
    Console.WriteLine("| 4. Modificar producte                               |");
    Console.WriteLine("| 5. Ordenar productes                                |");
    Console.WriteLine("| 6. Ordenar preus                                    |");
    Console.WriteLine("| 7. Mostrar Productes                                |");
    Console.WriteLine("| 8. Mostra Detallada                                 |");
    Console.WriteLine("| 9. Tornar menú                                      |");
    Console.WriteLine("| 10. Sortir                                          |");
    Console.WriteLine("+-----------------------------------------------------+");
    int num = Int32.Parse(Console.ReadLine());
    switch (num)
    {
        case 1:
            Console.WriteLine("Quin prodcute vols afegir?");
            string producte = Console.ReadLine();
            Console.WriteLine("Preu per unitat del producte?");
            double preu = Double.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("El preu és incorrecte...");
                preu = Double.Parse(Console.ReadLine());

            } while (!PreuCorrecte(preu));
            if (nElemBotiga.Length > preusArray.Length)
            {

            }
            else if (nElemBotiga.Length <= preusArray.Length)
            {
                Console.WriteLine("Tenim la botiga plena, vols ampliarla? (s/n)");
                string sino = Console.ReadLine();
                if (sino == "s")
                {
                    OnColocar(nElemBotiga, preusArray, productesBotiga);
                }
            }
            break;
    }
    return correcte;
}
static bool PreuCorrecte(double preu)
{
    string patro = @"^\$?\d+(\.\d{1,2})?$";
    string preuString = preu.ToString();
    return Regex.IsMatch(patro, preuString);
}
static int OnColocar(int[] nElemBotiga, double[] preusArray, string[] productesBotiga)
{
    int posicio = 0;
    for (int i = 0; i >= nElemBotiga.Length; i++)
    {
        if (preusArray[i] == 0.00)
        {
            posicio = i;
            i = nElemBotiga.Length;
        }
    }
    return posicio;
}
static bool CistellaMenu(bool correcte)
{
    Console.WriteLine("+-----------------------------------------------------+");
    Console.WriteLine("|              Benvolgut a la cistella                |");
    Console.WriteLine("+-----------------------------------------------------+");
    Console.WriteLine("| 1. Afegir Productes                                 |");
    Console.WriteLine("| 2. Comprar Producte                                 |");
    Console.WriteLine("| 3. Ordenar Cistella                                 |");
    Console.WriteLine("| 4. Mostrar Cistella                                 |");
    Console.WriteLine("| 5. Mostrar Productes                                |");
    Console.WriteLine("| 6. Tiquet                                           |");
    Console.WriteLine("| 7. Tornar menú                                      |");
    Console.WriteLine("| 8. Sortir                                           |");
    Console.WriteLine("+-----------------------------------------------------+");
    int num = Int32.Parse(Console.ReadLine());
    switch (num)
    {
        case 1:

            break;
    }
    return correcte;
}
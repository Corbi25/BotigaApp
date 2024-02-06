bool correcte = false;
string[] productesBotiga = null;
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
    switch (num)
    {
        case 1:
            BotigaMenu(correcte);
            TornarMenu();
            break;
        case 2:

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
static bool BotigaMenu(bool correcte)
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

            break;
    }
    return correcte;
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
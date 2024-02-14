using System.Text.RegularExpressions;
using System.Threading.Channels; //Regex

bool correcte = false;
string[] productesBotiga = { "null", "null" }; //Nom productes
double[] preusArray = new double[2]; // Preus dels prodcutes
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
            BotigaMenu(ref correcte, ref nElemBotiga, ref preusArray, ref productesBotiga);
            TornarMenu();
            break;
        case 2:
            CistellaMenu(correcte);
            TornarMenu();
            break;
        case 3:
            correcte = true;
            Console.Clear();
            Console.WriteLine("Adeu, Adeu");
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
static bool BotigaMenu(ref bool correcte, ref int[] nElemBotiga, ref double[] preusArray, ref string[] productesBotiga)
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
            bool trobat = false;
            int j = 0;
            for (int i = 0; i <= nElemBotiga.Length - 1; i++)
            {
                int posicio = 0;
                if (preusArray[i] == 0.00)
                {
                    posicio = i + 1;
                    Console.WriteLine("Aqui tenim al lloc " + posicio + " de " + nElemBotiga.Length + " per a colocar a la botiga");
                    preusArray[i] = preu;
                    productesBotiga[i] = producte;
                    i = nElemBotiga.Length;
                    trobat = true;
                }
                else
                {
                    posicio = i + 1;
                    Console.WriteLine("Posicio " + posicio + " de " + nElemBotiga.Length + " ocupada...");
                    j++;
                }
                if (trobat == false && j == nElemBotiga.Length)
                {
                    Console.WriteLine("Tenim la botiga plena, anem a ampliarla!");
                    AmpliarBotiga(ref nElemBotiga, ref preusArray, ref productesBotiga);
                }
            }
            break;
        case 2:
            AmpliarBotiga(ref nElemBotiga, ref preusArray, ref productesBotiga);
            break;
        case 3:
            CambiarPreu(ref preusArray, ref productesBotiga);
            break;
        case 4:
            CambiarProducte(ref productesBotiga);
            break;
        case 5:

            break;
        case 6:

            break;
        case 7:
            MostrarElements(ref nElemBotiga, ref preusArray, ref productesBotiga);
            break;
        case 8:

            break;
        case 9:
            TornarMenu();
            break;
        case 10:
            correcte = true;
            break;
    }
    return correcte;
}
static int OnColocar(ref int[] nElemBotiga, ref double[] preusArray, ref string[] productesBotiga)
{
    int posicio = 0;
    for (int i = 0; i < nElemBotiga.Length; i++)
    {
        if (preusArray[i] == 00.00)
        {
            posicio = i;
            i = nElemBotiga.Length;
        }
    }
    return posicio;
}
static void MostrarElements(ref int[] nElemBotiga, ref double[] preusArray, ref string[] productesBotiga)
{
    for (int i = 0; i < nElemBotiga.Length; i++)
    {
        int posicio = i + 1;
        Console.WriteLine("\r");
        Console.WriteLine("+------------------------------------------------------------------------------------------+");
        Console.WriteLine("|                                                                                          |");
        Console.WriteLine("             Posició " + posicio + " de " + nElemBotiga.Length + " amb el producte " + productesBotiga[i]);
        Console.WriteLine("             Posició " + posicio + " de " + nElemBotiga.Length + " amb el preu " + preusArray[i]);
        Console.WriteLine("|                                                                                          |");
        Console.WriteLine("+------------------------------------------------------------------------------------------+");
    }
}
static void CambiarPreu(ref double[] preusArray, ref string[] productesBotiga)
{
    Console.WriteLine("Quin producte vols editar el preu?");
    string prodcute = Console.ReadLine();
    Console.WriteLine("Quin preu vols ara?");
    double nouPreu = Double.Parse(Console.ReadLine());
    bool trobat = false;
    for (int i = 0; i < productesBotiga.Length; i++)
    {
        if (productesBotiga[i] == prodcute)
        {
            Console.WriteLine("Producte trobat!");
            preusArray[i] = nouPreu;
            trobat = true;
        }
        else if (i == productesBotiga.Length - 1 && trobat == false)
        {
            Console.WriteLine("No tenim l'article " + prodcute);
            Console.WriteLine("Vols tornar a buscar? (s/n)");
            string sino = Console.ReadLine();
            if (sino == "s")
            {
                CambiarPreu(ref preusArray, ref productesBotiga);
            }
            else
            {
                i = productesBotiga.Length;
            }
        }
    }
}
static void CambiarProducte(ref string[] productesBotiga)
{
    Console.WriteLine("Quin producte vols cambiar el nom?");
    string prodcute = Console.ReadLine();
    bool trobat = false;
    for (int i = 0; i < productesBotiga.Length; i++)
    {
        if (productesBotiga[i] == prodcute)
        {
            Console.WriteLine("Producte trobat!");
            Console.WriteLine("Ara donam el nou nom del producte " + prodcute);
            prodcute = Console.ReadLine();
            productesBotiga[i] = prodcute;
            Console.WriteLine("Fet!");
            trobat = true;
        }
        else if (i == productesBotiga.Length - 1 && trobat == false)
        {
            Console.WriteLine("No tenim l'article " + prodcute);
            Console.WriteLine("Vols tornar a buscar? (s/n)");
            string sino = Console.ReadLine();
            if (sino == "s")
            {
                CambiarProducte(ref productesBotiga);
            }
            else
            {
                i = productesBotiga.Length;
            }
        }

    }
}
static void AmpliarBotiga(ref int[] nElemBotiga, ref double[] preusArray, ref string[] productesBotiga)
{
    Console.WriteLine("Quants llocs vols ampliar la tenda? ");
    int ampliarBotiga = Int32.Parse(Console.ReadLine());

    int[] aux = new int[ampliarBotiga + nElemBotiga.Length]; //Nou array amb el tamany actualitzat
    Array.Copy(nElemBotiga, aux, nElemBotiga.Length); //Copia del array al nou array amb la mida que volgem en aquest cas amb la mida del array antic
    nElemBotiga = aux; // ara ja que preusArray va amb referencia li diem que aux el nou array és igual a el array "antic"

    double[] aux2 = new double[ampliarBotiga + preusArray.Length];
    Array.Copy(preusArray, aux2, preusArray.Length);
    preusArray = aux2;

    string[] aux3 = new string[ampliarBotiga + productesBotiga.Length];
    Array.Copy(productesBotiga, aux3, productesBotiga.Length);
    productesBotiga = aux3;
    Console.WriteLine("Ara la amplada de la botiga es de " + preusArray.Length + " posicions!");
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
        case 2:

            break;
        case 3:

            break;
        case 4:

            break;
        case 5:

            break;
        case 6:

            break;
        case 7:
            TornarMenu();
            break;
        case 8:
            correcte = true;
            break;
    }
    return correcte;
}
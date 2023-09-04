/*  Operander
    
    ----------------------------------------------- 
    ==      lika med
    !=      inte lika med
    <       mindre än
    >       större än
    <=      mindre eller lika med
    >=      större eller lika med
    &&      och
    ||      eller
    !       inte                                            < (mac opt + 7)
    ??      om första värdet är null välj det andra
  
*/

/*  Arrays
    ------------------------------------------------
    En array är en statisk lista med fixerat antal platser som 
    man varken kan lägga till nya eller ta bort men det går att
    byta ut informationen i en specifik plats.

    string[] names = new string[] { "Hans", "Tommy", "Joakim", "Jeanette" };
    string[] names = new string[10];
    names[0] = "Hans";
    names[4] = "Tommy";
    names[9] = "Anki";
 */

/*  IF-Satser
    --------------------------------------------------
    if (statment) {}

    if (statement) {} else {}

    if (statement) {} else if (statement) {} else {}

    (statement) ? do_this : else_do_this;



    string firstName = "Hans";
    string lastName = null!;

    if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
    {
        Console.WriteLine("Något utav värdena är inte ifyllda.");
    }


    string firstName = "Hans";

    if (!string.IsNullOrEmpty(firstName))
    {
        Console.WriteLine("Nu gör vi någonting med förnamnet");
    }
    else
    {
        Console.WriteLine("Det finns inget förnamn");
    }



    string key = "blue";

    if (key == "blue")
    {
        Console.WriteLine("Unlock blue door");
    }
    else if (key == "orange")
    {
        Console.WriteLine("Unlock orange door");
    }
    else if (key == "gray")
    {
        Console.WriteLine("Unlock gray door");
    }
    else
    {
        Console.WriteLine("Go through white door");
    }



*/

/*  SWITCH  
    ----------------------------------------------------------------------------------------------
    string key = "black";

    switch (key)
    {
        case "blue":
            Console.WriteLine("Unlock blue door");
            break;

        case "orange":
            Console.WriteLine("Unlock orange door");
            break;

        case "gray":
            Console.WriteLine("Unlock gray door");
            break;

        default:
            Console.WriteLine("Go through white door");
            break;
    }
*/

/*  FOR-LOOP  
    ----------------------------------------------------------------------------------------
    Vi loopar igenom en lista eller gör något ett givet antal gånger    

    for (initialize value; condition; increment inizialized value)    
    {
    }

    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"i: {i}");
    }

    string[] names = new string[] { "Hans", "Tommy", "Joakim", "Jeanette" };

    names[2] = "Stina";

    for (int i = 0; i < names.Length; i++)
    {
        Console.WriteLine(names[i]);
    }
*/

/*  FOREACH-LOOP  
    ----------------------------------------------------------------------------------------
    Vi loopar igenom alla objekt i en lista    
    
    foreach (var object in list) 
    {
    }

    string[] names = new string[] { "Hans", "Tommy", "Joakim", "Jeanette" };

    names[2] = "Stina";

    foreach(var name in names)
    {
        Console.WriteLine(name);
    }
    
*/

/*  WHILE-LOOP
    ----------------------------------------------------------
    gör en sak om och om igen tills ett tillstånd är uppnått.
    Varav kontrollen sker i början.
   
    while (statement)
    {
    }


    int number = 0;
    while (number < 10)
    {
        Console.WriteLine(number);
        number++;
    }

    i++     gör något sen ökar med 1
    i--     gör något sen minska med 1
    ++i     öka med 1 och sedan gör något
    --i     minska med 1 och sedan gör något
 
 
 */

/* DO-WHILE LOOP  
   -------------------------------------------------------
   gör loopen minst en gång sedan kollar den tillståndet 

    do
    {
    } while (statement);

    int number = 0;

    do
    {
        Console.WriteLine(number);
        number++;

    } while (number < 10);

*/


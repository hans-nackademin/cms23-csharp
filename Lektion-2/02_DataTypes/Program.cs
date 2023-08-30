/* 
    C# standard datatyper som används
    -------------------------------------------------------------------------------------
   * string              till för text               string name = "Hans";
   * int                 till för heltal             int age = 39;
     long                till för heltal             long age = 39;
   * decimal             till för decimaltal         decimal length = 164.5m;
     double              till för decimaltal         double length = 164.5;
     float               till för decimaltal         float length = 165.6f;
   * bool                till för sant/falskt        bool isHuman = true;
     char                till för enskilt tecken     char gender = 'M';
     dynamic             kan innehålla vad som       dynamic lastName = "Mattin-Lassei";
                                                    dynamic weight = 90.0;
   * Guid                globalt unikt id            Guid id = Guid.NewGuid();
     byte                                            
   * null                är ingenting alls           
     object
*/

/* 
    Deklarera variabler i C#
    -------------------------------------------------------------------------------------
    Hur skriver vi variabel namn:
    
    camelCase               firstName               string firstName = "Hans";
    Pascal                  FirstName               string FirstName = "Hans";
    kebab-case              first-name              string first-name = "Hans";
    snake_case              first_name              string first_name = "Hans";

    C# använder sig primärt av Pascal men även camelCase

    korrekt sätt att deklarera:             string firstName = "Hans";
    latmanssättet att deklarera:            var firstName = "Hans";
    
*/

/*  
    STRING - textbaserade värden
    ------------------------------------------------------------------------------------------
    
    string firstName = "Hans";
    var lastName = "Mattin-Lassei";

    string sentence_1 = "Jag heter Hans och jag är bäst.";
    string sentence_2 = "Jag heter Hans och jag är \"bäst\".";
    string sentence_3 = "Jag heter Hans och jag är 'bäst'.";

    string url_1 = "c:\\education\\cms23-csharp";
    string url_2 = @"c:\education\cms23-csharp";

    string placeholder_1 = "Hej jag heter " + firstName + " " + lastName + ".";
    string placeholder_2 = $"Hej jag heter {firstName} {lastName}.";
    string placeholder_3 = string.Format("Hej jag heter {0} {1}.", firstName, lastName);

 */

Console.Write("Skriv ditt förnamn: ");
string firstName = Console.ReadLine() ?? "";

Console.Write("Skriv ditt efternamn: ");
string lastName = Console.ReadLine() ?? string.Empty;

Console.WriteLine($"Hej {firstName} {lastName}.");
Console.ReadKey();

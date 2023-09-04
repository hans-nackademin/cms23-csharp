/* String - till för text

    string firstName = "Hans";
    var lastName = "Mattin-Lassei";

    string sentence = "Jag är \"Bäst\" i hela världen";

    string uri_1 = "c:\\users\\hans\\document";
    string uri_2 = @"c:\users\hans\document";

    string placeholder_1 = "Hej jag heter " + firstName + " " + lastName + ".";
    string placeholder_2 = $"Hej jag heter {firstName} {lastName}.";
    string placeholder_3 = string.Format("Hej jag heter {0} {1}.", firstName, lastName);

    string email = "Hans.Mattin-Lassei@domain.com";
    Console.WriteLine($"Original: {email}");
    Console.WriteLine($"ToUpper: {email.ToUpper()}");
    Console.WriteLine($"ToLower: {email.ToLower()}");
    Console.WriteLine();


    string firstName = "Hans ";
    string lastName = "Mattin-Lassei";
    Console.WriteLine($"{firstName} {lastName}");
    Console.WriteLine($"{firstName.Trim()} {lastName.Trim()}");
    Console.WriteLine();

    string sentence = "Här har vi en text som är på svenska.";
    Console.WriteLine(sentence.Replace("ä", "a"));
    Console.WriteLine();

    string name = "Hans Mattin-Lassei";
    string domain = "domain.com";
    string emailaddress = $"{name}@{domain}";
    Console.WriteLine(emailaddress);

    emailaddress = emailaddress.Replace(" ", ".").ToLower();
    Console.WriteLine(emailaddress);
*/

/*  
    INTEGRALS & FLOATING PONTS
    -----------------------------------------------------------------------------------
    
        Type        Bits        RANGE (min, max)
        ---------------------------------------------------------------
      * byte        8           0                       255
        sbyte       8           -128                    127
        short       16          -32768                  32767
        ushort      16          0                       65535
      * int         32          -2147483648             2147483647
        uint        32          0                       4294967295
      * long        64          -9223372036854775808    9223372036854775807
        ulong       64          0                       18446744073709551615

        int age = 39;        
        long age = 39;



        Type        Bytes       DECIMAL RANGE       SUFFIX
        --------------------------------------------------------------
        float       4           6-9 digits          f eller F
        double      8           15-16 digits        inget eller d eller D    
      * decimal     16          28-29 digits        m eller M      
 

        float floatValue = 0.1f + 0.1f + 0.1f;      // 0.3
        Console.WriteLine(floatValue);

        double doubleValue = 0.1 + 0.1 + 0.1;       // 0.300000000004 ish
        Console.WriteLine(doubleValue); 

        decimal decimalValue = 0.1m + 0.1m + 0.1m;
        Console.WriteLine(decimalValue);

        float = 1.123456789f;
        double = 1.123456789012345;
        decimal = 1.1234567890123456789012345678m;
*/

/*  
    BOOLEAN - Sant/falskt 

    TYPE                    Bits            
    -------------------------------------------------------------------------------------------------------
    bool                    0/1             false/true
    
    bool isEnabled = false;
    bool isActive = true;

*/

/*  
    GUID/UUID (Globally Unique Identifier)
    ------------------------------------------------------------------------------------------------------
    Guid            16 bytes            Guid.NewGuid();             8428f0a1-129e-4c57-a5aa-461bfd15da84   
 

    Guid userId = Guid.NewGuid();
    Console.WriteLine(userId);
*/


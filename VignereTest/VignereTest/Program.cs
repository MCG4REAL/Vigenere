using System;
using System.Text;
/*
namespace VignereTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = "Lorom ipsum dolor";

            Console.WriteLine(Vigenere(inputText));
        }
        static string Vigenere(string inputText)
        {
            string key = "Theophil";
            

            byte[] inputBytes = Encoding.ASCII.GetBytes(inputText); //Wandel die inputText Buchstaben in eine Liste an Bytes um
            byte[] keyBytes = Encoding.ASCII.GetBytes(key);     //Wandel die key Buchstaben in eine Liste an Bytes um

            int keyIndex = 0;
            for (int inputBytesIndex = 0; inputBytesIndex < inputBytes.Length; inputBytesIndex++)    //Durch alle Bytes durchgehen
            {
                inputBytes[inputBytesIndex] = (byte)(inputBytes[inputBytesIndex] + keyBytes[keyIndex]);    //Bytes um Key verschieben

                if (inputBytes[inputBytesIndex] > 127) //Wenn das Ergebnis größer als 127 ist, bei 32 wieder neu anfangen
                {
                    inputBytes[inputBytesIndex] -= 127 + 32;
                }
                if (keyIndex == keyBytes.Length - 1) //Wenn das Ende des Keys erreicht ist, wieder von vorne neu starten
                {
                    keyIndex = 0;
                }
                else
                {
                    keyIndex++;
                }
            }
        return Encoding.ASCII.GetString(inputBytes);
        }
    }
}
*/
Console.WriteLine("Geben sie den zu verschlüsselden Text ein: ");
string klartext = Console.ReadLine();

Console.WriteLine("Geben Sie den Schlüssel ein: ");
string schlüssel = Console.ReadLine();
int mal= 1; 
(string, string, int) text = VigenereVerschlüsseln(klartext, schlüssel, mal);
Console.WriteLine("Der verschlüsselte Text: " + text.Item1);
mal = -1;
(string, string, int) txt = VigenereVerschlüsseln(klartext, schlüssel, mal);
//string entschlüsselt = VigenereEntschlüsseln(verschlüsselt, schlüssel);
Console.WriteLine("Der entschlüsselte Text: " + text.Item2 + "\nEs ist mal " + text.Item3);

static (string, string, int) VigenereVerschlüsseln(string klartext, string schlüssel, int mal)
{
    StringBuilder verschlüsselText = new StringBuilder();
   

    int schlüsselIndex = 0;
    
    for (int i = 0; i < klartext.Length; i++)
    {
        char character = klartext[i];
        char schlüsselChar = schlüssel[schlüsselIndex];
 
        if (32 <= character && character <= 127)
        {
            int shift = (schlüsselChar + 32) % 96;

            char verschlüsselChar = (char)(((character - 32 + shift *mal) % 96) + 32);

            verschlüsselText.Append(verschlüsselChar);
          
            schlüsselIndex = (schlüsselIndex + 1) % schlüssel.Length;
        }
        else
        {
            verschlüsselText.Append(character);
        }

    }

    string verschlüsselt = verschlüsselText.ToString();
    StringBuilder entschlüsselText = new StringBuilder();
            entschlüsselText.Append(klartext);

    return (verschlüsselt, klartext.ToString(),mal);
}

    //schlüsselIndex = 0;

    //for (int i = 0; i < verschlüsselt.Length; i++)
   // {
     //   char character = verschlüsselt[i];
       // char schlüsselChar = schlüssel[schlüsselIndex];

       // if (32 <= character && character <= 127)
        //{
            //int shift = ((schlüsselChar - 32) % 96);

            //char entschlüsselChar = (char)(((character - 32 - shift + 96) % 96) + 32);


        //    schlüsselIndex = (schlüsselIndex + 1) % schlüssel.Length;
       // }
       // else
        //{
            //entschlüsselText.Append(character);
        //}

   // }

/*Console.WriteLine("Geben sie den zu verschlüsselden Text ein: ");
string klartext = Console.ReadLine();

Console.WriteLine("Geben Sie den Schlüssel ein: ");
string schlüssel = Console.ReadLine();

string verschlüsselt = VigenereVerschlüsseln(klartext, schlüssel);
Console.WriteLine("Der verschlüsselte Text: " + verschlüsselt);

string entschlüsselt = VigenereEntschlüsseln(verschlüsselt, schlüssel);
Console.WriteLine("Der entschlüsselte Text: " + entschlüsselt);

static string VigenereVerschlüsseln(string klartext, string schlüssel)
{
    StringBuilder verschlüsselText = new StringBuilder();

    int schlüsselIndex = 0;

    for (int i = 0; i < klartext.Length; i++)
    {
        char character = klartext[i];
        char schlüsselChar = schlüssel[schlüsselIndex];

        if (32 <= character && character <= 127)
        {
            int shift = (schlüsselChar - 32) % 96;

            char verschlüsselChar = (char)(((character - 32 + shift) % 96) + 32);

            verschlüsselText.Append(verschlüsselChar);

            schlüsselIndex = (schlüsselIndex + 1) % schlüssel.Length;
        }
        else
        {
            verschlüsselText.Append(character);
        }

    }

    return verschlüsselText.ToString();
}

static string VigenereEntschlüsseln(string verschlüsseltext, string schlüssel)
{
    StringBuilder entschlüsselText = new StringBuilder();


    int schlüsselIndex = 0;

    for (int i = 0; i < verschlüsseltext.Length; i++)
    {
        char character = verschlüsseltext[i];
        char schlüsselChar = schlüssel[schlüsselIndex];

        if (32 <= character && character <= 127)
        {
            int shift = ((schlüsselChar - 32) % 96);

            char entschlüsselChar = (char)(((character - 32 - shift + 96) % 96) + 32);

            entschlüsselText.Append(entschlüsselChar);

            schlüsselIndex = (schlüsselIndex + 1) % schlüssel.Length;
        }
        else
        {
            entschlüsselText.Append(character);
        }

    }

    return entschlüsselText.ToString();
}
*/













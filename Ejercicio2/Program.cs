using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe el codigo ASCII para transformar en letras");
            string escrito = Console.ReadLine();

            string[] codigo =  escrito.Split(' ');

            string[,] letrasyASCII = new string[,] { { " ", "032" },  { "$", "036"}, { "%", "037"}, { "&", "038"}, { "/", "047"}, { "(", "040"}, { ")", "041"}, { "-", "045"}, {".", "046" }, { "@","064"},{ "0", "048"}, { "1", "049"}, { "2", "050"},{ "3", "051"},{ "4", "052"},{ "5", "053"},{ "6", "054"},{ "7", "055"},{ "8", "056"}, { "9", "057"},
                                                                      { "A", "065"}, { "B", "066"}, { "C", "067"}, { "D", "068"}, { "E", "069"}, {"F", "070" }, { "G", "071"}, { "H", "072"}, { "I", "073"}, { "J", "074"}, { "K", "075"}, { "L", "076"}, { "M", "077"}, { "N", "078"},{ "Ñ", "165"}, { "O", "079"}, { "P", "080"}, { "Q", "081"}, { "R", "082"}, { "S", "083"}, { "T", "084"}, { "U", "085"}, { "V", "086"}, { "W", "087"}, { "X", "088"}, { "Y", "089"}, { "Z", "090"},
                                                                      { "a", "097"}, { "b", "098"}, { "c", "099"}, { "d", "100"}, { "e", "101"}, {"e", "102" }, { "g", "103"}, { "h", "104"}, { "i", "105"}, { "j", "106"}, { "k", "107"}, { "l", "108"}, { "m", "109"}, { "n", "110"},{ "ñ", "164"}, { "o", "111"}, { "p", "112"}, { "q", "113"}, { "r", "114"}, { "s", "115"}, { "t", "116"}, { "u", "117"}, { "v", "118"}, { "w", "119"}, { "x", "120"}, { "y", "121"}, { "z", "122"} };
            string resultado = string.Empty;
            for (int i = 0; i < codigo.Length; i++)
            {
                int contador = 0;
                bool esDigito = false;
                while (codigo[i].Length > contador)
                {
                    if (char.IsDigit(codigo[i], 0))
                    { contador += 1; esDigito = true; }
                    else { esDigito = false; break; }
                }
                if (esDigito)
                {
                    if (codigo[i].Length > 3)
                    {
                        resultado = "El codigo ASCII no debe ser mayor de 3 digitos";
                        break;
                    }
                    if (codigo[i].Length < 3)
                    {
                        resultado = "El codigo ASCII no debe ser menor de 3 digitos";
                        break;
                    }
                    for (int j = 0; j < letrasyASCII.GetLength(0); j++)
                    {
                        if (letrasyASCII[j, 1] == codigo[i])
                        {
                            resultado += letrasyASCII[j, 0];
                            break;
                        }
                    }
                }
                else { resultado = "No se permiten caracteres o simbolos"; }

            }

            Console.WriteLine(resultado);
        }
    }
}

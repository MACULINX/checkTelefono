using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.PortableExecutable;

public static class Telefono
{

    public static string Check(string[] input)
    {
        for(int i=0 ; i < input.Length ; i++)
            foreach (char c in input[i])
                if(!char.IsDigit(c) && c != '+')
                    input[i] = "Non Valido";

        for(int i=0 ; i < input.Length ; i++)
            if(((input[i].Length == 14) && (input[i][0] == '0') && (input[i][4]  == '3')) ||
               ((input[i].Length == 13) && (input[i][0] == '+') && (input[i][4]  == '3')) || 
               ((input[i].Length == 10) && (input[i][0]  == '3'))) 
                return input[i];

              
        return "";
    }
}
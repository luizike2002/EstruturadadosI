﻿using System.Collections;

//Criar Hash
Hashtable openWith = new Hashtable();

try
{
    openWith.Add("txt", "notepad.exe");
    openWith.Add("bmp", "paint.exe");
    openWith.Add("dib", "paint.exe");
    openWith.Add("rtf", "wordpad.exe");

    openWith.Add("txt", "notepad++.exe");
}
catch(ArgumentException aex)
{
    Console.WriteLine("Opss, Você tentou adicionar uma chave inválida");
    Console.WriteLine($"Detalhes:{aex.Message}");
}
catch(Exception ex)
{
    Console.WriteLine("Erro genérico.");
}

//Acessando o conteúdo da tabela Hash
Console.WriteLine("Na \\ chave = \"rtf\" é {0}", openWith["rtf"] );

//Alterando o contrúdo tabela hash
openWith["rtf"] = "winword.exe";
Console.WriteLine(
    "na \\ chave = \"rtf\" é {0}" 
    , openWith ["rtf"]
);

//Testar se chave existe na hash
if(!openWith.ContainsKey("ht"))
{
    openWith.Add("ht", "hypertrm.exe");
    Console.WriteLine("Chave ht adicionada.");
}

//Percorredo hash com foreach
Console.WriteLine();
foreach(DictionaryEntry de in openWith)
{
    Console.WriteLine(
        "Key = {0} - Value = {1}"
        , de.Key
        , de.Value
        );
}

//obtendo apenas os valores do hash
ICollection valueCol = openWith.Keys;
Console.WriteLine();
foreach(string s in valueCol)
{
    Console.WriteLine("value = {0}", s);
}
ICollection keyCol = openWith.Keys;
Console.WriteLine();
foreach(string s in keyCol)
{
    Console.WriteLine("key = {0}", s);
}
//remover registro do hash
Console.WriteLine("removendo (\"doc\")");
openWith.Remove("doc");
{
    Console.WriteLine(
        "Chave \"doc\" foi removida."
    );
}
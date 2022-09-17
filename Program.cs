//FUNZIONE 1

//void StampaArray(int[] array): che preso un array di numeri interi e
//stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]“.

using System;

int[] numbers = {1,2,3,4,5};


void StampaArray(int[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ",");
    }

    Console.Write("]");
}


//FUNZIONE 2

//int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.

int Quadrato(int numero)
{
    return numero * numero;
    
}


//FUNZIONE 3
/* int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi
elevati quadrato. Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione!
Vi ricordate perchè? Pensateci (vedi slide) */


int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] quadrato = new int[array.Length];

    for (int i=0; i<array.Length; i++)
    {
        quadrato[i] = array[i] * array[i];
    }
        return quadrato;
}


//FUNZIONE 4

/* int sommaElementiArray(int[] array): che preso un array di numeri interi, 
 * restituisca la somma totale di tutti gli elementi dell’array. */

int sommaElementiArray(int[] array)
{
    int sum = 0;
    
    for(int i=0; i<array.Length; i++)
    {
        sum += array[i];
    }
        return sum;
}


//FUNZIONE 5

int[] arrNumbers = { 2, 6, 7, 5, 3, 9 };

Console.WriteLine("Stampare l’array di numeri fornito a video");
StampaArray(arrNumbers);
Console.WriteLine("");

Console.WriteLine("");
Console.WriteLine("Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato.");
StampaArray(ElevaArrayAlQuadrato(arrNumbers));
Console.WriteLine("");

Console.WriteLine("");
Console.WriteLine("Stampare la somma di tutti i numeri");
Console.WriteLine(sommaElementiArray(arrNumbers));

Console.WriteLine("");
Console.WriteLine("Stampare la somma di tutti i numeri elevati al quadrati.");
Console.WriteLine(sommaElementiArray(ElevaArrayAlQuadrato(arrNumbers)));


//BONUS

/*Convertire le funzioni appena dichiarate in funzioni generiche, 
ossia funzioni che possono lavorare con array di numeri interi di lunghezza variabile, 
ossia debbono poter funzionare sia che gli passi array di 5 elementi, sia di 6, di 7, di ... e così via. 
A questo punto modificare il programma in modo che chieda all’utente quanti numeri voglia inserire, 
e dopo di che questi vengono inseriti a mano dall’utente esternamente.
Rieseguire il programma con l’input preso esternamente dall’utente.*/

Console.WriteLine("Quanti numeri vuoi inserire?");

int number = Convert.ToInt32(Console.ReadLine());

int[] arrayNum = new int[number];

for(int i=0; i<number; i++)
{
    Console.WriteLine($"Inserisci il {i + 1}° numero");
    arrayNum[i] = Convert.ToInt32(Console.ReadLine());
}

StampaArray(arrayNum);
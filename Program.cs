// See https://aka.ms/new-console-template for more information

//void StampaArray(int[] array): che preso un array di numeri interi e
//stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]“.

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

StampaArray(numbers);
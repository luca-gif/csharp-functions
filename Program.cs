//FUNZIONE 1

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


//FUNZIONE 2

//int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.

/*int Quadrato(int numero)
{
    return numero * numero;
    
}

Console.WriteLine(Quadrato(10));*/

//FUNZIONE 3
/* int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi
elevati quadrato. Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione!
Vi ricordate perchè? Pensateci (vedi slide) */


/*int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] quadrato = new int[array.Length];

    for (int i=0; i<array.Length; i++)
    {
        quadrato[i] = array[i] * array[i];
    }
        return quadrato;
}

StampaArray(ElevaArrayAlQuadrato(numbers));*/

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

Console.WriteLine(sommaElementiArray(numbers));
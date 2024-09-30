// See https://aka.ms/new-console-template for more information

using SintassiClassi;

Console.WriteLine("Gestione Biblioteca");


bool continua = true;
Libro[] biblioteca = new Libro[500];
int indice = 0;

while (continua)
{

    // per creare un oggetto a partire da una classe: 
    //Keyword: Nome della calsse 
    // Nome dell'oggetto => Detto anche "Istanza"
    // new => il programma alloca della memoria per l'oggetto creato
    // "NomeDellaClasse()"
    Libro oggettoLibro = new Libro();



    Console.WriteLine("Inserisci il titolo");
    oggettoLibro.Titolo = Console.ReadLine();

    Console.WriteLine("Inserisci l'autore");
    oggettoLibro.Autore = Console.ReadLine();

    Console.WriteLine("Inserisci il numero di pagine");
    oggettoLibro.Pagine = int.Parse(Console.ReadLine());

    Console.WriteLine("Inserisci il prezzo");
    oggettoLibro.Prezzo = double.Parse(Console.ReadLine());

    Console.WriteLine("Vuoi inserire un altro libro? (s/n)");
    string risposta = Console.ReadLine();
    if (risposta == "n")
    {
        continua = false;
    }
    biblioteca[indice] = oggettoLibro;
    indice++;

    Console.WriteLine("Il prezzo in dollari sarà pari a " + oggettoLibro.PrezzoInDollari());


}




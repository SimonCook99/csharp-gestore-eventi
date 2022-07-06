using csharp_gestore_eventi;

//test vari, validazione dei dati in fase di creazione implementata




Console.WriteLine("Inserisci il nome dell'evento da creare:");
string titolo = Console.ReadLine();
Console.WriteLine("Inserisci la data dell'evento (gg/mm/yyyy):");
DateTime data = DateTime.Parse(Console.ReadLine());
Console.WriteLine("Inserisci il numero di posti totali:");
int capienza = int.Parse(Console.ReadLine());

Evento e = new Evento(titolo, data, capienza);

Console.WriteLine("Quanti posti desideri prenotare?");
int postiPrenotati = int.Parse(Console.ReadLine());

//non si possono prenotare più posti della capienza massima
e.PrenotaPosti(postiPrenotati);

Console.WriteLine($"Posti prenotati: {postiPrenotati}");
Console.WriteLine($"Posti ancora disponibili: {e.capienzaMassima - postiPrenotati}");

string sceltaUtente = null;
while(sceltaUtente != "si" || sceltaUtente == "no"){
    Console.WriteLine("Vuoi disdire dei posti? si/no");
    sceltaUtente = Console.ReadLine();
    if (sceltaUtente == "no"){
        Console.WriteLine("Ok, buon divertimento :)");
    }
    else if (sceltaUtente == "si"){
        Console.WriteLine("Quanti posti vuoi disdire?");
        int postiDaRimuovere = int.Parse(Console.ReadLine());
        int postiAggionrati = e.DisdiciPosti(postiDaRimuovere);

        Console.WriteLine($"Hai ancora {postiAggionrati} posti prenotati");
    }
}


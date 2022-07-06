using csharp_gestore_eventi;

//test vari, validazione dei dati in fase di creazione implementata
Evento e = new Evento("spettacolo", new DateTime(2023, 12, 21), 10);

//non si possono prenotare più posti della capienza massima
e.PrenotaPosti(20);

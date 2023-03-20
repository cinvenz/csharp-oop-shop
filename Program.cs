//PRIMO PRODOTTO

Prodotto prodotto = new Prodotto("Giacca", "Giacca nera in vera pelle", 79.99, 22);

Console.WriteLine("Codice prodotto: " + prodotto.GetProductCode());

Console.WriteLine("Nome esteso: " + prodotto.GetNomeEsteso());

Console.WriteLine("Prezzo base: " + prodotto.GetPrezzoBase() + " euro");
Console.WriteLine("Prezzo ivato: " + prodotto.GetPrezzoIva() + " euro");

Console.WriteLine();
//secondo PRODOTTO

Prodotto prodotto2 = new Prodotto("Sneakers", "Sneakers Nike colore bianco", 49.99, 22);

Console.WriteLine("Codice prodotto: " + prodotto2.GetProductCode());

Console.WriteLine("Nome esteso: " + prodotto2.GetNomeEsteso());

Console.WriteLine("Prezzo base: " + prodotto2.GetPrezzoBase() + " euro");
Console.WriteLine("Prezzo ivato: " + prodotto2.GetPrezzoIva() + " euro");
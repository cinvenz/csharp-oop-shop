//ARRAY BONUS
Prodotto[] productList = new Prodotto[3];

productList[0] = new Prodotto("Giacca", "Giacca nera in vera pelle", 79.99, 22);
productList[1] = new Prodotto("Sneakers", "Sneakers Nike colore bianco", 49.99, 22);
productList[2] = new Prodotto("Jeans", "Jeans colore blu scuro", 39.99, 22);

Console.WriteLine("Elenco prodotti nel negozio:");
Console.WriteLine();

foreach (Prodotto product in productList)
{
    Console.WriteLine("Codice prodotto: " + product.GetProductCode());
    Console.WriteLine("Nome esteso: " + product.GetNomeEsteso());
    Console.WriteLine("Prezzo base: " + product.GetPrezzoBase() + " euro");
    Console.WriteLine("Prezzo ivato: " + product.GetPrezzoIva() + " euro");

    Console.WriteLine();

}


//PRIMO PRODOTTO

Prodotto prodotto = new Prodotto("Giacca", "Giacca nera in vera pelle", 79.99, 22);

Console.WriteLine("Codice prodotto: " + prodotto.GetProductCode());

Console.WriteLine("Nome esteso: " + prodotto.GetNomeEsteso());

Console.WriteLine("Prezzo base: " + prodotto.GetPrezzoBase() + " euro");

Console.WriteLine("Prezzo ivato: " + prodotto.GetPrezzoIva() + " euro");


Console.WriteLine();

//SECONDO PRODOTTO

Prodotto prodotto2 = new Prodotto("Sneakers", "Sneakers Nike colore bianco", 49.99, 22);

Console.WriteLine("Codice prodotto: " + prodotto2.GetProductCode());

Console.WriteLine("Nome esteso: " + prodotto2.GetNomeEsteso());

Console.WriteLine("Prezzo base: " + prodotto2.GetPrezzoBase() + " euro");

Console.WriteLine("Prezzo ivato: " + prodotto2.GetPrezzoIva() + " euro");


Console.WriteLine();


//TERZO PRODOTTO

Prodotto prodotto3 = new Prodotto("Jeans", "Jeans colore blu scuro", 39.99, 22);

Console.WriteLine("Codice prodotto: " + prodotto3.GetProductCode());

Console.WriteLine("Nome esteso: " + prodotto3.GetNomeEsteso());

Console.WriteLine("Prezzo base: " + prodotto3.GetPrezzoBase() + " euro");

Console.WriteLine("Prezzo ivato: " + prodotto3.GetPrezzoIva() + " euro");
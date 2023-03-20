using System;

class Prodotto 
{
    private int productCode;
    private string name;
    private string description;
    private double price;
    private double piva;

    public Prodotto(string name, string description, double price, double piva)
    {
        this.productCode = new Random().Next(0, 9999999);
        this.name = name;
        this.description = description;
        this.price = price;
        this.piva = piva;
    }

    public int ProductCode
    {
        get { return productCode; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }


    public string Description
    {
        get { return description; }
        set { description = value; }
    }


    public double Price
    {
        get { return price; }
        set { price = value; }
    }


    public double Piva
    {
        get { return piva; }
        set { piva = value; }
    }

    public string GetProductCode()
    {
        string addZero = productCode.ToString();
        while (addZero.Length < 8)
        {
            addZero = "0" + addZero;
        }
        return addZero;
    }


    public double GetPrezzoBase()
    {
        return price;
    }

    public double GetPrezzoIva()
    {
        double prezzoIva = price + price * piva / 100;
        return Math.Round(prezzoIva, 2);
    }

    public string GetNomeEsteso()
    {
        string addZero = productCode.ToString();
        while (addZero.Length < 8)
        {
            addZero = "0" + addZero;
        }
        return addZero + " - " + name;
    }

}
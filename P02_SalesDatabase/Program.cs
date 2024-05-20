using P02_SalesDatabase.Data;
using P02_SalesDatabase.Models;

internal class Program
{
    static void Main(string[] args)
    {
        Customers customers = new Customers();
        Products products = new Products();
        Stores stores = new Stores();   
        Sales sales = new Sales();
        SalesContext salesContext = new SalesContext();

    }
}
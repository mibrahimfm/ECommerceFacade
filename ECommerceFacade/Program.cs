// See https://aka.ms/new-console-template for more information
using ECommerceFacade;

OrderFacade facade = new();
List<string> products = new()
{
    "Book",
    "Pen",
    "Stapler"
};

double total = 85.45;
string address = "1st street, 123. North Pole";

facade.PlaceOrder(products, total, address);
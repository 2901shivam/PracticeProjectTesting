// See https://aka.ms/new-console-template for more information
using PracticeProjectSection4;

Console.WriteLine("List Of Item");

List<Item> items = new List<Item>()
{
    new Item(){Id=1,Iname="Panner Tikka",IPrice=150},
    new Item(){Id=2,Iname="Panner Masala",IPrice=250},
    new Item(){Id=3,Iname="Button Mashroom",IPrice=350},
    new Item(){Id=4,Iname="Chole khulche",IPrice=50},
    new Item(){Id=5,Iname="Mix Veg",IPrice=150},
};

foreach(Item it in items)
{
    Console.WriteLine("ID:"+it.Id);
    Console.WriteLine("Item Name:" + it.Iname);
    Console.WriteLine("Item Price:" + it.IPrice);

}

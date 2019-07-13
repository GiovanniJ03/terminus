using System;

namespace NadekoBot.Core.Services.Database.Models
{
    public class WaifuItem : DbEntity
    {
        public int? WaifuInfoId { get; set; }
        public string ItemEmoji { get; set; }
        public int Price { get; set; }
        public ItemName Item { get; set; }

        public enum ItemName
        {
            Galleta,
            Rosa,
            Carta,
            Chocolate,
            Arroz,
            BoletoDeCine,
            Libro,
            LapizLabial,
            Laptop,
            Violin,
            Anillo,
            Helicoptero,
            Telefono, //4000
            Gato, //2000
            Perro, //2001
            Paleta, //30
            Bolso, //3500
            Sushi, //300
            Helado, //200
            Piano, //8000
            Yate, //12000
            Coche, //9000
            Casa, //15000
            NaveEspacial, //30000
            Cerveza, //75
            Pizza, //150
            Leche, //125
            Pan, //100
            Taco, //300
            Bento, //1200
            Patata, //20
            Luna, //100k
            Panda, //5k
            Pastel, //2000
            Sandia,//1000
            Vestido, //4000
        }

        public WaifuItem()
        {

        }

        public WaifuItem(string itemEmoji, int price, ItemName item)
        {
            ItemEmoji = itemEmoji;
            Price = price;
            Item = item;
        }

        public static WaifuItem GetItemObject(ItemName itemName, int mult)
        {
            WaifuItem wi;
            switch (itemName)
            {
                case ItemName.Patata:
                    wi = new WaifuItem("🥔", 5, itemName);
                    break;
                case ItemName.Galleta:
                    wi = new WaifuItem("🍪", 10, itemName);
                    break;
                case ItemName.Pan:
                    wi = new WaifuItem("🥖", 20, itemName);
                    break;
                case ItemName.Paleta:
                    wi = new WaifuItem("🍭", 30, itemName);
                    break;
                case ItemName.Rosa:
                    wi = new WaifuItem("🌹", 50, itemName);
                    break;
                case ItemName.Cerveza:
                    wi = new WaifuItem("🍺", 70, itemName);
                    break;
                case ItemName.Taco:
                    wi = new WaifuItem("🌮", 85, itemName);
                    break;
                case ItemName.Carta:
                    wi = new WaifuItem("💌", 100, itemName);
                    break;
                case ItemName.Leche:
                    wi = new WaifuItem("🥛", 125, itemName);
                    break;
                case ItemName.Pizza:
                    wi = new WaifuItem("🍕", 150, itemName);
                    break;
                case ItemName.Chocolate:
                    wi = new WaifuItem("🍫", 200, itemName);
                    break;
                case ItemName.Helado:
                    wi = new WaifuItem("🍦", 250, itemName);
                    break;
                case ItemName.Sushi:
                    wi = new WaifuItem("🍣", 300, itemName);
                    break;
                case ItemName.Arroz:
                    wi = new WaifuItem("🍚", 400, itemName);
                    break;
                case ItemName.Sandia:
                    wi = new WaifuItem("🍉", 500, itemName);
                    break;
                case ItemName.Bento:
                    wi = new WaifuItem("🍱", 600, itemName);
                    break;
                case ItemName.BoletoDeCine:
                    wi = new WaifuItem("🎟", 800, itemName);
                    break;
                case ItemName.Pastel:
                    wi = new WaifuItem("🍰", 1000, itemName);
                    break;
                case ItemName.Libro:
                    wi = new WaifuItem("📔", 1500, itemName);
                    break;
                case ItemName.Gato:
                    wi = new WaifuItem("🐱", 2000, itemName);
                    break;
                case ItemName.Perro:
                    wi = new WaifuItem("🐶", 2001, itemName);
                    break;
                case ItemName.Panda:
                    wi = new WaifuItem("🐼", 2500, itemName);
                    break;
                case ItemName.LapizLabial:
                    wi = new WaifuItem("💄", 3000, itemName);
                    break;
                case ItemName.Bolso:
                    wi = new WaifuItem("👛", 3500, itemName);
                    break;
                case ItemName.Telefono:
                    wi = new WaifuItem("📱", 4000, itemName);
                    break;
                case ItemName.Vestido:
                    wi = new WaifuItem("👗", 4500, itemName);
                    break;
                case ItemName.Laptop:
                    wi = new WaifuItem("💻", 5000, itemName);
                    break;
                case ItemName.Violin:
                    wi = new WaifuItem("🎻", 7500, itemName);
                    break;
                case ItemName.Piano:
                    wi = new WaifuItem("🎹", 8000, itemName);
                    break;
                case ItemName.Coche:
                    wi = new WaifuItem("🚗", 9000, itemName);
                    break;
                case ItemName.Anillo:
                    wi = new WaifuItem("💍", 10000, itemName);
                    break;
                case ItemName.Yate:
                    wi = new WaifuItem("🛳", 12000, itemName);
                    break;
                case ItemName.Casa:
                    wi = new WaifuItem("🏠", 15000, itemName);
                    break;
                case ItemName.Helicoptero:
                    wi = new WaifuItem("🚁", 20000, itemName);
                    break;
                case ItemName.NaveEspacial:
                    wi = new WaifuItem("🚀", 30000, itemName);
                    break;
                case ItemName.Luna:
                    wi = new WaifuItem("🌕", 50000, itemName);
                    break;
                default:
                    throw new ArgumentException("Item is not implemented", nameof(itemName));
            }
            wi.Price = wi.Price * mult;
            return wi;
        }
    }
}


/*
🍪 Galleta 10
🌹  Rosa 50
💌 Carta 100
🍫  Chocolate 200
🍚 Arroz 400
🎟  BoletoDeCine 800
📔 Libro 1.5k
💄  LapizLabial 3k
💻 Laptop 5k
🎻 Violin 7.5k
💍 Anillo 10k
*/

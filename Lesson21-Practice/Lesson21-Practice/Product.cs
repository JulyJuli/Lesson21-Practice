
namespace Lesson21_Practice
{
    public class Product
    {
        //        Разработка ПО для управления продажами.
        //Информация о товаре для события: необходимо создать наследника класса EventArgs - GoodsInfoEventArgs.
        //Внутри объявить свойства: имя, стоимость товара.
        //Customer – event listener.Содержит свойство имя и метод GotNewGoods() для подписки на события.
        //OnlineShop - event publisher.У него есть событие типа EventHandler<GoodsInfoEventArgs> и метод NewGoods(). 
        //Метод оповещает пользователей о поступлении нового товара в магазин.
        ////Объявить нескольких клиентов с разными именами и магазин. Создать подписку для получения уведомления о поступлении новых товаров.
        public string ProductName { get; set; }

        public decimal Cost { get; set; }

        public EnumProducts Category { get; set; }
    }
}

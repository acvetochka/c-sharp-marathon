string productName = "Олівець"; // назва продукту
double productPrice = 5.75;     // ціна однієї позиції продукту
double shippingPrice = 80;      // ціна доставки

// виконайте наступні дії
// 1 - покажіть користувачу назву та ціну товару
// 2 - запитайте скільки одиниць товару потрібно замовити, значення не може бути менше ніж 1
// 3 - запитайте чи потрібно виконувати доставку товару, якщо так ціна доставки shippingPrice інакше 0
// 4 - порахуйте вартість замовлених товарів з урахуванням кількості і доставки, та виведіть результат

string shipping = "";

Console.OutputEncoding = System.Text.Encoding.UTF8; 

Console.WriteLine(productName + ", ціна " + productPrice + "грн");
Console.WriteLine("Cкільки одиниць товару потрібно замовити?");
int count = Convert.ToInt32(Console.ReadLine());
if(count > 0)
{
    Console.WriteLine("Чи потрібно виконувати доставку товару? (так/ні)");
    if (Console.ReadLine() != "так") {
        shippingPrice = 0;
    }
    else
    {
        shipping = " (включаючи доставку " + shippingPrice + "грн)" ; 
    }

    double price = productPrice*count + shippingPrice;
    Console.WriteLine("Замовлено " + count + " " + productName + " на загальну суму " + price + "грн" + shipping); 
    
}
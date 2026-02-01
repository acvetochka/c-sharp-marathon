Console.OutputEncoding = System.Text.Encoding.UTF8;

double productPrice1 = 101.5; // ціна 1го продукту
double productPrice2 = 50.25; // ціна 2го продукту
double productPrice3 = 10.11; // ціна 3го продукту

int productQuantity1 = 5;  // кількість одиниць 1го продукту на складі
int productQuantity2 = 9;  // кількість одиниць 2го продукту на складі
int productQuantity3 = 15; // кількість одиниць 3го продукту на складі

// Виведіть на екран:
// 1) Середню ціну на продукти 
// 2) Загальну ціну усіх продуктів які є на складі

double averagePrice = (productPrice1 + productPrice2 + productPrice3) / 3;
double product1 = productPrice1 * productQuantity1;
double product2 = productPrice2 * productQuantity2;
double product3 = productPrice3 * productQuantity3;
double price = product1 + product2 + product3;

Console.WriteLine("Середня ціна на продукти "+ averagePrice);
Console.WriteLine("Загальна ціна усіх продуктів, які є на складі " + price);


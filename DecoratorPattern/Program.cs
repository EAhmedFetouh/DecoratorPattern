using DecoratorPattern;
using DecoratorPattern.Decorator;


//var item = new InvoiceItem
//{
//    Name = "Laptop",
//    BasePrice = 1000,
//    HasGiftWrap = true,
//    GiftWrapCost = 100,
//    HasDiscount = true,
//    DiscountRate = .1f
//};

//Console.WriteLine(item.GetPrice());


var product = new Product("Laptop", 1000);
var wrapped = new WrapBundle(product, 100);
var insurance = new InsuranceBundle(wrapped, 100);
//var discout = new DiscountBundle(insurance, .1f);

Console.WriteLine(insurance.GetDetails());
Console.WriteLine(insurance.GetPrice());










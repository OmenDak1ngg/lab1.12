using lab1;

Product product1 = new Product("Молоко");
Product product2 = new Product("Творог");
Product product3 = new Product("Сметана");
Product product4 = new Product("Кефир");
Product product5 = new Product("Йогурт");
Product product6 = new Product("Сливки");
Product product7 = new Product("Ряженка");
Product product8 = new Product("Простокваша");

Buyer buyer1 = new Buyer(new Product[] { product1, product2, product3, product5, product7 });
Buyer buyer2 = new Buyer(new Product[] { product2, product4, product6, product8 });
Buyer buyer3 = new Buyer(new Product[] { product1, product3, product5, product7 });
Buyer buyer4 = new Buyer(new Product[] { product1, product2, product3, product4, product6, product8 });
Buyer buyer5 = new Buyer(new Product[] { product2, product5, product7 });
Buyer buyer6 = new Buyer(new Product[] { product2, product4, product6, product7, product8 });
Buyer buyer7 = new Buyer(new Product[] { product1, product2, product3, product4, product5, product6, product7 });
Buyer buyer8 = new Buyer(new Product[] { product1, product4, product5, product8 });
Buyer buyer9 = new Buyer(new Product[] { product2, product3, product5, product6, product7, product8 });
Buyer buyer10 = new Buyer(new Product[] { product1, product2, product5, product7 });
Buyer buyer11 = new Buyer(new Product[] { product1, product3, product6, product7, product8 });
Buyer buyer12 = new Buyer(new Product[] { product1, product3, product4, product5, product6, product8 });
Buyer buyer13 = new Buyer(new Product[] { product2, product4, product5, product7 });
Buyer buyer14 = new Buyer(new Product[] { product1, product2, product3, product4, product6, product7, product8 });
Buyer buyer15 = new Buyer(new Product[] { product1, product3, product4, product6, product7 });

Buyer[] buyers = { buyer1, buyer2,  buyer3};

int min = 2;
Calculator calculator = new Calculator();

Dictionary<string, int> C1 = calculator.CalculateC(buyers, 1);
Dictionary<string, int> L1 = calculator.CalculateL(C1, min, 1);

// Для длины 2
Dictionary<string, int> C2 = calculator.CalculateC(buyers, 2);
Dictionary<string, int> L2 = calculator.CalculateL(C2, min, 2);

// Для длины 3
Dictionary<string, int> C3 = calculator.CalculateC(buyers, 3);
Dictionary<string, int> L3 = calculator.CalculateL(C3, min, 3);

// Для длины 4
Dictionary<string, int> C4 = calculator.CalculateC(buyers, 4);
Dictionary<string, int> L4 = calculator.CalculateL(C4, min, 4);
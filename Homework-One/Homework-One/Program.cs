using Homework_One.Models;

Dog sharko = new Dog("Sharko", 3, true, "Sharplaninec");
sharko.PrintAnimal();
sharko.Bark();
Console.WriteLine("--------------------------------------------------------");
Dog dzoni = new Dog("Dzoni", 7, false, "Chiuaua");
dzoni.PrintAnimal();
dzoni.Bark();
Console.WriteLine("--------------------------------------------------------");
Cat maco = new Cat("Maco", 7, true, "siamese");
maco.PrintAnimal();
maco.Eat();
Console.WriteLine("--------------------------------------------------------");
Cat macmac = new Cat("Sijam", 3, false, "konti");
macmac.PrintAnimal();
macmac.Eat();

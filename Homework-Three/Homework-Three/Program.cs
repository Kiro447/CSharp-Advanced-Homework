
using Homework_Three.Database;
using Homework_Three.Entities;
using Homework_Three.Entities.Enum;

ItalianCar kola = new ItalianCar(1, "Ferrari", "360 Modena", 400, 500,FuelType.Petrol);
GenericDb<ItalianCar>.AddCar(kola);
GenericDb<ItalianCar>.AddCar(kola);
GenericDb<ItalianCar>.AddCar(kola);
GenericDb<ItalianCar>.AddCar(kola);
GenericDb<ItalianCar>.AddCar(kola);
GenericDb<ItalianCar>.PrintAll();

GermanCar car = new GermanCar(2, "BMW", "i7", 500, 700, FuelType.Diesel);
GenericDb<GermanCar>.AddCar(car);

GenericDb<GermanCar>.GetCar(2);

string text = "blablabla";
text.ColorChange(ConsoleColor.Red);

GenericDb<GermanCar>.RemoveCar(5);

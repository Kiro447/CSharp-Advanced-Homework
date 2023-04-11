using Homework_Two.Database;
using Homework_Two.Entities;
Db.PrintAllCars();
Console.WriteLine("------------BIKES------------");
Db.PrintAllBikes();
Console.WriteLine(Validator.Validate(Db.VehichleDb[0]));
Console.WriteLine(Validator.Validate(Db.VehichleDb[1]));

Console.WriteLine(Validator.Validate(Db.VehichleDb[4]));
Console.WriteLine(Validator.Validate(Db.VehichleDb[5]));

Db.VehichleDb[0].PrintVehicle();
Db.VehichleDb[5].PrintVehicle();
using System.Timers;
using Packt.Shared;
using static System.Console;
using Interface.Shared;


A obA = new A();
B obB = new B();

ISampleInterface iOb = (ISampleInterface) obA;
iOb.SampleMethod();
iOb = (ISampleInterface) obB;
iOb.SampleMethod();







//ImplementationClass obj = new ImplementationClass();
//obj.SampleMethod();











// var harry = new Person {name = "Harry"};
// var mary = new Person{name = "Mary"};
// var jill = new Person {name = "Jill"};



// var baby1 = mary.PorcreateWith(harry);
// var baby2 = Person.Procreate(harry, jill);
// var baby3 = harry*mary;

// WriteLine($"{harry.name} has {harry.Children.Count} children");
// WriteLine($"{mary.name} has {mary.Children.Count} children");
// WriteLine($"{jill.name} has {jill.Children.Count} children");

// WriteLine(
//      format: "{0}'s first child name \"{1}\".",
//      arg0: harry.name,
//      arg1:harry.Children[0].name
// );

















// Employee aliceInEmployee = new Employee
// {
//      name = "Alice",
//      EmployeeCode = "AA123"
// };
// Person aliceInPerson = aliceInEmployee;
// aliceInEmployee.WriteToConsole();
// aliceInPerson.WriteToConsole();
// WriteLine(aliceInEmployee.ToString());
// WriteLine(aliceInPerson.ToString());




// if(aliceInPerson is Employee)
// {
//      WriteLine($"{nameof(aliceInPerson)} is an Employee");
//      Employee explictAlice = (Employee) aliceInPerson;
// }
// Employee aliceAsEmployee = aliceInPerson as Employee;

// if(aliceAsEmployee != null)
// {
//       WriteLine($"{nameof(aliceInPerson)} AS an Employee");
// }



// bool CheckCordinates(int x, int y)
// {    int R = 10;
//      if( (Math.Pow(x,2) + Math.Pow(y,2) < Math.Pow(R,2)) &&( x < 0 && y < 0) && Math.Abs(x) < Math.Abs(y))
//      {
//           return true;
//      }
//      else
//      {
//           return false;
//      }
// }


// Employee john = new Employee
// {
//      name = "John Jones",
//      DateofBirth = new DateTime(1999,7,23)
// };
// john.WriteToConsole();
// john.EmployeeCode = "jj001";
// john.HireDate = new DateTime(2014,11,23);
// WriteLine($"{john.name} was hired on {john.HireDate:dd/MM/yy}");
// WriteLine(john.ToString');

// try 
// {
//      checked 
//      {
//           int x = int.MaxValue -1;
//           WriteLine($"initial value {x}");
//           x++;
//           WriteLine($"After value {x}");
//           x++;
//           WriteLine($"after value {x}");
//           x++;
//           WriteLine($"after value {x}");
//      }
// }
// catch(OverflowException)
// {
//      WriteLine("You have reached the limit of the int32! be careful!");
// }



// WriteLine("Before parsing");
// WriteLine("what os your age?");

// string input = ReadLine();

// try 
// {
//      int age = int.Parse(input);
//      WriteLine($"You are {age} years old");

// }
// catch(FormatException)
// {
//      WriteLine("this age is entered is not a valid number formant");
// }
// catch(OverflowException)
// {
//      WriteLine("Your age is valid formant bit it is either too big or small.");
// }
// catch(Exception ex)
// {
//      WriteLine($"{ex.GetType()} says {ex.Message}");
// }

// WriteLine("After parsing");


// var sam = new Person
// {
//      name = "Sam",
//      DateofBirth = new DateTime(1972,1,11)
// };

// WriteLine(sam.Origin);
// WriteLine(sam.Greeting);
// WriteLine(sam.Age);

// sam.FavoriteIceCream = "Chocolate Fudge";
// WriteLine($"Sam's favorite ice-cream flavor is {sam.FavoriteIceCream}.");
// sam.FavoritePrimaryColor = "Red";
// WriteLine($"Sam's favorite primary color is {sam.FavoritePrimaryColor}.");

// sam.Children.Add(new Person {name = "Charlie"});
// sam.Children.Add(new Person {name = "Ella"});
// WriteLine($"Sam's first children is {sam.Children[0].name}");
// WriteLine($"Sam's second children is {sam.Children[1].name}");
// WriteLine($"Sam's first children is {sam[0].name}");
// WriteLine($"Sam's second children is {sam[1].name}");




// var blankPerson = new Person();
// WriteLine (
//      format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
//      arg0: blankPerson.name,
//      arg1: blankPerson.HomePlanet,
//      arg2: blankPerson.Instantiated);
     
// var gunny = new Person("Gunny", "Mars");
// WriteLine (
//      format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
//      arg0: gunny.name,
//      arg1: gunny.HomePlanet,
//      arg2: gunny.Instantiated);
     
// BankAccount.InterestRate = 0.012M;
// var jonesAccount = new BankAccount();
// jonesAccount.AccountName = "MRs. Jones";
// jonesAccount.Balance = 2400;

// WriteLine (
//     format: "{0} earned {1:C} interest",
//     arg0: jonesAccount.AccountName,
//     arg1: jonesAccount.Balance* BankAccount.InterestRate);
 
//  var gerrierAccount = new BankAccount();
// gerrierAccount.AccountName = "Ms Gerrier";
// gerrierAccount.Balance = 98;

// WriteLine (
//     format: "{0} earned {1:C} interest",
//     arg0: gerrierAccount.AccountName,
//     arg1: gerrierAccount.Balance*BankAccount.InterestRate);
 



// var bob = new Person();
// WriteLine(bob.ToString());
// bob.name = "Bob Smith";
// bob.DateofBirth = new DateTime(1965,12,22);
// bob.FavoriteWonder = AncientWonders.GreatPyramidofGiza;

// WriteLine($"{bob.name} is a {Person.Species}");
// WriteLine($"{bob.name} was born {bob.HomePlanet}");


// bob.Children.Add(new Person {name = "Alfred"});
// bob.Children.Add(new Person {name = "Zoe"});

// WriteLine($"{bob.name} has  {bob.Children.Count} childreen");

// for(int child = 0; child < bob.Children.Count;child++){
//     WriteLine(bob.Children[child].name);
// }
// // bob.BucketList = Wonn
// WriteLine (
//     format: "{0} favorite wonder is {1} and the integer is {2}",
//     arg0: bob.name,
//     arg1: bob.FavoriteWonder,
//     arg2: (int)bob.FavoriteWonder);
   


// var alice = new Person{
//     name = "Alice Ta",
//     DateofBirth = new DateTime(1999,09,6) };

// WriteLine (
//     format: "{0} was born on {1:dddd, d MMMM yyyy}",
//     arg0: alice.name,
//     arg1: alice.DateofBirth);
//AncientWonders Wonder = AncientWonders.GreatPyramidofGiza;

// home work  chessboard in console with input figures: libary project {all figues with its classes} and console app  


////Task1


//static void GetPowerOfTwo(int n)
//{
//    int result = 0;

//    while (n > 1 && n % 2 == 0)
//    {
//        n = (n /= 2);
//    }
//    if (n == 1)
//    {
//        Console.WriteLine("Quvvetidir");
//    }else
//    {
//        Console.WriteLine("Deyil");
//    }
//}

//GetPowerOfTwo(10);


////Task2

//var result = Math.Pow(2, 5);

//Console.WriteLine(result);

//------------------------------


//var result2 = Math.Sqrt(64);

//Console.WriteLine(result2);


//////Task3

//using ConsoleApp1;

//CustomMath math = new CustomMath();

////Console.WriteLine(math.SumOfOddNumbers(new int[] { 1, 3, 4, 5, 6, 7 }));

//Console.WriteLine(math.FindEvenNumbersPow(new int[] { 1, 3, 4, 5, 6, 7 },4));

//Console.WriteLine(math.Factorial(4));


//Task5


//using ConsoleApp1.Models;


//static void GetEmployeesByAge (int age)
//{
//    Employee[] employees = GetEmployees();
//    Employee[] fileteredEmployees =employees.Where(m=> m.age > age).ToArray();

//    foreach (Employee employee in fileteredEmployees)
//    {
//        string result = $"{employee.name} - {employee.surname} - {employee.id} - {employee.adress} - {employee.age} - {employee.email}";
//        Console.WriteLine(result);
//    }


//}

//GetEmployeesByAge(20);



//static int CountOfEmployeeByAge(int startAge,int endAge) => GetEmployees().Where(m=> m.age > startAge && m.age < endAge).Count();


//static Employee[] GetEmployees()
//{
//    Employee employee1 = new Employee()
//    {
//id = 1,
//name = "Test",
//surname = "Book",
//adress = "Baki",
//email = "Test@gamil.com",
//age = 30,

//    };

//    Employee employee2 = new Employee()
//    {
//        id = 2,
//        name = "Test",
//        surname = "Ahmadov",
//        adress = "Bilacari",
//        email = "haci@gmail.com",
//        age = 27,

//    };

//    Employee employee3 = new Employee()
//    {
//        id = 3,
//        name = "Tt",
//        surname = "Ah333madov",
//        adress = "Bilacaddddri",
//        email = "hacddi@gmail.com",
//        age = 21,

//    };
//    Employee[] employees = {employee1, employee2, employee3};
//    return employees;





//}




////Task6

//using ConsoleApp1;

//Factorial factorial = new Factorial();

//int factorialResult = factorial.GetFactorial(4);


//Console.WriteLine(factorialResult);

using Intro.Business;
using Intro.Entities;

Console.WriteLine("Hello, World!");

string message1 = "Krediler";
int term = 36;
double amount = 100000.5;
bool isAunthenticated = true;


Console.WriteLine(message1);

// Conditions
if (isAunthenticated) // Eğer isAunthenticated true ise
{
    Console.WriteLine("Buton --> Hoşgeldin Berkcan");
}
else
{
    Console.WriteLine("Buton --> Sisteme Giriş Yap.");
}

string[] loans = new string[] { "Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5", "Kredi 6" }; 

for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}

//string[] loans2 = new string[6];
//loans2[0] = "Kredi 1";
//loans2[1] = "Kredi 2";
//loans2[2] = "Kredi 3";
//loans2[3] = "Kredi 4";
//loans2[4] = "Kredi 5";
//loans2[5] = "Kredi 6";


Course course1 = new Course(); // Course sınıfından course1 adında bir nesne oluşturduk. new : Bellekte bir alan oluşturur.
course1.Id = 1;
course1.Name = "C#";
course1.Description = ".NET 8";
course1.Price = 0;


Course course2 = new Course();
course2.Id = 2;
course2.Name = "Java";
course2.Description = "Java 17";
course2.Price = 10;

Course course3 = new Course();
course3.Id = 3;
course3.Name = "Python";
course3.Description = "Python 3.12";
course3.Price = 20;


Course[] courses = new Course[] { course1, course2, course3 };

for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine(courses[i].Name + " / " + courses[i].Price);
}

Console.WriteLine("------------------");
CourseManager courseManager = new CourseManager();
Course[] courses2 = courseManager.GetAll();
for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);
}
courseManager.GetAll();

Console.WriteLine("Kod Bitti");

IndividualCustomer customer1  = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "564654564654";
customer1.FirstName = "Aslı";
customer1.LastName = "Karayiğit";
customer1.CustomerNumber = "1234";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "5646545264654";
customer2.FirstName = "Özgür";
customer2.LastName = "Atılgan";
customer2.CustomerNumber = "123444";


CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlama.io";
customer3.CustomerNumber = "54654545";
customer3.TaxNumber = "1234547654";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "Abc";
customer4.CustomerNumber = "654779";
customer4.TaxNumber = "1234547654";

//value types --> int, bool, double...
//reference types --> array, class, interface...

BaseCustomer[] customers = {customer1,  customer2, customer3, customer4}; 

//polymorphism

foreach(BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}

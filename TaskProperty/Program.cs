using TaskProperty.Models;

Information info = new Information();

Console.WriteLine("How many users do you want to enter ");
int count = Convert.ToInt32((Console.ReadLine()));
for (int i = 1; i <= count; i++)
{
    Console.WriteLine("enter username : " + count);
    string username = Console.ReadLine();
    info.username=username;
}


//info.Salary(salary);

Console.WriteLine("Please enter Salary = ");
info.Salary = Convert.ToInt32((Console.ReadLine()));

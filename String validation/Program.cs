Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
string a;
bool b = false;
do
{
    a = Console.ReadLine();
    if (a != null)
    {
        a = a.Trim();
        a = a.ToLower();
        if (a == "administrator" || a == "manager" || a == "user")
        {
            b = true;
        }

        else
        {
            Console.WriteLine($"The role name that you entered, \"{a}\" is not valid.");
            Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
        }
    }
}
while (b == false);
Console.WriteLine($"Your input value ({a}) has been accepted.");
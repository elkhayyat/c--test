string permission = "Admin|Manager";
int level = 55;
if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}

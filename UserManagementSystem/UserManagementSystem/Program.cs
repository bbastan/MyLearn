using UserManagementSystem;

User user = new("Ali",25,"ali123","a@123");

try
{
    user.Login("ali123", "a@123");
    user.DisplayInfo();
    user.Logout();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

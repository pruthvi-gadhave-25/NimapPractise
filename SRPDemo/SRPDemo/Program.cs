using SRPDemo;

public  class Program
{
    public  static void Main(string[] args)
    {
        Console.WriteLine("SRP Demo! ");

        User user = new User
        {
            Name = "Pruthvitak",
            Email = "ofijo@mial.com"

        };
        UserRepository userRepository = new UserRepository();
        userRepository.SaveToFilePath(user);

        UserPrinter userPrinter = new UserPrinter();
        userPrinter.Print(user);

    }
}
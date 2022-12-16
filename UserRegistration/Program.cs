namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WelCome to User Registration Program");

            Pattern patternCheck = new Pattern();

            Console.WriteLine("Registration of First name");
            patternCheck.FirstNameCheck();

            Console.WriteLine("Registration of Last name");
            patternCheck.LastNameCheck();

            Console.WriteLine("Registration of Email Id");
            patternCheck.EmailCheck();

            Console.WriteLine("Registration of Mobile Number");
            patternCheck.MobileNumberCheck();
        }
    }
}
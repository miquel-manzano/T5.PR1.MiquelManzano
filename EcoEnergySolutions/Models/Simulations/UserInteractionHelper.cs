namespace SimulationsLibrary
{
    public class UserInteractionHelper
    {
        public static double UserDoubleInput(double minValue)
        {
            double userNumber = 0;
            bool isValid;
            do
            {
                try
                {
                    userNumber = double.Parse(Console.ReadLine());
                    if (userNumber < minValue)
                    {
                        throw new Exception();
                    }
                    isValid = true;
                }
                catch
                {
                    Console.WriteLine("Invalid number");
                    isValid = false;
                }
            } while (!isValid);
            return userNumber;
        }

        public static int UserIntInput()
        {
            return UserIntInput(0);
        }

        public static int UserIntInput(int minValue)
        {
            int userNumber = 0;
            bool isValid;
            do
            {
                try
                {
                    userNumber = int.Parse(Console.ReadLine());
                    if (userNumber < minValue)
                    {
                        throw new Exception();
                    }
                    isValid = true;
                }
                catch
                {
                    Console.WriteLine("Invalid number");
                    isValid = false;
                }
            } while (!isValid);
            return userNumber;
        }
    }
}

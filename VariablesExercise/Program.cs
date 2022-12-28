namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
                string dogName; //declaration syntax

                   dogName = "Rex"; //initializing variable

                int dogAge = 5;  //declaring & initializing

                char firstInitial = 'R';

                bool isHungry = true;

                double dogWeight = 54.3;

                decimal dogHeight = 14.7m;

                Console.WriteLine($"My dog's name is {dogName}. He is {dogAge} years old. " +
                    $"It is {isHungry} he is always hungry. He weighs {dogWeight}" +
                    $"pounds and is {dogHeight} inches tall. ");
        }
    }
}

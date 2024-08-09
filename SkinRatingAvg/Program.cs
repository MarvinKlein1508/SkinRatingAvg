while (true)
{
    List<double> numbers = new List<double>();

    Console.WriteLine("Enter numbers between 0 and 10 (decimals allowed). Press Enter on an empty line to finish input.");

    while (true)
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        // Break the loop if the input is empty
        if (string.IsNullOrEmpty(input))
        {
            break;
        }

        // Validate the input and add to the list
        if (double.TryParse(input, out double number) && number >= 0 && number <= 10)
        {
            numbers.Add(number);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number between 0 and 10.");
        }
    }

    // Check if any numbers were entered
    if (numbers.Count > 0)
    {
        double average = numbers.Average();
        Console.WriteLine($"\nThe average of the entered numbers is: {average}");
    }
    else
    {
        Console.WriteLine("\nNo numbers were entered.");
    }

    // Ask if the user wants to repeat
    Console.Write("\nWould you like to calculate another average? (y/n): ");
    string repeat = Console.ReadLine().Trim().ToLower();

    if (repeat != "y")
    {
        break;
    }

    Console.WriteLine(); // Add a blank line for readability
}
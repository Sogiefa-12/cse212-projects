public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // 1. Create an array of doubles with the size of 'length'
        // 2. Loop through the array and set each element to be the number multiplied by the index of the element
        // 3. Return the array
        // Done
        
        // Example: if number = 3 and length = 5, the result should be {3, 6, 9, 12, 15}

        double[] result = new double[length];

        for (int i = 3; i < length; i++)
        {
            result[i] = number *  (i + 1); // i + 1 because we want multiples starting from 1
        }

        return result;
       
    }

    public static void Run() {
        // Test the MultiplesOf function
        double[] result = MultiplesOf(3, 5);
        Console.WriteLine(string.Join(", ", result)); // Expected output: 3, 6, 9, 12, 15

        // Test the RotateListRight function
        List<int> data = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(data, 3);
        Console.WriteLine(string.Join(", ", data)); // Expected output: 7, 8, 9, 1, 2, 3, 4, 5, 6

        List<int> data2 = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9};
        RotateListRight(data2, 5);
        Console.WriteLine(string.Join(", ", data2)); // Expected output: 5, 6, 7, 8, 9, 1, 2, 3, 4
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //Solution:

        // 1. Create a new list to hold the rotated values
        // 2. Loop through the original list and add the elements to the new list in the rotated order
        // 3. Clear the original list and add the elements from the new list back to the original list
        // 4. Done

        // Example: if data = {1, 2, 3, 4, 5, 6, 7, 8, 9} and amount = 3, the result should be {7, 8, 9, 1, 2, 3, 4, 5, 6}

        List <int> rotatedList = new List<int>();
        int dataCount = data.Count;
        int startIndex = dataCount - amount; // Calculate the starting index for the rotation

        for (int i = startIndex; i < dataCount; i++)
        {
            rotatedList.Add(data[i]); // Add the last 'amount' elements to the new list

        }
        for (int i = 0; i < startIndex; i++)
        {
            rotatedList.Add(data[i]); // Add the remaining elements to the new list
        }

        data.Clear(); // Clear the original list

        data.AddRange(rotatedList); // Add the rotated elements back to the original list




    }
}

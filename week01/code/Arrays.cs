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

        // Step 1: Create a List to contain the multiples. Step 2: Create a for loop that multiples
        // the number with i and iterate through up to the length of the list. Step 3: In the for loop, 
        //add the multiple to the multiples list. Step 4: Return the list as an array of doubles
        var multiplesList = new List<double>();
        for (int i = 1; i < length + 1; i++)
        {
            var multiple = number * i;
            multiplesList.Add(multiple);
        }

        return multiplesList.ToArray(); // replace this return statement with your own
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

        //Splice the list to get all the numbers except the new value wanted at data[0] and save
        //as variable. Use RemoveRange to remove the spliced list from data. Add the spliced list
        //back to the original list.

        var spliced = data.GetRange(0, data.Count - amount);
        data.RemoveRange(0, data.Count - amount);
        data.AddRange(spliced);
    }
}
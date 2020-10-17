using System;

class ArrayExample
{
    static void DisplayArray(string[] arr) => Console.WriteLine(string.Join(" ", arr));

    // Change the array by reversing its elements.
    static void ChangeArray(string[] arr) => Array.Reverse(arr);

    static void ChangeArrayElements(string[] arr)
    {
        // Change the value of the first three array elements.
        arr[0] = "Mon";
        arr[1] = "Wed";
        arr[2] = "Fri";
    }

    static void Main()
    {
        // Declare and initialize an array.
        string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
        // Display the array elements.
        Console.WriteLine("Before");
        DisplayArray(weekDays);
        Console.WriteLine();

        // Reverse the array.
        ChangeArray(weekDays);
        // Display the array again to verify that it stays reversed.
        Console.WriteLine("After:");
        DisplayArray(weekDays);
        Console.WriteLine();

        //// Assign new values to individual array elements.
        //ChangeArrayElements(weekDays);
        //// Display the array again to verify that it has changed.
        //Console.WriteLine("Array weekDays after the call to ChangeArrayElements:");
        //DisplayArray(weekDays);
    }
}

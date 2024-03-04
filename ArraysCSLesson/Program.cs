namespace ArraysCSLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///In C#, an array is a data structure that stores a fixed-size sequential collection 
            ///of elements of the same type. The elements can be accessed by their index in the array,
            ///which is an integer value that starts at 0 for the first element and increases by 1 for 
            ///each subsequent element. You can declare an array by specifying the data type of its elements
            ///and the number of elements in square brackets, like this:
            
            int[] myArray = new int[10];
            
            ///This declares an array named "myArray" and can hold 10 integers in index 0-9
            ///Another way of initialising an array is doing so with values like this:
           
            int[] numArray = {1,2,3,4,5};
           
            ///An alternative is to use the new keyword like this:
           
            int[] numsArray = new int[] { 1, 2, 3, 4, 5 };

            ///To access the elements of an array, use the index in square brackets like this

            myArray[0] = 100;

            ///To get the value use the same method
           
            Console.WriteLine(myArray[0]);

            ///Arrays have a number of tools that you can use with them, the most common is finding the length like this:

            Console.WriteLine(myArray.Length);

            ///You can use loops to iterate over the elements of an array and perform operations on them
            ///in C# you can use the "For" loop like this:
            
            for(int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            /// in the above example the loop starts at 0 and continues while i is less than the length
            /// The length is always one more than the last index
            /// An alternative is to loop through each element using a foreach loop
            
            foreach(int i in numsArray)
            {
                Console.WriteLine(i);
            }

            /// This code will do the same as the previous one but i is used to store the value in the array element
            /// that is being accessed.  The example below is the same but for an array of strings
            string[] strArray = { "This", "is", "an", "array", "of", "strings" };
            foreach(string str in strArray)
            {
                Console.WriteLine(str);
            }
        }
    }
}

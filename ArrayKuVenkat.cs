namespace DotNet_VS_Code
{
    //Can you store different types in C# array
    //Answer is -- Yes if you create an object array.

    public class ArrayKuVenkat
    {
        public ArrayKuVenkat()
        {
            
        }

        object[] objArray;

        public object[] GetArray()
        {
            objArray = new object[4];
            objArray[0] = 1; objArray[1] = "Alok"; objArray[2] = "Dream UPSC"; objArray[3] = 66000.50;
            return objArray;
        }

        //For storing different types you can use 
        // Array, class property, ArrayList
    }
}
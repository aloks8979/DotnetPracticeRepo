namespace DotNet_VS_Code
{
    public class Student1
    {
        string name = "Alok Singh";
        public Student1(string name=null)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }
    }
}
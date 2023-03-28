// --------- Divide By Zero! ----------


//static double Divide(double x, double y)
//{
    //this does not work....does not throw error as expected
//try
//    {
//        return x / y;
//    }
//    catch (ArgumentOutOfRangeException e) 
//    {
//        throw new ArgumentOutOfRangeException("You cannot divide by zero!");
//    }
//        if (y == 0)
//        throw new ArgumentOutOfRangeException("You cannot divide by zero!");

//    return x / y;
//}


// Test out your Divide() function here!
//Console.WriteLine(Divide(7, 0));

// --------- Test Student Labs ----------

static int CheckFileExtension(string fileName)
{
    // Write your code here!
    if (fileName == null || fileName == "")
    {
        throw new ArgumentNullException("filename", "Student did not submit work.");
    }

    if (fileName.EndsWith(".cs"))
    {
            return 1;
    }
    else
    {
        return 0;
    }

}


// Test out your CheckFileExtension() function here!

Dictionary<string, string> students = new Dictionary<string, string>();
students.Add("Carl", "Program.cs");
students.Add("Brad", "");
students.Add("Elizabeth", "MyCode.cs");

Console.WriteLine(CheckFileExtension(students["Brad"]));

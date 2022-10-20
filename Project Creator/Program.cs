using System;
using System.Diagnostics;


Console.WriteLine("1. React.js");
Console.WriteLine("2. Vue.js");
Console.WriteLine("3. Next.js");

Console.WriteLine("Which project do you want to create?");


int project = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your project name?");
string pname = Console.ReadLine();
//Console.WriteLine("Enter your project location");
//string loc = Console.ReadLine();
string react = "npx create-react-app "+pname;

switch (project)
{
    case 1:
        ProcessStartInfo startInfo = new ProcessStartInfo();
        startInfo.FileName = "CMD.exe";
        startInfo.Arguments = "/k" + react;
        startInfo.UseShellExecute = false;
        startInfo.Verb = "runas";
        Process.Start(startInfo);
        break;
    case 2:
        Console.WriteLine("Vue");
        break;
    case 3:
        Console.WriteLine("Next");
        break;
    case 4:
        Console.WriteLine("test");
        break;
    default:
        break;
}



Console.ReadLine();
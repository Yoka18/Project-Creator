using System;
using System.Diagnostics;

ProcessStartInfo startInfo = new ProcessStartInfo();

Console.WriteLine("1. React.js");
Console.WriteLine("2. Vue.js");
Console.WriteLine("3. Next.js");

Console.WriteLine("Which project do you want to create?");


int project = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your project name?");
string pname = Console.ReadLine();
Console.WriteLine("Enter your project location");
string loc = Console.ReadLine();
string react = "npx create-react-app " + pname;
string next = "npx create-next-app " + pname;
string vue = "npm init vue@latest " + pname;


switch (project)
{
    case 1:
        startInfo.FileName = "CMD.exe";
        startInfo.Arguments = "/k" + react;
        startInfo.UseShellExecute = false;
        startInfo.WorkingDirectory = loc;
        startInfo.Verb = "runas";
        Process.Start(startInfo);
        Process.Start("explorer.exe", loc);
        break;
    case 2:
        startInfo.FileName = "CMD.exe";
        startInfo.Arguments = "/k" + vue;
        startInfo.UseShellExecute = false;
        startInfo.WorkingDirectory = loc;
        startInfo.Verb = "runas";
        Process.Start(startInfo);
        Process.Start("explorer.exe", loc);
        break;
    case 3:
        startInfo.FileName = "CMD.exe";
        startInfo.Arguments = "/k" + next;
        startInfo.UseShellExecute = false;
        startInfo.WorkingDirectory = loc;
        startInfo.Verb = "runas";
        Process.Start(startInfo);
        Process.Start("explorer.exe", loc);
        break;
    default:
        break;
}



Console.ReadLine();
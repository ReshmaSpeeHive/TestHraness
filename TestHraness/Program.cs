using System.Reflection;

const string TargetAssemblyFileName = "UtilityFunctions.dll";
const string TargetNamespace = "UtilityFunctions";
Assembly assembly= Assembly.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, TargetAssemblyFileName));
List<System.Type> classes= assembly.GetTypes()
    .Where(t=>t.Namespace == TargetNamespace).ToList();
ThisClass.WritePromptToScreen("Please press the number key associated with " +
                                   "the class you wish to test");
int count = 0;
foreach (System.Type t in classes)
{
    count++;
    Console.WriteLine($"{count}.{t}");
}
ConsoleKey consoleKey = Console.ReadKey().Key;
Type classChoice = null;
switch (consoleKey)
{
    case ConsoleKey.D1:
        classChoice = classes[0];
        break;
    case ConsoleKey.D2:
        classChoice = classes[1];
        break;
    case ConsoleKey.D3:
        classChoice = classes[2];
        break;
    case ConsoleKey.D4:
        classChoice = classes[3];
        break;
}
object classInstance = Activator.CreateInstance(classChoice, null);
Console.Clear();
ThisClass.WriteHeadingToScreen($"Class: '{classChoice}'");
public static class ThisClass
{
    public static void WritePromptToScreen(string promptText)
    {
        Console.WriteLine(promptText);

    }
   public static void WriteHeadingToScreen(string heading)
    {
        Console.WriteLine(heading);
        Console.WriteLine(new string('-', heading.Length));
        Console.WriteLine();

    }
}
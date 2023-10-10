using System.Reflection;

const string TargetAssemblyFileName = "UtilityFunctions.dll";
const string TargetNamespace = "UtilityFunctions";
Assembly assembly= Assembly.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, TargetAssemblyFileName));
List<System.Type> classes= assembly.GetTypes()
    .Where(t=>t.Namespace == TargetNamespace).ToList();
ThisClass.WritePromptToScreen("Please press the number key associated with " +
                                   "the class you wish to test");
//int count = 0;
//foreach (System.Type t in classes)
//{
//    count++;
//    Console.WriteLine($"{count}.{t}");
//}
ThisClass.DisplayProgramElementList(classes);
Type typeChoice=ThisClass.ReturnProgramElementReferenceFromList(classes);

//ConsoleKey consoleKey = Console.ReadKey().Key;
//Type classChoice = null;
//switch (consoleKey)
//{
//    case ConsoleKey.D1:
//        classChoice = classes[0];
//        break;
//    case ConsoleKey.D2:
//        classChoice = classes[1];
//        break;
//    case ConsoleKey.D3:
//        classChoice = classes[2];
//        break;
//    case ConsoleKey.D4:
//        classChoice = classes[3];
//        break;
//}
object classInstance = Activator.CreateInstance(typeChoice, null);
Console.Clear();
ThisClass.WriteHeadingToScreen($"Class: '{typeChoice}'");
ThisClass.WritePromptToScreen("Please enter the number associated with the method you wish to test");
List<MethodInfo> methods = typeChoice.GetMethods().ToList();
ThisClass.DisplayProgramElementList(methods);
MethodInfo methodChoice = ThisClass.ReturnProgramElementReferenceFromList(methods);
if (methodChoice != null)
{
    Console.Clear();

    ThisClass.WriteHeadingToScreen($"Class: '{typeChoice}' - Method: '{methodChoice.Name}'");
    ParameterInfo[] parameters = methodChoice.GetParameters();

}
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
    public static void DisplayProgramElementList<T>(List<T> list)
    {
        int count = 0;

        foreach (var item in list)
        {
            count++;
            Console.WriteLine($"{count}. {item}");
        }

    }
    public static T ReturnProgramElementReferenceFromList<T>(List<T> list)
    {
        ConsoleKey consoleKey = Console.ReadKey().Key;

        switch (consoleKey)
        {
            case ConsoleKey.D1:
                return list[0];
            case ConsoleKey.D2:
                return list[1];
            case ConsoleKey.D3:
                return list[2];
            case ConsoleKey.D4:
                return list[3];

        }
        return default;
    }

}
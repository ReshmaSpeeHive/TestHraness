using System.Reflection;

const string TargetAssemblyFileName = "UtilityFunctions.dll";
const string TargetNamespace = "UtilityFunctions";
Assembly assembly= Assembly.Load(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, TargetAssemblyFileName));
List<System.Type> classes= assembly.GetTypes()
    .Where(t=>t.Namespace == TargetNamespace).ToList();
ThisClass.WritePromptToScreen("Please press the number key associated with " +
                                   "the class you wish to test");
 public static class ThisClass
{
    public static void WritePromptToScreen(string promptText)
    {
        Console.WriteLine(promptText);

    }
}
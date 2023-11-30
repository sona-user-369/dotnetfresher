global using System ;
using System.Reflection;

Assembly? myApp = Assembly.GetEntryAssembly();

if (myApp == null) return;

foreach (AssemblyName name in myApp.GetReferencedAssemblies())
{
    Assembly a = Assembly.Load(name);

    int countMethod = 0;
    
    foreach(TypeInfo t in a.DefinedTypes)
    {
        countMethod =+ t.GetMethods().Count();
    }
    
    Console.WriteLine(
        "{0:N0} type with {1:N0} methods in {2} assembly",
        arg0:a.DefinedTypes.Count(),
        arg1:countMethod,
        arg2:name.Name
        );


}

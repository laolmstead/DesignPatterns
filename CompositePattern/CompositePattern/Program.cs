using CompositePattern;

// Build structure
CompositeFolder root = new CompositeFolder("Root folder");
root.Components.Add(new CompositeFile("File 1"));
root.Components.Add(new CompositeFile("File 2"));

CompositeFolder compositeFolder = new CompositeFolder("Folder 1");
root.Components.Add(compositeFolder);

compositeFolder.Components.Add(new CompositeFile("File 3"));
compositeFolder.Components.Add(new CompositeFile("File 4"));

CompositeFolder compositeFolder1 = new CompositeFolder("Folder 2");
compositeFolder1.Components.Add(new CompositeFile("File 5"));

compositeFolder.Components.Add(compositeFolder1);
compositeFolder.Components.Add(new CompositeFile("File 6"));

// Traverse the tree and print names
PrintNames(root, string.Empty);


static void PrintNames(IComponent comp, string prefix)
{
    Console.WriteLine($"{prefix}{comp.Name}");

    if (comp is CompositeFolder folder)
    {
        prefix += "\t";
        foreach (IComponent component in folder.Components)
            PrintNames(component, prefix);
    }
    else if (comp is CompositeFile)
    {
        return;
    }
}
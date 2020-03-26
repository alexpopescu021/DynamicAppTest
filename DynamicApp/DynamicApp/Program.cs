﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DynamicApp.Abstractions;
using DynamicApp.Shared;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Reflection;

namespace DynamicApp
{
    
    public class Program
    {
        static UIModuleLoader moduleLoader = new UIModuleLoader();
        static void Main(string[] args)
        {

            DirectoryCatalog dcatalog = new DirectoryCatalog("plugins", "*.dll");

            Console.WriteLine(dcatalog);
            
            AggregateCatalog catalog = new AggregateCatalog(dcatalog);

            CompositionContainer container = new CompositionContainer(catalog);
            container.ComposeParts(moduleLoader);


        }
        /*
        var currentDirectory = Directory.GetCurrentDirectory();
        UIModuleLoader moduleLoader = new UIModuleLoader();

        try
        {
            if (moduleLoader.LoadModulesFromDirectory(Path.Combine(currentDirectory, "plugins")))
            {
                Console.WriteLine($"{moduleLoader.Modules.Count()} modules were loaded");
            }
            else
            {
                Console.WriteLine($"Some of the modules could not be loaded. We have {moduleLoader.Modules.Count()} modules loaded");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Unexpected exception occured while trying to load modules. " + e.Message);
        }            

        Console.WriteLine("Press enter to continue");
        Console.ReadLine();
        List<IMenu> mainMenuItems = new List<IMenu>();
        foreach (IDynamicModule currentModule in moduleLoader.Modules)
        {
            mainMenuItems.Add(currentModule.GetModuleMenu());
        }

        Menu mainMenu = new Menu(mainMenuItems);
mainMenu.Execute(null);*/

    }
}
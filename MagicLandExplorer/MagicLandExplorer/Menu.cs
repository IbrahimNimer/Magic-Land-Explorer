using System;
using System.Collections.Generic;

public delegate void MenuAction();

public class MenuItem
{
    public string Description { get; }
    public MenuAction Action { get; }

    public MenuItem(string description, MenuAction action)
    {
        Description = description;
        Action = action;
    }
}

public class Menu
{
    private readonly List<MenuItem> _menuItems;

    public Menu(List<MenuItem> menuItems)
    {
        _menuItems = menuItems;
    }

    public void Display()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Magic Land Explorer Menu");
            Console.WriteLine("------------------------");

            for (int i = 0; i < _menuItems.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_menuItems[i].Description}");
            }

            Console.Write("\nPlease select an option: ");
            if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= _menuItems.Count)
            {
                _menuItems[choice - 1].Action();
                if (_menuItems[choice - 1].Description == "Exit")
                {
                    break;
                }
            }
            else
            {
                Console.WriteLine("Invalid selection. Please try again.");
                Pause();
            }
        }
    }

    private static void Pause()
    {
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }
}

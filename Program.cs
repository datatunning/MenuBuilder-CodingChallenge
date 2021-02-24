using System;
using System.Collections.Generic;
using DerivCo.interfaces;

namespace DerivCo
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Initialize menu!");
    
            var rootMenu = new List<IMenuItem>
            {
                new MenuItem("Administration",
                    new MenuItem("User Admin", 
                        new MenuItem("Create User"),
                        new MenuItem("Edit User")),
                    new MenuItem("Product Admin", 
                        new MenuItem("All Products", 
                            new MenuItem("My Products")
                        ), 
                        new MenuItem("Create product")
                    ),
                    new MenuItem("Order Admin", 
                        new MenuItem("Order Reports", 
                            new MenuItem("Audit Reports", 
                                new MenuItem("Updated Orders"),
                                new MenuItem("Created Orders")
                            ), 
                            new MenuItem("Create Order")
                        )
                    )
                ),
                new MenuItem("Reports", 
                    new MenuItem("Win Tech Report"),
                    new MenuItem("Microsoft Report")
                ),
            };

            rootMenu.ForEach((menu) => PrintMenu(menu));

        }

        /// <summary>
        /// Recursively print and indent the menu and its sub-menu..
        /// </summary>
        /// <param name="menu">The menu.</param>
        /// <param name="indent">The indent.</param>
        static void PrintMenu(IMenuItem menu, int indent = 0)
        {
            Console.WriteLine($"{" ".PadLeft(indent * 3)}- {menu?.Name}");
            indent++;
            menu?.SubMenu?.ForEach((sm) => PrintMenu(sm, indent));
        }
    }
}

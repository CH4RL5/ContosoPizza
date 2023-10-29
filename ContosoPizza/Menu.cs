using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoPizza
{
    public class Menu
    {
        string optionMenu = " ";
        CRUD crud = new CRUD();
        public void Start() {
            do {
                Options();
            }while (optionMenu != "0");

        }
        private void Options() {
            Console.WriteLine("Pizza Menu");
            Console.WriteLine("\n");
            Console.WriteLine("1: [Add Pizza]    -   3: [Delete Pizza]");
            Console.WriteLine("2: [List Pizza]   -   4: [Edit Pizza]");
            Console.WriteLine("0: [Salir]");
            Console.WriteLine("\n");
            Console.WriteLine("Selection the option that you wish");
            optionMenu = Console.ReadLine();
            selectionMenu(optionMenu);

        }
        private void selectionMenu(string op) { 
            if (op == "") 
                return;
            switch (op)
            {
                case "1":
                    crud.createProduct();
                    break;
                case "2":
                    crud.readProduct();
                    break;
                case "3":
                    crud.deleteProduct();
                    break;
                case "4":
                    crud.updateProduct();
                    break;
                case "r":
                    Console.Clear();
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Option Invalid");
                    break;

            }
            
        }
        private void returnMenu() {
            string op;
            Console.WriteLine("Press r for return to main menu");
            op = Console.ReadLine();
            selectionMenu(op);
        }
    }
}

using System;

    class Principal
    {
        bool salir;

        Principal()
        {
        }

        public void menu()
        {
            Contacto contacto = new Contacto();
            int opcion;
            string id, nombre, telefono;
            Console.Write("1.- Mostrar contactos" +
                "\n2.- Agregar contacto" +
                "\n3.- Modificar contacto" +
                "\n4.- Eliminar contacto" +
                "\n5.- Salir" +
                "\n\nSelecciona una opcion: ");
            try
            {
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1: contacto.mostrarTodos();
                        break;
                    case 2: Console.Write("Nombre: ");
                        nombre = Console.ReadLine();
                        Console.Write("Telefono: ");
                        telefono = Console.ReadLine();
                        contacto.insertarRegistroNuevo(nombre, telefono);
                        break;
                    case 3: Console.Write("Id: ");
                        id = Console.ReadLine();
                        if (contacto.consultaId(id).Length > 0)
                        {
                            Console.Write("Nombre: ");
                            nombre = Console.ReadLine();
                            Console.Write("Telefono: ");
                            telefono = Console.ReadLine();
                            contacto.editarRegistro(id, nombre, telefono);
                        }
                        else
                            Console.WriteLine("El id no existe");
                        break;
                    case 4: Console.Write("Id: ");
                        id = Console.ReadLine();
                        if (contacto.consultaId(id).Length > 0)
                        {
                            Console.WriteLine("Contacto eliminado");
                            contacto.eliminarRegistroPorId(id);
                        }
                        else
                            Console.WriteLine("El id no existe");
                        break;
                    case 5:
                        salir = true;
                        break;
                    default: Console.WriteLine("Opcion invalida");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Debe ingresar un entero");
            }

        }


        static void Main(string[] args)
        {
            Console.Title = "Agenda";
            Console.SetWindowSize(100, 30);
            Principal principal = new Principal();
            do
            {
                Console.Clear();
                principal.menu();
                Console.ReadKey();
            } while (!principal.salir);
        }
    }
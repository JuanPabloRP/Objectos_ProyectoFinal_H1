

namespace Objectos_ProyectoFinal_H1
{

    //clase usuarios que maneja el software
    class Usuario
    {
        public int id { get; set; }
        public string name { get; set; }
        public int docI { get; set; }
        public string username { get; set; }
        public string password { get; set; }


        public Usuario(int _id)
        {
            id = _id;
            name = null;
            docI = 0;
            username = null;
            password = null;
        }
    }

    //cliente, el dueño del vehiculo - También esta clase puede ser llamada vehiculo
    class Cliente
    {
        public int id { get; set; }
        public string tipo { get; set; }
        public string placa { get; set; }
        public string color { get; set; }
        public double totalAPagar { get; set; }

        public Cliente(int _id)
        {
            id = _id;
            tipo = null;
            placa = null;
            color = null;
            totalAPagar = 0;
        }

        

    }

    //el lugar de estacionamiento, esta clase se usara internamente para el funcionamiento
    class Lugar
    {
        public int id { get; set; }
        public string puesto { get; set; }
        public bool disponible { get; set; }


        public Lugar(int _id)
        {
            id = _id;
            puesto = null;
            disponible = true;
        }

    }


    class Program
    {
        
        static void Main()
        {

            //Pa crear un usuario
            Console.WriteLine("\nPa crear el usuario admin: ");
            int id = 0;
            
            Console.Write("Ingrese su id: ");
            id = int.Parse(Console.ReadLine());

            Usuario user = new Usuario(id);


            Console.Write("\nIngrese su nombre: ");
            user.name = Console.ReadLine();

            Console.Write("\nIngrese su documento de identidad: ");
            user.docI = int.Parse(Console.ReadLine());

            Console.Write("\nIngrese su username: ");
            user.username = Console.ReadLine();

            Console.Write("\nIngrese su password: ");
            user.password = Console.ReadLine();


            Console.WriteLine("\nId del sujeto: " + user.id);
            Console.WriteLine("Name del sujeto: " + user.name);
            Console.WriteLine("Doc Identidad del sujeto: " + user.docI);
            Console.WriteLine("Username del sujeto: " + user.username);
            Console.WriteLine("PassW del sujeto: " + user.password);
            Console.WriteLine("\n");


            //pa crear un vehiculo
            Console.WriteLine("\nPa crear el cliente/vehiculo: ");
            id = 0;
            
            Console.Write("\nIngrese su id: ");
            id = int.Parse(Console.ReadLine());
            
            Cliente cliente = new Cliente(id);
            
            Console.Write("\nIngrese su tipo: ");
            cliente.tipo = Console.ReadLine();

            Console.Write("\nIngrese su placa: ");
            cliente.placa = Console.ReadLine();

            Console.Write("\nIngrese su color: ");
            cliente.color = Console.ReadLine();

            Console.WriteLine("\nId del vehiculo: " + cliente.id);
            Console.WriteLine("Tipo de vehiculo: " + cliente.tipo);
            Console.WriteLine("Email del sujeto: " + cliente.placa);
            Console.WriteLine("Username del sujeto: " + cliente.color);
            Console.WriteLine("\n");


            //pa crear un puesto
            Console.WriteLine("\nPa crear un puesto de estacionamiento: ");
            id = 0;
            string disponible = "";

            Console.Write("\nIngrese su id: ");
            id = int.Parse(Console.ReadLine());

            Lugar lugar = new Lugar(id);

            Console.Write("\nIngrese su puesto: ");
            lugar.puesto = Console.ReadLine();

            Console.Write("\nIngrese su disponible: ");
            lugar.disponible = bool.Parse(Console.ReadLine());

            Console.WriteLine("\nId del lugar: " + lugar.id);
            Console.WriteLine("Puesto: " + lugar.puesto);


            disponible = lugar.disponible == true ? "Disponible" : "Ocupado";

            Console.WriteLine("Disponibilidad del puesto: " + disponible);
            

        }
    }
}




//cambios pa después - jprp xd

//va en Program
/*
static List<int> ids = new List<int>();
static List<string> users = new List<string>();
static List<string> password = new List<string>();
*/



//va en el main xd

/*
            int op = 0, id = 0;
            string dato = "";
            
            do
            {
                Console.WriteLine("Ingrese su id: ");
                dato = Console.ReadLine();
                
                if (int.TryParse(dato, out id))
                {
                    Usuarios user = new Usuarios(id);

                    Console.WriteLine("\nIngrese su username: ");
                    user.username = Console.ReadLine();

                    Console.WriteLine("\nIngrese su password: ");
                    user.password = Console.ReadLine();

                    
                    Console.WriteLine("Id del sujeto: " + user.id);
                    Console.WriteLine("Name del sujeto: " + user.username);
                    Console.WriteLine("PassW del sujeto: " + user.password);
                    

                    ids.Add(user.id);
                    users.Add(user.username);
                    password.Add(user.password);


                }
                else
                {
                    Console.WriteLine("Error, ingrese un ID numerico");
                }

                dato = "";
                Console.WriteLine("1-si desea continuar, otra tecla si desea salir: ");
                op = int.Parse(Console.ReadLine());



                if (op != 1)
                {
                    break;
                }
                

            } while ( int.TryParse(dato, out id) == false || op == 1);


            ids.ForEach(id => Console.WriteLine("id: " + id));
            users.ForEach(user => Console.WriteLine("user: " + user));
            password.ForEach(password => Console.WriteLine("password: " + password) );

            */
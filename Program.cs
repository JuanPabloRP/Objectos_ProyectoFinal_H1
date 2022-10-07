

namespace Objectos_ProyectoFinal_H1
{

    //clase usuarios
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

    class Vehiculo
    {
        public int id { get; set; }
        public string tipo { get; set; }
        public string placa { get; set; }
        public string color { get; set; }

        public Vehiculo(int _id)
        {
            id = _id;
            tipo = null;
            placa = null;
            color = null;
        }

    }

    class Program
    {
        
        static void Main()
        {
            /*
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
            */

            
            int id = 0;

            Console.Write("Ingrese su id: ");
            id = int.Parse(Console.ReadLine());

            Vehiculo vehiculo = new Vehiculo(id);

            Console.Write("\nIngrese su tipo: ");
            vehiculo.tipo = Console.ReadLine();

            Console.Write("\nIngrese su placa: ");
            vehiculo.placa = Console.ReadLine();

            Console.Write("\nIngrese su color: ");
            vehiculo.color = Console.ReadLine();

            Console.WriteLine("\nId del vehiculo: " + vehiculo.id);
            Console.WriteLine("Tipo de vehiculo: " + vehiculo.tipo);
            Console.WriteLine("Email del sujeto: " + vehiculo.placa);
            Console.WriteLine("Username del sujeto: " + vehiculo.color);
            Console.WriteLine("\n");
            
        }
    }
}




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
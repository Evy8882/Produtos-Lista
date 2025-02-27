using System;

namespace ProdutosMenu
{

    class Item
    {
        public string Name;
        public float Price;
        public Item(string name, float price)
        {
            Name = name;
            Price = price;
        }
    }
    class Program
    {
        static Item MateriaisEscolares()
        {
            Console.WriteLine("Digite o número do produto que deseja: \n\t1 - Lápis\tR$ 2,00\n\t2 - Caneta\tR$ 4,00");
            int opt = Int32.Parse(Console.ReadLine());
            while (opt != 1 && opt != 2 && opt != 3 && opt != 4 && opt != 5)
            {
                Console.WriteLine("Código inválido");
                Console.WriteLine("Digite o número do produto que deseja: \n\t1 - Lápis\tR$ 2,00\n\t2 - Caneta\tR$ 4,00");
                opt = Int32.Parse(Console.ReadLine());
            }
            switch (opt)
            {
                case 1:
                    return new Item("Lápis", 2);
                case 2:
                    return new Item("Caneta", 4);
                default:
                    return new Item("", 0);
            };
        }
        static Item Eletrodomestico()
        {
            Console.WriteLine("Digite o número do produto que deseja: \n\t1 - Microondas\tR$ 200,00\n\t2 - Geladeira\tR$ 799,00");
            int opt = Int32.Parse(Console.ReadLine());
            while (opt != 1 && opt != 2 && opt != 3 && opt != 4 && opt != 5)
            {
                Console.WriteLine("Código inválido");
                Console.WriteLine("Digite o número do produto que deseja: \n\t1 - Microondas\tR$ 200,00\n\t2 - Geladeira\tR$ 799,00");
                opt = Int32.Parse(Console.ReadLine());
            }
            switch (opt)
            {
                case 1:
                    return new Item("Microondas", 200);
                case 2:
                    return new Item("Geladeira", 799);
                default:
                    return new Item("", 0);
            };
        }
        static Item Ia()
        {
            Console.WriteLine("Digite o número do produto que deseja: \n\t1 - ChatGPT\tR$ 50,00\n\t2 - DeepSeek\tR$ 20,00");
            int opt = Int32.Parse(Console.ReadLine());
            while (opt != 1 && opt != 2 && opt != 3 && opt != 4 && opt != 5)
            {
                Console.WriteLine("Código inválido");
                Console.WriteLine("Digite o número do produto que deseja: \n\t1 - ChatGPT\tR$ 50,00\n\t2 - DeepSeek\tR$ 20,00");
                opt = Int32.Parse(Console.ReadLine());
            }
            switch (opt)
            {
                case 1:
                    return new Item("ChatGPT", 50);
                case 2:
                    return new Item("DeepSeek", 20);
                default:
                    return new Item("", 0);
            };
        }
        static Item MaterialLimpeza()
        {
            Console.WriteLine("Digite o número do produto que deseja: \n\t1 - Agua sanitaria\tR$ 10,00\n\t2 - Detergente\tR$ 5,00");
            int opt = Int32.Parse(Console.ReadLine());
            while (opt != 1 && opt != 2 && opt != 3 && opt != 4 && opt != 5)
            {
                Console.WriteLine("Código inválido");
                Console.WriteLine("Digite o número do produto que deseja: \n\t1 - Agua sanitaria\tR$ 10,00\n\t2 - Detergente\tR$ 5,00");
                opt = Int32.Parse(Console.ReadLine());
            };
            switch (opt)
            {
                case 1:
                    return new Item("Agua Sanitaria", 10);
                case 2:
                    return new Item("Detergente", 5);
                default:
                    return new Item("", 0);
            };
        }
        static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                float total = 0;
                string nome = "";
                Item produto;
                Console.WriteLine("Digite o número correspondente ao tipo de produto que procura: \n\t1 - Materiais escolares\n\t2 - Eletrodomésticos\n\t3 - I.A.\n\t4 - Materiais de limpeza\n\t5 - Sair");
                int opt = Int32.Parse(Console.ReadLine());
                while (opt != 1 && opt != 2 && opt != 3 && opt != 4 && opt != 5)
                {
                    Console.WriteLine("Código inválido");
                    Console.WriteLine("Digite o número correspondente ao tipo de produto que procura: \n\t1 - Materiais escolares\n\t2 - Eletrodomésticos\n\t3 - I.A.\n\t4 - Materiais de limpeza\n\t5 - Sair");
                    opt = Int32.Parse(Console.ReadLine());
                }
                switch (opt)
                {
                    default:
                        produto = MateriaisEscolares();
                        total = produto.Price;
                        nome = produto.Name;
                        break;
                    case 2:
                        produto = Eletrodomestico();
                        total = produto.Price;
                        nome = produto.Name;
                        break;
                    case 3:
                        produto = Ia();
                        total = produto.Price;
                        nome = produto.Name;
                        break;
                    case 4:
                        produto = MaterialLimpeza();
                        total = produto.Price;
                        nome = produto.Name;
                        break;
                    case 5:

                        break;
                }
                Console.WriteLine($"Comprou o produto {nome} por R${total}");
                Console.WriteLine("Deseja continuar?\n\t1 - Sim \n\t2 - Não");
                if (Console.ReadLine() != "1")
                {
                    continuar = false;
                }
            }
        }
    }
}

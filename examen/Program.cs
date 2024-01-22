namespace examen
{
    internal class Program
    {
        static void Main(string[] args)

          
        Console.Write("Introduceți numele clientului: ");
        string customerName = Console.ReadLine();

        Order order = new Order(customerName, orderDate, orderTotal);
    }
}
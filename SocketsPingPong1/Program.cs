using SocketsPingPong1;
using System;

class Program
{
    static void Main(string[] args)
    {
        ClientSide clientSide = new ClientSide();
        clientSide.SendMessage(Console.ReadLine());
    }
}

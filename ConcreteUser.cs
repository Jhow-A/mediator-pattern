using System;

namespace MediatorPattern
{
    // Concrete Colleague
    public class ConcreteUser : User
    {
        public ConcreteUser(IFacebookGroupMediator mediator, string name) : base(mediator, name) { }

        public override void Receive(string message)
        {
            Console.WriteLine($"{name}: recebida <= { message}");
        }

        public override void Send(string message)
        {
            Console.WriteLine($"\n{name}: enviada => {message}\n");
            mediator.SendMessage(message, this);
        }
    }
}

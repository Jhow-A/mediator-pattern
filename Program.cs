using System;

namespace MediatorPattern
{
    static class Program
    {
        static void Main(string[] args)
        {
            var facebookMediator = new ConcreteFacebookGroupMediator();

            var gabi = new ConcreteUser(facebookMediator, "Gabriela");
            var math = new ConcreteUser(facebookMediator, "Matheus");
            var lari = new ConcreteUser(facebookMediator, "Larissa");
            var jhow = new ConcreteUser(facebookMediator, "Jhonathan");

            facebookMediator.RegisterUser(gabi);
            facebookMediator.RegisterUser(math);
            facebookMediator.RegisterUser(lari);
            facebookMediator.RegisterUser(jhow);

            jhow.Send("Teste de envio 1");
            lari.Send("Teste de envio 2");
            gabi.Send("Teste de envio 3");
        }
    }
}

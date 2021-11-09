using System.Collections.Generic;

namespace MediatorPattern
{
    // Concrete Mediator
    public class ConcreteFacebookGroupMediator : IFacebookGroupMediator
    {
        private List<User> usersList = new List<User>();

        public void RegisterUser(User user) => usersList.Add(user);

        public void SendMessage(string message, User user)
        {
            foreach (var u in usersList)
            {
                // Não enviar a mensagem para o remetente também
                if (u != user)
                    u.Receive(message);
            }
        }
    }
}

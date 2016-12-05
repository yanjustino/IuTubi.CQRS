using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IuTubi.CQRS
{

    public class Message
    {
        public DateTime TimeStamp { get; protected set; }
    }

    public class Command : Message
    {
        public string Name { get; protected set; }
    }

    public class Event : Message
    {
    }

    public interface IBus
    {
        void Send<T>(T command) where T : Command;
        void RaiseEvent<T>(T theEvent) where T : Event;
        void RegisterHandler<T>();
    }

    public interface ICanHandle<T> where T : Message
    {
        void Handle(T message);
    }

    public class InMemoryBus : IBus
    {
        private static IList<Type> RegisteredHandlers = new List<Type>();

        void IBus.Send<T>(T message)
        {
            SendInternal(message);
        }

        void IBus.RegisterHandler<T>()
        {
            RegisteredHandlers.Add(typeof(T));
        }

        void SendInternal<T>(T message) where T : Message
        {
            // Step 1: Launch sagas that start with given message
            // Step 2: Deliver message to all already running sagas that
            // match the ID (message contains a saga ID)
            // Step 3: Deliver message to registered handlers
        }

        public void RaiseEvent<T>(T theEvent) where T : Event
        {
            //throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;
using Akka.Actor.Internal;
using Exercise.Akka.Actors;
using Exercise.Akka.Messages;

namespace Exercise.Akka
{
    class Program
    {
        private static ActorSystem StreamingActorSystem;
        static void Main(string[] args)
        {
            StreamingActorSystem = ActorSystem.Create("StreamingActorSystem");

            Console.WriteLine("Actor system was created");

            Props playbackActorProps = Props.Create<PlaybackActor>();

            IActorRef actorRef = StreamingActorSystem.ActorOf(playbackActorProps, "PlaybackActor");

            actorRef.Tell(new PlayMessage("The title", 42));
            actorRef.Tell(new PlayMessage("Play this", 3));
            actorRef.Tell(new PlayMessage("And play that", 643));

            //actorRef.Tell(42);

            //actorRef.Tell(4D);

            Console.ReadLine();

            Console.WriteLine("Disposing actor system");

            StreamingActorSystem.Dispose();

            Console.WriteLine("Disposed");

            Console.ReadLine();
        }
    }
}

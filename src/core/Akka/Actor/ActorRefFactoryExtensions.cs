﻿namespace Akka.Actor
{
    public static class ActorRefFactoryExtensions
    {
        public static IActorRef ActorOf<TActor>(this ActorRefFactory factory, string name = null) where TActor : ActorBase, new()
        {
            return factory.ActorOf(Props.Create<TActor>(), name: name);
        }

    }
}
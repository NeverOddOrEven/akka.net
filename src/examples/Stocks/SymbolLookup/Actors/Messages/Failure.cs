﻿using System;
using Akka.Actor;

namespace SymbolLookup.Actors.Messages
{
    public class Failure
    {
        public Failure(Exception ex, IActorRef actor)
        {
            Cause = ex;
            Child = actor;
        }

        public Exception Cause { get; private set; }

        public IActorRef Child { get; private set; }
    }
}

﻿// Copyright (c) 2019 Jon P Smith, GitHub: JonPSmith, web: http://www.thereformedprogrammer.net/
// Licensed under MIT license. See License.txt in the project root for license information.

using GenericEventRunner.DomainParts;

namespace GenericEventRunner.ForHandlers.Internal
{
    internal class EntityAndEvent
    {
        public EntityAndEvent(object callingEntity, IDomainEvent domainEvent)
        {
            CallingEntity = callingEntity;
            DomainEvent = domainEvent;
        }

        public object CallingEntity { get; }
        public IDomainEvent DomainEvent { get; }
    }
}
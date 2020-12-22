﻿using System;

namespace VotingSystem.Core.InfrastructureAbstractions
{
    public interface IIdentityService<out TIdentity> 
        where TIdentity : IIdentity
    {
        bool IsSignedIn { get; }
        TIdentity GetIdentity();
    }
    
    public interface IIdentity
    {
        public Guid Id { get; }
        bool IsValid();
    }
}
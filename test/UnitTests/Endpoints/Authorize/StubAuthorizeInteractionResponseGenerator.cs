﻿using IdentityServer4.Core.ResponseHandling;
using System.Threading.Tasks;
using IdentityServer4.Core.Models;
using IdentityServer4.Core.Validation;

namespace UnitTests.Endpoints.Authorize
{
    class StubAuthorizeInteractionResponseGenerator : IAuthorizeInteractionResponseGenerator
    {
        internal InteractionResponse Response { get; set; } = new InteractionResponse();

        public Task<InteractionResponse> ProcessInteractionAsync(ValidatedAuthorizeRequest request, ConsentResponse consent = null)
        {
            return Task.FromResult(Response);
        }
    }
}
﻿using IdentityServer4.Core.Validation;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Security.Claims;

namespace UnitTests.Endpoints.Authorize
{
    public class StubAuthorizeRequestValidator : IAuthorizeRequestValidator
    {
        public AuthorizeRequestValidationResult Result { get; set; } = new AuthorizeRequestValidationResult();

        public Task<AuthorizeRequestValidationResult> ValidateAsync(NameValueCollection parameters, ClaimsPrincipal subject = null)
        {
            return Task.FromResult(Result);
        }
    }
}
// <auto-generated/>
#pragma warning disable
using FluentValidation;
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;
using Wolverine.Http;
using Wolverine.Http.FluentValidation;

namespace Internal.Generated.WolverineHandlers
{
    // START: POST_validate2_customer
    public class POST_validate2_customer : Wolverine.Http.HttpHandler
    {
        private readonly Wolverine.Http.WolverineHttpOptions _wolverineHttpOptions;
        private readonly Wolverine.Http.FluentValidation.IProblemDetailSource<Wolverine.Http.Tests.DifferentAssembly.Validation.CreateCustomer2> _problemDetailSource;
        private readonly FluentValidation.IValidator<Wolverine.Http.Tests.DifferentAssembly.Validation.CreateCustomer2> _validator;

        public POST_validate2_customer(Wolverine.Http.WolverineHttpOptions wolverineHttpOptions, Wolverine.Http.FluentValidation.IProblemDetailSource<Wolverine.Http.Tests.DifferentAssembly.Validation.CreateCustomer2> problemDetailSource, FluentValidation.IValidator<Wolverine.Http.Tests.DifferentAssembly.Validation.CreateCustomer2> validator) : base(wolverineHttpOptions)
        {
            _wolverineHttpOptions = wolverineHttpOptions;
            _problemDetailSource = problemDetailSource;
            _validator = validator;
        }



        public override async System.Threading.Tasks.Task Handle(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            var (customer, jsonContinue) = await ReadJsonAsync<Wolverine.Http.Tests.DifferentAssembly.Validation.CreateCustomer2>(httpContext);
            if (jsonContinue == Wolverine.HandlerContinuation.Stop) return;
            var result1 = await Wolverine.Http.FluentValidation.Internals.FluentValidationHttpExecutor.ExecuteOne<Wolverine.Http.Tests.DifferentAssembly.Validation.CreateCustomer2>(_validator, _problemDetailSource, customer).ConfigureAwait(false);
            if (!(result1 is Wolverine.Http.WolverineContinue))
            {
                await result1.ExecuteAsync(httpContext).ConfigureAwait(false);
                return;
            }

            var result_of_Post = Wolverine.Http.Tests.DifferentAssembly.Validation.Validated2Endpoint.Post(customer);
            await WriteString(httpContext, result_of_Post);
        }

    }

    // END: POST_validate2_customer
    
    
}


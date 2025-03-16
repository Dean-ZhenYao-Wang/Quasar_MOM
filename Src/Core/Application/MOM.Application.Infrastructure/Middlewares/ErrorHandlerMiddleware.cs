using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using MOM.Application.Wrappers;

namespace MOM.Application.Infrastructure.Middlewares
{
    public class ErrorHandlerMiddleware(RequestDelegate next)
    {
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception error)
            {
                var response = context.Response;
                response.ContentType = "application/json";
                var responseModel = BaseResult.Failure();

                switch (error)
                {
                    case ValidationException e:
                        // validation error
                        response.StatusCode = (int)HttpStatusCode.BadRequest;
                        foreach (var validationFailure in e.Errors)
                        {
                            responseModel.AddError(new Error(ErrorCode.ModelStateNotValid, validationFailure.ErrorMessage, validationFailure.PropertyName));
                        }
                        break;
                    case KeyNotFoundException e:
                        // not found error
                        response.StatusCode = (int)HttpStatusCode.NotFound;
                        responseModel.AddError(new Error(ErrorCode.NotFound, e.Message));
                        break;
                    case CommandExecutionException e:
                        response.StatusCode = 999;
                        responseModel.AddError(new Error(ErrorCode.Exception,e.ErrorCode, e.Message));
                        break;
                    default:
                        // unhandled error
                        response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        responseModel.AddError(new Error(ErrorCode.Exception, error.Message));
                        break;
                }
                var result = JsonSerializer.Serialize(responseModel, new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                });

                await response.WriteAsync(result);
            }
        }
    }
}

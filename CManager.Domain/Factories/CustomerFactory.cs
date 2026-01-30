using CManager.Domain.Exceptions;
using CManager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CManager.Domain.Factories;

public class CustomerFactory
{
    public static Customer Create(CreateCustomerRequest request)

    {
        if (string.IsNullOrWhiteSpace(request.FirstName))
            throw new DomainException("First name is required");

        if (string.IsNullOrWhiteSpace(request.LastName))
            throw new DomainException("Last name is required");

        if (string.IsNullOrWhiteSpace(request.Email))
            throw new DomainException("Email is required");


        return new Customer
        {
            Id = Guid.NewGuid(),
            FirstName = request.FirstName.Trim(),
            LastName = request.LastName.Trim(),
            Email = request.Email.Trim(),
            Phone = request.Phone?.Trim()
        };
    }
}

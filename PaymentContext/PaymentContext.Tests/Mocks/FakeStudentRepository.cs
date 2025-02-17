﻿using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Repositories;

namespace PaymentContext.Tests.Mocks
{
    public class FakeStudentRepository : IStudentRepository
    {
        public bool CreateSubscription(Student student)
        {
            throw new System.NotImplementedException();
        }

        public bool DocumentExists(string document)
        {
            if (document == "12345678900")
                return true;
            return false;
        }

        public bool EmailExists(string email)
        {
            if (email == "hello@balta.io")
                return true;
            return false;
        }
    }
}

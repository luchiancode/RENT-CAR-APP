﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using CAR_RENTAL_APPLICATION.Models;
using CAR_RENTAL_APPLICATION.Repositories;

namespace CAR_RENTAL_APPLICATION.Services
{
    public class PaymentService : BaseService
    {
        public PaymentService(IRepositoryWrapper repositoryWrapper)
            : base(repositoryWrapper)
        {
        }

        public List<Payment> GetPayment()
        {
            return repositoryWrapper.PaymentRepository.FindAll().ToList();
        }

        public List<Payment> GetPaymentByCondition(Expression<Func<Payment, bool>> expression)
        {
            return repositoryWrapper.PaymentRepository.FindByCondition(expression).ToList();
        }

        public void AddPayment(Payment Payment)
        {
            repositoryWrapper.PaymentRepository.Create(Payment);
        }

        public void UpdatePayment(Payment Payment)
        {
            repositoryWrapper.PaymentRepository.Update(Payment);
        }

        public void DeletePayment(Payment Payment)
        {
            repositoryWrapper.PaymentRepository.Delete(Payment);
        }
    }
}
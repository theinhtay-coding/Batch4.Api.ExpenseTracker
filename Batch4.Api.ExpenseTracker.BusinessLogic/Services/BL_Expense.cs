﻿using Batch4.Api.ExpenseTracker.DataAccess.Models;
using Batch4.Api.ExpenseTracker.DataAccess.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch4.Api.ExpenseTracker.BusinessLogic.Services
{
    public class BL_Expense
    {
        private readonly DA_Expense _da_Expense;

        public BL_Expense(DA_Expense da_Expense)
        {
            _da_Expense = da_Expense;
        }

        public int UpdateExpense(int id , ExpenseModel requestModel)
        {
            var result = _da_Expense.UpdateExpense(id, requestModel);
            return result;
        }
        public int DeleteExpense(int id)
        {
            var result = _da_Expense.DeleteExpense(id);
            return result;
        }
    }
}

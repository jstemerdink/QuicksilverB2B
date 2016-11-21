﻿using System;
using System.Collections.Generic;
using EPiServer.Reference.Commerce.Site.B2B.Models.Entities;

namespace EPiServer.Reference.Commerce.Site.B2B.DomainServiceContracts
{
    public interface IBudgetDomainService
    {
        List<Budget> GetActiveUserBudgets(Guid contactId);
        List<Budget> GetActiveOrganizationBudgets(Guid organizationId);
        List<Budget> GetUserBudgets(Guid contactId);
        List<Budget> GetOrganizationBudgets(Guid organizationId);
        List<Budget> GetAllBudgets();
        Budget GetNewBudget();
        Budget GetBudgetById(Guid budgetId);
    }
}

﻿using System.Collections.Generic;
using Hi.UrlRewrite.Entities.Conditions;

namespace Hi.UrlRewrite.Entities.Rules
{
    public interface IConditionList
    {
        List<Condition> Conditions { get; set; }
    }
}
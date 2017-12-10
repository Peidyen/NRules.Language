﻿namespace NRules.RuleSharp.IntegrationTests.TestAssets
{
    public abstract class BaseRuleTestFixture
    {
        protected BaseRuleTestFixture()
        {
            Repository.AddReference(typeof(BaseRuleTestFixture).Assembly);
        }

        protected RuleRepository Repository { get; } = new RuleRepository();
    }
}

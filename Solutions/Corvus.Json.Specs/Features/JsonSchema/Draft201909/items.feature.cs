﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Features.JsonSchema.Draft201909
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("items draft2019-09")]
    [NUnit.Framework.CategoryAttribute("draft2019-09")]
    public partial class ItemsDraft2019_09Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "draft2019-09"};
        
#line 1 "items.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/JsonSchema/Draft201909", "items draft2019-09", "    In order to use json-schema\r\n    As a developer\r\n    I want to support items " +
                    "in draft2019-09", ProgrammingLanguage.CSharp, new string[] {
                        "draft2019-09"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("a schema given for items")]
        [NUnit.Framework.TestCaseAttribute("#/000/tests/000/data", "true", "valid items", null)]
        [NUnit.Framework.TestCaseAttribute("#/000/tests/001/data", "false", "wrong type of items", null)]
        [NUnit.Framework.TestCaseAttribute("#/000/tests/002/data", "true", "ignores non-arrays", null)]
        [NUnit.Framework.TestCaseAttribute("#/000/tests/003/data", "true", "JavaScript pseudo-array is valid", null)]
        public virtual void ASchemaGivenForItems(string inputDataReference, string valid, string description, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("inputDataReference", inputDataReference);
            argumentsOfScenario.Add("valid", valid);
            argumentsOfScenario.Add("description", description);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("a schema given for items", "/* Schema: \r\n{\r\n            \"items\": {\"type\": \"integer\"}\r\n        }\r\n*/", tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 8
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 14
    testRunner.Given("the input JSON file \"items.json\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 15
    testRunner.And("the schema at \"#/0/schema\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 16
    testRunner.And(string.Format("the input data at \"{0}\"", inputDataReference), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 17
    testRunner.And("I generate a type for the schema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 18
    testRunner.And("I construct an instance of the schema type from the data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 19
    testRunner.When("I validate the instance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 20
    testRunner.Then(string.Format("the result will be {0}", valid), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("an array of schemas for items")]
        [NUnit.Framework.TestCaseAttribute("#/001/tests/000/data", "true", "correct types", null)]
        [NUnit.Framework.TestCaseAttribute("#/001/tests/001/data", "false", "wrong types", null)]
        [NUnit.Framework.TestCaseAttribute("#/001/tests/002/data", "true", "incomplete array of items", null)]
        [NUnit.Framework.TestCaseAttribute("#/001/tests/003/data", "true", "array with additional items", null)]
        [NUnit.Framework.TestCaseAttribute("#/001/tests/004/data", "true", "empty array", null)]
        [NUnit.Framework.TestCaseAttribute("#/001/tests/005/data", "true", "JavaScript pseudo-array is valid", null)]
        public virtual void AnArrayOfSchemasForItems(string inputDataReference, string valid, string description, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("inputDataReference", inputDataReference);
            argumentsOfScenario.Add("valid", valid);
            argumentsOfScenario.Add("description", description);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("an array of schemas for items", "/* Schema: \r\n{\r\n            \"items\": [\r\n                {\"type\": \"integer\"},\r\n   " +
                    "             {\"type\": \"string\"}\r\n            ]\r\n        }\r\n*/", tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 29
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 38
    testRunner.Given("the input JSON file \"items.json\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 39
    testRunner.And("the schema at \"#/1/schema\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 40
    testRunner.And(string.Format("the input data at \"{0}\"", inputDataReference), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 41
    testRunner.And("I generate a type for the schema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 42
    testRunner.And("I construct an instance of the schema type from the data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 43
    testRunner.When("I validate the instance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 44
    testRunner.Then(string.Format("the result will be {0}", valid), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("items with boolean schema (true)")]
        [NUnit.Framework.TestCaseAttribute("#/002/tests/000/data", "true", "any array is valid", null)]
        [NUnit.Framework.TestCaseAttribute("#/002/tests/001/data", "true", "empty array is valid", null)]
        public virtual void ItemsWithBooleanSchemaTrue(string inputDataReference, string valid, string description, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("inputDataReference", inputDataReference);
            argumentsOfScenario.Add("valid", valid);
            argumentsOfScenario.Add("description", description);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("items with boolean schema (true)", "/* Schema: \r\n{\"items\": true}\r\n*/", tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 55
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 59
    testRunner.Given("the input JSON file \"items.json\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 60
    testRunner.And("the schema at \"#/2/schema\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 61
    testRunner.And(string.Format("the input data at \"{0}\"", inputDataReference), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 62
    testRunner.And("I generate a type for the schema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 63
    testRunner.And("I construct an instance of the schema type from the data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 64
    testRunner.When("I validate the instance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 65
    testRunner.Then(string.Format("the result will be {0}", valid), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("items with boolean schema (false)")]
        [NUnit.Framework.TestCaseAttribute("#/003/tests/000/data", "false", "any non-empty array is invalid", null)]
        [NUnit.Framework.TestCaseAttribute("#/003/tests/001/data", "true", "empty array is valid", null)]
        public virtual void ItemsWithBooleanSchemaFalse(string inputDataReference, string valid, string description, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("inputDataReference", inputDataReference);
            argumentsOfScenario.Add("valid", valid);
            argumentsOfScenario.Add("description", description);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("items with boolean schema (false)", "/* Schema: \r\n{\"items\": false}\r\n*/", tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 72
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 76
    testRunner.Given("the input JSON file \"items.json\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 77
    testRunner.And("the schema at \"#/3/schema\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 78
    testRunner.And(string.Format("the input data at \"{0}\"", inputDataReference), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 79
    testRunner.And("I generate a type for the schema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 80
    testRunner.And("I construct an instance of the schema type from the data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 81
    testRunner.When("I validate the instance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 82
    testRunner.Then(string.Format("the result will be {0}", valid), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("items with boolean schemas")]
        [NUnit.Framework.TestCaseAttribute("#/004/tests/000/data", "true", "array with one item is valid", null)]
        [NUnit.Framework.TestCaseAttribute("#/004/tests/001/data", "false", "array with two items is invalid", null)]
        [NUnit.Framework.TestCaseAttribute("#/004/tests/002/data", "true", "empty array is valid", null)]
        public virtual void ItemsWithBooleanSchemas(string inputDataReference, string valid, string description, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("inputDataReference", inputDataReference);
            argumentsOfScenario.Add("valid", valid);
            argumentsOfScenario.Add("description", description);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("items with boolean schemas", "/* Schema: \r\n{\r\n            \"items\": [true, false]\r\n        }\r\n*/", tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 89
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 95
    testRunner.Given("the input JSON file \"items.json\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 96
    testRunner.And("the schema at \"#/4/schema\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 97
    testRunner.And(string.Format("the input data at \"{0}\"", inputDataReference), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 98
    testRunner.And("I generate a type for the schema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 99
    testRunner.And("I construct an instance of the schema type from the data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 100
    testRunner.When("I validate the instance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 101
    testRunner.Then(string.Format("the result will be {0}", valid), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("items and subitems")]
        [NUnit.Framework.TestCaseAttribute("#/005/tests/000/data", "true", "valid items", null)]
        [NUnit.Framework.TestCaseAttribute("#/005/tests/001/data", "false", "too many items", null)]
        [NUnit.Framework.TestCaseAttribute("#/005/tests/002/data", "false", "too many sub-items", null)]
        [NUnit.Framework.TestCaseAttribute("#/005/tests/003/data", "false", "wrong item", null)]
        [NUnit.Framework.TestCaseAttribute("#/005/tests/004/data", "false", "wrong sub-item", null)]
        [NUnit.Framework.TestCaseAttribute("#/005/tests/005/data", "true", "fewer items is valid", null)]
        public virtual void ItemsAndSubitems(string inputDataReference, string valid, string description, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("inputDataReference", inputDataReference);
            argumentsOfScenario.Add("valid", valid);
            argumentsOfScenario.Add("description", description);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("items and subitems", @"/* Schema: 
{
            ""$defs"": {
                ""item"": {
                    ""type"": ""array"",
                    ""additionalItems"": false,
                    ""items"": [
                        { ""$ref"": ""#/$defs/sub-item"" },
                        { ""$ref"": ""#/$defs/sub-item"" }
                    ]
                },
                ""sub-item"": {
                    ""type"": ""object"",
                    ""required"": [""foo""]
                }
            },
            ""type"": ""array"",
            ""additionalItems"": false,
            ""items"": [
                { ""$ref"": ""#/$defs/item"" },
                { ""$ref"": ""#/$defs/item"" },
                { ""$ref"": ""#/$defs/item"" }
            ]
        }
*/", tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 109
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 135
    testRunner.Given("the input JSON file \"items.json\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 136
    testRunner.And("the schema at \"#/5/schema\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 137
    testRunner.And(string.Format("the input data at \"{0}\"", inputDataReference), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 138
    testRunner.And("I generate a type for the schema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 139
    testRunner.And("I construct an instance of the schema type from the data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 140
    testRunner.When("I validate the instance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 141
    testRunner.Then(string.Format("the result will be {0}", valid), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("nested items")]
        [NUnit.Framework.TestCaseAttribute("#/006/tests/000/data", "true", "valid nested array", null)]
        [NUnit.Framework.TestCaseAttribute("#/006/tests/001/data", "false", "nested array with invalid type", null)]
        [NUnit.Framework.TestCaseAttribute("#/006/tests/002/data", "false", "not deep enough", null)]
        public virtual void NestedItems(string inputDataReference, string valid, string description, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("inputDataReference", inputDataReference);
            argumentsOfScenario.Add("valid", valid);
            argumentsOfScenario.Add("description", description);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("nested items", @"/* Schema: 
{
            ""type"": ""array"",
            ""items"": {
                ""type"": ""array"",
                ""items"": {
                    ""type"": ""array"",
                    ""items"": {
                        ""type"": ""array"",
                        ""items"": {
                            ""type"": ""number""
                        }
                    }
                }
            }
        }
*/", tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 152
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 170
    testRunner.Given("the input JSON file \"items.json\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 171
    testRunner.And("the schema at \"#/6/schema\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 172
    testRunner.And(string.Format("the input data at \"{0}\"", inputDataReference), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 173
    testRunner.And("I generate a type for the schema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 174
    testRunner.And("I construct an instance of the schema type from the data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 175
    testRunner.When("I validate the instance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 176
    testRunner.Then(string.Format("the result will be {0}", valid), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

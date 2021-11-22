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
namespace Features.JsonSchema.Draft2020212
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("uniqueItems draft2020-12")]
    [NUnit.Framework.CategoryAttribute("draft2020-12")]
    public partial class UniqueItemsDraft2020_12Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "draft2020-12"};
        
#line 1 "uniqueItems.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/JsonSchema/Draft2020212", "uniqueItems draft2020-12", "    In order to use json-schema\r\n    As a developer\r\n    I want to support unique" +
                    "Items in draft2020-12", ProgrammingLanguage.CSharp, new string[] {
                        "draft2020-12"});
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
        [NUnit.Framework.DescriptionAttribute("uniqueItems validation")]
        [NUnit.Framework.TestCaseAttribute("#/000/tests/000/data", "true", "unique array of integers is valid", null)]
        [NUnit.Framework.TestCaseAttribute("#/000/tests/001/data", "false", "non-unique array of integers is invalid", null)]
        [NUnit.Framework.TestCaseAttribute("#/000/tests/002/data", "false", "numbers are unique if mathematically unequal", null)]
        [NUnit.Framework.TestCaseAttribute("#/000/tests/003/data", "true", "false is not equal to zero", null)]
        [NUnit.Framework.TestCaseAttribute("#/000/tests/004/data", "true", "true is not equal to one", null)]
        [NUnit.Framework.TestCaseAttribute("#/000/tests/005/data", "true", "unique array of objects is valid", null)]
        [NUnit.Framework.TestCaseAttribute("#/000/tests/006/data", "false", "non-unique array of objects is invalid", null)]
        [NUnit.Framework.TestCaseAttribute("#/000/tests/007/data", "true", "unique array of nested objects is valid", null)]
        [NUnit.Framework.TestCaseAttribute("#/000/tests/008/data", "false", "non-unique array of nested objects is invalid", null)]
        [NUnit.Framework.TestCaseAttribute("#/000/tests/009/data", "true", "unique array of arrays is valid", null)]
        [NUnit.Framework.TestCaseAttribute("#/000/tests/010/data", "false", "non-unique array of arrays is invalid", null)]
        [NUnit.Framework.TestCaseAttribute("#/000/tests/011/data", "true", "1 and true are unique", null)]
        [NUnit.Framework.TestCaseAttribute("#/000/tests/012/data", "true", "0 and false are unique", null)]
        [NUnit.Framework.TestCaseAttribute("#/000/tests/013/data", "true", "[1] and [true] are unique", null)]
        [NUnit.Framework.TestCaseAttribute("#/000/tests/014/data", "true", "[0] and [false] are unique", null)]
        [NUnit.Framework.TestCaseAttribute("#/000/tests/015/data", "true", "nested [1] and [true] are unique", null)]
        [NUnit.Framework.TestCaseAttribute("#/000/tests/016/data", "true", "nested [0] and [false] are unique", null)]
        [NUnit.Framework.TestCaseAttribute("#/000/tests/017/data", "true", "unique heterogeneous types are valid", null)]
        [NUnit.Framework.TestCaseAttribute("#/000/tests/018/data", "false", "non-unique heterogeneous types are invalid", null)]
        [NUnit.Framework.TestCaseAttribute("#/000/tests/019/data", "true", "different objects are unique", null)]
        [NUnit.Framework.TestCaseAttribute("#/000/tests/020/data", "false", "objects are non-unique despite key order", null)]
        [NUnit.Framework.TestCaseAttribute("#/000/tests/021/data", "true", "{\"a\": false} and {\"a\": 0} are unique", null)]
        [NUnit.Framework.TestCaseAttribute("#/000/tests/022/data", "true", "{\"a\": true} and {\"a\": 1} are unique", null)]
        public virtual void UniqueItemsValidation(string inputDataReference, string valid, string description, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("inputDataReference", inputDataReference);
            argumentsOfScenario.Add("valid", valid);
            argumentsOfScenario.Add("description", description);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("uniqueItems validation", "/* Schema: \r\n{\"uniqueItems\": true}\r\n*/", tagsOfScenario, argumentsOfScenario, this._featureTags);
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
#line 12
    testRunner.Given("the input JSON file \"uniqueItems.json\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 13
    testRunner.And("the schema at \"#/0/schema\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
    testRunner.And(string.Format("the input data at \"{0}\"", inputDataReference), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
    testRunner.And("I generate a type for the schema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 16
    testRunner.And("I construct an instance of the schema type from the data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 17
    testRunner.When("I validate the instance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 18
    testRunner.Then(string.Format("the result will be {0}", valid), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("uniqueItems with an array of items")]
        [NUnit.Framework.TestCaseAttribute("#/001/tests/000/data", "true", "[false, true] from items array is valid", null)]
        [NUnit.Framework.TestCaseAttribute("#/001/tests/001/data", "true", "[true, false] from items array is valid", null)]
        [NUnit.Framework.TestCaseAttribute("#/001/tests/002/data", "false", "[false, false] from items array is not valid", null)]
        [NUnit.Framework.TestCaseAttribute("#/001/tests/003/data", "false", "[true, true] from items array is not valid", null)]
        [NUnit.Framework.TestCaseAttribute("#/001/tests/004/data", "true", "unique array extended from [false, true] is valid", null)]
        [NUnit.Framework.TestCaseAttribute("#/001/tests/005/data", "true", "unique array extended from [true, false] is valid", null)]
        [NUnit.Framework.TestCaseAttribute("#/001/tests/006/data", "false", "non-unique array extended from [false, true] is not valid", null)]
        [NUnit.Framework.TestCaseAttribute("#/001/tests/007/data", "false", "non-unique array extended from [true, false] is not valid", null)]
        public virtual void UniqueItemsWithAnArrayOfItems(string inputDataReference, string valid, string description, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("inputDataReference", inputDataReference);
            argumentsOfScenario.Add("valid", valid);
            argumentsOfScenario.Add("description", description);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("uniqueItems with an array of items", "/* Schema: \r\n{\r\n            \"prefixItems\": [{\"type\": \"boolean\"}, {\"type\": \"boolea" +
                    "n\"}],\r\n            \"uniqueItems\": true\r\n        }\r\n*/", tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 46
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
#line 53
    testRunner.Given("the input JSON file \"uniqueItems.json\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 54
    testRunner.And("the schema at \"#/1/schema\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 55
    testRunner.And(string.Format("the input data at \"{0}\"", inputDataReference), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 56
    testRunner.And("I generate a type for the schema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 57
    testRunner.And("I construct an instance of the schema type from the data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 58
    testRunner.When("I validate the instance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 59
    testRunner.Then(string.Format("the result will be {0}", valid), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("uniqueItems with an array of items and additionalItems equals false")]
        [NUnit.Framework.TestCaseAttribute("#/002/tests/000/data", "true", "[false, true] from items array is valid", null)]
        [NUnit.Framework.TestCaseAttribute("#/002/tests/001/data", "true", "[true, false] from items array is valid", null)]
        [NUnit.Framework.TestCaseAttribute("#/002/tests/002/data", "false", "[false, false] from items array is not valid", null)]
        [NUnit.Framework.TestCaseAttribute("#/002/tests/003/data", "false", "[true, true] from items array is not valid", null)]
        [NUnit.Framework.TestCaseAttribute("#/002/tests/004/data", "false", "extra items are invalid even if unique", null)]
        public virtual void UniqueItemsWithAnArrayOfItemsAndAdditionalItemsEqualsFalse(string inputDataReference, string valid, string description, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("inputDataReference", inputDataReference);
            argumentsOfScenario.Add("valid", valid);
            argumentsOfScenario.Add("description", description);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("uniqueItems with an array of items and additionalItems equals false", "/* Schema: \r\n{\r\n            \"prefixItems\": [{\"type\": \"boolean\"}, {\"type\": \"boolea" +
                    "n\"}],\r\n            \"uniqueItems\": true,\r\n            \"items\": false\r\n        }\r\n" +
                    "*/", tagsOfScenario, argumentsOfScenario, this._featureTags);
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
#line 80
    testRunner.Given("the input JSON file \"uniqueItems.json\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 81
    testRunner.And("the schema at \"#/2/schema\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 82
    testRunner.And(string.Format("the input data at \"{0}\"", inputDataReference), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 83
    testRunner.And("I generate a type for the schema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 84
    testRunner.And("I construct an instance of the schema type from the data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 85
    testRunner.When("I validate the instance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 86
    testRunner.Then(string.Format("the result will be {0}", valid), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("uniqueItems equals false validation")]
        [NUnit.Framework.TestCaseAttribute("#/003/tests/000/data", "true", "unique array of integers is valid", null)]
        [NUnit.Framework.TestCaseAttribute("#/003/tests/001/data", "true", "non-unique array of integers is valid", null)]
        [NUnit.Framework.TestCaseAttribute("#/003/tests/002/data", "true", "numbers are unique if mathematically unequal", null)]
        [NUnit.Framework.TestCaseAttribute("#/003/tests/003/data", "true", "false is not equal to zero", null)]
        [NUnit.Framework.TestCaseAttribute("#/003/tests/004/data", "true", "true is not equal to one", null)]
        [NUnit.Framework.TestCaseAttribute("#/003/tests/005/data", "true", "unique array of objects is valid", null)]
        [NUnit.Framework.TestCaseAttribute("#/003/tests/006/data", "true", "non-unique array of objects is valid", null)]
        [NUnit.Framework.TestCaseAttribute("#/003/tests/007/data", "true", "unique array of nested objects is valid", null)]
        [NUnit.Framework.TestCaseAttribute("#/003/tests/008/data", "true", "non-unique array of nested objects is valid", null)]
        [NUnit.Framework.TestCaseAttribute("#/003/tests/009/data", "true", "unique array of arrays is valid", null)]
        [NUnit.Framework.TestCaseAttribute("#/003/tests/010/data", "true", "non-unique array of arrays is valid", null)]
        [NUnit.Framework.TestCaseAttribute("#/003/tests/011/data", "true", "1 and true are unique", null)]
        [NUnit.Framework.TestCaseAttribute("#/003/tests/012/data", "true", "0 and false are unique", null)]
        [NUnit.Framework.TestCaseAttribute("#/003/tests/013/data", "true", "unique heterogeneous types are valid", null)]
        [NUnit.Framework.TestCaseAttribute("#/003/tests/014/data", "true", "non-unique heterogeneous types are valid", null)]
        public virtual void UniqueItemsEqualsFalseValidation(string inputDataReference, string valid, string description, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("inputDataReference", inputDataReference);
            argumentsOfScenario.Add("valid", valid);
            argumentsOfScenario.Add("description", description);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("uniqueItems equals false validation", "/* Schema: \r\n{ \"uniqueItems\": false }\r\n*/", tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 96
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
#line 100
    testRunner.Given("the input JSON file \"uniqueItems.json\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 101
    testRunner.And("the schema at \"#/3/schema\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 102
    testRunner.And(string.Format("the input data at \"{0}\"", inputDataReference), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 103
    testRunner.And("I generate a type for the schema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 104
    testRunner.And("I construct an instance of the schema type from the data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 105
    testRunner.When("I validate the instance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 106
    testRunner.Then(string.Format("the result will be {0}", valid), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("uniqueItems equals false with an array of items")]
        [NUnit.Framework.TestCaseAttribute("#/004/tests/000/data", "true", "[false, true] from items array is valid", null)]
        [NUnit.Framework.TestCaseAttribute("#/004/tests/001/data", "true", "[true, false] from items array is valid", null)]
        [NUnit.Framework.TestCaseAttribute("#/004/tests/002/data", "true", "[false, false] from items array is valid", null)]
        [NUnit.Framework.TestCaseAttribute("#/004/tests/003/data", "true", "[true, true] from items array is valid", null)]
        [NUnit.Framework.TestCaseAttribute("#/004/tests/004/data", "true", "unique array extended from [false, true] is valid", null)]
        [NUnit.Framework.TestCaseAttribute("#/004/tests/005/data", "true", "unique array extended from [true, false] is valid", null)]
        [NUnit.Framework.TestCaseAttribute("#/004/tests/006/data", "true", "non-unique array extended from [false, true] is valid", null)]
        [NUnit.Framework.TestCaseAttribute("#/004/tests/007/data", "true", "non-unique array extended from [true, false] is valid", null)]
        public virtual void UniqueItemsEqualsFalseWithAnArrayOfItems(string inputDataReference, string valid, string description, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("inputDataReference", inputDataReference);
            argumentsOfScenario.Add("valid", valid);
            argumentsOfScenario.Add("description", description);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("uniqueItems equals false with an array of items", "/* Schema: \r\n{\r\n            \"prefixItems\": [{\"type\": \"boolean\"}, {\"type\": \"boolea" +
                    "n\"}],\r\n            \"uniqueItems\": false\r\n        }\r\n*/", tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 126
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
#line 133
    testRunner.Given("the input JSON file \"uniqueItems.json\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 134
    testRunner.And("the schema at \"#/4/schema\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 135
    testRunner.And(string.Format("the input data at \"{0}\"", inputDataReference), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 136
    testRunner.And("I generate a type for the schema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 137
    testRunner.And("I construct an instance of the schema type from the data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 138
    testRunner.When("I validate the instance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 139
    testRunner.Then(string.Format("the result will be {0}", valid), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("uniqueItems equals false with an array of items and additionalItems equals false")]
        [NUnit.Framework.TestCaseAttribute("#/005/tests/000/data", "true", "[false, true] from items array is valid", null)]
        [NUnit.Framework.TestCaseAttribute("#/005/tests/001/data", "true", "[true, false] from items array is valid", null)]
        [NUnit.Framework.TestCaseAttribute("#/005/tests/002/data", "true", "[false, false] from items array is valid", null)]
        [NUnit.Framework.TestCaseAttribute("#/005/tests/003/data", "true", "[true, true] from items array is valid", null)]
        [NUnit.Framework.TestCaseAttribute("#/005/tests/004/data", "false", "extra items are invalid even if unique", null)]
        public virtual void UniqueItemsEqualsFalseWithAnArrayOfItemsAndAdditionalItemsEqualsFalse(string inputDataReference, string valid, string description, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("inputDataReference", inputDataReference);
            argumentsOfScenario.Add("valid", valid);
            argumentsOfScenario.Add("description", description);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("uniqueItems equals false with an array of items and additionalItems equals false", "/* Schema: \r\n{\r\n            \"prefixItems\": [{\"type\": \"boolean\"}, {\"type\": \"boolea" +
                    "n\"}],\r\n            \"uniqueItems\": false,\r\n            \"items\": false\r\n        }\r" +
                    "\n*/", tagsOfScenario, argumentsOfScenario, this._featureTags);
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
#line 160
    testRunner.Given("the input JSON file \"uniqueItems.json\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 161
    testRunner.And("the schema at \"#/5/schema\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 162
    testRunner.And(string.Format("the input data at \"{0}\"", inputDataReference), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 163
    testRunner.And("I generate a type for the schema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 164
    testRunner.And("I construct an instance of the schema type from the data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 165
    testRunner.When("I validate the instance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 166
    testRunner.Then(string.Format("the result will be {0}", valid), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

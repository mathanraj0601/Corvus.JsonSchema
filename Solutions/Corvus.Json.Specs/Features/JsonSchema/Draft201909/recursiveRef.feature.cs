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
    [NUnit.Framework.DescriptionAttribute("recursiveRef draft2019-09")]
    [NUnit.Framework.CategoryAttribute("draft2019-09")]
    public partial class RecursiveRefDraft2019_09Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "draft2019-09"};
        
#line 1 "recursiveRef.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/JsonSchema/Draft201909", "recursiveRef draft2019-09", "    In order to use json-schema\r\n    As a developer\r\n    I want to support recurs" +
                    "iveRef in draft2019-09", ProgrammingLanguage.CSharp, new string[] {
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
        [NUnit.Framework.DescriptionAttribute("$recursiveRef without $recursiveAnchor works like $ref")]
        [NUnit.Framework.TestCaseAttribute("#/000/tests/000/data", "true", "match", null)]
        [NUnit.Framework.TestCaseAttribute("#/000/tests/001/data", "true", "recursive match", null)]
        [NUnit.Framework.TestCaseAttribute("#/000/tests/002/data", "false", "mismatch", null)]
        [NUnit.Framework.TestCaseAttribute("#/000/tests/003/data", "false", "recursive mismatch", null)]
        public virtual void RecursiveRefWithoutRecursiveAnchorWorksLikeRef(string inputDataReference, string valid, string description, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("inputDataReference", inputDataReference);
            argumentsOfScenario.Add("valid", valid);
            argumentsOfScenario.Add("description", description);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("$recursiveRef without $recursiveAnchor works like $ref", "/* Schema: \r\n{\r\n            \"properties\": {\r\n                \"foo\": { \"$recursive" +
                    "Ref\": \"#\" }\r\n            },\r\n            \"additionalProperties\": false\r\n        " +
                    "}\r\n*/", tagsOfScenario, argumentsOfScenario, this._featureTags);
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
#line 17
    testRunner.Given("the input JSON file \"recursiveRef.json\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 18
    testRunner.And("the schema at \"#/0/schema\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 19
    testRunner.And(string.Format("the input data at \"{0}\"", inputDataReference), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 20
    testRunner.And("I generate a type for the schema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
    testRunner.And("I construct an instance of the schema type from the data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 22
    testRunner.When("I validate the instance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 23
    testRunner.Then(string.Format("the result will be {0}", valid), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("$recursiveRef without using nesting")]
        [NUnit.Framework.TestCaseAttribute("#/001/tests/000/data", "true", "integer matches at the outer level", null)]
        [NUnit.Framework.TestCaseAttribute("#/001/tests/001/data", "true", "single level match", null)]
        [NUnit.Framework.TestCaseAttribute("#/001/tests/002/data", "false", "integer does not match as a property value", null)]
        [NUnit.Framework.TestCaseAttribute("#/001/tests/003/data", "true", "two levels, properties match with inner definition", null)]
        [NUnit.Framework.TestCaseAttribute("#/001/tests/004/data", "false", "two levels, no match", null)]
        public virtual void RecursiveRefWithoutUsingNesting(string inputDataReference, string valid, string description, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("inputDataReference", inputDataReference);
            argumentsOfScenario.Add("valid", valid);
            argumentsOfScenario.Add("description", description);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("$recursiveRef without using nesting", @"/* Schema: 
{
            ""$id"": ""http://localhost:4242/recursiveRef2/schema.json"",
            ""$defs"": {
                ""myobject"": {
                    ""$id"": ""myobject.json"",
                    ""$recursiveAnchor"": true,
                    ""anyOf"": [
                        { ""type"": ""string"" },
                        {
                            ""type"": ""object"",
                            ""additionalProperties"": { ""$recursiveRef"": ""#"" }
                        }
                    ]
                }
            },
            ""anyOf"": [
                { ""type"": ""integer"" },
                { ""$ref"": ""#/$defs/myobject"" }
            ]
        }
*/", tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 32
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
#line 55
    testRunner.Given("the input JSON file \"recursiveRef.json\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 56
    testRunner.And("the schema at \"#/1/schema\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 57
    testRunner.And(string.Format("the input data at \"{0}\"", inputDataReference), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 58
    testRunner.And("I generate a type for the schema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 59
    testRunner.And("I construct an instance of the schema type from the data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 60
    testRunner.When("I validate the instance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 61
    testRunner.Then(string.Format("the result will be {0}", valid), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("$recursiveRef with nesting")]
        [NUnit.Framework.TestCaseAttribute("#/002/tests/000/data", "true", "integer matches at the outer level", null)]
        [NUnit.Framework.TestCaseAttribute("#/002/tests/001/data", "true", "single level match", null)]
        [NUnit.Framework.TestCaseAttribute("#/002/tests/002/data", "true", "integer now matches as a property value", null)]
        [NUnit.Framework.TestCaseAttribute("#/002/tests/003/data", "true", "two levels, properties match with inner definition", null)]
        [NUnit.Framework.TestCaseAttribute("#/002/tests/004/data", "true", "two levels, properties match with $recursiveRef", null)]
        public virtual void RecursiveRefWithNesting(string inputDataReference, string valid, string description, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("inputDataReference", inputDataReference);
            argumentsOfScenario.Add("valid", valid);
            argumentsOfScenario.Add("description", description);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("$recursiveRef with nesting", @"/* Schema: 
{
            ""$id"": ""http://localhost:4242/recursiveRef3/schema.json"",
            ""$recursiveAnchor"": true,
            ""$defs"": {
                ""myobject"": {
                    ""$id"": ""myobject.json"",
                    ""$recursiveAnchor"": true,
                    ""anyOf"": [
                        { ""type"": ""string"" },
                        {
                            ""type"": ""object"",
                            ""additionalProperties"": { ""$recursiveRef"": ""#"" }
                        }
                    ]
                }
            },
            ""anyOf"": [
                { ""type"": ""integer"" },
                { ""$ref"": ""#/$defs/myobject"" }
            ]
        }
*/", tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 71
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
    testRunner.Given("the input JSON file \"recursiveRef.json\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 96
    testRunner.And("the schema at \"#/2/schema\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
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
        [NUnit.Framework.DescriptionAttribute("$recursiveRef with $recursiveAnchor: false works like $ref")]
        [NUnit.Framework.TestCaseAttribute("#/003/tests/000/data", "true", "integer matches at the outer level", null)]
        [NUnit.Framework.TestCaseAttribute("#/003/tests/001/data", "true", "single level match", null)]
        [NUnit.Framework.TestCaseAttribute("#/003/tests/002/data", "false", "integer does not match as a property value", null)]
        [NUnit.Framework.TestCaseAttribute("#/003/tests/003/data", "true", "two levels, properties match with inner definition", null)]
        [NUnit.Framework.TestCaseAttribute("#/003/tests/004/data", "false", "two levels, integer does not match as a property value", null)]
        public virtual void RecursiveRefWithRecursiveAnchorFalseWorksLikeRef(string inputDataReference, string valid, string description, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("inputDataReference", inputDataReference);
            argumentsOfScenario.Add("valid", valid);
            argumentsOfScenario.Add("description", description);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("$recursiveRef with $recursiveAnchor: false works like $ref", @"/* Schema: 
{
            ""$id"": ""http://localhost:4242/recursiveRef4/schema.json"",
            ""$recursiveAnchor"": false,
            ""$defs"": {
                ""myobject"": {
                    ""$id"": ""myobject.json"",
                    ""$recursiveAnchor"": false,
                    ""anyOf"": [
                        { ""type"": ""string"" },
                        {
                            ""type"": ""object"",
                            ""additionalProperties"": { ""$recursiveRef"": ""#"" }
                        }
                    ]
                }
            },
            ""anyOf"": [
                { ""type"": ""integer"" },
                { ""$ref"": ""#/$defs/myobject"" }
            ]
        }
*/", tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 111
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
    testRunner.Given("the input JSON file \"recursiveRef.json\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 136
    testRunner.And("the schema at \"#/3/schema\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
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
        [NUnit.Framework.DescriptionAttribute("$recursiveRef with no $recursiveAnchor works like $ref")]
        [NUnit.Framework.TestCaseAttribute("#/004/tests/000/data", "true", "integer matches at the outer level", null)]
        [NUnit.Framework.TestCaseAttribute("#/004/tests/001/data", "true", "single level match", null)]
        [NUnit.Framework.TestCaseAttribute("#/004/tests/002/data", "false", "integer does not match as a property value", null)]
        [NUnit.Framework.TestCaseAttribute("#/004/tests/003/data", "true", "two levels, properties match with inner definition", null)]
        [NUnit.Framework.TestCaseAttribute("#/004/tests/004/data", "false", "two levels, integer does not match as a property value", null)]
        public virtual void RecursiveRefWithNoRecursiveAnchorWorksLikeRef(string inputDataReference, string valid, string description, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("inputDataReference", inputDataReference);
            argumentsOfScenario.Add("valid", valid);
            argumentsOfScenario.Add("description", description);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("$recursiveRef with no $recursiveAnchor works like $ref", @"/* Schema: 
{
            ""$id"": ""http://localhost:4242/recursiveRef5/schema.json"",
            ""$defs"": {
                ""myobject"": {
                    ""$id"": ""myobject.json"",
                    ""$recursiveAnchor"": false,
                    ""anyOf"": [
                        { ""type"": ""string"" },
                        {
                            ""type"": ""object"",
                            ""additionalProperties"": { ""$recursiveRef"": ""#"" }
                        }
                    ]
                }
            },
            ""anyOf"": [
                { ""type"": ""integer"" },
                { ""$ref"": ""#/$defs/myobject"" }
            ]
        }
*/", tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 151
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
#line 174
    testRunner.Given("the input JSON file \"recursiveRef.json\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 175
    testRunner.And("the schema at \"#/4/schema\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 176
    testRunner.And(string.Format("the input data at \"{0}\"", inputDataReference), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 177
    testRunner.And("I generate a type for the schema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 178
    testRunner.And("I construct an instance of the schema type from the data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 179
    testRunner.When("I validate the instance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 180
    testRunner.Then(string.Format("the result will be {0}", valid), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("$recursiveRef with no $recursiveAnchor in the initial target schema resource")]
        [NUnit.Framework.TestCaseAttribute("#/005/tests/000/data", "false", "leaf node does not match; no recursion", null)]
        [NUnit.Framework.TestCaseAttribute("#/005/tests/001/data", "true", "leaf node matches: recursion uses the inner schema", null)]
        [NUnit.Framework.TestCaseAttribute("#/005/tests/002/data", "false", "leaf node does not match: recursion uses the inner schema", null)]
        public virtual void RecursiveRefWithNoRecursiveAnchorInTheInitialTargetSchemaResource(string inputDataReference, string valid, string description, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("inputDataReference", inputDataReference);
            argumentsOfScenario.Add("valid", valid);
            argumentsOfScenario.Add("description", description);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("$recursiveRef with no $recursiveAnchor in the initial target schema resource", @"/* Schema: 
{
            ""$id"": ""http://localhost:4242/recursiveRef6/base.json"",
            ""$recursiveAnchor"": true,
            ""anyOf"": [
                { ""type"": ""boolean"" },
                {
                    ""type"": ""object"",
                    ""additionalProperties"": {
                        ""$id"": ""http://localhost:4242/recursiveRef6/inner.json"",
                        ""$comment"": ""there is no $recursiveAnchor: true here, so we do NOT recurse to the base"",
                        ""anyOf"": [
                            { ""type"": ""integer"" },
                            { ""type"": ""object"", ""additionalProperties"": { ""$recursiveRef"": ""#"" } }
                        ]
                    }
                }
            ]
        }
*/", tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 190
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
#line 211
    testRunner.Given("the input JSON file \"recursiveRef.json\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 212
    testRunner.And("the schema at \"#/5/schema\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 213
    testRunner.And(string.Format("the input data at \"{0}\"", inputDataReference), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 214
    testRunner.And("I generate a type for the schema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 215
    testRunner.And("I construct an instance of the schema type from the data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 216
    testRunner.When("I validate the instance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 217
    testRunner.Then(string.Format("the result will be {0}", valid), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("$recursiveRef with no $recursiveAnchor in the outer schema resource")]
        [NUnit.Framework.TestCaseAttribute("#/006/tests/000/data", "false", "leaf node does not match; no recursion", null)]
        [NUnit.Framework.TestCaseAttribute("#/006/tests/001/data", "true", "leaf node matches: recursion only uses inner schema", null)]
        [NUnit.Framework.TestCaseAttribute("#/006/tests/002/data", "false", "leaf node does not match: recursion only uses inner schema", null)]
        public virtual void RecursiveRefWithNoRecursiveAnchorInTheOuterSchemaResource(string inputDataReference, string valid, string description, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("inputDataReference", inputDataReference);
            argumentsOfScenario.Add("valid", valid);
            argumentsOfScenario.Add("description", description);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("$recursiveRef with no $recursiveAnchor in the outer schema resource", @"/* Schema: 
{
            ""$id"": ""http://localhost:4242/recursiveRef7/base.json"",
            ""anyOf"": [
                { ""type"": ""boolean"" },
                {
                    ""type"": ""object"",
                    ""additionalProperties"": {
                        ""$id"": ""http://localhost:4242/recursiveRef7/inner.json"",
                        ""$recursiveAnchor"": true,
                        ""anyOf"": [
                            { ""type"": ""integer"" },
                            { ""type"": ""object"", ""additionalProperties"": { ""$recursiveRef"": ""#"" } }
                        ]
                    }
                }
            ]
        }
*/", tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 225
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
#line 245
    testRunner.Given("the input JSON file \"recursiveRef.json\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 246
    testRunner.And("the schema at \"#/6/schema\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 247
    testRunner.And(string.Format("the input data at \"{0}\"", inputDataReference), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 248
    testRunner.And("I generate a type for the schema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 249
    testRunner.And("I construct an instance of the schema type from the data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 250
    testRunner.When("I validate the instance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 251
    testRunner.Then(string.Format("the result will be {0}", valid), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("multiple dynamic paths to the $recursiveRef keyword")]
        [NUnit.Framework.TestCaseAttribute("#/007/tests/000/data", "true", "recurse to anyLeafNode - floats are allowed", null)]
        [NUnit.Framework.TestCaseAttribute("#/007/tests/001/data", "false", "recurse to integerNode - floats are not allowed", null)]
        public virtual void MultipleDynamicPathsToTheRecursiveRefKeyword(string inputDataReference, string valid, string description, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("inputDataReference", inputDataReference);
            argumentsOfScenario.Add("valid", valid);
            argumentsOfScenario.Add("description", description);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("multiple dynamic paths to the $recursiveRef keyword", @"/* Schema: 
{
            ""$id"": ""recursiveRef8_main.json"",
            ""$defs"": {
                ""inner"": {
                    ""$id"": ""recursiveRef8_inner.json"",
                    ""$recursiveAnchor"": true,
                    ""title"": ""inner"",
                    ""additionalProperties"": {
                        ""$recursiveRef"": ""#""
                    }
                }
            },
            ""if"": {
                ""propertyNames"": {
                    ""pattern"": ""^[a-m]""
                }
            },
            ""then"": {
                ""title"": ""any type of node"",
                ""$id"": ""recursiveRef8_anyLeafNode.json"",
                ""$recursiveAnchor"": true,
                ""$ref"": ""recursiveRef8_main.json#/$defs/inner""
            },
            ""else"": {
                ""title"": ""integer node"",
                ""$id"": ""recursiveRef8_integerNode.json"",
                ""$recursiveAnchor"": true,
                ""type"": [ ""object"", ""integer"" ],
                ""$ref"": ""recursiveRef8_main.json#/$defs/inner""
            }
        }
*/", tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 259
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
#line 293
    testRunner.Given("the input JSON file \"recursiveRef.json\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 294
    testRunner.And("the schema at \"#/7/schema\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 295
    testRunner.And(string.Format("the input data at \"{0}\"", inputDataReference), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 296
    testRunner.And("I generate a type for the schema", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 297
    testRunner.And("I construct an instance of the schema type from the data", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 298
    testRunner.When("I validate the instance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 299
    testRunner.Then(string.Format("the result will be {0}", valid), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

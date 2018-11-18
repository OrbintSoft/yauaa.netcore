﻿//<copyright file="TestErrorHandling.cs" company="OrbintSoft">
//	Yet Another UserAgent Analyzer.NET Standard
//	Porting realized by Stefano Balzarotti, Copyright (C) OrbintSoft
//
//	Original Author and License:
//
//	Yet Another UserAgent Analyzer
//	Copyright(C) 2013-2018 Niels Basjes
//
//	Licensed under the Apache License, Version 2.0 (the "License");
//	you may not use this file except in compliance with the License.
//	You may obtain a copy of the License at
//
//	https://www.apache.org/licenses/LICENSE-2.0
//
//	Unless required by applicable law or agreed to in writing, software
//	distributed under the License is distributed on an "AS IS" BASIS,
//	WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//	See the License for the specific language governing permissions and
//	limitations under the License.
//
//</copyright>
//<author>Stefano Balzarotti, Niels Basjes</author>
//<date>2018, 11, 14, 20:22</date>
//<summary></summary>

namespace OrbintSoft.Yauaa.Analyzer.Test.Parse.UserAgentNS
{
    using FluentAssertions;
    using OrbintSoft.Yauaa.Analyzer.Parse.UserAgentNS;
    using OrbintSoft.Yauaa.Analyzer.Parse.UserAgentNS.Analyze;
    using OrbintSoft.Yauaa.Analyzer.Parse.UserAgentNS.Debug;
    using OrbintSoft.Yauaa.Analyzer.Parse.UserAgentNS.Parse;
    using OrbintSoft.Yauaa.Analyzer.Test.Fixtures;
    using System;
    using Xunit;

    /// <summary>
    /// Defines the <see cref="TestErrorHandling" />
    /// </summary>
    public class TestErrorHandling : IClassFixture<LogFixture>
    {
        /// <summary>
        /// The RunTest
        /// </summary>
        /// <param name="directory">The directory<see cref="string"/></param>
        /// <param name="file">The file<see cref="string"/></param>
        /// <param name="expectedMessage">The expectedMessage<see cref="string"/></param>
        private void RunTest(string directory, string file, string expectedMessage)
        {
            Action a = new Action(() =>
            {
                UserAgentAnalyzerTester uaa = new UserAgentAnalyzerTester(directory, file);
                uaa.RunTests(false, false);
            });
            a.Should().Throw<InvalidParserConfigurationException>().Where(e => e.Message.Contains(expectedMessage));
        }

        /// <summary>
        /// The CheckNoFile
        /// </summary>
        [Fact]
        public void CheckNoFile()
        {
            RunTest("YamlResources/BadDefinitions", "ThisOneDoesNotExist---Really.yaml", "Unable to find ANY config files");
        }

        /// <summary>
        /// The CheckEmptyFile
        /// </summary>
        [Fact]
        public void CheckEmptyFile()
        {
            RunTest("YamlResources/BadDefinitions", "EmptyFile.yaml", "The file EmptyFile.yaml is empty");
        }

        /// <summary>
        /// The CheckFileIsNotAMap
        /// </summary>
        [Fact]
        public void CheckFileIsNotAMap()
        {
            RunTest("YamlResources/BadDefinitions", "FileIsNotAMap.yaml", "Yaml config problem.(FileIsNotAMap.yaml:21): The value should be a sequence but it is a Mapping");
        }

        /// <summary>
        /// The CheckLookupSetMissing
        /// </summary>
        [Fact]
        public void CheckLookupSetMissing()
        {
            RunTest("YamlResources/BadDefinitions", "LookupSetMissing.yaml", "Missing lookupSet");
        }

        /// <summary>
        /// The CheckBadEntry
        /// </summary>
        [Fact]
        public void CheckBadEntry()
        {
            RunTest("YamlResources/BadDefinitions", "BadEntry.yaml", "Found unexpected config entry:");
        }

        /// <summary>
        /// The CheckLookupMissing
        /// </summary>
        [Fact]
        public void CheckLookupMissing()
        {
            RunTest("YamlResources/BadDefinitions", "LookupMissing.yaml", "Missing lookup");
        }

        /// <summary>
        /// The CheckFixedStringLookupMissing
        /// </summary>
        [Fact]
        public void CheckFixedStringLookupMissing()
        {
            RunTest("YamlResources/BadDefinitions", "FixedStringLookupMissing.yaml", "Missing lookup");
        }

        /// <summary>
        /// The CheckNoExtract
        /// </summary>
        [Fact]
        public void CheckNoExtract()
        {
            RunTest("YamlResources/BadDefinitions", "NoExtract.yaml", "Matcher does not extract anything");
        }

        /// <summary>
        /// The CheckInvalidExtract
        /// </summary>
        [Fact]
        public void CheckInvalidExtract()
        {
            RunTest("YamlResources/BadDefinitions", "InvalidExtract.yaml", "Invalid extract config line: agent.text=\"foo\"");
        }

        /// <summary>
        /// The CheckNoTestInput
        /// </summary>
        [Fact]
        public void CheckNoTestInput()
        {
            RunTest("YamlResources/BadDefinitions", "NoTestInput.yaml", "Test is missing input");
        }

        /// <summary>
        /// The CheckSyntaxErrorRequire
        /// </summary>
        [Fact]
        public void CheckSyntaxErrorRequire()
        {
            RunTest("YamlResources/BadDefinitions", "SyntaxErrorRequire.yaml", "Syntax error");
        }

        /// <summary>
        /// The CheckSyntaxErrorExtract1
        /// </summary>
        [Fact]
        public void CheckSyntaxErrorExtract1()
        {
            RunTest("YamlResources/BadDefinitions", "SyntaxErrorExtract1.yaml", "Syntax error");
        }

        /// <summary>
        /// The CheckSyntaxErrorExtract2
        /// </summary>
        [Fact]
        public void CheckSyntaxErrorExtract2()
        {
            RunTest("YamlResources/BadDefinitions", "SyntaxErrorExtract2.yaml", "Invalid extract config line");
        }

        /// <summary>
        /// The CheckSyntaxErrorVariable1
        /// </summary>
        [Fact]
        public void CheckSyntaxErrorVariable1()
        {
            RunTest("YamlResources/BadDefinitions", "SyntaxErrorVariable1.yaml", "Syntax error");
        }

        /// <summary>
        /// The CheckSyntaxErrorVariable2
        /// </summary>
        [Fact]
        public void CheckSyntaxErrorVariable2()
        {
            RunTest("YamlResources/BadDefinitions", "SyntaxErrorVariable2.yaml", "Invalid variable config line:");
        }

        /// <summary>
        /// The CheckSyntaxErrorVariableBackReference
        /// </summary>
        [Fact]
        public void CheckSyntaxErrorVariableBackReference()
        {
            RunTest("YamlResources/BadDefinitions", "Variable-BackReference.yaml", "Syntax error");
        }

        /// <summary>
        /// The CheckSyntaxErrorVariableBadDefinition
        /// </summary>
        [Fact]
        public void CheckSyntaxErrorVariableBadDefinition()
        {
            RunTest("YamlResources/BadDefinitions", "Variable-BadDefinition.yaml", "Invalid variable config line:");
        }

        /// <summary>
        /// The CheckSyntaxErrorVariableFixedString
        /// </summary>
        [Fact]
        public void CheckSyntaxErrorVariableFixedString()
        {
            RunTest("YamlResources/BadDefinitions", "Variable-FixedString.yaml", "Syntax error");
        }

        /// <summary>
        /// The MethodInputValidation
        /// </summary>
        [Fact]
        public void MethodInputValidation()
        {
            UserAgentAnalyzer uaa = UserAgentAnalyzer.NewBuilder()
                .WithField("AgentClass")
                .Build();

            UserAgent agent = uaa.Parse((string)null);
            agent.Should().NotBeNull();
            agent.UserAgentString.Should().BeNull();

            agent = uaa.Parse((UserAgent)null);
            agent.Should().BeNull();

            EvilManualUseragentStringHacks.FixIt(null).Should().BeNull();
        }
    }
}

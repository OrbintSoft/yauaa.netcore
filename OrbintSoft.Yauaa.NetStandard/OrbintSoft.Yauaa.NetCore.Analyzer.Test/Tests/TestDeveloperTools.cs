﻿//-----------------------------------------------------------------------
// <copyright file="TestDeveloperTools.cs" company="OrbintSoft">
//    Yet Another User Agent Analyzer for .NET Standard
//    porting realized by Stefano Balzarotti, Copyright 2018 (C) OrbintSoft
//
//    Original Author and License:
//
//    Yet Another UserAgent Analyzer
//    Copyright(C) 2013-2018 Niels Basjes
//
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//
//    https://www.apache.org/licenses/LICENSE-2.0
//
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
//   
// </copyright>
// <author>Stefano Balzarotti, Niels Basjes</author>
// <date>2018, 11, 24, 17:39</date>
// <summary></summary>
//-----------------------------------------------------------------------
namespace OrbintSoft.Yauaa.Testing.Tests
{
    using FluentAssertions;
    using OrbintSoft.Yauaa.Analyze;
    using OrbintSoft.Yauaa.Analyzer;
    using OrbintSoft.Yauaa.Debug;
    using OrbintSoft.Yauaa.Testing.Fixtures;
    using OrbintSoft.Yauaa.Tests;
    using Xunit;

    /// <summary>
    /// Defines the <see cref="TestDeveloperTools" />
    /// </summary>
    public class TestDeveloperTools : IClassFixture<LogFixture>
    {
        /// <summary>
        /// The ValidateErrorSituationOutput
        /// </summary>
        [Fact]
        public void ValidateErrorSituationOutput()
        {
            UserAgentAnalyzerTester uaa = UserAgentAnalyzerTester
                .NewBuilder()
                .HideMatcherLoadStats()
                .DelayInitialization()
                .DropTests()
                .Build() as UserAgentAnalyzerTester;
            uaa.SetShowMatcherStats(true);
            uaa.KeepTests();
            uaa.LoadResources(Config.RESOURCES_PATH , "CheckErrorOutput.yaml");
            uaa.RunTests(false, true).Should().BeFalse();  // This test must return an error state
        }

        /// <summary>
        /// The ValidateNewTestcaseSituationOutput
        /// </summary>
        [Fact]
        public void ValidateNewTestcaseSituationOutput()
        {
            UserAgentAnalyzerTester uaa = UserAgentAnalyzerTester
            .NewBuilder()
            .DelayInitialization()
            .HideMatcherLoadStats()
            .DropTests()
            .Build() as UserAgentAnalyzerTester;
            uaa.SetShowMatcherStats(true);
            uaa.KeepTests();
            uaa.LoadResources(Config.RESOURCES_PATH, "CheckNewTestcaseOutput.yaml");
            uaa.RunTests(false, true).Should().BeTrue();  // This test must return an error state
        }

        /// <summary>
        /// The ValidateStringOutputsAndMatches
        /// </summary>
        [Fact]
        public void ValidateStringOutputsAndMatches()
        {
            UserAgentAnalyzerTester uaa = UserAgentAnalyzerTester.NewBuilder().WithField("DeviceName").Build() as UserAgentAnalyzerTester;
            UserAgent useragent = uaa.Parse("Mozilla/5.0 (Linux; Android 7.0; Nexus 6 Build/NBD90Z) " +
                "AppleWebKit/537.36 (KHTML, like Gecko) Chrome/53.0.2785.124 Mobile Safari/537.36");
            useragent.ToString().Contains("'Google Nexus 6'").Should().BeTrue();
            useragent.ToJson().Contains("\"DeviceName\":\"Google Nexus 6\"").Should().BeTrue();
            useragent.ToYamlTestCase(true).Contains("'Google Nexus 6'").Should().BeTrue();

            bool ok = false;
            foreach (MatchesList.Match match in uaa.GetMatches())
            {
                if ("agent.(1)product.(1)comments.(3)entry[3-3]".Equals(match.Key))
                {
                    match.Value.Should().Be("Build");
                    ok = true;
                    break;
                }
            }
            ok.Should().BeTrue("Did not see the expected match.");

            ok = false;
            foreach (MatchesList.Match match in uaa.GetUsedMatches(useragent))
            {
                if ("agent.(1)product.(1)comments.(3)entry[3-3]".Equals(match.Key))
                {
                    match.Value.Should().Be("Build");
                    ok = true;
                    break;
                }
            }
            ok.Should().BeTrue("Did not see the expected match.");
        }
    }
}

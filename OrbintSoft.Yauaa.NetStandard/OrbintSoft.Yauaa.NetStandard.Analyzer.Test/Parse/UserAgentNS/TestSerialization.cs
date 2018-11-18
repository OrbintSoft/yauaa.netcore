﻿//<copyright file="TestSerialization.cs" company="OrbintSoft">
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
    using log4net;
    using OrbintSoft.Yauaa.Analyzer.Parse.UserAgentNS.Debug;
    using OrbintSoft.Yauaa.Analyzer.Test.Fixtures;
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;
    using Xunit;

    /// <summary>
    /// Defines the <see cref="TestSerialization" />
    /// </summary>
    public class TestSerialization : IClassFixture<LogFixture>
    {
        /// <summary>
        /// Defines the LOG
        /// </summary>
        private static readonly ILog LOG = LogManager.GetLogger(typeof(TestPredefinedBrowsersPerField));

        /// <summary>
        /// The SerializeAndDeserializeUAA
        /// </summary>
        /// <param name="delay">The delay<see cref="bool"/></param>
        /// <returns>The <see cref="UserAgentAnalyzerTester"/></returns>
        public UserAgentAnalyzerTester SerializeAndDeserializeUAA(bool delay)
        {
            LOG.Info("==============================================================");
            LOG.Info("Create");
            LOG.Info("--------------------------------------------------------------");
            var uaa = new UserAgentAnalyzerTester();
            uaa.SetShowMatcherStats(false);
            if (delay)
            {
                uaa.DelayInitialization();
            }
            else
            {
                uaa.ImmediateInitialization();
            }

            uaa.Initialize();

            LOG.Info("--------------------------------------------------------------");
            LOG.Info("Serialize");
            byte[] bytes;

            using (MemoryStream memoryStream = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(memoryStream, uaa);
                bytes = memoryStream.ToArray();
            }

            LOG.Info(string.Format("The UserAgentAnalyzer was serialized into {0} bytes", bytes.LongLength));
            LOG.Info("--------------------------------------------------------------");
            LOG.Info("Deserialize");

            using (MemoryStream memoryStream = new MemoryStream(bytes))
            {
                var formatter = new BinaryFormatter();
                object obj = formatter.Deserialize(memoryStream);
                obj.Should().BeOfType<UserAgentAnalyzerTester>();
                uaa = obj as UserAgentAnalyzerTester;
            }

            LOG.Info("Done");
            LOG.Info("==============================================================");

            return uaa;
        }

        /// <summary>
        /// The ValidateAllPredefinedBrowsers
        /// </summary>
        /// <param name="delay">The delay<see cref="bool"/></param>
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ValidateAllPredefinedBrowsers(bool delay)
        {
            UserAgentAnalyzerTester uaa = SerializeAndDeserializeUAA(delay);
            LOG.Info("==============================================================");
            LOG.Info("Validating when getting all fields");
            LOG.Info("--------------------------------------------------------------");
            uaa.RunTests(false, true).Should().BeTrue();
        }
    }
}

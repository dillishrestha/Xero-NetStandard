/* 
 * Xero Payroll AU
 *
 * This is the Xero Payroll API for orgs in Australia region.
 *
 * The version of the OpenAPI document: 2.8.0
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Model.PayrollAu;
using Xero.NetStandard.OAuth2.Client;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Xero.NetStandard.OAuth2.Test.Model.PayrollAu
{
    /// <summary>
    ///  Class for testing BankAccount
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class BankAccountTests : IDisposable
    {
        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test the property 'Remainder'
        /// </summary>
        [Theory]
        [InlineData("true", true)]
        [InlineData("false", false)]
        [InlineData("null", null)]
        public async Task RemainderTest(string input, bool? expected)
        {
            var jsonContent = $@"{{
                ""Remainder"": {input}
            }}";
            var response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(jsonContent, Encoding.UTF8, "application/json")
            };
            response.EnsureSuccessStatusCode();
            var deserializer = new CustomJsonCodec(new Configuration());
            var actual = await deserializer.Deserialize<BankAccount>(response);
            Assert.Equal(expected, actual.Remainder);
        }
        /// <summary>
        /// Test the property 'Amount'
        /// </summary>
        [Theory]
        [InlineData("20.00")]
        [InlineData("20")]
        public async Task AmountTest(string input)
        {
            var jsonContent = $@"{{
                ""Amount"": {input}
            }}";
            var response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(jsonContent, Encoding.UTF8, "application/json")
            };
            response.EnsureSuccessStatusCode();
            var deserializer = new CustomJsonCodec(new Configuration());
            var actual = await deserializer.Deserialize<BankAccount>(response);
            Assert.Equal(20, actual.Amount);
        }
    }
}

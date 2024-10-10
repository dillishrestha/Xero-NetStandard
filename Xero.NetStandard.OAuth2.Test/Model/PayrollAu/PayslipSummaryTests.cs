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
using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Model.PayrollAu;
using Xero.NetStandard.OAuth2.Client;
using System.Reflection;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Xero.NetStandard.OAuth2.Test.Model.PayrollAu
{
    /// <summary>
    ///  Class for testing PayslipSummary
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PayslipSummaryTests : IDisposable
    {
        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test the property 'Wages'
        /// </summary>
        [Theory]
        [InlineData("20.00")]
        [InlineData("20")]
        public async Task WagesTest(string input)
        {
            await JsonDoc.Assert<PayslipSummary, decimal?>(
                input: new JsonDoc.Number(nameof(PayslipSummary.Wages), input),
                toProperty: x => x.Wages,
                shouldBe: 20
            );
        }
        /// <summary>
        /// Test the property 'Deductions'
        /// </summary>
        [Theory]
        [InlineData("20.00")]
        [InlineData("20")]
        public async Task DeductionsTest(string input)
        {
            await JsonDoc.Assert<PayslipSummary, decimal?>(
                input: new JsonDoc.Number(nameof(PayslipSummary.Deductions), input),
                toProperty: x => x.Deductions,
                shouldBe: 20
            );
        }
        /// <summary>
        /// Test the property 'Tax'
        /// </summary>
        [Theory]
        [InlineData("20.00")]
        [InlineData("20")]
        public async Task TaxTest(string input)
        {
            await JsonDoc.Assert<PayslipSummary, decimal?>(
                input: new JsonDoc.Number(nameof(PayslipSummary.Tax), input),
                toProperty: x => x.Tax,
                shouldBe: 20
            );
        }
        /// <summary>
        /// Test the property 'Super'
        /// </summary>
        [Theory]
        [InlineData("20.00")]
        [InlineData("20")]
        public async Task SuperTest(string input)
        {
            await JsonDoc.Assert<PayslipSummary, decimal?>(
                input: new JsonDoc.Number(nameof(PayslipSummary.Super), input),
                toProperty: x => x.Super,
                shouldBe: 20
            );
        }
        /// <summary>
        /// Test the property 'Reimbursements'
        /// </summary>
        [Theory]
        [InlineData("20.00")]
        [InlineData("20")]
        public async Task ReimbursementsTest(string input)
        {
            await JsonDoc.Assert<PayslipSummary, decimal?>(
                input: new JsonDoc.Number(nameof(PayslipSummary.Reimbursements), input),
                toProperty: x => x.Reimbursements,
                shouldBe: 20
            );
        }
        /// <summary>
        /// Test the property 'NetPay'
        /// </summary>
        [Theory]
        [InlineData("20.00")]
        [InlineData("20")]
        public async Task NetPayTest(string input)
        {
            await JsonDoc.Assert<PayslipSummary, decimal?>(
                input: new JsonDoc.Number(nameof(PayslipSummary.NetPay), input),
                toProperty: x => x.NetPay,
                shouldBe: 20
            );
        }
    }
}

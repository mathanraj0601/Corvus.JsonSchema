// <copyright file="Benchmark1.cs" company="Endjin Limited">
// Copyright (c) Endjin Limited. All rights reserved.
// </copyright>
#pragma warning disable
namespace Ipv4Draft201909Feature.ValidationOfIPAddresses
{
    using System.Threading.Tasks;
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Diagnosers;
    using Corvus.JsonSchema.Benchmarking.Benchmarks;
    /// <summary>
    /// Additional properties benchmark.
    /// </summary>
    [MemoryDiagnoser]
    public class Benchmark1 : BenchmarkBase
    {
        /// <summary>
        /// Global setup.
        /// </summary>
        /// <returns>A <see cref="Task"/> which completes once setup is complete.</returns>
        [GlobalSetup]
        public Task GlobalSetup()
        {
            return this.GlobalSetup("draft2019-09\\ipv4.json", "#/0/schema", "#/000/tests/001/data", false);
        }
        /// <summary>
        /// Validates using the Corvus types.
        /// </summary>
        [Benchmark]
        public void ValidateCorvus()
        {
            this.ValidateCorvusCore<Ipv4Draft201909Feature.ValidationOfIPAddresses.Schema>();
        }
        /// <summary>
        /// Validates using the Newtonsoft types.
        /// </summary>
        [Benchmark]
        public void ValidateNewtonsoft()
        {
            this.ValidateNewtonsoftCore();
        }
    }
}

// <copyright file="GeneratedBenchmark42.cs" company="Endjin Limited">
// Copyright (c) Endjin Limited. All rights reserved.
// </copyright>
#pragma warning disable
namespace Benchmarks
{
    using System.Threading.Tasks;
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Diagnosers;

    /// <summary>
    /// tests - Undescribed scenario.
    /// </summary>
    [MemoryDiagnoser]
    public class GeneratedBenchmark42 : BenchmarkBase
    {
        private Corvus.Json.Patch.Model.JsonPatchDocument corvusPatch;
        private Json.Patch.JsonPatch? jePatch;

        /// <summary>
        /// Global setup.
        /// </summary>
        /// <returns>A <see cref="Task"/> which completes once setup is complete.</returns>
        [GlobalSetup]
        public async Task GlobalSetup()
        {
            this.jePatch = BuildJEPatch("[{\"op\":\"replace\",\"path\":\"/baz/0/qux\",\"value\":\"world\"}]");
                
            this.corvusPatch = Corvus.Json.Patch.Model.JsonPatchDocument.Parse("[{\"op\":\"replace\",\"path\":\"/baz/0/qux\",\"value\":\"world\"}]");

            await this.GlobalSetupJson("{\"foo\":[1,2,3,4],\"baz\":[{\"qux\":\"hello\"}]}").ConfigureAwait(false);
        }

        /// <summary>
        /// Validates using the Corvus types.
        /// </summary>
        [Benchmark]
        public void PatchCorvus()
        {
            bool result = Corvus.Json.Patch.JsonPatchExtensions.TryApplyPatch(this.Any, this.corvusPatch, out Corvus.Json.JsonAny output);
        }

        /// <summary>
        /// Validates using the Newtonsoft types.
        /// </summary>
        [Benchmark(Baseline = true)]
        public void PatchJsonEverything()
        {
            try
            {
               Json.Patch.PatchResult? patchResult = this.jePatch?.Apply(ElementAsNode());
            }
            catch(Exception)
            {
                // Swallow failures until we can diagnose the issue with running inside BMDN
                // https://github.com/dotnet/BenchmarkDotNet/issues/2032
                throw;
            }
        }
    }
}

// <auto-generated />
#pragma warning disable

using System.CodeDom.Compiler;
using global::System.Runtime.CompilerServices;
using System.Threading.Tasks;

[assembly: global::Xunit.TestFramework("Reqnroll.xUnit.ReqnrollPlugin.XunitTestFrameworkWithAssemblyFixture", "Reqnroll.xUnit.ReqnrollPlugin")]
[assembly: global::Reqnroll.xUnit.ReqnrollPlugin.AssemblyFixture(typeof(global::XUnitAssemblyFixture))]

[GeneratedCode("Reqnroll", "3.10.3-beta")]
public class XUnitAssemblyFixture : global::Xunit.IAsyncLifetime
{
    [MethodImpl(MethodImplOptions.NoInlining)]
    public async Task InitializeAsync()
    {
        var currentAssembly = typeof(XUnitAssemblyFixture).Assembly;
        await global::Reqnroll.TestRunnerManager.OnTestRunStartAsync(currentAssembly);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public async Task DisposeAsync()
    {
        var currentAssembly = typeof(XUnitAssemblyFixture).Assembly;
        await global::Reqnroll.TestRunnerManager.OnTestRunEndAsync(currentAssembly);
    }
}

[global::Xunit.CollectionDefinition("ReqnrollNonParallelizableFeatures", DisableParallelization = true)]
public class ReqnrollNonParallelizableFeaturesCollectionDefinition
{
}
#pragma warning restore

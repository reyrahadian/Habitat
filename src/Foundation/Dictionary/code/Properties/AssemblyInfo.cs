using Hedgehog.ZeroDeploy.Client.Attributes;
using System.Reflection;
using System.Runtime.CompilerServices;

[assembly: AssemblyTitle("Sitecore.Foundation.Dictionary")]
#if ZERODEPLOY
[assembly: AssemblyVersion("1.0.*")]
[assembly: ZeroDeployAssembly]
#else
[assembly: AssemblyVersion("1.0.0.0")]
#endif

[assembly: AssemblyFileVersion("1.0.0.0")]

#if DEBUG
[assembly: InternalsVisibleTo("Sitecore.Foundation.Dictionary.Tests")]

#endif
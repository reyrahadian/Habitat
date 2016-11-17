using Hedgehog.ZeroDeploy.Client.Attributes;
using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("Sitecore.Foundation.FieldEditor")]
#if ZERODEPLOY
[assembly: AssemblyVersion("1.0.*")]
[assembly: ZeroDeployAssembly]
#else
[assembly: AssemblyVersion("1.0.0.0")]
#endif

[assembly: AssemblyFileVersion("1.0.0.0")]
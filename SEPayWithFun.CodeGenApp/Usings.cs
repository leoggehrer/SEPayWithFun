//@CodeCopy
#if IDINT_ON
global using IdType = System.Int32;
#elif IDLONG_ON
    global using IdType = System.Int64;
#elif IDGUID_ON
    global using IdType = System.Guid;
#else
global using IdType = System.Int32;
#endif
global using Common = SEPayWithFun.Common;
global using CommonModules = SEPayWithFun.Common.Modules;
global using SEPayWithFun.Common.Extensions;
global using CommonStaticLiterals = SEPayWithFun.Common.StaticLiterals;
global using TemplatePath = SEPayWithFun.Common.Modules.Template.TemplatePath;

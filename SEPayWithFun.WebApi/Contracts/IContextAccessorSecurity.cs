﻿//@CodeCopy
#if ACCOUNT_ON
namespace SEPayWithFun.WebApi.Contracts
{
    partial interface IContextAccessor
    {
        string SessionToken { set; }
    }
}
#endif

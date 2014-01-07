﻿// Type: SmartQuant.Services.ExecutionServiceEventArgs
// Assembly: SmartQuant.Services, Version=1.0.5036.28340, Culture=neutral, PublicKeyToken=null
// MVID: BBD4879A-0902-4B9F-9A9A-214E03CD2FAE
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Services.dll

using System.Runtime.CompilerServices;
using yVXZ4JIJtSP6EX4fjq;

namespace SmartQuant.Services
{
  public class ExecutionServiceEventArgs : MarketServiceEventArgs
  {
    public IExecutionService Service
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return base.Service as IExecutionService;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ExecutionServiceEventArgs(IExecutionService service)
    {
      BjOiEgGuG7SsSXTumY.w07s1ndzACihi();
      // ISSUE: explicit constructor call
      base.\u002Ector((IMarketService) service);
    }
  }
}

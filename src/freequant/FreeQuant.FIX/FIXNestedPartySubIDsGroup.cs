﻿// Type: SmartQuant.FIX.FIXNestedPartySubIDsGroup
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using QjaKfQ9Jr3AV8F2T87;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  public class FIXNestedPartySubIDsGroup : FIXGroup
  {
    [FIXField("545", EFieldOption.Optional)]
    public string NestedPartySubID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(545).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(545, value);
      }
    }

    [FIXField("805", EFieldOption.Optional)]
    public int NestedPartySubIDType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(805).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(805, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXNestedPartySubIDsGroup()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}

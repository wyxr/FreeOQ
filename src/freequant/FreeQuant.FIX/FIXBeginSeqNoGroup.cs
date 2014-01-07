﻿using QjaKfQ9Jr3AV8F2T87;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXBeginSeqNoGroup : FIXGroup
  {
    [FIXField("7", EFieldOption.Required)]
    public int BeginSeqNo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(7).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(7, value);
      }
    }

    [FIXField("16", EFieldOption.Required)]
    public int EndSeqNo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(16).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(16, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXBeginSeqNoGroup()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXBeginSeqNoGroup(int BeginSeqNo, int EndSeqNo)
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.BeginSeqNo = BeginSeqNo;
      this.EndSeqNo = EndSeqNo;
    }
  }
}

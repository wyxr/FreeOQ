﻿// Type: SmartQuant.FIX.FIXDiscretionInstructions
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using QjaKfQ9Jr3AV8F2T87;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  public class FIXDiscretionInstructions : FIXMessage
  {
    [FIXField("388", EFieldOption.Optional)]
    public char DiscretionInst
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharField(388).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddCharField(388, value);
      }
    }

    [FIXField("389", EFieldOption.Optional)]
    public double DiscretionOffsetValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleField(389).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddDoubleField(389, value);
      }
    }

    [FIXField("841", EFieldOption.Optional)]
    public int DiscretionMoveType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(841).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(841, value);
      }
    }

    [FIXField("842", EFieldOption.Optional)]
    public int DiscretionOffsetType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(842).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(842, value);
      }
    }

    [FIXField("843", EFieldOption.Optional)]
    public int DiscretionLimitType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(843).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(843, value);
      }
    }

    [FIXField("844", EFieldOption.Optional)]
    public int DiscretionRoundDirection
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(844).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(844, value);
      }
    }

    [FIXField("846", EFieldOption.Optional)]
    public int DiscretionScope
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(846).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(846, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXDiscretionInstructions()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}

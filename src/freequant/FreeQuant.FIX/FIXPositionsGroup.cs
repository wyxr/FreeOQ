﻿// Type: SmartQuant.FIX.FIXPositionsGroup
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using QjaKfQ9Jr3AV8F2T87;
using System.Collections;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  public class FIXPositionsGroup : FIXGroup
  {
    private ArrayList Mkcupst1Wb;

    [FIXField("703", EFieldOption.Optional)]
    public string PosType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringValue(703);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetStringValue(703, value);
      }
    }

    [FIXField("704", EFieldOption.Optional)]
    public double LongQty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(704);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(704, value);
      }
    }

    [FIXField("705", EFieldOption.Optional)]
    public double ShortQty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetDoubleValue(705);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetDoubleValue(705, value);
      }
    }

    [FIXField("706", EFieldOption.Optional)]
    public int PosQtyStatus
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(706);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(706, value);
      }
    }

    [FIXField("539", EFieldOption.Optional)]
    public int NoNestedPartyIDs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntValue(539);
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.SetIntValue(539, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXPositionsGroup()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      this.Mkcupst1Wb = new ArrayList();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXNestedPartyIDsGroup GetNestedPartyIDsGroup(int i)
    {
      if (i < this.NoNestedPartyIDs)
        return (FIXNestedPartyIDsGroup) this.Mkcupst1Wb[i];
      else
        return (FIXNestedPartyIDsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXNestedPartyIDsGroup group)
    {
      this.Mkcupst1Wb.Add((object) group);
      ++this.NoNestedPartyIDs;
    }
  }
}
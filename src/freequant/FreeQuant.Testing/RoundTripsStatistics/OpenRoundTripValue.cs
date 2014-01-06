﻿// Type: SmartQuant.Testing.RoundTripsStatistics.OpenRoundTripValue
// Assembly: SmartQuant.Testing, Version=1.0.5036.28344, Culture=neutral, PublicKeyToken=null
// MVID: 176468FF-0FA0-4631-84AD-38EF6EDC463D
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Testing.dll

using Byqm85MNrFBe6JPJlI;
using SmartQuant.Testing.RoundTrips;
using System.Runtime.CompilerServices;

namespace SmartQuant.Testing.RoundTripsStatistics
{
  public class OpenRoundTripValue : RoundTripsTesterItem
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public OpenRoundTripValue(RoundTripList parentRoundTripList, string title)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector(parentRoundTripList, title);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void CalculateSeries(int firstIndex, int lastIndex)
    {
      double Data = this.series.Count != 0 ? this.series.Last : 0.0;
      for (int index = firstIndex; index <= lastIndex; ++index)
      {
        if (index >= this.parentRoundTripList.CountOfClosedRoundTrips())
        {
          double resultWithoutCost = this.parentRoundTripList[index].RoundTripResultWithoutCost;
          Data += resultWithoutCost;
          this.series.Add(this.parentRoundTripList[index].ExitDateTime, Data);
        }
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override double GetValue(int lastIndex)
    {
      double num = 0.0;
      for (int index = this.parentRoundTripList.CountOfClosedRoundTrips(); index <= lastIndex; ++index)
      {
        double resultWithoutCost = this.parentRoundTripList[index].RoundTripResultWithoutCost;
        num += resultWithoutCost;
      }
      return num;
    }
  }
}

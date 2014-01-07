﻿using OpenQuant.ObjectMap;

namespace OpenQuant.API
{
  public class BarSeriesList
  {
    public BarSeries this[Instrument instrument, BarType barType, long barSize]
    {
      get
      {
        return new BarSeries(SmartQuant.Instruments.DataManager.Bars[Map.OQ_SQ_Instrument[(object) instrument] as SmartQuant.Instruments.Instrument, EnumConverter.Convert(barType), barSize]);
      }
    }

    public BarSeries this[Instrument instrument]
    {
      get
      {
        return new BarSeries(SmartQuant.Instruments.DataManager.Bars[Map.OQ_SQ_Instrument[(object) instrument] as SmartQuant.Instruments.Instrument]);
      }
    }
  }
}
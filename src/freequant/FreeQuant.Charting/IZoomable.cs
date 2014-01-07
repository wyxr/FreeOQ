﻿// Type: SmartQuant.Charting.IZoomable
// Assembly: SmartQuant.Charting, Version=1.0.5036.28338, Culture=neutral, PublicKeyToken=null
// MVID: 31D4C736-04FD-420E-87A7-219DB548155F
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Charting.dll

namespace SmartQuant.Charting
{
  public interface IZoomable
  {
    bool IsPadRangeX();

    bool IsPadRangeY();

    PadRange GetPadRangeX(Pad pad);

    PadRange GetPadRangeY(Pad pad);
  }
}

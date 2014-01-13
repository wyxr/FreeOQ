﻿// Type: SmartQuant.Indicators.PDI
// Assembly: SmartQuant.Indicators, Version=1.0.5036.28340, Culture=neutral, PublicKeyToken=null
// MVID: 31E147DE-EF63-4F0C-B049-23C3662CE212
// Assembly location: E:\OpenQuant\Framework\bin\SmartQuant.Indicators.dll

using JgR8Nw4Dcm7J7u8IfB;
using ko1tl8f5ZvqOYr69tl;
using SmartQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace SmartQuant.Indicators
{
  [Serializable]
  public class PDI : Indicator
  {
    protected EIndicatorStyle fStyle;
    protected int fLength;
    protected DoubleSeries fPDM;
    protected DoubleSeries fTR;

    [Description("")]
    [Category("Parameters")]
    [IndicatorParameter(0)]
    public int Length
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fLength;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fLength = value;
        this.Init();
      }
    }

    [Description("")]
    [Category("Parameters")]
    [IndicatorParameter(1)]
    public EIndicatorStyle Style
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fStyle;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fStyle = value;
        this.Init();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PDI()
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PDI(TimeSeries input, int length, EIndicatorStyle style)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fLength = length;
      this.fStyle = style;
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PDI(TimeSeries input, int length, EIndicatorStyle style, Color color)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fLength = length;
      this.fStyle = style;
      this.Init();
      this.Color = color;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PDI(TimeSeries input, int length, EIndicatorStyle style, Color color, EDrawStyle drawStyle)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fLength = length;
      this.fStyle = style;
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PDI(TimeSeries input, int length)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fLength = length;
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PDI(TimeSeries input, int length, Color color)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fLength = length;
      this.Color = color;
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Init()
    {
      this.fName = GXPBSPblRhtUOANrS4.LSuAVoYjy(3036) + (object) this.fLength + GXPBSPblRhtUOANrS4.LSuAVoYjy(3050);
      this.fTitle = GXPBSPblRhtUOANrS4.LSuAVoYjy(3056);
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null)
        return;
      if (TimeSeries.fNameOption == ENameOption.Long)
        this.fName = this.fInput.Name + GXPBSPblRhtUOANrS4.LSuAVoYjy(3112) + this.fName;
      this.fPDM = new DoubleSeries();
      this.fTR = new DoubleSeries();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Calculate(int index)
    {
      double Data1 = double.NaN;
      if (this.fStyle == EIndicatorStyle.QuantStudio)
      {
        double Data2 = 0.0;
        double Data3 = 0.0;
        if (index >= this.fLength + this.fInput.FirstIndex)
        {
          if (index == this.fLength + this.fInput.FirstIndex)
          {
            for (int index1 = index; index1 >= index - this.fLength + 1; --index1)
            {
              Data3 += TR.Value(this.fInput, index1);
              Data2 += PDM.Value(this.fInput, index1);
            }
          }
          else
          {
            Data2 = this.fPDM[index - 1] - PDM.Value(this.fInput, index - this.fLength) + PDM.Value(this.fInput, index);
            Data3 = this.fTR[index - 1] - TR.Value(this.fInput, index - this.fLength) + TR.Value(this.fInput, index);
          }
          if (Data3 != 0.0)
            Data1 = Data2 / Data3 * 100.0;
        }
        this.fPDM.Add(this.fInput.GetDateTime(index), Data2);
        this.fTR.Add(this.fInput.GetDateTime(index), Data3);
      }
      else
      {
        double Data2 = 0.0;
        double Data3 = 0.0;
        if (index >= this.fLength + this.fInput.FirstIndex)
        {
          if (index == this.fLength + this.fInput.FirstIndex)
          {
            for (int index1 = index; index1 >= index - this.fLength + 1; --index1)
            {
              Data3 += TR.Value(this.fInput, index1);
              Data2 += PDM.Value(this.fInput, index1);
            }
          }
          else
          {
            Data2 = this.fPDM[index - 1] - this.fPDM[index - 1] / (double) this.fLength + PDM.Value(this.fInput, index);
            Data3 = this.fTR[index - 1] - this.fTR[index - 1] / (double) this.fLength + TR.Value(this.fInput, index);
          }
          if (Data3 != 0.0)
            Data1 = Data2 / Data3 * 100.0;
        }
        this.fPDM.Add(this.fInput.GetDateTime(index), Data2);
        this.fTR.Add(this.fInput.GetDateTime(index), Data3);
      }
      this.Add(this.fInput.GetDateTime(index), Data1);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Value(TimeSeries input, int index, int length, EIndicatorStyle style)
    {
      if (style == EIndicatorStyle.QuantStudio)
      {
        double num1 = 0.0;
        double num2 = 0.0;
        if (index < length + input.FirstIndex)
          return double.NaN;
        for (int index1 = index; index1 > index - length; --index1)
        {
          num2 += TR.Value(input, index1);
          num1 += PDM.Value(input, index1);
        }
        return num1 / num2 * 100.0;
      }
      else
      {
        double num1 = 0.0;
        double num2 = 0.0;
        if (index < length + input.FirstIndex)
          return double.NaN;
        for (int index1 = length + input.FirstIndex; index1 >= input.FirstIndex + 1; --index1)
        {
          num2 += TR.Value(input, index1);
          num1 += PDM.Value(input, index1);
        }
        for (int index1 = length + 1 + input.FirstIndex; index1 <= index; ++index1)
        {
          num1 = num1 - num1 / (double) length + PDM.Value(input, index1);
          num2 = num2 - num2 / (double) length + TR.Value(input, index1);
        }
        return num1 / num2 * 100.0;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Value(TimeSeries input, int index, int length)
    {
      return PDI.Value(input, index, length, EIndicatorStyle.QuantStudio);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
    {
      if (!this.fMonitored)
        return;
      int index = this.fInput.GetIndex(EventArgs.DateTime);
      if (index == -1)
        return;
      if (this.fStyle == EIndicatorStyle.QuantStudio)
      {
        for (int Index = index; Index <= Math.Min(this.fInput.Count - 1, index + this.fLength); ++Index)
          this.Calculate(Index);
      }
      else
      {
        for (int Index = index; Index <= this.fInput.Count - 1; ++Index)
          this.Calculate(Index);
      }
    }
  }
}
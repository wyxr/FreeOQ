﻿// Type: SmartQuant.Execution.SellSideOrderList
// Assembly: SmartQuant.Execution, Version=1.0.5036.28343, Culture=neutral, PublicKeyToken=null
// MVID: 444CC37E-F17B-4ED8-9FD1-FAF0B8C26A05
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Execution.dll

using RZ1j9O1DCcsDf19ge6;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SmartQuant.Execution
{
  public class SellSideOrderList : ICollection, IEnumerable
  {
    private Dictionary<string, SingleOrder> iX0Aocoro;
    private List<SingleOrder> YCZoPZ1j9;

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.YCZoPZ1j9.Count;
      }
    }

    public bool IsSynchronized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return false;
      }
    }

    public object SyncRoot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (object) null;
      }
    }

    public SingleOrder this[string orderID]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        SingleOrder singleOrder;
        if (this.iX0Aocoro.TryGetValue(orderID, out singleOrder))
          return singleOrder;
        else
          return (SingleOrder) null;
      }
    }

    public SingleOrder this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.YCZoPZ1j9[index];
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal SellSideOrderList()
    {
      NwTRRFsYX0ocoroLCZ.RAuNDcAzwyQvC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.iX0Aocoro = new Dictionary<string, SingleOrder>();
      this.YCZoPZ1j9 = new List<SingleOrder>();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTo(Array array, int index)
    {
      this.YCZoPZ1j9.ToArray().CopyTo(array, index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator()
    {
      return (IEnumerator) this.YCZoPZ1j9.GetEnumerator();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void HKElmrgRF()
    {
      this.iX0Aocoro.Clear();
      this.YCZoPZ1j9.Clear();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void YKsdCTvel([In] SingleOrder obj0)
    {
      this.iX0Aocoro.Add(obj0.OrderID, obj0);
      this.YCZoPZ1j9.Add(obj0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void rkS4wTRRF([In] int obj0)
    {
      this.iX0Aocoro.Remove(this.YCZoPZ1j9[obj0].OrderID);
      this.YCZoPZ1j9.RemoveAt(obj0);
    }
  }
}

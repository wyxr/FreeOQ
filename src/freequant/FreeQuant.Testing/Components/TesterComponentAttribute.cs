﻿// Type: SmartQuant.Testing.Components.TesterComponentAttribute
// Assembly: SmartQuant.Testing, Version=1.0.5036.28344, Culture=neutral, PublicKeyToken=null
// MVID: 176468FF-0FA0-4631-84AD-38EF6EDC463D
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Testing.dll

using Byqm85MNrFBe6JPJlI;
using System;
using System.Runtime.CompilerServices;

namespace SmartQuant.Testing.Components
{
  [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
  public class TesterComponentAttribute : Attribute
  {
    private Guid OKRyrLQ5yq;
    private string e85yyNrFBe;
    private string WJPyeJlI4g;

    public Guid GUID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.OKRyrLQ5yq;
      }
    }

    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.e85yyNrFBe;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.e85yyNrFBe = value;
      }
    }

    public string Description
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.WJPyeJlI4g;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.WJPyeJlI4g = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TesterComponentAttribute(string guid)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.OKRyrLQ5yq = new Guid(guid);
      this.e85yyNrFBe = (string) null;
      this.WJPyeJlI4g = (string) null;
    }
  }
}
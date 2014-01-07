﻿using ASQMKC8WePBGJ83PL4;
using Byqm85MNrFBe6JPJlI;
using FreeQuant;
using FreeQuant.Testing;
using FreeQuant.Testing.TesterItems;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Testing.Components
{
  public class TesterComponentManager
  {
    private const string Rr2b3xvpH = "tester";
    public const string COMP_EXT = ".cpt";
    private static TesterComponentRecordList G1d22oBB0;

    public static TesterComponentRecordList Components
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return TesterComponentManager.G1d22oBB0;
      }
    }

    public static event TesterComponentEventHandler TesterComponentAdded;

    public static event TesterComponentEventHandler TesterComponentRemoved;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static TesterComponentManager()
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      TesterComponentManager.G1d22oBB0 = new TesterComponentRecordList();
      TesterComponentManager.D970UYDsW();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TesterComponentManager()
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void D970UYDsW()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static TesterComponentRecord[] rAdPWPX1l([In] FileInfo obj0)
    {
      CompilerResults compilerResults = CompilingService.Compile(new string[1]
      {
        obj0.FullName
      }, new string[2]
      {
        s3j2vikrJi2pVH1Xpv.aMieSmUS9G(1864),
        s3j2vikrJi2pVH1Xpv.aMieSmUS9G(1888)
      }, 0 != 0);
      ArrayList arrayList = new ArrayList();
      foreach (Type type in compilerResults.CompiledAssembly.GetTypes())
      {
        object[] customAttributes = type.GetCustomAttributes(typeof (TesterComponentAttribute), false);
        string name;
        string description;
        if (customAttributes.Length > 0)
        {
          TesterComponentAttribute componentAttribute = customAttributes[0] as TesterComponentAttribute;
          name = componentAttribute.Name == null ? type.Name : componentAttribute.Name;
          description = componentAttribute.Description == null ? "" : componentAttribute.Description;
        }
        else
        {
          name = type.Name;
          description = "";
        }
        TesterComponentRecord testerComponentRecord = new TesterComponentRecord(name, description, obj0, type);
        TesterComponentManager.G1d22oBB0.x1QyU3cJOi(testerComponentRecord);
        arrayList.Add((object) testerComponentRecord);
      }
      return arrayList.ToArray(typeof (TesterComponentRecord)) as TesterComponentRecord[];
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void AddExistingComponent(FileInfo existingFile)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TesterComponentRecordList GetComponents(bool onlySeries)
    {
      TesterComponentRecordList componentRecordList = new TesterComponentRecordList();
      foreach (TesterComponentRecord testerComponentRecord in TesterComponentManager.G1d22oBB0)
      {
        if (!onlySeries || testerComponentRecord.Type == typeof (SeriesTesterItem))
          componentRecordList.x1QyU3cJOi(testerComponentRecord);
      }
      return componentRecordList;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TesterItem GetComponent(string name)
    {
      TesterComponentRecord testerComponentRecord = TesterComponentManager.G1d22oBB0[name];
      TesterItem testerItem = Activator.CreateInstance(testerComponentRecord.Type, new object[1]
      {
        (object) name
      }) as TesterItem;
      testerItem.Name = testerComponentRecord.Name;
      testerItem.Description = testerComponentRecord.Description;
      return testerItem;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SaveComponent(TesterItem component, string fileDir)
    {
      StreamWriter streamWriter = new StreamWriter(fileDir + component.Name + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(1928));
      streamWriter.WriteLine(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(1940) + component.GetType().Name);
      foreach (PropertyInfo propertyInfo in component.GetType().GetProperties())
      {
        BrowsableAttribute[] browsableAttributeArray = propertyInfo.GetCustomAttributes(typeof (BrowsableAttribute), true) as BrowsableAttribute[];
        bool flag = true;
        foreach (BrowsableAttribute browsableAttribute in browsableAttributeArray)
        {
          if (!browsableAttribute.Browsable)
            flag = false;
        }
        if (flag)
          TesterComponentManager.WFNAaUJL5(component, propertyInfo, streamWriter);
      }
      streamWriter.Close();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static TesterItem LoadComponent(LiveTester tester, string fileName)
    {
      StreamReader streamReader = new StreamReader(fileName);
      string str1 = streamReader.ReadLine();
      TesterItem component = TesterComponentManager.GetComponent(str1.Remove(0, str1.IndexOf(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(1980)) + 3));
      string str2;
      while ((str2 = streamReader.ReadLine()) != null)
        TesterComponentManager.zWD3jRjZ4(tester, component, str2, fileName);
      streamReader.Close();
      return component;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void WFNAaUJL5([In] TesterItem obj0, [In] PropertyInfo obj1, [In] StreamWriter obj2)
    {
      string name = obj1.Name;
      string str = "";
      if (obj1.PropertyType.IsSubclassOf(typeof (TesterItem)))
      {
        TesterItem testerItem = obj1.GetValue((object) obj0, (object[]) null) as TesterItem;
        if (testerItem != null)
          str = testerItem.Name;
      }
      else
        str = obj1.GetValue((object) obj0, (object[]) null).ToString();
      obj2.WriteLine(name + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(1986) + str);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void zWD3jRjZ4([In] LiveTester obj0, [In] TesterItem obj1, [In] string obj2, [In] string obj3)
    {
      string name = obj2.Substring(0, obj2.IndexOf(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(1996)));
      string index = obj2.Remove(0, obj2.IndexOf(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(2002)) + 3);
      PropertyInfo property = obj1.GetType().GetProperty(name);
      object obj = (object) null;
      if (property.PropertyType.IsSubclassOf(typeof (TesterItem)))
      {
        if (obj0.Components.Contains(index))
          obj = (object) obj0.Components[index];
        else if (index != "")
          obj = !new FileInfo((string) (object) (obj3.LastIndexOf(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(2008)) + 1) + (object) index + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(2014)).Exists ? (object) TesterComponentManager.GetComponent(index) : (object) TesterComponentManager.LoadComponent(obj0, obj3.Substring(0, obj3.LastIndexOf(s3j2vikrJi2pVH1Xpv.aMieSmUS9G(2026)) + 1) + index + s3j2vikrJi2pVH1Xpv.aMieSmUS9G(2032));
      }
      else if (property.PropertyType == typeof (double))
        obj = (object) double.Parse(index);
      else if (property.PropertyType == typeof (string))
        obj = (object) index;
      else if (property.PropertyType == typeof (int))
        obj = (object) int.Parse(index);
      property.SetValue((object) obj1, obj, (object[]) null);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void D46LsaCyb([In] TesterComponentRecord obj0)
    {
      if (TesterComponentManager.hCg6tO1Ha == null)
        return;
      TesterComponentManager.hCg6tO1Ha(new TesterComponentEventArgs(obj0));
    }
  }
}

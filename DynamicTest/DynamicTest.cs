using System;
using System.Collections.Generic;
using System.Dynamic;

// https://docs.microsoft.com/en-us/dotnet/api/system.dynamic.dynamicobject?view=netcore-3.1

namespace DynamicTest {
  public class DynamicDictionary : DynamicObject {
    Dictionary<string, object> dictionary = new Dictionary<string, object> ();

    public int Count {
      get {
        return dictionary.Count;
      }
    }
    public override bool TryGetMember (
      GetMemberBinder binder, out object result) {
      string name = binder.Name.ToLower ();

      return dictionary.TryGetValue (name, out result);
    }

    public override bool TrySetMember (
      SetMemberBinder binder, object value) {
      dictionary[binder.Name.ToLower ()] = value;

      return true;
    }
  }
}
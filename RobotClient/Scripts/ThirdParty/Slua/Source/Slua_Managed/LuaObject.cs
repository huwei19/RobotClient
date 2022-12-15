// The MIT License (MIT)

// Copyright 2015 Siney/Pangweiwei siney@yeah.net
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

namespace SLua
{

#if !SLUA_STANDALONE
	using UnityEngine;
#endif
	using System;
	using System.Reflection;
	using System.Collections.Generic;

	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Struct | AttributeTargets.Delegate | AttributeTargets.Interface)]
	public class CustomLuaClassAttribute : System.Attribute
	{
		public CustomLuaClassAttribute()
		{
			//
		}
	}

	[AttributeUsage(AttributeTargets.Enum)]
	public class EnumLuaExportAttribute : System.Attribute
	{
		public EnumLuaExportAttribute ()
		{
			//
		}
	}

	public class DoNotToLuaAttribute : System.Attribute
	{
		public DoNotToLuaAttribute()
		{
			//
		}
	}

	public class LuaBinderAttribute : System.Attribute
	{
		public int order;
		public LuaBinderAttribute(int order)
		{
			this.order = order;
		}
	}

	[AttributeUsage(AttributeTargets.Method)]
	public class StaticExportAttribute : System.Attribute
	{
		public StaticExportAttribute()
		{
			//
		}
	}

	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
	public class LuaOverrideAttribute : System.Attribute {
		public string fn;
		public LuaOverrideAttribute(string fn) {
			this.fn = fn;
		}
	}

	public class OverloadLuaClassAttribute : System.Attribute {
		public OverloadLuaClassAttribute(Type target) {
			targetType = target;
		}
		public Type targetType;
	}


    public class LuaOut { }

	public partial class LuaObject
	{

		//static protected LuaCSFunction lua_gc = new LuaCSFunction(luaGC);
		//static protected LuaCSFunction lua_add = new LuaCSFunction(luaAdd);
		//static protected LuaCSFunction lua_sub = new LuaCSFunction(luaSub);
		//static protected LuaCSFunction lua_mul = new LuaCSFunction(luaMul);
		//static protected LuaCSFunction lua_div = new LuaCSFunction(luaDiv);
		//static protected LuaCSFunction lua_unm = new LuaCSFunction(luaUnm);
		//static protected LuaCSFunction lua_eq = new LuaCSFunction(luaEq);
  //      static protected LuaCSFunction lua_lt = new LuaCSFunction(luaLt);
  //      static protected LuaCSFunction lua_le = new LuaCSFunction(luaLe);
  //      static protected LuaCSFunction lua_tostring = new LuaCSFunction(ToString);

		const string DelgateTable = "__LuaDelegate";
		static protected Dictionary<MethodBase, string> methodDict = new Dictionary<MethodBase, string>();

		internal const int VersionNumber = 0x1500;


		static public void assert(bool cond,string err) {
			if(!cond) throw new Exception(err);
		}

        /// <summary>
        /// Change Type, alternative for Convert.ChangeType, but has exception handling
        /// change fail, return origin value directly, useful for some LuaVarObject value assign
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="t"></param>
        /// <returns></returns>
	    static public object changeType(object obj, Type t)
        {
            if (t == typeof (object)) return obj;
            if (null == obj) return default(Type);
            if (obj.GetType() == t) return obj;

            try
            {
                return Convert.ChangeType(obj, t);
            }
            catch
            {
                return obj;
            }
	    }
	}

}

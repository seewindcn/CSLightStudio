﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSEvil
{
    public class CLS_Type_Var : ICLS_Type
    {
        public class var
        {

        }
        public string keyword
        {
            get { return "var"; }
        }

        public Type type
        {
            get { return typeof(var); }
        }

        public ICLS_Value MakeValue(object value)
        {
            throw new NotImplementedException();
        }

        public object ConvertTo(CLS_Content env, object src, Type targetType)
        {
            throw new NotImplementedException();
        }

        public object Math2Value(CLS_Content env, char code, object left, CLS_Content.Value right, out Type returntype)
        {
            throw new NotImplementedException();
        }

        public bool MathLogic(CLS_Content env, logictoken code, object left, CLS_Content.Value right)
        {
            throw new NotImplementedException();
        }

        public ICLS_TypeFunction function
        {
            get { throw new NotImplementedException(); }
        }
        public object DefValue
        {
            get { return null; }
        }
    }
}

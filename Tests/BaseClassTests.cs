using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using AidMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEvents.Domain.Interfaces;

namespace Tests
{
    public class BaseClassTests<TClass, TBaseClass> : BaseTests
    {
        protected TClass obj;

        [TestInitialize]
        public virtual void TestInitialize()
        {
            type = typeof(TClass);
        }

        [TestMethod]
        public void IsInheritedTest()
        {
            Assert.AreEqual(typeof(TBaseClass), type.BaseType);
        }

        protected static void IsNullableProperty<T>(Func<T> get, Action<T> set)
        {
            IsProperty(get, set);
            set(default);
            Assert.IsNull(get());
        }
        //protected static void IsNullableProperty(object o, string name, Type t)
        //{
        //    IsProperty(o, name, t);
        //    var p = o.GetType().GetProperty(name);
        //    CanSetValue(o, p, null);
        //}

        //protected static void IsProperty(object o, string name, Type t)
        //{
        //    var p = IsReadWriteProperty(o, name, t);
        //    CanSetValue(o, p, GetRandom.Value(t));
        //}

        protected static void IsNullableProperty(object o, string name, Type type)
        {
            var property = o.GetType().GetProperty(name);
            Assert.IsNotNull(property);
            Assert.AreEqual(type, property.PropertyType);
            Assert.IsTrue(property.CanWrite);
            Assert.IsTrue(property.CanRead);
            property.SetValue(o, null);
            var actual = property.GetValue(o);
            Assert.AreEqual(null, actual);
        }

        protected void IsNullableProperty<TType>()
        {
            var n = GetPropertyName();
            IsNullableProperty(obj, n, typeof(TType));
        }

        protected static void IsProperty<T>(Func<T> get, Action<T> set)
        {
            var d = (T) GetRandom.Value(typeof(T));
            Assert.AreNotEqual(d, get());
            set(d);
            Assert.AreEqual(d, get());
        }

        //protected static void IsReadOnlyProperty(object o, string name, object expected)
        //{
        //    var property = o.GetType().GetProperty(name);
        //    Assert.IsNotNull(property);
        //    Assert.IsFalse(property.CanWrite);
        //    Assert.IsTrue(property.CanRead);
        //    var actual = property.GetValue(o);
        //    Assert.AreEqual(expected, actual);
        //}
        protected static object IsReadOnlyProperty(object o, string name)
        {
            var property = o.GetType().GetProperty(name);
            Assert.IsNotNull(property);
            Assert.IsFalse(property.CanWrite);
            Assert.IsTrue(property.CanRead);

            return property.GetValue(o);
        }

        protected void IsReadOnlyProperty(object expected)
        {
            var n = GetPropertyNameAfter("IsReadOnlyProperty");
            IsReadOnlyProperty(obj, n, expected);
        }

        protected static void IsReadOnlyProperty(object o, string name, object expected)
        {
            var actual = IsReadOnlyProperty(o, name);
            Assert.AreEqual(expected, actual);
        }

        protected string GetPropertyNameAfter(string methodName)
        {
            var stack = new StackTrace();
            int i;
            for (i = 0; i < stack.FrameCount - 1; i++)
            {
                var n = stack.GetFrame(i)?.GetMethod()?.Name;

                if (n == methodName) break;
            }

            for (i += 1; i < stack.FrameCount - 1; i++)
            {
                var n = stack.GetFrame(i)?.GetMethod()?.Name;

                if (n == "MoveNext" || n == "Start") continue;

                return n?.Replace("Test", string.Empty);
            }

            return string.Empty;
        }

        protected static void IsProperty(object o, string name, Type t)
        {
            var p = IsReadWriteProperty(o, name, t);
            CanSetValue(o, p, GetRandom.Value(t));
        }

        protected static PropertyInfo IsReadWriteProperty(object o, string name, Type t)
        {
            var p = o.GetType().GetProperty(name);
            Assert.IsNotNull(p);
            Assert.AreEqual(t, p.PropertyType);
            Assert.IsTrue(p.CanWrite);
            Assert.IsTrue(p.CanRead);

            return p;
        }

        private static void CanSetValue(object o, PropertyInfo p, object v)
        {
            p.SetValue(o, v);
            Assert.AreEqual(v, p.GetValue(o));
        }

        protected void IsNullableProperty<TType>(string displayName)
        {
            var n = GetPropertyName();
            IsNullableProperty(obj, n, typeof(TType));
            HasDisplayName(n, displayName);
        }

        protected void IsProperty<TType>(string displayName)
        {
            var n = GetPropertyName();
            IsProperty(obj, n, typeof(TType));
            HasDisplayName(n, displayName);
        }

        protected static void HasDisplayName(string propertyName, string displayName)
            => Assert.AreEqual(displayName, GetMember.DisplayName<TClass>(propertyName));

        protected string GetPropertyName(int stackFrameIdx = 2)
        {
            var stack = new StackTrace();
            var n = stack.GetFrame(stackFrameIdx)?.GetMethod()?.Name;

            return n?.Replace("Test", string.Empty);
        }


        //protected static void IsReadOnlyProperty(object o, string name, object expected)
        //{
        //    var actual = IsReadOnlyProperty(o, name);
        //    Assert.AreEqual(expected, actual);
        //}

        //protected static object IsReadOnlyProperty(object o, string name)
        //{
        //    var property = o.GetType().GetProperty(name);
        //    Assert.IsNotNull(property);
        //    Assert.IsFalse(property.CanWrite);
        //    Assert.IsTrue(property.CanRead);

        //    return property.GetValue(o);
        //}

    }
}

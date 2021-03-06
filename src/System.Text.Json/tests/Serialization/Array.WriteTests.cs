﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Xunit;

namespace System.Text.Json.Serialization.Tests
{
    public static partial class ArrayTests
    {
        [Fact]
        public static void WriteClassWithStringArray()
        {
            string json;

            {
                TestClassWithStringArray obj = new TestClassWithStringArray();
                obj.Initialize();
                obj.Verify();
                json = JsonSerializer.ToString(obj);
            }

            {
                TestClassWithStringArray obj = JsonSerializer.Parse<TestClassWithStringArray>(json);
                obj.Verify();
            }

            {
                TestClassWithStringArray obj = JsonSerializer.Parse<TestClassWithStringArray>(TestClassWithStringArray.s_data);
                obj.Verify();
            }
        }

        [Fact]
        public static void WriteClassWithObjectArray()
        {
            string json;

            {
                TestClassWithObjectList obj = new TestClassWithObjectList();
                obj.Initialize();
                obj.Verify();
                json = JsonSerializer.ToString(obj);
            }

            {
                TestClassWithObjectList obj = JsonSerializer.Parse<TestClassWithObjectList>(json);
                obj.Verify();
            }

            {
                TestClassWithObjectList obj = JsonSerializer.Parse<TestClassWithObjectList>(TestClassWithObjectList.s_data);
                obj.Verify();
            }
        }



        [Fact]
        public static void WriteClassWithGenericList()
        {
            string json;

            {
                TestClassWithGenericList obj = new TestClassWithGenericList();
                obj.Initialize();
                obj.Verify();
                json = JsonSerializer.ToString(obj);
            }

            {
                TestClassWithGenericList obj = JsonSerializer.Parse<TestClassWithGenericList>(json);
                obj.Verify();
            }

            {
                TestClassWithGenericList obj = JsonSerializer.Parse<TestClassWithGenericList>(TestClassWithGenericList.s_data);
                obj.Verify();
            }
        }

        public static void WriteClassWithGenericIEnumerableT()
        {
            string json;

            {
                TestClassWithGenericIEnumerableT obj = new TestClassWithGenericIEnumerableT();
                obj.Initialize();
                obj.Verify();
                json = JsonSerializer.ToString(obj);
            }

            {
                TestClassWithGenericIEnumerableT obj = JsonSerializer.Parse<TestClassWithGenericIEnumerableT>(json);
                obj.Verify();
            }

            {
                TestClassWithGenericIEnumerableT obj = JsonSerializer.Parse<TestClassWithGenericIEnumerableT>(TestClassWithGenericIEnumerableT.s_data);
                obj.Verify();
            }
        }

        [Fact]
        public static void WriteClassWithGenericIListT()
        {
            string json;

            {
                TestClassWithGenericIListT obj = new TestClassWithGenericIListT();
                obj.Initialize();
                obj.Verify();
                json = JsonSerializer.ToString(obj);
            }

            {
                TestClassWithGenericIListT obj = JsonSerializer.Parse<TestClassWithGenericIListT>(json);
                obj.Verify();
            }

            {
                TestClassWithGenericIListT obj = JsonSerializer.Parse<TestClassWithGenericIListT>(TestClassWithGenericIListT.s_data);
                obj.Verify();
            }
        }

        [Fact]
        public static void WriteClassWithGenericICollectionT()
        {
            string json;

            {
                TestClassWithGenericICollectionT obj = new TestClassWithGenericICollectionT();
                obj.Initialize();
                obj.Verify();
                json = JsonSerializer.ToString(obj);
            }

            {
                TestClassWithGenericICollectionT obj = JsonSerializer.Parse<TestClassWithGenericICollectionT>(json);
                obj.Verify();
            }

            {
                TestClassWithGenericICollectionT obj = JsonSerializer.Parse<TestClassWithGenericICollectionT>(TestClassWithGenericICollectionT.s_data);
                obj.Verify();
            }
        }

        [Fact]
        public static void WriteClassWithGenericIReadOnlyCollectionT()
        {
            string json;

            {
                TestClassWithGenericIReadOnlyCollectionT obj = new TestClassWithGenericIReadOnlyCollectionT();
                obj.Initialize();
                obj.Verify();
                json = JsonSerializer.ToString(obj);
            }

            {
                TestClassWithGenericIReadOnlyCollectionT obj = JsonSerializer.Parse<TestClassWithGenericIReadOnlyCollectionT>(json);
                obj.Verify();
            }

            {
                TestClassWithGenericIReadOnlyCollectionT obj = JsonSerializer.Parse<TestClassWithGenericIReadOnlyCollectionT>(TestClassWithGenericIReadOnlyCollectionT.s_data);
                obj.Verify();
            }
        }

        [Fact]
        public static void WriteClassWithGenericIReadOnlyListT()
        {
            string json;

            {
                TestClassWithGenericIReadOnlyListT obj = new TestClassWithGenericIReadOnlyListT();
                obj.Initialize();
                obj.Verify();
                json = JsonSerializer.ToString(obj);
            }

            {
                TestClassWithGenericIReadOnlyListT obj = JsonSerializer.Parse<TestClassWithGenericIReadOnlyListT>(json);
                obj.Verify();
            }

            {
                TestClassWithGenericIReadOnlyListT obj = JsonSerializer.Parse<TestClassWithGenericIReadOnlyListT>(TestClassWithGenericIEnumerableT.s_data);
                obj.Verify();
            }
        }

        [Fact]
        public static void WriteClassWithObjectIEnumerableT()
        {
            string json;

            {
                TestClassWithObjectIEnumerableT obj = new TestClassWithObjectIEnumerableT();
                obj.Initialize();
                obj.Verify();
                json = JsonSerializer.ToString(obj);
            }

            {
                TestClassWithObjectIEnumerableT obj = JsonSerializer.Parse<TestClassWithObjectIEnumerableT>(json);
                obj.Verify();
            }

            {
                TestClassWithObjectIEnumerableT obj = JsonSerializer.Parse<TestClassWithObjectIEnumerableT>(TestClassWithObjectIEnumerableT.s_data);
                obj.Verify();
            }
        }

        [Fact]
        public static void WriteClassWithObjectIListT()
        {
            string json;

            {
                TestClassWithObjectIListT obj = new TestClassWithObjectIListT();
                obj.Initialize();
                obj.Verify();
                json = JsonSerializer.ToString(obj);
            }

            {
                TestClassWithObjectIListT obj = JsonSerializer.Parse<TestClassWithObjectIListT>(json);
                obj.Verify();
            }

            {
                TestClassWithObjectIListT obj = JsonSerializer.Parse<TestClassWithObjectIListT>(TestClassWithObjectIListT.s_data);
                obj.Verify();
            }
        }

        [Fact]
        public static void WriteClassWithObjectICollectionT()
        {
            string json;

            {
                TestClassWithObjectICollectionT obj = new TestClassWithObjectICollectionT();
                obj.Initialize();
                obj.Verify();
                json = JsonSerializer.ToString(obj);
            }

            {
                TestClassWithObjectICollectionT obj = JsonSerializer.Parse<TestClassWithObjectICollectionT>(json);
                obj.Verify();
            }

            {
                TestClassWithObjectICollectionT obj = JsonSerializer.Parse<TestClassWithObjectICollectionT>(TestClassWithObjectICollectionT.s_data);
                obj.Verify();
            }
        }

        [Fact]
        public static void WriteClassWithObjectIReadOnlyCollectionT()
        {
            string json;

            {
                TestClassWithObjectIReadOnlyCollectionT obj = new TestClassWithObjectIReadOnlyCollectionT();
                obj.Initialize();
                obj.Verify();
                json = JsonSerializer.ToString(obj);
            }

            {
                TestClassWithObjectIReadOnlyCollectionT obj = JsonSerializer.Parse<TestClassWithObjectIReadOnlyCollectionT>(json);
                obj.Verify();
            }

            {
                TestClassWithObjectIReadOnlyCollectionT obj = JsonSerializer.Parse<TestClassWithObjectIReadOnlyCollectionT>(TestClassWithObjectIReadOnlyCollectionT.s_data);
                obj.Verify();
            }
        }

        [Fact]
        public static void WriteClassWithObjectIReadOnlyListT()
        {
            string json;

            {
                TestClassWithObjectIReadOnlyListT obj = new TestClassWithObjectIReadOnlyListT();
                obj.Initialize();
                obj.Verify();
                json = JsonSerializer.ToString(obj);
            }

            {
                TestClassWithObjectIReadOnlyListT obj = JsonSerializer.Parse<TestClassWithObjectIReadOnlyListT>(json);
                obj.Verify();
            }

            {
                TestClassWithObjectIReadOnlyListT obj = JsonSerializer.Parse<TestClassWithObjectIReadOnlyListT>(TestClassWithObjectIEnumerableT.s_data);
                obj.Verify();
            }
        }
    }
}

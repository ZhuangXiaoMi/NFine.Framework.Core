﻿using System;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xunit.Abstractions;
using System.IO;

namespace NFine.XUnitTesting
{
    public class UnitTest1
    {
        protected readonly ITestOutputHelper OutputHelper;

        public UnitTest1(ITestOutputHelper outputHelper)
        {
            OutputHelper = outputHelper;
        }

        [Fact]
        public void Test1()
        {
            List<string> list = new List<string>();
            Console.WriteLine("中文");
            string aaa = "中文信息";
            
            Assert.Empty(list);
        }

        [Fact]
        public void Test2()
        {
            string currentAssembleFileName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            OutputHelper.WriteLine($"当前的{currentAssembleFileName}");
            //Console.WriteLine("currentAssembleFileName:" + currentAssembleFileName);
            string assembleFileName = Path.Combine(currentAssembleFileName, "NFine.Mapping.dll"); //currentAssembleFileName.Replace(".Data.", ".Mapping.").Replace("file:///", "");
            Console.WriteLine(assembleFileName);
            OutputHelper.WriteLine(assembleFileName);
        }
        

    }
}

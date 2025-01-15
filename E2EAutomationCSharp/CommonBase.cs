//#region Assembly BlackLine.Automation.Framework, Version=26.0.0.0, Culture=neutral, PublicKeyToken=null
//// C:\Users\vikas.tripathi\.nuget\packages\blackline.automation.framework\26.0.100\lib\net6.0\BlackLine.Automation.Framework.dll
//// Decompiled with ICSharpCode.Decompiler 8.1.1.7464
//#endregion

//using System;
//using System.Collections.Generic;
//using BlackLine.Automation.Framework.Entity.Setting;
//using BlackLine.Automation.Framework.Extensions;
//using BlackLine.Automation.Framework.Logger;
//using BlackLine.Automation.Framework.Model;
//using BlackLine.Automation.Framework.Service;
//using BlackLine.Automation.Framework.Utilities;
//using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
//using OpenQA.Selenium;

//namespace BlackLine.Automation.Framework.Base;

//public abstract class CommonBase
//{
//    public static IList<ServiceModel> AvailableServices => TestSetUp.AvailableServices;

//    public TestLogger TestLogger { get; set; }

//    public TestSettings TestSettings { get; set; }

//    public AuthService AuthService { get; set; }

//    public Lazy<IWebDriver> LazyDriver { get; set; }

//    public IWebDriver Driver => LazyDriver.Value;

//    public WaitUtils WaitUtils { get; set; }

//    public By PageElement { get; set; }

//    public string PageTitle { get; set; }

//    public By Container { get; set; }

//    protected void ScrollIntoView(IWebElement element)
//    {
//        Driver.Action().MoveToElement(element).Perform();
//    }

//    public void ScrollIntoViewJs(IWebElement element, bool alignToTop = false)
//    {
//        Driver.Scripts().ExecuteScript("arguments[0].scrollIntoView(arguments[1])", element, alignToTop);
//    }

//    public virtual void SwitchToFrame(By by)
//    {
//        Driver.SwitchTo().Frame(Driver.FindElement(by));
//    }

//    public virtual void SwitchToFrame(int frameIndex)
//    {
//        Driver.SwitchTo().Frame(frameIndex);
//    }

//    public virtual void SwitchToFrame(string frameName)
//    {
//        Driver.SwitchTo().Frame(frameName);
//    }

//    public void ContextClick(IWebElement element)
//    {
//        Driver.Action().ContextClick(element).Build()
//            .Perform();
//    }

//    public void DoubleClick(IWebElement element)
//    {
//        Driver.Action().DoubleClick(element).Build()
//            .Perform();
//    }

//    public void RefreshPage()
//    {
//        Driver.Navigate().Refresh();
//    }
//}
//#if false // Decompilation log
//'316' items in cache
//------------------
//Resolve: 'System.Runtime, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
//Found single assembly: 'System.Runtime, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\microsoft.netcore.app.ref\6.0.32\ref\net6.0\System.Runtime.dll'
//------------------
//Resolve: 'System.Collections, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
//Found single assembly: 'System.Collections, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\microsoft.netcore.app.ref\6.0.32\ref\net6.0\System.Collections.dll'
//------------------
//Resolve: 'System.Collections.Concurrent, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
//Found single assembly: 'System.Collections.Concurrent, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\microsoft.netcore.app.ref\6.0.32\ref\net6.0\System.Collections.Concurrent.dll'
//------------------
//Resolve: 'RestSharp, Version=106.11.7.0, Culture=neutral, PublicKeyToken=598062e77f915f75'
//Found single assembly: 'RestSharp, Version=106.11.7.0, Culture=neutral, PublicKeyToken=598062e77f915f75'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\restsharp\106.11.7\lib\netstandard2.0\RestSharp.dll'
//------------------
//Resolve: 'System.ComponentModel.Primitives, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
//Found single assembly: 'System.ComponentModel.Primitives, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\microsoft.netcore.app.ref\6.0.32\ref\net6.0\System.ComponentModel.Primitives.dll'
//------------------
//Resolve: 'DocumentFormat.OpenXml, Version=2.20.0.0, Culture=neutral, PublicKeyToken=8fb06cb64d019a17'
//Found single assembly: 'DocumentFormat.OpenXml, Version=2.20.0.0, Culture=neutral, PublicKeyToken=8fb06cb64d019a17'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\documentformat.openxml\2.20.0\lib\net6.0\DocumentFormat.OpenXml.dll'
//------------------
//Resolve: 'Newtonsoft.Json, Version=13.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed'
//Found single assembly: 'Newtonsoft.Json, Version=13.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\newtonsoft.json\13.0.3\lib\net6.0\Newtonsoft.Json.dll'
//------------------
//Resolve: 'BlackLine.Automation.TestCaseManager, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null'
//Found single assembly: 'BlackLine.Automation.TestCaseManager, Version=3.0.0.0, Culture=neutral, PublicKeyToken=null'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\blackline.automation.testcasemanager\3.0.40\lib\netstandard2.0\BlackLine.Automation.TestCaseManager.dll'
//------------------
//Resolve: 'System.Security.Cryptography.Algorithms, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
//Found single assembly: 'System.Security.Cryptography.Algorithms, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\microsoft.netcore.app.ref\6.0.32\ref\net6.0\System.Security.Cryptography.Algorithms.dll'
//------------------
//Resolve: 'System.Security.Cryptography.Primitives, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
//Found single assembly: 'System.Security.Cryptography.Primitives, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\microsoft.netcore.app.ref\6.0.32\ref\net6.0\System.Security.Cryptography.Primitives.dll'
//------------------
//Resolve: 'WebDriver, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null'
//Found single assembly: 'WebDriver, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\selenium.webdriver\4.19.0\lib\netstandard2.0\WebDriver.dll'
//------------------
//Resolve: 'NPOI.OOXML, Version=2.5.3.0, Culture=neutral, PublicKeyToken=0df73ec7942b34e1'
//Found single assembly: 'NPOI.OOXML, Version=2.5.3.0, Culture=neutral, PublicKeyToken=0df73ec7942b34e1'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\npoi\2.5.3\lib\netstandard2.1\NPOI.OOXML.dll'
//------------------
//Resolve: 'NPOI, Version=2.5.3.0, Culture=neutral, PublicKeyToken=0df73ec7942b34e1'
//Found single assembly: 'NPOI, Version=2.5.3.0, Culture=neutral, PublicKeyToken=0df73ec7942b34e1'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\npoi\2.5.3\lib\netstandard2.1\NPOI.dll'
//------------------
//Resolve: 'System.IO.Compression, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
//Found single assembly: 'System.IO.Compression, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\microsoft.netcore.app.ref\6.0.32\ref\net6.0\System.IO.Compression.dll'
//------------------
//Resolve: 'CsvHelper, Version=30.0.0.0, Culture=neutral, PublicKeyToken=8c4959082be5c823'
//Found single assembly: 'CsvHelper, Version=30.0.0.0, Culture=neutral, PublicKeyToken=8c4959082be5c823'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\csvhelper\30.0.1\lib\net6.0\CsvHelper.dll'
//------------------
//Resolve: 'System.Linq, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
//Found single assembly: 'System.Linq, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\microsoft.netcore.app.ref\6.0.32\ref\net6.0\System.Linq.dll'
//------------------
//Resolve: 'WebDriver.Support, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null'
//Found single assembly: 'WebDriver.Support, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\selenium.support\4.19.0\lib\netstandard2.0\WebDriver.Support.dll'
//------------------
//Resolve: 'System.Drawing.Primitives, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
//Found single assembly: 'System.Drawing.Primitives, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\microsoft.netcore.app.ref\6.0.32\ref\net6.0\System.Drawing.Primitives.dll'
//------------------
//Resolve: 'System.Net.Primitives, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
//Found single assembly: 'System.Net.Primitives, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\microsoft.netcore.app.ref\6.0.32\ref\net6.0\System.Net.Primitives.dll'
//------------------
//Resolve: 'System.Text.RegularExpressions, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
//Found single assembly: 'System.Text.RegularExpressions, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\microsoft.netcore.app.ref\6.0.32\ref\net6.0\System.Text.RegularExpressions.dll'
//------------------
//Resolve: 'VaultSharp, Version=1.7.0.4, Culture=neutral, PublicKeyToken=cb3d4aad92b0eded'
//Found single assembly: 'VaultSharp, Version=1.7.0.4, Culture=neutral, PublicKeyToken=cb3d4aad92b0eded'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\vaultsharp\1.7.0.4\lib\net6.0\VaultSharp.dll'
//------------------
//Resolve: 'ReportPortal.Client, Version=3.4.1.0, Culture=neutral, PublicKeyToken=null'
//Found single assembly: 'ReportPortal.Client, Version=3.4.1.0, Culture=neutral, PublicKeyToken=null'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\reportportal.client\3.4.1\lib\net6.0\ReportPortal.Client.dll'
//------------------
//Resolve: 'System.Drawing.Common, Version=4.0.2.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
//Found single assembly: 'System.Drawing.Common, Version=5.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51'
//WARN: Version mismatch. Expected: '4.0.2.0', Got: '5.0.0.0'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\system.drawing.common\5.0.0\ref\netcoreapp3.0\System.Drawing.Common.dll'
//------------------
//Resolve: 'nunit.framework, Version=3.13.1.0, Culture=neutral, PublicKeyToken=2638cd05610744eb'
//Found single assembly: 'nunit.framework, Version=3.13.1.0, Culture=neutral, PublicKeyToken=2638cd05610744eb'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\nunit\3.13.1\lib\netstandard2.0\nunit.framework.dll'
//------------------
//Resolve: 'System.Linq.Expressions, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
//Found single assembly: 'System.Linq.Expressions, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\microsoft.netcore.app.ref\6.0.32\ref\net6.0\System.Linq.Expressions.dll'
//------------------
//Resolve: 'Microsoft.Graph, Version=3.30.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35'
//Found single assembly: 'Microsoft.Graph, Version=3.30.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\microsoft.graph\3.30.0\lib\netstandard2.0\Microsoft.Graph.dll'
//------------------
//Resolve: 'Confluent.Kafka, Version=2.0.2.0, Culture=neutral, PublicKeyToken=12c514ca49093d1e'
//Found single assembly: 'Confluent.Kafka, Version=2.0.2.0, Culture=neutral, PublicKeyToken=12c514ca49093d1e'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\confluent.kafka\2.0.2\lib\net6.0\Confluent.Kafka.dll'
//------------------
//Resolve: 'System.ComponentModel, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
//Found single assembly: 'System.ComponentModel, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\microsoft.netcore.app.ref\6.0.32\ref\net6.0\System.ComponentModel.dll'
//------------------
//Resolve: 'Microsoft.Extensions.Logging, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60'
//Found single assembly: 'Microsoft.Extensions.Logging, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\microsoft.extensions.logging\6.0.0\lib\netstandard2.1\Microsoft.Extensions.Logging.dll'
//------------------
//Resolve: 'BlackLine.Messaging.Kafka, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null'
//Found single assembly: 'BlackLine.Messaging.Kafka, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\blackline.messaging.kafka\4.0.0\lib\netstandard2.0\BlackLine.Messaging.Kafka.dll'
//------------------
//Resolve: 'Microsoft.Extensions.DependencyInjection.Abstractions, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60'
//Found single assembly: 'Microsoft.Extensions.DependencyInjection.Abstractions, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\microsoft.extensions.dependencyinjection.abstractions\6.0.0\lib\net6.0\Microsoft.Extensions.DependencyInjection.Abstractions.dll'
//------------------
//Resolve: 'Microsoft.Extensions.DependencyInjection, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60'
//Found single assembly: 'Microsoft.Extensions.DependencyInjection, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\microsoft.extensions.dependencyinjection\6.0.1\lib\net6.0\Microsoft.Extensions.DependencyInjection.dll'
//------------------
//Resolve: 'Autofac, Version=6.2.0.0, Culture=neutral, PublicKeyToken=17863af14b0044da'
//Found single assembly: 'Autofac, Version=6.2.0.0, Culture=neutral, PublicKeyToken=17863af14b0044da'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\autofac\6.2.0\lib\net5.0\Autofac.dll'
//------------------
//Resolve: 'System.Net.Http, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
//Found single assembly: 'System.Net.Http, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\microsoft.netcore.app.ref\6.0.32\ref\net6.0\System.Net.Http.dll'
//------------------
//Resolve: 'Microsoft.Extensions.Configuration.Abstractions, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60'
//Found single assembly: 'Microsoft.Extensions.Configuration.Abstractions, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\microsoft.extensions.configuration.abstractions\6.0.0\lib\netstandard2.0\Microsoft.Extensions.Configuration.Abstractions.dll'
//------------------
//Resolve: 'Appium.Net, Version=5.0.0.0, Culture=neutral, PublicKeyToken=null'
//Found single assembly: 'Appium.Net, Version=5.0.0.0, Culture=neutral, PublicKeyToken=null'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\appium.webdriver\5.0.0-beta01\lib\netstandard2.0\Appium.Net.dll'
//------------------
//Resolve: 'System.Text.Encoding.CodePages, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
//Found single assembly: 'System.Text.Encoding.CodePages, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\microsoft.netcore.app.ref\6.0.32\ref\net6.0\System.Text.Encoding.CodePages.dll'
//------------------
//Resolve: 'System.IO.Compression.ZipFile, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
//Found single assembly: 'System.IO.Compression.ZipFile, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\microsoft.netcore.app.ref\6.0.32\ref\net6.0\System.IO.Compression.ZipFile.dll'
//------------------
//Resolve: 'System.Threading.Thread, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
//Found single assembly: 'System.Threading.Thread, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\microsoft.netcore.app.ref\6.0.32\ref\net6.0\System.Threading.Thread.dll'
//------------------
//Resolve: 'System.Net.Security, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
//Found single assembly: 'System.Net.Security, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\microsoft.netcore.app.ref\6.0.32\ref\net6.0\System.Net.Security.dll'
//------------------
//Resolve: 'System.Console, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
//Found single assembly: 'System.Console, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\microsoft.netcore.app.ref\6.0.32\ref\net6.0\System.Console.dll'
//------------------
//Resolve: 'Microsoft.Extensions.Configuration, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60'
//Found single assembly: 'Microsoft.Extensions.Configuration, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\microsoft.extensions.configuration\6.0.0\lib\netstandard2.0\Microsoft.Extensions.Configuration.dll'
//------------------
//Resolve: 'Microsoft.Extensions.Configuration.FileExtensions, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60'
//Found single assembly: 'Microsoft.Extensions.Configuration.FileExtensions, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\microsoft.extensions.configuration.fileextensions\6.0.0\lib\netstandard2.0\Microsoft.Extensions.Configuration.FileExtensions.dll'
//------------------
//Resolve: 'Microsoft.Extensions.Configuration.Json, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60'
//Found single assembly: 'Microsoft.Extensions.Configuration.Json, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\microsoft.extensions.configuration.json\6.0.0\lib\netstandard2.1\Microsoft.Extensions.Configuration.Json.dll'
//------------------
//Resolve: 'Microsoft.Extensions.Configuration.EnvironmentVariables, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60'
//Found single assembly: 'Microsoft.Extensions.Configuration.EnvironmentVariables, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\microsoft.extensions.configuration.environmentvariables\6.0.0\lib\netstandard2.0\Microsoft.Extensions.Configuration.EnvironmentVariables.dll'
//------------------
//Resolve: 'Microsoft.Extensions.Configuration.Binder, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60'
//Found single assembly: 'Microsoft.Extensions.Configuration.Binder, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\microsoft.extensions.configuration.binder\6.0.0\lib\netstandard2.0\Microsoft.Extensions.Configuration.Binder.dll'
//------------------
//Resolve: 'System.Diagnostics.StackTrace, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
//Found single assembly: 'System.Diagnostics.StackTrace, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\microsoft.netcore.app.ref\6.0.32\ref\net6.0\System.Diagnostics.StackTrace.dll'
//------------------
//Resolve: 'System.Threading, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
//Found single assembly: 'System.Threading, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\microsoft.netcore.app.ref\6.0.32\ref\net6.0\System.Threading.dll'
//------------------
//Resolve: 'RazorLight, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null'
//Found single assembly: 'RazorLight, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\razorlight\2.0.0-beta1\lib\netstandard2.0\RazorLight.dll'
//------------------
//Resolve: 'FluentAssertions, Version=6.12.0.0, Culture=neutral, PublicKeyToken=33f2691a05b67b6a'
//Found single assembly: 'FluentAssertions, Version=6.12.0.0, Culture=neutral, PublicKeyToken=33f2691a05b67b6a'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\fluentassertions\6.12.0\lib\net6.0\FluentAssertions.dll'
//------------------
//Resolve: 'Microsoft.Extensions.Logging.Debug, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60'
//Found single assembly: 'Microsoft.Extensions.Logging.Debug, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\microsoft.extensions.logging.debug\6.0.0\lib\netstandard2.0\Microsoft.Extensions.Logging.Debug.dll'
//------------------
//Resolve: 'Microsoft.Extensions.Logging.Console, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60'
//Found single assembly: 'Microsoft.Extensions.Logging.Console, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\microsoft.extensions.logging.console\6.0.0\lib\net6.0\Microsoft.Extensions.Logging.Console.dll'
//------------------
//Resolve: 'BlackLine.Messaging.Kafka.DotNetCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null'
//Found single assembly: 'BlackLine.Messaging.Kafka.DotNetCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=null'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\blackline.messaging.kafka.dotnetcore\4.0.0\lib\netstandard2.1\BlackLine.Messaging.Kafka.DotNetCore.dll'
//------------------
//Resolve: 'System.Drawing.Primitives, Version=4.2.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
//Found single assembly: 'System.Drawing.Primitives, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
//WARN: Version mismatch. Expected: '4.2.0.0', Got: '6.0.0.0'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\microsoft.netcore.app.ref\6.0.32\ref\net6.0\System.Drawing.Primitives.dll'
//------------------
//Resolve: 'System.Runtime.InteropServices, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null'
//Found single assembly: 'System.Runtime.InteropServices, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\microsoft.netcore.app.ref\6.0.32\ref\net6.0\System.Runtime.InteropServices.dll'
//------------------
//Resolve: 'System.Runtime.CompilerServices.Unsafe, Version=6.0.0.0, Culture=neutral, PublicKeyToken=null'
//Found single assembly: 'System.Runtime.CompilerServices.Unsafe, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
//Load from: 'C:\Users\vikas.tripathi\.nuget\packages\microsoft.netcore.app.ref\6.0.32\ref\net6.0\System.Runtime.CompilerServices.Unsafe.dll'
//#endif

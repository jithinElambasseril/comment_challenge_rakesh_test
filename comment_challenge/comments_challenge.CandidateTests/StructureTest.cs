
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NUnit.Framework;

namespace comments_challenge.CandidateTests
{
    /// <summary>
    /// !!! WARNING 
    /// !!! Project structure test.
    /// !!! DON'T CHANGE IT! 
    /// !!! Changes may cause the solution to be rejected.
    /// </summary>
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// !!! WARNING 
        /// !!! Project structure test.
        /// !!! DON'T CHANGE IT! 
        /// !!! Changes may cause the solution to be rejected.
        /// </summary>
        [Test]
        public void StructureTest()
        {
            
            Assembly assembly;
            Type type;
            Type methodReturnType;
            MethodInfo method;
            int methodsCount;
            ParameterInfo parameter;
            int parametersCount;
            int constructorsCount;
            List<string> constructorParameterNameTypeDictionary;
            ConstructorInfo constructor;
            int fieldsCount;
            FieldInfo field;
            Type fieldReturnType;
            PropertyInfo property;
            int propertiesCount;
            Type propertyReturnType;
            assembly = Assembly.Load(Decode("Y29tbWVudHNfY2hhbGxlbmdlLCBWZXJzaW9uPTEuMC4wLjAsIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49bnVsbA==") /*"comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"*/ );
            Assert.IsNotNull(assembly, "Missing  comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null");

                type = assembly.GetTypes().FirstOrDefault(x=>x.FullName == Decode("Y29tbWVudHNfY2hhbGxlbmdlLk12Y0FwcGxpY2F0aW9u") /*"comments_challenge.MvcApplication"*/ );
                Assert.IsNotNull(type, "Missing assembly: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.MvcApplication");
                    Assert.IsTrue(type.IsClass, "assembly: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.MvcApplication is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.MvcApplication is not public class");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("RGlzcG9zZQ==") /*"Dispose"*/ );                            Assert.IsNotNull(method, "method: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.MvcApplication.Dispose() does not exists");
                            Assert.IsTrue(method.IsPublic, "method: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.MvcApplication.Dispose() is not public");
                            Assert.IsTrue(method.IsVirtual, "method: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.MvcApplication.Dispose() is not virtual");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Void",methodReturnType.FullName, "method: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.MvcApplication.Dispose() return type has changed");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.MvcApplication() does not exists");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("U2l0ZQ==") /*"Site"*/ );
                            Assert.IsNotNull(property, "property: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.MvcApplication.ISite Site does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1NpdGU=") /*"get_Site"*/ );                                Assert.IsNotNull(method, "method: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.MvcApplication.get_Site() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.MvcApplication.get_Site() is not public");
                                Assert.IsTrue(method.IsVirtual, "method: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.MvcApplication.get_Site() is not virtual");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.ComponentModel.ISite",methodReturnType.FullName, "method: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.MvcApplication.get_Site() return type has changed");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X1NpdGU=") /*"get_Site"*/ );                                Assert.IsNotNull(method, "method: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.MvcApplication.get_Site() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.MvcApplication.get_Site() is not public");
                                Assert.IsTrue(method.IsVirtual, "method: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.MvcApplication.get_Site() is not virtual");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.ComponentModel.ISite",methodReturnType.FullName, "method: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.MvcApplication.get_Site() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.ComponentModel.ISite",propertyReturnType.FullName, "property: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.MvcApplication.ISite Site  type has changed");

                type = assembly.GetTypes().FirstOrDefault(x=>x.FullName == Decode("Y29tbWVudHNfY2hhbGxlbmdlLkZpbHRlckNvbmZpZw==") /*"comments_challenge.FilterConfig"*/ );
                Assert.IsNotNull(type, "Missing assembly: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.FilterConfig");
                    Assert.IsTrue(type.IsClass, "assembly: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.FilterConfig is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.FilterConfig is not public class");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("UmVnaXN0ZXJHbG9iYWxGaWx0ZXJz") /*"RegisterGlobalFilters"*/ );                            Assert.IsNotNull(method, "method: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.FilterConfig.RegisterGlobalFilters(GlobalFilterCollection filters) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.FilterConfig.RegisterGlobalFilters(GlobalFilterCollection filters) is not public");
                            Assert.IsTrue(method.IsStatic, "method: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.FilterConfig.RegisterGlobalFilters(GlobalFilterCollection filters) is not static");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Void",methodReturnType.FullName, "method: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.FilterConfig.RegisterGlobalFilters(GlobalFilterCollection filters) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.FilterConfig.RegisterGlobalFilters(GlobalFilterCollection filters) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("ZmlsdGVycw==") /*"filters"*/  && x.ParameterType.FullName == "System.Web.Mvc.GlobalFilterCollection");
                                Assert.IsNotNull(parameter, "method: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.FilterConfig.RegisterGlobalFilters(GlobalFilterCollection filters) parameter filters does not exists or does not have type System.Web.Mvc.GlobalFilterCollection");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.FilterConfig() does not exists");

                type = assembly.GetTypes().FirstOrDefault(x=>x.FullName == Decode("Y29tbWVudHNfY2hhbGxlbmdlLlJvdXRlQ29uZmln") /*"comments_challenge.RouteConfig"*/ );
                Assert.IsNotNull(type, "Missing assembly: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.RouteConfig");
                    Assert.IsTrue(type.IsClass, "assembly: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.RouteConfig is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.RouteConfig is not public class");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("UmVnaXN0ZXJSb3V0ZXM=") /*"RegisterRoutes"*/ );                            Assert.IsNotNull(method, "method: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.RouteConfig.RegisterRoutes(RouteCollection routes) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.RouteConfig.RegisterRoutes(RouteCollection routes) is not public");
                            Assert.IsTrue(method.IsStatic, "method: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.RouteConfig.RegisterRoutes(RouteCollection routes) is not static");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Void",methodReturnType.FullName, "method: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.RouteConfig.RegisterRoutes(RouteCollection routes) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "method: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.RouteConfig.RegisterRoutes(RouteCollection routes) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("cm91dGVz") /*"routes"*/  && x.ParameterType.FullName == "System.Web.Routing.RouteCollection");
                                Assert.IsNotNull(parameter, "method: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.RouteConfig.RegisterRoutes(RouteCollection routes) parameter routes does not exists or does not have type System.Web.Routing.RouteCollection");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.RouteConfig() does not exists");

                type = assembly.GetTypes().FirstOrDefault(x=>x.FullName == Decode("Y29tbWVudHNfY2hhbGxlbmdlLkNvbnRyb2xsZXJzLkVycm9yQ29udHJvbGxlcg==") /*"comments_challenge.Controllers.ErrorController"*/ );
                Assert.IsNotNull(type, "Missing assembly: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.Controllers.ErrorController");
                    Assert.IsTrue(type.IsClass, "assembly: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.Controllers.ErrorController is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.Controllers.ErrorController is not public class");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("RGlzcG9zZQ==") /*"Dispose"*/ );                            Assert.IsNotNull(method, "method: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.Controllers.ErrorController.Dispose() does not exists");
                            Assert.IsTrue(method.IsPublic, "method: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.Controllers.ErrorController.Dispose() is not public");
                            Assert.IsTrue(method.IsVirtual, "method: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.Controllers.ErrorController.Dispose() is not virtual");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Void",methodReturnType.FullName, "method: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.Controllers.ErrorController.Dispose() return type has changed");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.Controllers.ErrorController() does not exists");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("QXN5bmNNYW5hZ2Vy") /*"AsyncManager"*/ );
                            Assert.IsNotNull(property, "property: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.Controllers.ErrorController.AsyncManager AsyncManager does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0FzeW5jTWFuYWdlcg==") /*"get_AsyncManager"*/ );                                Assert.IsNotNull(method, "method: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.Controllers.ErrorController.get_AsyncManager() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.Controllers.ErrorController.get_AsyncManager() is not public");
                                Assert.IsTrue(method.IsVirtual, "method: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.Controllers.ErrorController.get_AsyncManager() is not virtual");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.Web.Mvc.Async.AsyncManager",methodReturnType.FullName, "method: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.Controllers.ErrorController.get_AsyncManager() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.Web.Mvc.Async.AsyncManager",propertyReturnType.FullName, "property: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.Controllers.ErrorController.AsyncManager AsyncManager  type has changed");

                type = assembly.GetTypes().FirstOrDefault(x=>x.FullName == Decode("Y29tbWVudHNfY2hhbGxlbmdlLkNvbnRyb2xsZXJzLlBvc3RzQ29udHJvbGxlcg==") /*"comments_challenge.Controllers.PostsController"*/ );
                Assert.IsNotNull(type, "Missing assembly: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.Controllers.PostsController");
                    Assert.IsTrue(type.IsClass, "assembly: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.Controllers.PostsController is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.Controllers.PostsController is not public class");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("RGlzcG9zZQ==") /*"Dispose"*/ );                            Assert.IsNotNull(method, "method: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.Controllers.PostsController.Dispose() does not exists");
                            Assert.IsTrue(method.IsPublic, "method: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.Controllers.PostsController.Dispose() is not public");
                            Assert.IsTrue(method.IsVirtual, "method: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.Controllers.PostsController.Dispose() is not virtual");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Void",methodReturnType.FullName, "method: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.Controllers.PostsController.Dispose() return type has changed");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructorParameterNameTypeDictionary.Add("DAL.CommentDAL");
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.Controllers.PostsController(CommentDAL comment) does not exists");
                                parametersCount = constructor.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "constructor: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.Controllers.PostsController(CommentDAL comment)  parameters count has changed");
                                parameter = constructor.GetParameters().FirstOrDefault(x=>x.Name == Decode("Y29tbWVudA==") /*"comment"*/  && x.ParameterType.FullName == "DAL.CommentDAL");
                                Assert.IsNotNull(parameter, "constructor: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.Controllers.PostsController(CommentDAL comment) parameter comment does not exists or does not have type DAL.CommentDAL");
                            property = type.GetProperties().Union(type.GetProperties().Where(x=>type.GetInterfaces().SelectMany(y=>y.GetProperties().Select(s=>s.Name)).Any(y => y == x.Name))).FirstOrDefault(x=>x.Name == Decode("QXN5bmNNYW5hZ2Vy") /*"AsyncManager"*/ );
                            Assert.IsNotNull(property, "property: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.Controllers.PostsController.AsyncManager AsyncManager does not exists");
                                method = type.GetMethods().FirstOrDefault(x=>x.Name == Decode("Z2V0X0FzeW5jTWFuYWdlcg==") /*"get_AsyncManager"*/ );                                Assert.IsNotNull(method, "method: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.Controllers.PostsController.get_AsyncManager() does not exists");
                                Assert.IsTrue(method.IsPublic, "method: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.Controllers.PostsController.get_AsyncManager() is not public");
                                Assert.IsTrue(method.IsVirtual, "method: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.Controllers.PostsController.get_AsyncManager() is not virtual");
                                methodReturnType = method.ReturnType;
                                Assert.AreEqual("System.Web.Mvc.Async.AsyncManager",methodReturnType.FullName, "method: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.Controllers.PostsController.get_AsyncManager() return type has changed");
                            propertyReturnType = property.PropertyType;
                            Assert.AreEqual("System.Web.Mvc.Async.AsyncManager",propertyReturnType.FullName, "property: comments_challenge, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:comments_challenge.Controllers.PostsController.AsyncManager AsyncManager  type has changed");


        }

        /// <summary>
        /// !!! WARNING 
        /// !!! Project structure test.
        /// !!! DON'T CHANGE IT! 
        /// !!! Changes may cause the solution to be rejected.
        /// </summary>
        private string Decode(string text)
        {
            return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(text));
        }
    }
}


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
    public class DALStructureTest
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
            assembly = Assembly.Load(Decode("REFMLCBWZXJzaW9uPTEuMC4wLjAsIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49bnVsbA==") /*"DAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"*/ );
            Assert.IsNotNull(assembly, "Missing  DAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null");

                type = assembly.GetTypes().FirstOrDefault(x=>x.FullName == Decode("REFMLkNvbW1lbnREQUw=") /*"DAL.CommentDAL"*/ );
                Assert.IsNotNull(type, "Missing assembly: DAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:DAL.CommentDAL");
                    Assert.IsTrue(type.IsClass, "assembly: DAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:DAL.CommentDAL is not class");
                    Assert.IsTrue(type.IsPublic, "assembly: DAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:DAL.CommentDAL is not public class");
                            method = type.GetMethods().Where(m => !m.IsSpecialName).FirstOrDefault(x=>x.Name == Decode("R2V0UG9zdHM=") /*"GetPosts"*/ );                            Assert.IsNotNull(method, "method: DAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:DAL.CommentDAL.GetPosts(String titleString sortOrder) does not exists");
                            Assert.IsTrue(method.IsPublic, "method: DAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:DAL.CommentDAL.GetPosts(String titleString sortOrder) is not public");
                            methodReturnType = method.ReturnType;
                            Assert.AreEqual("System.Collections.Generic.List`1[[EL.Models.PostModel, EL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]",methodReturnType.FullName, "method: DAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:DAL.CommentDAL.GetPosts(String titleString sortOrder) return type has changed");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(2,parametersCount, "method: DAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:DAL.CommentDAL.GetPosts(String titleString sortOrder) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("dGl0bGU=") /*"title"*/  && x.ParameterType.FullName == "System.String");
                                Assert.IsNotNull(parameter, "method: DAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:DAL.CommentDAL.GetPosts(String titleString sortOrder) parameter title does not exists or does not have type System.String");
                                parametersCount = method.GetParameters().Length;
                                Assert.AreEqual(2,parametersCount, "method: DAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:DAL.CommentDAL.GetPosts(String titleString sortOrder) parameters count has changed");
                                parameter = method.GetParameters().FirstOrDefault(x=>x.Name == Decode("c29ydE9yZGVy") /*"sortOrder"*/  && x.ParameterType.FullName == "System.String");
                                Assert.IsNotNull(parameter, "method: DAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:DAL.CommentDAL.GetPosts(String titleString sortOrder) parameter sortOrder does not exists or does not have type System.String");
                        constructorParameterNameTypeDictionary = new List<string>();
                            constructorParameterNameTypeDictionary.Add("EL.PostsContext");
                            constructor = type.GetConstructors().FirstOrDefault(x=>x.GetParameters().Select(y=>y.ParameterType.FullName).SequenceEqual(constructorParameterNameTypeDictionary));
                            Assert.IsNotNull(constructor, "constructor: DAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:DAL.CommentDAL(PostsContext dbContext) does not exists");
                                parametersCount = constructor.GetParameters().Length;
                                Assert.AreEqual(1,parametersCount, "constructor: DAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:DAL.CommentDAL(PostsContext dbContext)  parameters count has changed");
                                parameter = constructor.GetParameters().FirstOrDefault(x=>x.Name == Decode("ZGJDb250ZXh0") /*"dbContext"*/  && x.ParameterType.FullName == "EL.PostsContext");
                                Assert.IsNotNull(parameter, "constructor: DAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null:DAL.CommentDAL(PostsContext dbContext) parameter dbContext does not exists or does not have type EL.PostsContext");


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

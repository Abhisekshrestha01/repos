using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MoqDemoTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void simpletest()
        {
            
                using (var mock = AutoMock.GetLoose())
                {
                    mock.Mock<ISqliteDataAccess>()
                        .Setup(x => x.LoadData<PersonModel>("select * from Person"))
                        .Returns(GetSamplePeople());

                    var cls = mock.Create<PersonProcessor>();
                    var expected = GetSamplePeople();

                    var actual = cls.LoadPeople();

                    Assert.True(actual != null);
                    Assert.Equal(expected.Count, actual.Count);

                    for (int i = 0; i < expected.Count; i++)
                    {
                        Assert.Equal(expected[i].FirstName, actual[i].FirstName);
                        Assert.Equal(expected[i].LastName, actual[i].LastName);
                    }
                }
            }
        
    }
}

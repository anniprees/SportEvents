using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEvents.Data;
using SportEvents.Data.Common;

namespace Tests.Data
{
    [TestClass]
    public class SportsCategoryDataTests: SealedClassTests<SportsCategoryData, NamedEntityData>
    {
        [TestMethod]
        public void LocationTest() => IsNullableProperty(() => obj.Location, x => obj.Location = x);

        [TestMethod]
        public void MaxParticipantsTest() => IsProperty(() => obj.MaxParticipants, x => obj.MaxParticipants = x);
    }
}



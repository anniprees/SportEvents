using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEvents.Data;
using SportEvents.Data.Common;

namespace Tests.Data
{
    [TestClass]
    public class ParticipantDataTests: SealedClassTests<ParticipantData, NamedEntityData>
    {
        [TestMethod]
        public void EmailTest() => IsNullableProperty(() => obj.Email, x => obj.Email = x);
        [TestMethod]
        public void PhoneNumberTest() => IsNullableProperty(() => obj.PhoneNumber, x => obj.PhoneNumber = x);
    }
}


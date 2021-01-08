using AidMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEvents.Data;
using SportEvents.Domain;
using SportEvents.Domain.Common;

namespace Tests.Domain
{
   
    [TestClass]
    public class ParticipantTests : SealedClassTests<Participant, NamedEntity<ParticipantData>>
    {
        protected override Participant CreateObject() => new Participant(GetRandom.Object<ParticipantData>());
        [TestMethod]
        public void EmailTest() => IsReadOnlyProperty(obj.Data.Email);
        [TestMethod]
        public void PhoneNumberTest() => IsReadOnlyProperty(obj.Data.PhoneNumber);
    }
}

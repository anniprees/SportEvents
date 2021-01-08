using System;
using System.Collections.Generic;
using System.Text;
using AidMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEvents.Data;
using SportEvents.Domain;
using SportEvents.Domain.Common;

namespace Tests.Domain
{
    [TestClass]
    public class SportsCategoryTests : SealedClassTests<SportsCategory, NamedEntity<SportsCategoryData>>
    {
        protected override SportsCategory CreateObject() => new SportsCategory(GetRandom.Object<SportsCategoryData>());
        [TestMethod]
        public void LocationTest() => IsReadOnlyProperty(obj.Data.Location);
        [TestMethod]
        public void MaxParticipantsTest() => IsReadOnlyProperty(obj.Data.MaxParticipants);
    }
}



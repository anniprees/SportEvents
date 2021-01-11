using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEvents.Facade.Common;
using SportEvents.Facade.Views;

namespace Tests.Facade.ViewTests
{
    [TestClass]
    public class EventViewTests : SealedClassTests<EventView, NamedEntityView>
    {
        [TestMethod]
        public void EventDateTest() => IsNullableProperty<DateTime?>("Date");

        [TestMethod]
        public void EventTimeTest() => IsNullableProperty<DateTime?>("Time");

        [TestMethod]
        public void SportsCategoryIdTest() => IsNullableProperty<string>("Sports category");

        [TestMethod]
        public void LocationTest() => IsNullableProperty<string>("Location");

        [TestMethod]
        public void MaxParticipantsTest() => IsProperty<int>("Number of spots");

        [TestMethod]
        public void RegisteredParticipantsTest() => IsProperty<int>("Registrations");

    }
}


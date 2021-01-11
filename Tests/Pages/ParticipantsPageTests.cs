using AidMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEvents.Data;
using SportEvents.Domain;
using SportEvents.Domain.Interfaces;
using SportEvents.Facade.Views;
using SportEvents.Infra.Repositories;
using SportEvents.Pages;
using SportEvents.Pages.Common;
using Tests.Pages.Common;

namespace Tests.Pages
{[TestClass]
    public class ParticipantsPageTests: AbstractPageTests<ParticipantsPage, CommonPage<IParticipantsRepository, Participant, ParticipantView, ParticipantData>>
    {

        private class TestClass : ParticipantsPage
        {
            internal TestClass(IParticipantsRepository r) : base(r) { }
        }
        private class ParticipantsRepository : BaseTestRepository<Participant, ParticipantData>, IParticipantsRepository { }

        private ParticipantsRepository _participants;

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            _participants = new ParticipantsRepository();
            obj = new TestClass(_participants);
        }

       
        [TestMethod]
        public void ItemIdTest()
        {
            var item = GetRandom.Object<ParticipantView>();
            obj.Item = item;
            Assert.AreEqual(item.Id, obj.ItemId);
            obj.Item = null;
            Assert.AreEqual(string.Empty, obj.ItemId);
        }

        [TestMethod]
        public void PageTitleTest() => Assert.AreEqual("Participants", obj.PageTitle);

        [TestMethod]
        public void GetPageUrlTest() => Assert.AreEqual("/Sport/Participants", obj.PageUrl);

        [TestMethod]
        public void ToObjectTest()
        {
            var view = GetRandom.Object<ParticipantView>();
            var o = obj.ToObject(view);
            TestArePropertyValuesEqual(view, o.Data);
        }

        [TestMethod]
        public void ToViewTest()
        {
            var data = GetRandom.Object<ParticipantData>();
            var view = obj.ToView(new Participant(data));
            TestArePropertyValuesEqual(view, data);
        }

    }

}

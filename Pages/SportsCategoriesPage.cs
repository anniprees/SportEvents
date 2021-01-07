using System;
using System.Collections.Generic;
using System.Text;
using SportEvents.Data;
using SportEvents.Domain;
using SportEvents.Domain.Interfaces;
using SportEvents.Facade.ViewFactories;
using SportEvents.Facade.Views;
using SportEvents.Pages.Common;

namespace SportEvents.Pages
{
    public abstract class SportsCategoriesPage : CommonPage<ISportsCategoriesRepository, SportsCategory, SportsCategoryView, SportsCategoryData>
    {
        protected SportsCategoriesPage(ISportsCategoriesRepository r) : base(r)
        {
            PageTitle = "Sports categories";
        }

        public override string ItemId => Item?.Id ?? string.Empty;

        protected internal override string GetPageUrl() => "/Sport/Categories";

        protected internal override SportsCategory ToObject(SportsCategoryView view) => SportsCategoryViewFactory.Create(view);

        protected internal override SportsCategoryView ToView(SportsCategory obj) => SportsCategoryViewFactory.Create(obj);

    }
}

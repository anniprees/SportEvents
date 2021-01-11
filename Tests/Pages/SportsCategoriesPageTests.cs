﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportEvents.Data;
using SportEvents.Domain;
using SportEvents.Domain.Interfaces;
using SportEvents.Facade.Views;
using SportEvents.Pages;
using SportEvents.Pages.Common;
using Tests.Pages.Common;

namespace Tests.Pages
{
    [TestClass]
    public class SportsCategoriesPageTests : AbstractPageTests<SportsCategoriesPage, CommonPage<ISportsCategoriesRepository, SportsCategory, SportsCategoryView, SportsCategoryData>>
    {
    }
}

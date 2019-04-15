﻿namespace Treynessen.Localization
{
    public interface IPagesLocalization
    {
        string AddPage { get; }
        string ActionsWithPage { get; }
        string EditPage { get; }
        string DeletePage { get; }

        string PageType { get; }
        string Usual { get; }
        string Category { get; }

        string SaveButton { get; }
        string Title { get; }
        string Breadcrumb { get; }
        string PageDescription { get; }
        string PageKeywords { get; }
        string Template { get; }
        string WithoutTemplate { get; }
        string PreviousPage { get; }
        string WithoutPreviousPage { get; }
        string Alias { get; }
        string LinkAttributes { get; }
        string IsMainPage { get; }
        string Published { get; }
        string IsRobotIndex { get; }
        string IncorrectInput { get; }

        string CategoryName { get; }
    }
}
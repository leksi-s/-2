using System.Xml.Linq;

namespace лаб2.Queries
{
    internal interface IQueries
    {
        public void Output();
        IEnumerable<XElement> IdMoreThanFive();
        IEnumerable<XElement> SelectVeganCategory();
        IEnumerable<string> OnlyCategory();
        IEnumerable<XElement> IngredientsStartWithB();
        IEnumerable<XElement> SeveralSelections();
        IEnumerable<string> JoinDishesIngredients();
        ILookup<string, XElement> ByCategory();
        int SumOfCalories();
        IEnumerable<XElement> SkipOn();
        IEnumerable<XElement> MoreCalories();
        IEnumerable<string> ExtendedMenu();
        IEnumerable<XElement> LessCalories();
        IEnumerable<XElement> Take3();
        IEnumerable<string> Group();
        IEnumerable<string> PriceForAllDishesInACategory();
    }
}

using System.Xml;
using System.Xml.Linq;

namespace лаб2.Queries
{
    public class Queries : IQueries
    {
        static string _outputFilePath = "C://Users//Admin//source//repos//лаб2//лаб2//OutputFiles//FilledData.xml";
        XDocument doc = XDocument.Load(_outputFilePath);
        public void Output()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(_outputFilePath);
            doc.Save(Console.Out);
        }
        public IEnumerable<XElement> IdMoreThanFive()
        {
            var category = doc.Element("Data")?.Elements("Category");
            var q = category!.Where(x => int.TryParse(x.Element("CategoryId")?.Value, out int categoryId) && categoryId > 3);
            return q;

        }

        public IEnumerable<XElement> SelectVeganCategory()
        {
            return from category in doc.Element("Data")?.Elements("Category")
                   where category.Element("CategoryName")?.Value == "vegan"
                   select category;
        }

        public IEnumerable<string> OnlyCategory()
        {
            return doc.Descendants("CategoryName")
              .Select(category => category.Value);
        }

        public IEnumerable<XElement> IngredientsStartWithB()
        {
            return from ingredient in doc.Element("Data")?.Elements("Ingredient")
                   where ingredient.Element("IngredientName")?.Value?.StartsWith("b") == true
                   select ingredient;
        }

        public IEnumerable<XElement> SeveralSelections()
        {
            return from ingredient in doc.Element("Data")?.Elements("Ingredient") ?? Enumerable.Empty<XElement>()
                   where ingredient.Element("IngredientId")?.Value != null &&
                         int.TryParse(ingredient.Element("IngredientId")?.Value, out int ingredientId) &&
                         ingredientId > 2 &&
                         (ingredient.Element("AmountOfCalories")?.Value == "200" || ingredient.Element("AmountOfCalories")?.Value == "50")
                   select ingredient;
        }


        public IEnumerable<string> JoinDishesIngredients()
        {
            var dishes = doc.Element("Data")?.Elements("Dish");
            var ingredients = doc.Element("Data")?.Elements("Ingredient");

            var query = from dish in dishes
                        join ingredient in ingredients! on dish.Element("IngredientId")?.Value equals ingredient.Element("IngredientId")?.Value
                        select $"IngId: {dish.Element("IngredientId")?.Value}, DishName: {dish.Element("DishName")?.Value}, IngredientName: {ingredient.Element("IngredientName")?.Value}";

            return query;
        }

        public ILookup<string, XElement> ByCategory()
        {
            var q = doc.Element("Data")?.Elements("Category")
                .ToLookup(c => c.Element("CategoryName")?.Value);

            return q!;
        }

        public int SumOfCalories()
        {
            var sum = doc.Element("Data")?.Elements("Ingredient")
                .Sum(m => int.Parse(m.Element("AmountOfCalories")?.Value ?? "0"));

            return sum ?? 0;
        }

        public IEnumerable<XElement> SkipOn()
        {
            int skip = 2;
            return doc.Element("Data")!.Elements("Dish")!.Elements("DishId")!.Skip(skip).ToList();
        }

        public IEnumerable<XElement> MoreCalories()
        {
            return from i in doc.Element("Data")?
                .Elements("Ingredient")?
                .OrderByDescending(ingredient => (int)ingredient.Element("AmountOfCalories")!)
                   select i;
        }

        public IEnumerable<string> ExtendedMenu()
        {
            var query = from m in doc.Element("Data")!.Elements("Menu")
                        join c in doc.Element("Data")!.Elements("Category") on m.Element("CategoryId")!.Value equals c.Element("CategoryId")!.Value
                        select $"Category Name: {c.Element("CategoryName")?.Value} " +
                        $"Date: {m.Element("Date")?.Value} " +
                        $"Dish Name: {m.Element("DishName")?.Value} " +
                        $"Cost: {m.Element("Cost")?.Value}";
            return query;
        }

        public IEnumerable<XElement> LessCalories()
        {
            return doc.Element("Data")!.Elements("Ingredient").TakeWhile(i => (int)i.Element("AmountOfCalories")! <= 300);
        }

        public IEnumerable<XElement> Take3()
        {
            var q = doc.Element("Data")!.Elements("Ingredient").Take(3);
            return q.ToList();
        }

        public IEnumerable<string> Group()
        {
            return doc.Element("Data")!.Elements("Category")
                .GroupBy(c => c.Element("CategoryName")?.Value)
                .Select(x => $"CategoryName = {x.Key}, Count = {x.Count()}");
        }
        public IEnumerable<string> PriceForAllDishesInACategory()
        {
            var categoryId = "3";

            var resulet = from m in doc.Element("Data")?.Elements("Menu")
                          where m.Element("CategoryId")?.Value == categoryId
                          select $"{m.Element("CategoryId")} {m.Element("Cost")}";

            return resulet;
        }
    }
}


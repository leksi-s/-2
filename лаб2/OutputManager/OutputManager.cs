using System.Xml.Linq;

namespace лаб2.OutputManager
{
    public class OutputManager : IOutputManager
    {
        public Queries.Queries Queries { get; set; } = new Queries.Queries();
        public void Output<T>(IEnumerable<T> q)
        {
            foreach (var item in q)
                Console.WriteLine(item);
        }

        public void IdMoreThanThree_Output()
        {
            Console.WriteLine();
            Console.WriteLine("there are the elements with id more than 3:");
            var q = Queries.IdMoreThanFive();
            Output(q);
        }
        public void SelectVeganCategory_Output()
        {
            Console.WriteLine();
            Console.WriteLine("here are the elements that represent vegan dishes:");
            var q = Queries.SelectVeganCategory();
            Output(q);
        }

        public void OnlyCategory_Output()
        {
            Console.WriteLine();
            Console.WriteLine("here are the elements are only categories:");
            var q = Queries.OnlyCategory();
            Output(q);
        }

        public void IngredientsStartWithB_Output()
        {
            Console.WriteLine();
            Console.WriteLine("here are the ingredients that start with b:");
            var q = Queries.IngredientsStartWithB();
            Output(q);
        }

        public void SeveralSelections_Output()
        {
            Console.WriteLine();
            Console.WriteLine("here are the ingredients output with several selections(outputs only with calories=50/200 and id>2):");
            var q = Queries.SeveralSelections();
            Output(q);
        }
        public void JoinDishesIngredients_Output()
        {
            Console.WriteLine();
            Console.WriteLine("here are the join on the dish and ingredients lists:");
            IEnumerable<string> query = Queries.JoinDishesIngredients();
            Output(query);
        }

        public void ByCategory_Output()
        {
            Console.WriteLine("here is an otput by category:");
            ILookup<string, XElement> query = Queries.ByCategory();

            foreach (var group in query)
            {
                Console.WriteLine($"Category: {group.Key}");

                foreach (var ingredient in group)
                {
                    Console.WriteLine($"Name: {ingredient.Element("DishName")?.Value}");
                }

                Console.WriteLine();
            }

        }

        public void SumOfCalories_Output()
        {
            Console.WriteLine();
            Console.WriteLine("here are the sum of calories of all the ingredients you input:");
            var q = Queries.SumOfCalories();
            Console.WriteLine(q);
        }

        public void SkipOn_Output()
        {
            Console.WriteLine();
            Console.WriteLine("here are using of skip method(skips id >=2):");
            var q = Queries.SkipOn();
            Output(q);
        }

        public void MoreCalories_Output()
        {
            Console.WriteLine();
            Console.WriteLine("here are ingredients with decreasing value of calories:");
            var q = Queries.MoreCalories();
            Output(q);
        }

        public void ExtendedMenu_Output()
        {
            Console.WriteLine();
            Console.WriteLine("here is an extended menu:");
            var q = Queries.ExtendedMenu();
            Output(q);
        }

        public void LessCalories_Output()
        {
            Console.WriteLine();
            Console.WriteLine("here are ingredients with less than 300 calories:");
            var q = Queries.LessCalories();
            Output(q);
        }
        public void Take3_Output()
        {
            Console.WriteLine();
            Console.WriteLine("here are the first 3 items of collection:");
            var q = Queries.Take3();
            Output(q);
        }

        public void Group_Output()
        {
            Console.WriteLine();
            Console.WriteLine("here are counter of all the categories:");
            var q = Queries.Group();
            Output(q);
        }

        public void PriceForAllDishesInACategory_Output()
        {
            Console.WriteLine();
            Console.WriteLine("here are dishes with prices in one category:");
            var q = Queries.PriceForAllDishesInACategory();
            Output(q);
        }
    }
}

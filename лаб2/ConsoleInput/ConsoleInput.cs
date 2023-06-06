using System.Xml;
using лаб2.ClassesOfData;

namespace лаб2.ConsoleInput
{
    public class ConsoleInput : IConsoleInput
    {
        Xmlwriter.RestrauntXmlWriter xmlwriter = new Xmlwriter.RestrauntXmlWriter();

        public void ChooseCategories(XmlWriter xmlWriter)
        {
            Console.WriteLine("enter categoryid:");
            int categoriesid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter category:");
            string? category = Console.ReadLine();
            Console.WriteLine("enter name of your dish:");
            string? name = Console.ReadLine();

            var createdCategory = new CategoriesOfMenu
            {
                CategoriesId = categoriesid,
                Category = category!,
                Name = name!
            };

            xmlwriter.WriteCategory(xmlWriter, createdCategory);
        }

        public void ChooseMenu(XmlWriter xmlWriter)
        {
            Console.WriteLine("enter id of menu item:");
            int menuid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter category id of your dish:");
            int categoryid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter date of preparing of your dish in format yyyy, m, d: ");
            DateOnly date = DateOnly.Parse(Console.ReadLine()!);
            Console.WriteLine("enter name of your dish:");
            string? dishname = Console.ReadLine();
            Console.WriteLine("enter cost of your dish:");
            int cost = Convert.ToInt32(Console.ReadLine());

            var createdMenu = new Menu
            {
                MenuId = menuid,
                CategoryId = categoryid,
                Date = date,
                DishName = dishname!,
                Cost = cost
            };

            xmlwriter.WriteMenu(xmlWriter, createdMenu);
        }

        public void ChooseIngredient(XmlWriter xmlWriter)
        {
            Console.WriteLine("enter ingredient id:");
            int ingredientid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter name of your ingredient:");
            string? ingredientname = Console.ReadLine();
            Console.WriteLine("enter amount of calories:");
            int amountofcalories = Convert.ToInt32(Console.ReadLine());

            var createdIngredient = new Ingredient
            {
                IngredientId = ingredientid,
                IngredientName = ingredientname!,
                AmountOfCalories = amountofcalories
            };

            xmlwriter.WriteIngredient(xmlWriter, createdIngredient);
        }

        public void ChooseDish(XmlWriter xmlWriter)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            Console.WriteLine("enter dish id:");
            int dishid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter name of your dish:");
            string? dish_name = Console.ReadLine();
            Console.WriteLine("enter ingredient id of your dish:");
            int ingredient_id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter amount of this ingredient:");
            int amountofingredient = Convert.ToInt32(Console.ReadLine());

            var createdDish = new Dish
            {
                DishId = dishid,
                DishName = dish_name!,
                IngredientId = ingredient_id,
                AmountOfIngredient = amountofingredient
            };

            xmlwriter.WriteDish(xmlWriter, createdDish);

        }

    }
}

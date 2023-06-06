using System.Xml;
using лаб2.ClassesOfData;

namespace лаб2.Xmlwriter
{
    public class RestrauntXmlWriter : IXmlwriter
    {
        public void WriteDish(XmlWriter writer, Dish dish)
        {
            writer.WriteStartElement("Dish");
            writer.WriteElementString("DishId", dish.DishId.ToString());
            writer.WriteElementString("DishName", dish.DishName);
            writer.WriteElementString("IngredientId", dish.IngredientId.ToString());
            writer.WriteElementString("AmountOfIngredient", dish.AmountOfIngredient.ToString());
            writer.WriteEndElement();
        }

        public void WriteMenu(XmlWriter writer, Menu menu)
        {
            writer.WriteStartElement("Menu");
            writer.WriteElementString("MenuId", menu.MenuId.ToString());
            writer.WriteElementString("CategoryId", menu.CategoryId.ToString());
            writer.WriteElementString("Date", menu.Date.ToString());
            writer.WriteElementString("DishName", menu.DishName);
            writer.WriteElementString("Cost", menu.Cost.ToString());
            writer.WriteEndElement();

        }
        public void WriteCategory(XmlWriter xmlWriter, CategoriesOfMenu category)
        {
            xmlWriter.WriteStartElement("Category");
            xmlWriter.WriteElementString("CategoryId", category.CategoriesId.ToString());
            xmlWriter.WriteElementString("CategoryName", category.Category);
            xmlWriter.WriteElementString("DishName", category.Name);
            xmlWriter.WriteEndElement();
        }
        public void WriteIngredient(XmlWriter writer, Ingredient ingredient)
        {
            writer.WriteStartElement("Ingredient");
            writer.WriteElementString("IngredientId", ingredient.IngredientId.ToString());
            writer.WriteElementString("IngredientName", ingredient.IngredientName);
            writer.WriteElementString("AmountOfCalories", ingredient.AmountOfCalories.ToString());
            writer.WriteEndElement();
        }
    }
}




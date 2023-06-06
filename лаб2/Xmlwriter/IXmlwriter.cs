using System.Xml;
using лаб2.ClassesOfData;

namespace лаб2.Xmlwriter
{
    internal interface IXmlwriter
    {
        void WriteDish(XmlWriter writer, Dish dish);
        void WriteMenu(XmlWriter writer, Menu menu);
        void WriteCategory(XmlWriter xmlWriter, CategoriesOfMenu categories);
        void WriteIngredient(XmlWriter writer, Ingredient ingredient);
    }
}

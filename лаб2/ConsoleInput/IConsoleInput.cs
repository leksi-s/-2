using System.Xml;

namespace лаб2.ConsoleInput
{
    internal interface IConsoleInput
    {
        void ChooseCategories(XmlWriter xmlWriter);
        void ChooseMenu(XmlWriter xmlWriter);
        void ChooseIngredient(XmlWriter xmlWriter);
        void ChooseDish(XmlWriter xmlWriter);
    }
}

using System.Xml;
using лаб2.ConsoleInput;
using лаб2.OutputManager;
using лаб2.Queries;

class Program
{
    public static string _basePath = "C://Users//Admin//source//repos//лаб2//лаб2//OutputFiles//Data.xml";
    static void Main(string[] args)
    {
        ConsoleInput input = new ConsoleInput();

        XmlWriterSettings settings = new XmlWriterSettings();
        settings.Indent = true;

        using (XmlWriter writer = XmlWriter.Create(_basePath, settings))
        {
            writer.WriteStartElement("Data");
            bool isAlive = true;
            int x;
            do
            {
                Console.WriteLine("enter list in which you want to add data: \n 1.categories of menu \n 2.menu \n 3.ingredients \n 4.dish \n 9. close");
                x = Convert.ToInt32(Console.ReadLine());

                switch (x)
                {
                    case 1:
                        input.ChooseCategories(writer);
                        break;

                    case 2:
                        input.ChooseMenu(writer);
                        break;

                    case 3:
                        input.ChooseIngredient(writer);
                        break;

                    case 4:
                        input.ChooseDish(writer);
                        break;

                    case 9:
                        writer.WriteEndElement();


                        isAlive = false;
                        break;
                }

            } while (isAlive);
        }
        OutputManager outputManager = new OutputManager();
        new Queries().Output();
        outputManager.IdMoreThanThree_Output();//1
        outputManager.SelectVeganCategory_Output();//2
        outputManager.OnlyCategory_Output();//3
        outputManager.IngredientsStartWithB_Output();//4
        outputManager.SeveralSelections_Output();//5
        outputManager.JoinDishesIngredients_Output();//6
        outputManager.ByCategory_Output();//7
        outputManager.SumOfCalories_Output();//8
        outputManager.SkipOn_Output();//9
        outputManager.MoreCalories_Output();//10
        outputManager.ExtendedMenu_Output();//11
        outputManager.LessCalories_Output();//12
        outputManager.Take3_Output();//13
        outputManager.Group_Output();//14
        outputManager.PriceForAllDishesInACategory_Output();//15
    }
}

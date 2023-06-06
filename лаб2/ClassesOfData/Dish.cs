namespace лаб2.ClassesOfData
{
    public class Dish
    {

        public int DishId { get; set; }
        public string? DishName { get; set; }
        public int IngredientId { get; set; }
        public int AmountOfIngredient { get; set; }

        public override string ToString()
        {
            return string.Format($"id:{DishId};  dish name:{DishName} ingredient:{IngredientId} amount:{AmountOfIngredient} ");
        }

    }
}


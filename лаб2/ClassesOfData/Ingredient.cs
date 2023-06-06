namespace лаб2
{
    public class Ingredient
    {

        public int IngredientId { get; set; }
        public string? IngredientName { get; set; }
        public int AmountOfCalories { get; set; }
        public override string ToString()
        {
            return string.Format($"id:{this.IngredientId};  name:{this.IngredientName}; amount of calories:{this.AmountOfCalories} ");
        }

    }
}

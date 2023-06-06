namespace лаб2
{
    public class Menu
    {
        public int MenuId { get; set; }
        public int CategoryId { get; set; }
        public DateOnly Date { get; set; }
        public string? DishName { get; set; }
        public int Cost { get; set; }

        public override string ToString()
        {
            return string.Format($"id:{this.MenuId}; catid:{this.CategoryId}; date:{this.Date}; dish name:{this.DishName} price:{Cost}");
        }
    }
}

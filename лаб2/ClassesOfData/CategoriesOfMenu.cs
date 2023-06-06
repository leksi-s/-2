namespace лаб2.ClassesOfData
{
    public class CategoriesOfMenu
    {
        public int CategoriesId { get; set; }
        public string? Category { get; set; }
        public string? Name { get; set; }

        public override string ToString()
        {
            return string.Format($"id:{CategoriesId};  category:{Category}; dish name:{Name} ");
        }
    }
}

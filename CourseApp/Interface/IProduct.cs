namespace CourseApp
{
    public interface IProduct
    {
        string Name { get; set; }

        double Price { get; set; }

        void Present();
    }
}

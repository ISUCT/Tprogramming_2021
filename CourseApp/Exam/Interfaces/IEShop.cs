namespace CourseApp.Exam.Interfaces
{
    using System.Collections.Generic;

    public interface IEShop
    {
        string Name { get; set; }

        List<IProduct> Goods();

        void Present(IProduct obj);

        void Present(List<IProduct> objects);
    }
}
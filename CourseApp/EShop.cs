namespace CourseApp
{
    using System.Collections.Generic;

    public class EShop
    {
        private List<IProduct> goods = new List<IProduct>();
        private List<IMatrix> matrix = new List<IMatrix>();

        public EShop(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void Goods()
        {
            goods.Add(new AndroidPhone("GooglePixel", 10, 100));
            goods.Add(new IOSPhone("IPhone13", 100, 1000));
            matrix.Add(new Matrix("Экран"));
        }

        public void Present()
        {
            Goods();
            foreach (IProduct item in goods)
            {
                item.Present();
            }
        }

        public void InstallMatrix(float diagonal)
        {
            Goods();
            foreach (IMatrix item in matrix)
            {
                item.InstallMatrix(10);
            }
        }
    }
}

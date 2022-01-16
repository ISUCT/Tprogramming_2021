namespace CourseApp.Exam
{
    using System.Collections.Generic;
    using CourseApp.Exam.Interfaces;
    using CourseApp.Exam.PhoneClasses.CellPhones;
    using CourseApp.Exam.PhoneClasses.CellPhones.SmartPhones;

    public class EShop : IEShop
    {
        private List<IProduct> _goods;

        public EShop(string name)
        {
            Name = name;
            _goods = new List<IProduct>();
        }

        public string Name { get; set; }

        public List<IProduct> Goods()
        {
            _goods.Add(new BabushkaPhone("HelloBabushka", 30));
            _goods.Add(new IOSPhone("IPhone 13", 1000, 6.9f));
            _goods.Add(new AndroidPhone("Google Pixel", 800, 8f));
            return _goods;
        }

        public void Present(IProduct obj)
        {
            obj.Present();
        }

        public void Present(List<IProduct> objects)
        {
            foreach (var obj in objects)
            {
                this.Present(obj);
            }
        }

        public void Present()
        {
            Present(_goods);
        }
    }
}
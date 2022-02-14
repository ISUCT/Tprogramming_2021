namespace CourseApp.RPGSaga.Generators
{
    using CourseApp.RPGSaga.Interfaces;

    public abstract class Fabric : IFabric
    {
        public abstract IPlayer FactoryMethod();
    }
}

namespace AnimalFabric
{
    public interface IAnimal
    {
        // Пол
        bool IsFemale { get; set; }

        // Возраст
        byte Age { get; set; }

        // Вес
        float Weight { get; set; }

        // Количество жизней
        byte LifesCount { get; set; }

        // Ловкость
        // -128 - Спотыкается, пока идет по полу
        // 0 - Норм такой
        // 127 - Спрыгивает со шкафа и приземляется ровно, даже с бутербродом
        sbyte AgilityCount { get; set; }

        // Цвет глаз
        byte EyeColor { get; set; }

        // Количество добытой еды
        byte GetFoodCount();

        void Attack();
    }
}

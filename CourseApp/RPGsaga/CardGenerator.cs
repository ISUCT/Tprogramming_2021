namespace CourseApp.RPGsaga
{
    public static class CardGenerator
    {
        public static Card GenerateCard(Character player)
        {
            return new Card(player);
        }
    }
}

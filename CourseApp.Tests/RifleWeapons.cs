namespace CourseApp.Tests
{
    using Xunit;

    public class RifleWeapons
    {
        [Fact]
        public void GetModel()
        {
            var pistol = new NewWeapon("pistol", "Bersa Thunder 380", 9.17);
        }
    }
}

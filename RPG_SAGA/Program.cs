namespace RpgSaga;
using System;
using RpgSaga.Abilities;
using RpgSaga.Players;
class Program{
    public static void Main(string[] args){
        // Random rnd = new Random();
        // Console.WriteLine(rnd.Next(5, 10));
        // var archer = new Archer("John");
        // var arche = new Knight("John");
        // var arch = new Archer("John");
        // var arc = new Archer("John");
        // var ar = new Archer("John");
        // var a = new Archer("John");
        // // archer.SetAbility(new FireArrows());
        // // archer.UseAbility();
        // // Console.WriteLine(archer.HP);
        // // Console.WriteLine(archer.Strenght);
        // CreatePlayers cp = new CreatePlayers();
        // cp.AddPlayerToList(archer);
        // cp.AddPlayerToList(arche);
        // cp.AddPlayerToList(arch);
        // cp.AddPlayerToList(arc);
        // cp.AddPlayerToList(ar);
        // cp.AddPlayerToList(a);
        // foreach(var player in cp.players){
        //     Console.WriteLine($"{player.GetType().Name}");
        // }
        var cp = new CreatePlayers();
        cp.CreatePlayersList();
        foreach(var p in cp.players){
            Console.WriteLine(p.Name);
        }
        //1. Класс с методом который из массива имен выбирает рандомное имя
        //3. берет лист из CreatePlayer и передаем в него созданного плеера
    }
}
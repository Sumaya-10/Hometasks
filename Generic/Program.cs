using System;

namespace Generic;

internal class Program
{
    static void Main(string[] args)  //meni basa dusursense okeyle vpdan
    {
        Wolf wolf = new Wolf
        {
            IsPrideLeader = true,
            AttackDamage = 500,
            AvgLifeTime = 9,
            Gender = Animal.GenderType.Male,
            Breed = "Caqqal",
            HP = 10,
        };
        Elephant elephant = new Elephant
        {
            Weight = 500,
            IsTrained = true,
            AvgLifeTime = 10,
            Gender = Animal.GenderType.Female,
            Breed = "Pembe",
            HP = 7
        };
        Meat meat = new Meat
        {
            Calorie = 5,
            MeatType = Meat.Type.marojna
        };
        Grass grass = new Grass
        {
            Calorie = 10,
            Name = "Terxun"
        };
        ZooCage<Wolf, Meat> caqqal = new ZooCage<Wolf, Meat>(wolf, meat);
        ZooCage<Elephant, Grass> pembe = new ZooCage<Elephant, Grass>(elephant, grass);
        Console.WriteLine( elephant.HP);

        wolf.Hunt(elephant);
        
       
    }
}
/*Animal abstract class:+
int AvgLifeTime+
enum Gender+
string Breed+
int HP - Health point+*/

/*Wolf class: Animal+
bool IsPrideLeader+
int AttackDamage+*/

namespace Generic;

public class Wolf :Animal
{
    public bool IsPrideLeader { get; set; }
    public int AttackDamage { get; set; }
    public void Hunt<T>(T animal) where T : Animal
    {
        if (animal != null)
        {
            animal.HP = animal.HP - AttackDamage;
        }
    }
}

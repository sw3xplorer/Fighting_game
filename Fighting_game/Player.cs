using System;

public class Fighter
{
    public string name = "Micke";
    public string element;

    public int hp;

    public Fighter()
    {
        name = "Micke";
        element = "water";
    }

    public void PlayerChooseName()
    {

    }

    public void Attack(Fighter target)
    {
        if (target.element == "fire" && this.element == "water")
        {
            target.hp -= 90;
        }
    }

}


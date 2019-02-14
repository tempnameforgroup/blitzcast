﻿using UnityEngine;

[CreateAssetMenu(fileName = "New Creature Card", menuName = "Creature Card")]
public class CreatureCard : Card {

    public int damage;
    public int speed;
    public int health;
    //public Vector2Int size;
    //private Vector2Int place;

    public override Card Clone()
    {
        CreatureCard copy = new CreatureCard();

        copy.name = this.name;
        copy.art = this.art;
        copy.description = this.description;
        copy.timeCost = this.timeCost;
        copy.status = this.status;
        copy.castable = this.castable;

        copy.damage = this.damage;
        copy.speed = this.speed;
        copy.health = this.health;

        return copy;
    }
}

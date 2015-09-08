using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mst_boredom_remover
{
    class UnitType
    {
        public double max_health;

        public enum AttackType
        {
            Melee,
            Arrow,
            Fireball
        };
        public AttackType attack_type;
        public double attack_strength;
        public double attack_range;

        public enum MovementType
        {
            Walker,
            Swimmer,
            Flier,
            Digger
        };
        public MovementType movement_type;
        public double movement_speed;

        public enum Action
        {
            Move,
            Attack,
            Produce,
            Cast
        };
        public List<Action> actions;

        public enum Spell
        {
            Fireball,
            IvyWhip
        }
        public List<Spell> spells;
    }
}

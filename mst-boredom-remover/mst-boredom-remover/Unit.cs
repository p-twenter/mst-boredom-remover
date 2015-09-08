using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mst_boredom_remover
{
    class Unit
    {
        public int id;
        public UnitType type;
        public double health;

        public enum Status
        {
            Gaurding,
            FightMoving,
            Walking,
            Hiding,
            Dead
        };
        public Status satus;
        public Position target_position;
        public Player owner;
        public List<Order> orders;

        public enum UnitModifier
        {
            Slowed,
            Frozen,
            Disarmed,
            Poisoned,
            Burning,
            Enraged,
            Blessed
        };
        public List<UnitModifier> modifiers;
    }
}

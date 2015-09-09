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
        public Position position;

        public enum Status
        {
            Idle,
            FightMoving,
            Moving,
            Hiding,
            Attacking,
            Dead
        };
        public Status status;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mst_boredom_remover
{
    class Order
    {
        public enum OrderType
        {
            Move,
            Attack,
            Follow,
            AttackMove
        };
        public OrderType order_type;
        public Position target_position; // Can be Null
        public Unit target_unit; // Can be Null

        // Start
        // Called on the first tick of this order
        public void Start(Game game, Unit unit) // Circular dependency :(
        {
            // Reset the unit's status
            unit.status = Unit.Status.Idle;
            
            switch (order_type)
            {
                case OrderType.Move:
                    // Schedule an update for the end of this tick
                    game.future_updates[game.current_tick].Add(new Update
                    {
                        update_type = Update.UpdateType.Move,
                        recipient_unit = unit,
                        target_unit = null,
                        target_position = target_position
                    });
                    break;
                case OrderType.Attack:
                    // Schedule an update for the end of this tick
                    game.future_updates[game.current_tick].Add(new Update
                    {
                        update_type = Update.UpdateType.Attack,
                        recipient_unit = unit,
                        target_unit = target_unit,
                        target_position = null
                    });
                    break;
                    // TODO: AttackMove
                    // TODO: Follow
            }
        }
    }
}

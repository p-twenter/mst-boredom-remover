using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;

namespace mst_boredom_remover
{
    class Update
    {
        public enum UpdateType
        {
            Move,
            Attack,
            Stop
        };
        public UpdateType update_type;

        public Unit recipient_unit;
        public Unit target_unit;
        public Position target_position;

        public void Apply() 
        {
            bool end_order = false;

            switch (update_type)
            {
                case UpdateType.Move:
                    if (recipient_unit.position == target_position)
                    {
                        end_order = true;
                        break;
                    }
                    // TODO: Find path to target_pos
                    // TODO: Move one tile toward goal
                    recipient_unit.position = target_position;
                    recipient_unit.status = Unit.Status.Moving;
                    // TODO: Schedule update to move to target_pos again
                    break;
                case UpdateType.Attack:
                    if (target_unit.status == Unit.Status.Dead)
                    {
                        end_order = true;
                        break;
                    }
                    // TODO: Get into range
                    // TODO: Attack
                    recipient_unit.status = Unit.Status.Attacking;
                    // TODO: Schedule update to attack again after cooldown
                    break;
            }

            if (end_order)
            {
                recipient_unit.status = Unit.Status.Idle;
                // TODO: Pop and start next order
            }
        }
    }
}

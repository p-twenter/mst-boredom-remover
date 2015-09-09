using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace mst_boredom_remover
{
    class GameState
    {
        public Map map;
        public List<Player> players;
        public List<Unit> units;
        public List<Update> updates;
    }
}

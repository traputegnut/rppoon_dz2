using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    class Wizzard   /*napravljena je jako specificna klasa koja ne nasljeđuje općenitiju klasu ili sučelje,
                     * ispravno bi bilo da nasljeđuje npr klasu fighter i spellove specificne za wizzarda*/
    {
        public void CastFireSpell() { };
        public void CastWaterSpell() { };
        public void PhysicalStrike() { };
        public void Walk() { };
    }
}

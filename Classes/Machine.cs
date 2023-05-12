using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen_del_1.Classes
{
    public abstract class Machine
    {
        private bool _on = false;

        public bool On
        {
            get { return _on; }
            set { _on = value; }
        }

        public Machine(bool on)
        {
            _on = on;
        }

        /// <summary>
        /// used for turning the machine on and off
        /// </summary>
        /// <returns></returns>
        public string OnOff()
        {
            On = !On;
            if (On == true)
            {
                return $"Machine is now on \r\nStarts brewing";
            }
            else
            {
                return "Machine is turned off";
            }
        }
    }
}

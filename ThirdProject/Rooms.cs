using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdProject {
    internal class Rooms {
        public String? Name { get; set; }
        public String? Email { get; set; }
        public int RoomId { get; set; }
        public bool _rent;

        public Rooms() {
            _rent = false;
                }
        
        public bool Rent {
            get { return _rent; }
            set { _rent = value; }

        }

        public override string ToString() {
            return $"Name: {Name}\nEmail: {Email}\nQuarto: {RoomId + 1}";
        }

    }
}

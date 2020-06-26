using System;

namespace Unit3
{
    class BloodType {

        string _abo;

        char _sign;

        public BloodType(string abo, char sign) {
            // TODO: Validation on both properties
            // abo must be one of A, B, AB, O
            // sign must be - or +
            _abo = abo;
            _sign = sign;
        }

        public bool CanDonateTo(BloodType otherType) {
            // TODO: Add algorithm here

            return true;
        }
    }
}
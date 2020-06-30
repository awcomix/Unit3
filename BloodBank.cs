using System;
using System.Collections.Generic;

namespace Unit3
{
    // class Clinic {
    //     List<Donor> allDonors;

    //     public Donor FindDonorByName(string firstName) {
    //         for (int i = 0; i < allDonors.Count; i++) {
    //             if (allDonors[i]._firstNameMember == firstName) {
    //                 //Found a match!
    //                 return allDonors[i];
    //             }
    //         }
    //     }
    // }

    class Person {
        protected string _firstName;
        protected string _lastName;
        protected DateTime _dateOfBirth;

        public string FullName {
            get {
                return "";
                // Build and return the full name here
            }
        }

        public int Age {
            get {
                return -1;
                // Calculate and return the age here
                // Hint: Use something similar to how we calculated the days since a donor donated
            }
        }

        // Constructor
        public Person() {
            // Add in assignments to the fields
            // Optional: Do some validation on the inputs
        }
        
        public void Greet() {
            // Print out: "Hello Homer Simpson" (use the FullName property)
        }
    }


    class Receiver : Person {
        BloodType _bloodType;

        public Receiver(string firstNameArg, string lastNameArg, DateTime dateOfBirthArg, BloodType bloodTypeArg) {
            _firstName = firstNameArg;
            _lastName = lastNameArg;
            _dateOfBirth = dateOfBirthArg;
            _bloodType = bloodTypeArg;
        }

        public void PrintDetails() {
            Console.WriteLine($"------Receiver-------");
            Console.WriteLine($"Name: {_firstName} {_lastName}");
            Console.WriteLine($"DOB: {_dateOfBirth}");
        }
    }


    class Donor : Person {
        BloodType _bloodType;
        DateTime _lastDonationDate;
        int _numTimesDonated;

        public Donor(string firstNameArg, string lastNameArg, DateTime dateOfBirthArg, BloodType bloodTypeArg) {
            _firstName = firstNameArg;
            _lastName = lastNameArg;
            _dateOfBirth = dateOfBirthArg;
            _bloodType = bloodTypeArg;
            _numTimesDonated = 0;
        }

        public void TryToDonateTo(Receiver receiver) {
            // Check if donor is eligible
            // Check if donor blood type is compatible with receiver blood type
            // Update the donor values accordingly
            // Bonus: If this is the donor's fifth donation, then print a "Congrats" message

        }


        // Donor is eligible to donate if its been at least 56 days since last donation
        public bool IsEligibleToDonate() {
            if ((DateTime.Now - _lastDonationDate).Days > 56) {
                return true;
            } else {
                return false;
            }
        }

        public void TryToMakeDonation() {
            if (IsEligibleToDonate()) {
                _numTimesDonated++;
                _lastDonationDate = DateTime.Now;
                Console.WriteLine($"Donation made by {_firstName}");
            } else {
                throw new Exception("Donor is ineligible to donate");
            }
        }

        public void PrintDetails() {
            Console.WriteLine($"------Donor-------");
            Console.WriteLine($"Name: {_firstName} {_lastName}");
            Console.WriteLine($"DOB: {_dateOfBirth}");
            Console.WriteLine($"NumTimes Donated: {_numTimesDonated}\n");
        }

    }


    class BloodType {
        string _abo;
        char _sign;

        public BloodType(string abo, char sign) {
            // abo must be one of A, B, AB, O
            abo = abo.ToUpper();
            if (abo != "AB" && abo != "A" && abo != "B" && abo != "O") {
                throw new Exception($"Blood type {abo} is invalid");
            }
            // sign must be - or +
            if (sign != '-' && sign != '+') {
                throw new Exception($"Blood type sign {sign} is invalid");
            }

            _abo = abo;
            _sign = sign;
        }

        public bool CanDonateTo(BloodType receiverType) {
            /*** O ***/
            if (_abo == "O" && _sign == '-') {
                return true;
            }

            if (_abo == "O" && _sign == '+') {
                if (receiverType._sign == '+') {
                    return true;
                } else {
                    return false;
                }
            }

            /*** B ***/
            if (_abo == "B" && _sign == '-') {
                if (receiverType._abo == "B" || receiverType._abo == "AB") {
                    return true;
                }
            }

            if (_abo == "B" && _sign == '+') {
                if (receiverType._abo == "B" || receiverType._abo == "AB") {
                    if (receiverType._sign == '+') {
                        return true;
                    } else {
                        return false;
                    }
                }
            }

            /*** A ***/
            if (_abo == "A" && _sign == '-') {
                if (receiverType._abo == "A" || receiverType._abo == "AB") {
                    return true;
                }
            }

            if (_abo == "A" && _sign == '+') {
                if (receiverType._abo == "A" || receiverType._abo == "AB") {
                    if (receiverType._sign == '+') {
                        return true;
                    } else {
                        return false;
                    }
                }
            }

            /*** AB ***/
            if (_abo == "AB" && _sign == '-') {
                if (receiverType._abo == "AB") {
                    return true;
                }
            }

            if (_abo == "AB" && _sign == '+') {
                if (receiverType._abo == "AB" && receiverType._sign == '+') {
                    return true;
                } else {
                    return false;
                }
            }

            return false;
        }

        public void PrintDetails() {
            Console.WriteLine($"BloodType is {_abo}{_sign}");
        }
    }
}
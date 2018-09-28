using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TermAPI.Models {
    public class Term {

        public int Month { get; set; }
        public int Day { get; set; }
        public int Year { get; set; }
        public string Season { get; set; }

        public Term(DateTime date) {
            Month = date.Month;
            Day = date.Day;
            Year = date.Year;
            if (Month == 1) {
                Season = "Winter";
            }
            else if (Month >= 2 && Month <= 5) {
                Season = "Spring";
            }
            else if (Month >= 6 && Month <= 8) {
                Season = "Summer";
            }
            else if (Month >= 9 && Month <= 12)
                Season = "Fall";
            else {
                Season = "None";
            }
        }

        public Term(int digit) {
            if (digit == 1) {
                Season = "Winter";
            }
            else if (digit == 4) {
                Season = "Spring";
            }
            else if (digit == 6) {
                Season = "Summer";
            }
            else if (digit == 8) {
                Season = "Fall";
            }
            else {
                Season = "None";
            }
        }

    }
}

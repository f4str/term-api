using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TermAPI.Models {
    public class Term {

        public string Season { get; set; }
        public int Year { get; set; }

        public Term(DateTime date) {
            int month = date.Month;
            Year = date.Year;
            if (month == 1) {
                Season = "Winter";
            }
            else if (month >= 2 && month <= 5) {
                Season = "Spring";
            }
            else if (month >= 6 && month <= 8) {
                Season = "Summer";
            }
            else if (month >= 9 && month <= 12)
                Season = "Fall";
            else {
                Season = "None";
            }
        }

        public Term(int code) {
            int digit = code % 10;
            int year = 1900 + code / 10;
            Year = year;
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

using Microsoft.VisualStudio.TestTools.UnitTesting;
using NASACLI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASACLI.Tests {
    [TestClass()]
    public class KuldetesTests {

        [TestMethod()]
        [DataRow(24.0, 4600.0, "Közepes")]
        [DataRow(0.0, 4600.0, "Alacsony")]
        [DataRow(24.0, 15000.0, "Magas")]
        [DataRow(24.0, 25000.0, "Magas")]
        /*
         * "Magas" ha a költség meghaladja az 1 milliárd USD-t és a rakomány tömege több mint 10 tonna.
            "Közepes" ha csak az egyik feltétel teljesül.
            "Alacsony" ha egyik feltétel sem teljesül.
         */
        public void KockazatiSzintTest(double koltseg, double tomeg, string expected) {
            Kuldetes kuldetes = new Kuldetes($"Test;2024;Mars;5;Igen;Test leiras;{koltseg};{tomeg}");
            string actual = kuldetes.KockazatiSzint();
            Assert.AreEqual(expected, actual);
        }
    }
}
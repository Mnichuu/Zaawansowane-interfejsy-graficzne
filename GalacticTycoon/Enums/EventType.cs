using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticTycoon.Enums
{
    // Wlatując w osobliwość, możemy wylosować jedną z tych kart
    public enum EventType {
        PirateAttack,               // atak piratów (utrata 2 tur, możliwość zapłaty okupu lub wykorzystanie karty obrony)
        DefenseAgainstPirates,      // obrona przed piratami
        GalacticTicket,             // bilet galaktyczny (możliwość szybkiej podruży między stacjami)
        Tax,                        // pobranie podatku od nieruchomości (%)
        LotteryWin,                 // wygrana w loterii
        EgineFailure                // awaria silnika (strata kolejki + konieczność zapłaty za holowanie
    }
}

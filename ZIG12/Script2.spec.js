describe("potega", function () {
    it("zwraca potêgê gdy trzeci argument > 0 i wyk³adnik >= 0", function () {
        expect(potega(2, 3, 1)).toBe(8);
    });
    it("zwraca komunikat gdy trzeci argument <= 0", function () {
        expect(potega(2, 3, 0)).toBe("trzeci argument jest mniejszy od 0");
    });
    it("zwraca komunikat gdy wyk³adnik < 0", function () {
        expect(potega(2, -1, 1)).toBe("wykladnik mniejszy od 0");
    });
});

describe("zapiszWTablicy", function () {
    it("mno¿y ka¿dy element tablicy przez liczbê", function () {
        expect(zapiszWTablicy([1, 2, 3], 2)).toEqual([2, 4, 6]);
    });
});

describe("poleKola", function () {
    it("zwraca pole ko³a dla poprawnego promienia", function () {
        expect(poleKola(2)).toBeCloseTo(Math.PI * 4);
    });
    it("zwraca komunikat dla promienia <= 0", function () {
        expect(poleKola(0)).toBe("promien musi byc wiekszy od 0");
    });
});

describe("sumaCyfr", function () {
    it("zwraca komunikat dla liczby trzycyfrowej podzielnej przez 3", function () {
        expect(sumaCyfr(123)).toBe("liczba podzielna przez 3");
    });
    it("zwraca komunikat dla liczby trzycyfrowej niepodzielnej przez 3", function () {
        expect(sumaCyfr(124)).toBe("liczba nie jest podzielna przez 3");
    });
    it("zwraca komunikat dla liczby nie trzycyfrowej", function () {
        expect(sumaCyfr(99)).toBe("podana liczba nie jest trzycyfrowa");
    });
});

describe("zamienElementy", function () {
    it("zamienia elementy gdy warunek > 0 i indeksy poprawne", function () {
        expect(zamienElementy([1, 2, 3], 0, 2, 1)).toEqual([3, 2, 1]);
    });
    it("nie zamienia gdy warunek <= 0", function () {
        expect(zamienElementy([1, 2, 3], 0, 2, 0)).toEqual([1, 2, 3]);
    });
    it("zwraca komunikat gdy indeks poza zakresem", function () {
        expect(zamienElementy([1, 2, 3], 0, 5, 1)).toBe("indeks spoza zakresu");
    });
});

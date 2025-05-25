// a. Funkcja potega
function potega(a, b, c) {
    if (c <= 0) return "trzeci argument jest mniejszy od 0";
    if (b < 0) return "wykladnik mniejszy od 0";
    return Math.pow(a, b);
}

// b. Funkcja zapiszWTablicy
function zapiszWTablicy(tab, liczba) {
    return tab.map(x => x * liczba);
}

// c. Funkcja poleKola
function poleKola(r) {
    if (r <= 0) return "promien musi byc wiekszy od 0";
    return Math.PI * r * r;
}

// d. Funkcja sumaCyfr
function sumaCyfr(n) {
    if (!(Number.isInteger(n) && n > 99 && n < 1000)) {
        return "podana liczba nie jest trzycyfrowa";
    }
    const suma = Math.floor(n / 100) + Math.floor((n % 100) / 10) + (n % 10);
    if (suma % 3 === 0) return "liczba podzielna przez 3";
    return "liczba nie jest podzielna przez 3";
}

// e. Funkcja zamienElementy
function zamienElementy(tab, idx1, idx2, warunek) {
    if (idx1 < 0 || idx1 >= tab.length || idx2 < 0 || idx2 >= tab.length) {
        return "indeks spoza zakresu";
    }
    if (warunek > 0) {
        const temp = tab[idx1];
        tab[idx1] = tab[idx2];
        tab[idx2] = temp;
    }
    return tab;
}

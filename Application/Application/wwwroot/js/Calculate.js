function Calculate(val) {
    document.getElementById("display").value = val;
}
function PassValue(val) {
    document.getElementById("display").value += val;
}
function e() {
    try {
        Calculate(eval(document.getElementById("display").value))
    }
    catch (e) {
        c('Error')
    }
}
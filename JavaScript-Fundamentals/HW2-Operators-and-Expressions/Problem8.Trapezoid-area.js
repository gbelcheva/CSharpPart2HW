//Problem 8. Trapezoid area
//
//Write an expression that calculates trapezoid's area by given sides a and b and height h.
//
//Examples:
//a 	b 	h 	area
//5 	7 	12 	72
//2 	1 	33 	49.5
//8.5 	4.3 2.7 17.28
//100 	200 300 45000
//0.222 0.333 0.555 0.1540125

var i;

var a1 = 5,
    a2 = 2,
    a3 = 8.5,
    a4 = 100,
    a5 = 0.222,
    b1 = 7,
    b2 = 1,
    b3 = 4.3,
    b4 = 200,
    b5 = 0.333,
    h1 = 12,
    h2 = 33,
    h3 = 2.7,
    h4 = 300,
    h5 = 0.555;

var a = [
    a1,
    a2,
    a3,
    a4,
    a5];

var b = [
    b1,
    b2,
    b3,
    b4,
    b5];

var h = [
    h1,
    h2,
    h3,
    h4,
    h5];

for (i = 0; i < a.length; i += 1) {
    console.log('The trapezoid (a:' + a[i] + ', b:' + b[i] + ', h:' + h[i] + ') has area -> ' + getArea(a[i], b[i], h[i]));
}

function getArea(a, b, h) {
    return (a + b ) * h / 2;
}
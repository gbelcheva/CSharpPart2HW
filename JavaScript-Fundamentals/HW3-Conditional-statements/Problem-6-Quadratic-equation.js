//Problem 6. Quadratic equation
//
//Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
//Calculates and prints its real roots.
//
//    Note: Quadratic equations may have 0, 1 or 2 real roots.
//
//    Examples:
//a 	b 	c 	roots
//2 	5 	-3 	x1=-3; x2=0.5
//-1 	3 	0 	x1=3; x2=0
//-0.5 	4 	-8 	x1=x2=4
//5 	2 	8 	no real roots

var a1 = 2,
    a2 = -1,
    a3 = -0.5,
    a4 = 5,
    b1 = 5,
    b2 = 3,
    b3 = 4,
    b4 = 2,
    c1 = -3,
    c2 = 0,
    c3 = -8,
    c4 = 8;

var a = [
    a1,
    a2,
    a3,
    a4];

var b = [
    b1,
    b2,
    b3,
    b4];

var c = [
    c1,
    c2,
    c3,
    c4];

for (var i = 0; i < a.length; i++) {
    console.log(getRoots(a[i], b[i], c[i]));
}

function getRoots(a, b, c){
    var D = b * b - 4 * a * c,
        roots;

    if (D < 0) {
        roots = 'no real roots';
    }
    else if(D) {
        roots = 'x1=' + calculateRoot(-1, a, b, D);
        roots += '; x2=' + calculateRoot(1, a, b, D);
    }
    else {
        roots = 'x1=x2=' + calculateRoot(-1, a, b, D);
    }
    return roots;
}

function calculateRoot(sign, a, b, D){
    return (-b + sign * Math.sqrt(D)) / (2 * a);
}
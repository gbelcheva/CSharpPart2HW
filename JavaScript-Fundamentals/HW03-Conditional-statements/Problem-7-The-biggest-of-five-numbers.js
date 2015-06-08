//Problem 7. The biggest of five numbers
//
//Write a script that finds the greatest of given 5 variables.
//    Use nested if statements.
//
//    Examples:
//a 	b 	    c 	    d 	e 	    biggest
//5 	2 	    2 	    4 	1 	    5
//-2 	-22 	1 	    0 	0 	    1
//-2 	4 	    3 	    2 	0 	    4
//0 	-2.5 	0 	    5 	5 	    5
//-3 	-0.5 	-1.1 	-2 	-0.1 	-0.1

var a1 = 5,
    a2 = -2,
    a3 = -2,
    a4 = 0,
    a5 = -3,
    b1 = 2,
    b2 = -22,
    b3 = 4,
    b4 = -2.5,
    b5 = -0.5,
    c1 = 2,
    c2 = 1,
    c3 = 3,
    c4 = 0,
    c5 = -1.1,
    d1 = 4,
    d2 = 0,
    d3 = 2,
    d4 = 5,
    d5 = -2,
    e1 = 1,
    e2 = 0,
    e3 = 0,
    e4 = 5,
    e5 = -0.1;

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

var c = [
    c1,
    c2,
    c3,
    c4,
    c5];

var d = [
    d1,
    d2,
    d3,
    d4,
    d5];

var e = [
    e1,
    e2,
    e3,
    e4,
    e5];

for (var i = 0; i < a.length; i++) {
    var biggest = 0;
    if (a[i] > b[i]) {
        if (a[i] > c[i]) {
            if (a[i] > d[i]) {
                if (a[i] > e[i]) {
                    biggest = a[i];
                }
                else {
                    biggest = e[i];
                }
            }
            else {
                if (d[i] > e[i]) {
                    biggest = d[i];
                }
                else {
                    biggest = e[i];
                }
            }
        }
        else {
            if (c[i] > d[i]) {
                if (c[i] > e[i]) {
                    biggest = c[i];
                }
                else {
                    biggest = e[i];
                }
            }
            else {
                if (d[i] > e[i]) {
                    biggest = a[i];
                }
                else {
                    biggest = e[i];
                }
            }
        }
    }
    else {
        if (b[i] > c[i]) {
            if (b[i] > d[i]) {
                if (b[i] > e[i]) {
                    biggest = b[i];
                }
                else {
                    biggest = e[i];
                }
            }
            else {
                if (d[i] > e[i]) {
                    biggest = d[i];
                }
                else {
                    biggest = e[i];
                }
            }
        }
        else {
            if (c[i] > d[i]) {
                if (c[i] > e[i]) {
                    biggest = c[i];
                }
                else {
                    biggest = e[i];
                }
            }
            else {
                if (d[i] > e[i]) {
                    biggest = b[i];
                }
                else {
                    biggest = e[i];
                }
            }
        }
    }
    console.log(a[i] + ' ' + b[i] + ' ' + c[i] + ' ' + d[i] + ' ' + e[i] + ' -> ' + biggest);
}
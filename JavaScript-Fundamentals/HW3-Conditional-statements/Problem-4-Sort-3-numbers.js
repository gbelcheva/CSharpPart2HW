//Problem 4. Sort 3 numbers
//
//Sort 3 real values in descending order.
//    Use nested if statements.
//
//    Note: Don’t use arrays and the built-in sorting functionality.
//
//    Examples:
//a 	b 	    c 	result
//5 	1 	    2 	5 2 1
//-2 	-2 	    1 	1 -2 -2
//-2 	4 	    3 	4 3 -2
//0 	-2.5 	5 	5 0 -2.5
//-1.1 	-0.5 	-0.1 	-0.1 -0.5 -1.1
//10 	20 	    30 	    30 20 10
//1 	1 	    1 	    1 1 1

var a = [
    5,
    -2,
    -2,
    0,
    -1.1,
    10,
    1];

var b = [
    1,
    -2,
    4,
    -2.5,
    -0.5,
    20,
    1];

var c = [
    2,
    1,
    3,
    5,
    -0.1,
    30,
    1];

for (var i = 0; i < a.length; i++) {
    var sorted = '';
    if (a[i] > b[i]) {
        if (a[i] > c[i]) {
            sorted += a[i] + ' ';
            if (b[i] > c[i]) {
                sorted += b[i] + ' ' + c[i];
            }
            else {
                sorted += c[i] + ' ' + b[i];
            }
        }
        else {
            sorted += c[i] + ' ';
            if (a[i] > b[i]) {
                sorted += a[i] + ' ' + b[i];
            }
            else {
                sorted += b[i] + ' ' + a[i];
            }
        }
    }
    else {
        if (b[i] > c[i]) {
            sorted += b[i] + ' ';
            if (a[i] > c[i]) {
                sorted += a[i] + ' ' + c[i];
            }
            else {
                sorted += c[i] + ' ' + a[i];
            }

        }
        else {
            sorted += c[i] + ' ';
            if (a[i] > b[i]) {
                sorted += a[i] + ' ' + b[i];
            }
            else {
                sorted += b[i] + ' ' + a[i];
            }
        }
    }
    console.log(a[i] + ' ' + b[i] + ' ' + c[i] + ' -> ' + sorted);
}
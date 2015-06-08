//Problem 3. The biggest of Three
//
//Write a script that finds the biggest of three numbers.
//    Use nested if statements.
//
//    Examples:
//a 	b 	    c 	biggest
//5 	2 	    2 	5
//-2 	-2 	    1 	1
//-2 	4 	    3 	4
//0 	-2.5 	5 	5
//-0.1 	-0.5 	-1.1 	-0.1

var a = [
    5,
    -2,
    -2,
    0,
    -0.1];

var b = [
    2,
    -2,
    4,
    -2.5,
    -0.5];

var c = [
    2,
    1,
    3,
    5,
    -1.1];

for (var i = 0; i < a.length; i++) {
    var biggest = 0;
    if (a[i] > b[i]) {
        if (a[i] > c[i]) {
            biggest = a[i];
        }
        else {
            biggest = c[i];
        }
    }
    else {
        if (b[i] > c[i]) {
            biggest = b[i];

        }
        else {
            biggest = c[i];
        }
    }
    console.log(a[i] + ' ' + b[i] + ' ' + c[i] + ' -> ' + biggest);
}
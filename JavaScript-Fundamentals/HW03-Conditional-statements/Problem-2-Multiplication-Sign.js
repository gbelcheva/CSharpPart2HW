//Problem 2. Multiplication Sign
//
//Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//    Use a sequence of if operators.
//
//    Examples:
//a 	b 	    c 	result
//5 	2 	    2 	+
//-2 	-2 	    1 	+
//-2 	4 	    3 	-
//0 	-2.5 	4 	0
//-1 	-0.5 	-5.1 	-

var a = [
        5,
        -2,
        -2,
        0,
        -1],
    b = [
        2,
        -2,
        4,
        -0.2,
        -0.5],
    c = [
        2,
        1,
        3,
        4,
        -5.1];


for (var i = 0; i < a.length; i++) {
    var sign = 0;
    if (a[i] && b[i] && c[i]) {
        if (a[i] < 0) {
            sign += 1;
        }
        if (b[i] < 0) {
            sign += 1;
        }
        if (c[i] < 0) {
            sign += 1;
        }
        sign = (sign % 2) ? '-' : '+';
    }
    else {
        sign = 0;
    }
    console.log(a[i] + ' ' + b[i] + ' ' + c[i] + ' -> ' + sign);
}
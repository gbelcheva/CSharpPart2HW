//Problem 2. Correct brackets
//
//Write a JavaScript function to check if in a given expression the brackets are put correctly.
//
//    Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

var expressions = [
    '((a+b)/5-d)',
    ')(a+b))',
    ')(a+b)(',
    '((a+b)('];

function checkBrackets(expression){
    var symbols = expression.split(''),
        countBrackets = symbols.reduce(function(count, symbol) {
        if (symbol === '(') {
            if (count['(']) {
                count['('] += 1;
            }
            else {
                count['('] = 1;
            }
        }
        else if (symbol === ')') {
            if (count[')']) {
                count[')'] += 1;
            }
            else {
                count[')'] = 1;
            }
        }
        return count;
    }, {});
    return symbols.indexOf(')') > symbols.indexOf('(') &&
           countBrackets['('] === countBrackets[')'];
}

for (var expression of expressions) {
    console.log( expression + ' --> ' + checkBrackets(expression));
}
